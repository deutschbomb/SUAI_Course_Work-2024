
using EntityFramework.Exceptions.Common;
using System.Reflection;

namespace App
{
    public partial class RequestsForm : Form, IView, IViewDefault, IViewControls
    {
        Presenter Presenter;
        MainForm home;

        public void InitializeData(Presenter? presenter = null, MainForm? home = null)
        {
            this.Presenter = presenter;
            this.home = home;
            this.Presenter.ContextLoad();

            this.Presenter.RequestsTableLoad();
            this.Presenter.EmployeesBySpecialtyLoad(1);
            this.Presenter.OwnersTableLoad();
            this.Presenter.CarsTableLoad();

            this.requestBindingSource.DataSource = this.Presenter.RequestsTableToList();
            this.employeeBindingSource.DataSource = this.Presenter.EmployeesTableToList();
            this.ownerBindingSource.DataSource = this.Presenter.OwnersTableToList();
            this.carBindingSource.DataSource = this.Presenter.CarsTableToList();
        }

        public RequestsForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            InitializeData(Presenter, home);
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
            this.controlsLayoutPanel.Enabled = !this.controlsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;

            this.employeesPicker.SelectedIndex = -1;
            this.ownersPicker.SelectedIndex = -1;
            this.carsPicker.SelectedIndex = -1;

            this.completedCheckBox.Checked = false;

            this.postDatePicker.Value =
                this.startDatePicker.Value = DateTime.Now;
            this.completeDatePicker.Value = this.startDatePicker.Value.AddDays(1);
        }

        public void Return()
        {
            this.Controls_toDefault();

            this.acceptButton.Visible = true;
            this.editButton.Visible = false;
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            this.Controls_toDefault();
        }

        private void RequestsForm_FormClosed(object sender, EventArgs e)
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
            if (this.requestsTable.CurrentRow is null) return;

            this.controlsLayoutPanel.Enabled = !this.controlsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;

            int index = (int)this.requestsTable
                [0, this.requestsTable.CurrentRow.Index].Value;

            Request request = this.Presenter.RequestsFind(index);

            this.employeesPicker.SelectedValue = request.EmployeeId;
            this.ownersPicker.SelectedValue = request.OwnerId;
            this.carsPicker.SelectedValue = request.CarId;

            this.postDatePicker.Value = (DateTime)request.RequestDate;
            this.startDatePicker.Value = (DateTime)request.StartDate;
            this.completeDatePicker.Value = (DateTime)request.CompleteDate;

            this.completedCheckBox.Checked = request.Completed;

            this.acceptButton.Visible = false;
            this.editButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.requestsTable.CurrentRow is null) return;

            if (ResultDialog("Вы уверены, что хотите удалить выбранную запись о заявке на ремонт?",
                "Удалить запись") == DialogResult.No) return;

            int index = (int)this.requestsTable
                [0, this.requestsTable.CurrentRow.Index].Value;

            Request request = this.Presenter.RequestsFind(index);

            this.Presenter.RequestsRemove(request);
            this.Presenter.ContextSaveChanges();

            this.requestBindingSource.DataSource = this.Presenter.RequestsTableToList();

            MessageBox.Show("Запись о заявке на ремонт успешно удалена из базы данных!");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите добавить новую запись о заявке на ремонт?",
                "Добавить запись") == DialogResult.No) return;

            Request request = new Request();

            request.Employee = (Employee)this.employeesPicker.SelectedItem;
            request.Owner = (Owner)this.ownersPicker.SelectedItem;
            request.Car = (Car)this.carsPicker.SelectedItem;

            request.RequestDate = this.postDatePicker.Checked == true ? this.postDatePicker.Value : null;
            request.StartDate = this.startDatePicker.Checked == true ? this.startDatePicker.Value : null;
            request.CompleteDate = this.completeDatePicker.Checked == true ? this.completeDatePicker.Value : null;

            request.Completed = this.completedCheckBox.Checked;

            try
            {
                this.Presenter.RequestsAdd(request);
                this.Presenter.ContextSaveChanges();
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.RequestsRemove(request);

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                return;
            }

            this.requestBindingSource.DataSource = this.Presenter.RequestsTableToList();

            MessageBox.Show("Запись о заявке на ремонт успешно добавлена в базу данных!");
            this.Controls_toDefault();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите изменить существующую запись о заявке на ремонт?",
                "Измененить запись") == DialogResult.No) return;

            int index = (int)this.requestsTable
                [0, this.requestsTable.CurrentRow.Index].Value;

            Request request = this.Presenter.RequestsFind(index);

            request.Employee = (Employee)this.employeesPicker.SelectedValue;
            request.Owner = (Owner)this.ownersPicker.SelectedValue;
            request.Car = (Car)this.carsPicker.SelectedValue;

            request.RequestDate = this.postDatePicker.Checked == true ? this.postDatePicker.Value : null;
            request.StartDate = this.startDatePicker.Checked == true ? this.startDatePicker.Value : null;
            request.CompleteDate = this.completeDatePicker.Checked == true ? this.completeDatePicker.Value : null;

            request.Completed = this.completedCheckBox.Checked;

            try
            {
                this.Presenter.RequestsEntry(request);
                this.Presenter.ContextSaveChanges();
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.RequestsRemove(request);

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                return;
            }

            this.requestBindingSource.DataSource = this.Presenter.RequestsTableToList();

            MessageBox.Show("Запись о заявке на ремонт успешно изменена в базе данных!");
            this.Return();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору заявок на ремонт?",
                "Отмена операции") == DialogResult.No) return;

            this.Return();
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
