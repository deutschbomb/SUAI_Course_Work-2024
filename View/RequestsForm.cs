
using Microsoft.EntityFrameworkCore;

namespace App
{
    public partial class RequestsForm : Form, IView
    {
        Presenter Presenter;
        MainForm home;

        public RequestsForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;

            this.Presenter.db?.Requests.Load();
            this.requestBindingSource.DataSource = this.Presenter.db?.Requests.Local.ToList();
            this.Presenter.db?.Employees.Load();
            this.employeeBindingSource.DataSource = this.Presenter.db?.Employees.Local.ToList();
            this.Presenter.db?.Owners.Load();
            this.ownerBindingSource.DataSource = this.Presenter.db?.Owners.Local.ToList();
            this.Presenter.db?.Cars.Load();
            this.carBindingSource.DataSource = this.Presenter.db?.Cars.Local.ToList();

            this.controlsLayoutPanel.Enabled = false;
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

        private void RequestsForm_FormClosed(object sender, EventArgs e)
        {
            this.home.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = true;

            this.employeePicker.SelectedIndex = 0;
            this.ownersPicker.SelectedIndex = 0;
            this.carsPicker.SelectedIndex = 0;

            this.postDatePicker.Value = DateTime.Now;
            this.startDatePicker.Value = DateTime.Now;
            this.endDatePicker.Value = DateTime.Now;

            this.endedCheckBox.Checked = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = this.requestsTable.Columns[0].DisplayIndex != null ? true : false;
            if (this.requestsTable.CurrentCell.ColumnIndex == this.requestsTable.Columns[0].DisplayIndex)
            {
                int index = (int)this.requestsTable
                    [requestsTable.CurrentCellAddress.X, requestsTable.CurrentCellAddress.Y].Value;

                Request request = this.Presenter.db?.Requests.Find(index);

                this.employeePicker.SelectedValue = request.EmployeeId;
                this.ownersPicker.SelectedValue = request.OwnerId;
                this.carsPicker.SelectedValue = request.CarId;

                this.postDatePicker.Value = (DateTime)request.RequestDate;
                this.startDatePicker.Value = (DateTime)request.StartDate;
                this.endDatePicker.Value = (DateTime)request.CompleteDate;

                this.endedCheckBox.Checked = request.Completed;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.requestsTable.CurrentCell.ColumnIndex == this.requestsTable.Columns[0].DisplayIndex)
            {
                int index = (int)this.requestsTable
                    [requestsTable.CurrentCellAddress.X, requestsTable.CurrentCellAddress.Y].Value;

                DialogResult result = MessageBox.Show(
                    "Вы уверены, что хотите удалить выбранную запись?",
                    "Удалить запись",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                Request request = this.Presenter.db?.Requests.Find(index);

                this.Presenter.db?.Requests.Remove(request);
                this.Presenter.db?.SaveChanges();

                this.requestBindingSource.DataSource = this.Presenter.db?.Requests.Local.ToList();

                MessageBox.Show("Запись успешно удалена из базы данных!");
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите добавить новую запись?",
                "Добавить запись",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            Request request = new Request();
            request.Employee = (Employee)this.employeePicker.SelectedItem;
            request.Owner = (Owner)this.ownersPicker.SelectedItem;
            request.Car = (Car)this.carsPicker.SelectedItem;

            request.RequestDate = this.postDatePicker.Value;
            request.StartDate = this.startDatePicker.Value;
            request.CompleteDate = this.endDatePicker.Value;

            request.Completed = this.endedCheckBox.Checked;


            this.Presenter.db?.Requests.Add(request);
            this.Presenter.db?.SaveChanges();

            this.requestBindingSource.DataSource = this.Presenter.db?.StorageParts.Local.ToList();

            MessageBox.Show("Запись успешно добавлена в базу данных!");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = true;

            this.employeePicker.SelectedIndex = 0;
            this.ownersPicker.SelectedIndex = 0;
            this.carsPicker.SelectedIndex = 0;

            this.postDatePicker.Value = DateTime.Now;
            this.startDatePicker.Value = DateTime.Now;
            this.endDatePicker.Value = DateTime.Now;

            this.endedCheckBox.Checked = false;
        }
    }
}
