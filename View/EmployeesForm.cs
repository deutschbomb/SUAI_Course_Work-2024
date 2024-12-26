
using EntityFramework.Exceptions.Common;
using System.Reflection;
using System.Text.RegularExpressions;

namespace App
{
    public partial class EmployeesForm : Form, IView, IViewDefault, IViewControls
    {
        private Presenter Presenter;
        private MainForm home;

        public void InitializeData(Presenter? presenter = null, MainForm? home = null)
        {
            this.Presenter = presenter;
            this.home = home;
            this.Presenter.ContextLoad();

            this.Presenter.EmployeesTableLoad();
            this.Presenter.SpecialtiesTableLoad();

            this.employeeBindingSource.DataSource = this.Presenter.EmployeesTableToList();
            this.specialtyBindingSource.DataSource = this.Presenter.SpecialtiesTableToList();
        }

        public EmployeesForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            InitializeData(Presenter, home);
        }

        public DialogResult ResultDialog(string message, string header)
        {
            DialogResult result = MessageBox.Show(
                message,
                header,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            return result;
        }

        public void ErrorDialog(string message, string header)
        {
            DialogResult error = MessageBox.Show(
                message,
                header,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        public void Controls_toDefault()
        {
            this.controlsLayoutPanel.Enabled = !this.controlsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;

            this.employeesPicker.SelectedIndex = -1;
            this.specialtiesPicker.SelectedIndex = -1;

            this.nameInput.Text =
                this.surnameInput.Text =
                this.patronymicInput.Text =
                this.passportInput.Text =
                this.addressInput.Text =
                this.telephoneInput.Text = null;

            this.employmentDatePicker.Value = DateTime.Now;
            this.birthDatePicker.Value = this.birthDatePicker.MaxDate;
            this.birthDatePicker.Format = DateTimePickerFormat.Custom;
        }

        public void Return()
        {
            this.Controls_toDefault();

            this.acceptButton.Visible = true;
            this.editButton.Visible = false;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            this.birthDatePicker.MaxDate = DateTime.Now.AddYears(-18);

            this.Controls_toDefault();

        }

        private void EmployeesForm_FormClosed(object sender, EventArgs e)
        {
            this.Presenter.ContextDispose();
            this.home.Show();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Controls_toDefault();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (this.employeesPicker.SelectedIndex == -1) return;

            this.controlsLayoutPanel.Enabled = !this.controlsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;

            int index = (int)this.employeesPicker.SelectedValue;

            Employee employee = this.Presenter.EmployeesFind(index);

            this.specialtiesPicker.SelectedValue = employee.SpecialtyId;

            this.nameInput.Text = employee.EmployeeName;
            this.surnameInput.Text = employee.EmployeeSurname;
            this.patronymicInput.Text = employee.EmployeePatronymic;
            this.passportInput.Text = employee.EmployeePassportNumber;
            this.addressInput.Text = employee.EmployeeAddress;
            this.telephoneInput.Text = employee.EmployeeTelephone;

            this.employmentDatePicker.Value = (DateTime)employee.DateOfEmployment;

            this.birthDatePicker.Checked = employee.DateOfBirth == null ? false : true;
            if (this.birthDatePicker.Checked)
            {
                this.birthDatePicker.Value = (DateTime)employee.DateOfBirth;
                this.birthDatePicker.Format = DateTimePickerFormat.Long;
            }
            else
            {
                this.birthDatePicker.Value = this.birthDatePicker.MaxDate;
                this.birthDatePicker.Format = DateTimePickerFormat.Custom;
            }

            this.acceptButton.Visible = false;
            this.editButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.employeesPicker.SelectedIndex == -1) return;

            if (ResultDialog("Вы уверены, что хотите удалить выбранную запись о сотруднике?",
                "Удалить запись") == DialogResult.No) return;

            int index = (int)this.employeesPicker.SelectedValue;

            Employee employee = this.Presenter.EmployeesFind(index);

            this.Presenter.EmployeesRemove(employee);
            this.Presenter.ContextSaveChanges();

            this.employeeBindingSource.DataSource = this.Presenter.EmployeesTableToList();

            this.employeesPicker.SelectedIndex = -1;

            MessageBox.Show("Запись о сотруднике успешно удалена из базы данных!");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите добавить новую запись о сотруднике?",
                "Добавить запись") == DialogResult.No) return;

            Employee employee = new Employee();

            employee.Specialty = (Specialty)this.specialtiesPicker.SelectedItem;

            employee.EmployeeName = this.nameInput.Text != "" ? this.nameInput.Text : null;
            employee.EmployeeSurname = this.surnameInput.Text != "" ? this.surnameInput.Text : null;
            employee.EmployeePatronymic = this.patronymicInput.Text != "" ? this.patronymicInput.Text : null;

            employee.EmployeePassportNumber = this.passportInput.Text != "" ?
                this.passportInput.Text.Replace(" ", "") : null;

            employee.EmployeeAddress = this.addressInput.Text != "" ? this.addressInput.Text : null;

            employee.EmployeeTelephone = this.telephoneInput.Text != "" ?
                Regex.Replace(this.telephoneInput.Text, @"(\D)", @"").Insert(0, "+") : null;

            employee.DateOfEmployment = this.employmentDatePicker.Value;
            employee.DateOfBirth = this.birthDatePicker.Checked == true ? this.birthDatePicker.Value : null;

            try
            {
                this.Presenter.EmployeesAdd(employee);
                this.Presenter.ContextSaveChanges();
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.EmployeesRemove(employee);

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                return;
            }

            this.employeeBindingSource.DataSource = this.Presenter.EmployeesTableToList();

            MessageBox.Show("Запись о сотруднике успешно добавлена в базу данных!");
            this.Controls_toDefault();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите изменить существующую запись о сотруднике?",
                "Измененить запись") == DialogResult.No) return;

            int index = (int)this.employeesPicker.SelectedValue;

            Employee employee = this.Presenter.EmployeesFind(index);

            employee.Specialty = (Specialty)this.specialtiesPicker.SelectedItem;

            employee.EmployeeName = this.nameInput.Text != "" ? this.nameInput.Text : null;
            employee.EmployeeSurname = this.surnameInput.Text != "" ? this.surnameInput.Text : null;
            employee.EmployeePatronymic = this.patronymicInput.Text != "" ? this.patronymicInput.Text : null;

            employee.EmployeePassportNumber = this.passportInput.Text != "" ?
                this.passportInput.Text.Replace(" ", "") : null;

            employee.EmployeeAddress = this.addressInput.Text != "" ? this.addressInput.Text : null;

            employee.EmployeeTelephone = this.telephoneInput.Text != "" ?
                Regex.Replace(this.telephoneInput.Text, @"(\D)", @"").Insert(0, "+") : null;

            employee.DateOfEmployment = this.employmentDatePicker.Value;
            employee.DateOfBirth = this.birthDatePicker.Checked == true ? this.birthDatePicker.Value : null;

            try
            {
                this.Presenter.EmployeesEntry(employee);
                this.Presenter.ContextSaveChanges();
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.EmployeesRemove(employee);

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                return;
            }

            this.employeeBindingSource.DataSource = this.Presenter.EmployeesTableToList();

            MessageBox.Show("Запись о сотруднике успешно изменена в базе данных!");
            this.Return();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору сотрудников?",
                "Отмена операции") == DialogResult.No) return;

            this.Return();
        }

        private void passportInput_Enter(object sender, EventArgs e)
        {
            this.passportInput.Text = Regex.Replace(this.passportInput.Text, @"(\D)", @"");
        }

        private void passportInput_Leave(object sender, EventArgs e)
        {
            this.passportInput.Text = Regex.Replace(this.passportInput.Text, @"(\d{4})(\d{6})", @"$1 $2");
        }

        private void telephoneInput_Enter(object sender, EventArgs e)
        {
            this.telephoneInput.Text = "+" + Regex.Replace(this.telephoneInput.Text, @"(\D)", @"");
        }

        private void telephoneInput_Leave(object sender, EventArgs e)
        {
            this.telephoneInput.Text = Regex.IsMatch(this.telephoneInput.Text, @"^\+$") ? "" :
                Regex.Replace(this.telephoneInput.Text,
                    @"\+(\d{1})(\d{3})(\d{3})(\d{2})(\d{2})", @"+$1 ($2) $3-$4-$5");
        }

        private void birthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!this.birthDatePicker.Checked)
                this.birthDatePicker.Format = DateTimePickerFormat.Custom;
            else
                this.birthDatePicker.Format = DateTimePickerFormat.Long;
        }

        public void comboBox_DropDown(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            int widestStringInPixels = 0;
            foreach (Object o in cb.Items)
            {
                string toCheck;
                PropertyInfo pinfo;
                Type objectType = o.GetType();
                if (cb.DisplayMember.CompareTo("") == 0) toCheck = o.ToString();
                else
                {
                    pinfo = objectType.GetProperty(cb.DisplayMember);
                    toCheck = pinfo.GetValue(o, null).ToString();

                }
                if (TextRenderer.MeasureText(toCheck, cb.Font).Width > widestStringInPixels)
                    widestStringInPixels = TextRenderer.MeasureText(toCheck, cb.Font).Width;
            }
            cb.DropDownWidth = widestStringInPixels + 15;
        }
    }
}
