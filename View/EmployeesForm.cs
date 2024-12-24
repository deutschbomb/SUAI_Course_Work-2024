
using EntityFramework.Exceptions.Common;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace App
{
    public partial class EmployeesForm : Form, IView, IViewPages
    {
        private bool ADD_FLAG;
        private bool EDIT_FLAG;

        private Presenter Presenter;
        private MainForm home;

        public EmployeesForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.Presenter.db = new Context();
            this.Presenter.db.Database.EnsureCreated();
            this.home = home;

            this.Presenter.db.Employees.Load();
            this.employeeBindingSource.DataSource = this.Presenter.db.Employees.Local.ToList();
            this.Presenter.db.Specialties.Load();
            this.specialtyBindingSource.DataSource = this.Presenter.db.Specialties.Local.ToList();
        }

        public DialogResult ResultDialog(string message, string head)
        {
            DialogResult result = MessageBox.Show(
                message,
                head,
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

            this.employmentDatePicker.Format = DateTimePickerFormat.Custom;
            this.birthDatePicker.Format = DateTimePickerFormat.Custom;
            this.employmentDatePicker.ShowCheckBox = true;
            this.birthDatePicker.ShowCheckBox = true;
            this.employmentDatePicker.Checked = false;
            this.birthDatePicker.Checked = false;
        }

        public void Reset()
        {
            this.Controls_toDefault();

            this.ADD_FLAG = this.EDIT_FLAG = false;

            this.controlsLayoutPanel.Enabled = false;
            this.dbLayoutPanel.Enabled = true;
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = false;

            this.birthDatePicker.MaxDate = DateTime.Now.AddYears(-18);
            this.employeesPicker.SelectedIndex = -1;

            this.Controls_toDefault();
        }

        private void EmployeesForm_FormClosed(object sender, EventArgs e)
        {
            this.Presenter.db.Dispose();
            this.Presenter.db = null;
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
            this.controlsLayoutPanel.Enabled = true;
            this.dbLayoutPanel.Enabled = false;

            this.Controls_toDefault();

            this.ADD_FLAG = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.employeesPicker.SelectedIndex == -1) return;

            this.controlsLayoutPanel.Enabled = true;
            this.dbLayoutPanel.Enabled = false;

            int index = (int)this.employeesPicker.SelectedValue;

            Employee employee = this.Presenter.db.Employees.Find(index);

            this.specialtiesPicker.SelectedValue = employee.SpecialtyId;

            this.nameInput.Text = employee.EmployeeName;
            this.surnameInput.Text = employee.EmployeeSurname;
            this.patronymicInput.Text = employee.EmployeePatronymic;
            this.passportInput.Text = employee.EmployeePassportNumber;
            this.addressInput.Text = employee.EmployeeAddress;
            this.telephoneInput.Text = employee.EmployeeTelephone;

            this.employmentDatePicker.Checked = employee.DateOfEmployment == null ? false : true;
            this.birthDatePicker.Checked = employee.DateOfBirth == null ? false : true;


            this.employmentDatePicker.Value = this.employmentDatePicker.Checked ?
                (DateTime)employee.DateOfEmployment : DateTime.Now ;

            this.birthDatePicker.Value = this.birthDatePicker.Checked ?
                (DateTime)employee.DateOfBirth : this.birthDatePicker.MaxDate;

            this.EDIT_FLAG = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.employeesPicker.SelectedIndex == -1) return;

            int index = (int)this.employeesPicker.SelectedValue;

            if (ResultDialog("Вы уверены, что хотите удалить выбранную запись?",
                "Удалить запись") == DialogResult.No) return;

            Employee employee = this.Presenter.db.Employees.Find(index);

            this.Presenter.db.Employees.Remove(employee);
            this.Presenter.db.SaveChanges();

            this.employeeBindingSource.DataSource = this.Presenter.db.Employees.Local.ToList();

            this.employeesPicker.SelectedIndex = -1;

            MessageBox.Show("Запись успешно удалена из базы данных!");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ADD_FLAG)
            {
                if (ResultDialog("Вы уверены, что хотите добавить новую запись?",
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

                employee.DateOfBirth = this.birthDatePicker.Checked == true ? this.birthDatePicker.Value : null;
                employee.DateOfEmployment = this.employmentDatePicker.Checked == true ? this.employmentDatePicker.Value : null;

                try
                {
                    this.Presenter.db.Employees.Add(employee);
                    this.Presenter.db.SaveChanges();

                    this.employeeBindingSource.DataSource = this.Presenter.db.Employees.Local.ToList();
                    MessageBox.Show("Запись успешно добавлена в базу данных!");
                    this.Controls_toDefault();
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Employees.Remove(employee);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Employees.Remove(employee);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }

            if (EDIT_FLAG)
            {
                if (ResultDialog("Вы уверены, что хотите изменить существующую запись?",
                    "Измененить запись") == DialogResult.No) return;

                int index = (int)this.employeesPicker.SelectedValue;

                Employee employee = this.Presenter.db.Employees.Find(index);

                employee.Specialty = (Specialty)this.specialtiesPicker.SelectedItem;

                employee.EmployeeName = this.nameInput.Text != "" ? this.nameInput.Text : null;
                employee.EmployeeSurname = this.surnameInput.Text != "" ? this.surnameInput.Text : null;
                employee.EmployeePatronymic = this.patronymicInput.Text != "" ? this.patronymicInput.Text : null;

                employee.EmployeePassportNumber = this.passportInput.Text != "" ?
                    this.passportInput.Text.Replace(" ", "") : null;

                employee.EmployeeAddress = this.addressInput.Text != "" ? this.addressInput.Text : null;

                employee.EmployeeTelephone = this.telephoneInput.Text != "" ?
                    Regex.Replace(this.telephoneInput.Text, @"(\D)", @"").Insert(0, "+") : null;

                employee.DateOfBirth = this.birthDatePicker.Checked == true ? this.birthDatePicker.Value : null;
                employee.DateOfEmployment = this.employmentDatePicker.Checked == true ? this.employmentDatePicker.Value : null;

                try
                {
                    this.Presenter.db.Entry(employee).State = EntityState.Modified;
                    this.Presenter.db.SaveChanges();

                    this.employeeBindingSource.DataSource = this.Presenter.db.Employees.Local.ToList();
                    MessageBox.Show("Запись успешно изменена в базе данных!");
                    this.Reset();
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Employees.Remove(employee);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Employees.Remove(employee);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору сотрудников?",
                "Отмена операции") == DialogResult.No) return;

            this.Reset();
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
                this.telephoneInput.Text = Regex.Replace(this.telephoneInput.Text,
                    @"\+(\d{1})(\d{3})(\d{3})(\d{2})(\d{2})", @"+$1 ($2) $3-$4-$5");
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var dtp = sender as DateTimePicker;
            dtp.Format = DateTimePickerFormat.Long;
        }

        private void dateTimePicker_Leave(object sender, EventArgs e)
        {
            var dtp = sender as DateTimePicker;
            dtp.ShowCheckBox = dtp.Checked ? false : true;
        }
    }
}
