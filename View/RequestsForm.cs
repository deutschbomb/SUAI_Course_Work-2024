
using EntityFramework.Exceptions.Common;
using Microsoft.EntityFrameworkCore;

namespace App
{
    public partial class RequestsForm : Form, IView, IViewDefault
    {
        private bool ADD_FLAG;
        private bool EDIT_FLAG;

        Presenter Presenter;
        MainForm home;

        public RequestsForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;

            this.Presenter.db.Requests.Load();
            this.Presenter.db.Employees.Where(e => e.SpecialtyId == 1).Load();
            this.Presenter.db.Owners.Load();
            this.Presenter.db.Cars.Load();

            this.requestBindingSource.DataSource = this.Presenter.db.Requests.Local.ToList();
            this.employeeBindingSource.DataSource = this.Presenter.db.Employees.Local.ToList();
            this.ownerBindingSource.DataSource = this.Presenter.db.Owners.Local.ToList();
            this.carBindingSource.DataSource = this.Presenter.db.Cars.Local.ToList();
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

            this.ADD_FLAG = this.EDIT_FLAG = false;

            this.controlsLayoutPanel.Enabled = false;
            this.dbLayoutPanel.Enabled = true;
        }

        private void RequestsForm_Load(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = false;

            this.Controls_toDefault();
        }

        private void RequestsForm_FormClosed(object sender, EventArgs e)
        {
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

        private void toOrdersButton_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm(ref Presenter, home, this);
            this.Hide();
            order.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = true;
            this.dbLayoutPanel.Enabled = false;

            this.Controls_toDefault();

            this.ADD_FLAG = true;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = true;
            this.dbLayoutPanel.Enabled = false;
            this.requestsTable.Enabled = false;

            int index = (int)this.requestsTable
                [0, this.requestsTable.CurrentRow.Index].Value;

            Request request = this.Presenter.db.Requests.Find(index);

            this.postDatePicker.Value = (DateTime)request.RequestDate;
            this.startDatePicker.Value = (DateTime)request.StartDate;
            this.completeDatePicker.Value = (DateTime)request.CompleteDate;

            this.completedCheckBox.Checked = request.Completed;

            this.EDIT_FLAG = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int index = (int)this.requestsTable
                [0, this.requestsTable.CurrentRow.Index].Value;

            if (ResultDialog("Вы уверены, что хотите удалить выбранную запись о заявке на ремонт?",
                "Удалить запись") == DialogResult.No) return;

            Request request = this.Presenter.db.Requests.Find(index);

            this.Presenter.db.Requests.Remove(request);
            this.Presenter.db.SaveChanges();

            this.requestBindingSource.DataSource = this.Presenter.db.Requests.Local.ToList();

            MessageBox.Show("Запись о заявке на ремонт успешно удалена из базы данных!");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ADD_FLAG)
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
                    this.Presenter.db.Requests.Add(request);
                    this.Presenter.db.SaveChanges();

                    this.requestBindingSource.DataSource = this.Presenter.db.Requests.Local.ToList();
                    MessageBox.Show("Запись о заявке на ремонт успешно добавлена в базу данных!");
                    this.Controls_toDefault();
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Requests.Remove(request);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Requests.Remove(request);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }

                this.Controls_toDefault();
            }

            if (EDIT_FLAG)
            {
                int index = (int)this.requestsTable
                    [0, this.requestsTable.CurrentRow.Index].Value;

                if (ResultDialog("Вы уверены, что хотите изменить существующую запись о заявке на ремонт?",
                    "Измененить запись") == DialogResult.No) return;

                Request request = this.Presenter.db.Requests.Find(index);

                request.Employee = (Employee)this.employeesPicker.SelectedValue;
                request.Owner = (Owner)this.ownersPicker.SelectedValue;
                request.Car = (Car)this.carsPicker.SelectedValue;

                request.RequestDate = this.postDatePicker.Checked == true ? this.postDatePicker.Value : null;
                request.StartDate = this.startDatePicker.Checked == true ? this.startDatePicker.Value : null;
                request.CompleteDate = this.completeDatePicker.Checked == true ? this.completeDatePicker.Value : null;

                request.Completed = this.completedCheckBox.Checked;

                try
                {
                    this.Presenter.db.Entry(request).State = EntityState.Modified;
                    this.Presenter.db.SaveChanges();

                    this.requestBindingSource.DataSource = this.Presenter.db.Requests.Local.ToList();
                    MessageBox.Show("Запись о заявке на ремонт успешно изменена в базе данных!");
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Requests.Remove(request);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Requests.Remove(request);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору заявок на ремонт?",
                "Отмена операции") == DialogResult.No) return;

            this.Return();
        }
    }
}
