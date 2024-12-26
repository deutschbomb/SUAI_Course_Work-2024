
using EntityFramework.Exceptions.Common;

namespace App
{
    public partial class LogisticsForm : Form, IView, IViewDefault
    {
        Presenter Presenter;
        MainForm home;
        Form previous;

        public void InitializeData(Presenter? presenter = null, MainForm? home = null)
        {
            this.Presenter = presenter;
            this.home = home;
            this.previous = this.home;
            this.Presenter.ContextLoad();

            this.Presenter.SuppliesTableLoad();
            this.Presenter.EmployeesBySpecialtyLoad(3);
            this.Presenter.SuppliersTableLoad();

            this.Presenter.PartsTableLoad();
            this.Presenter.PositionsTableLoad();

            this.supplyBindingSource.DataSource = this.Presenter.SuppliesTableToList();
            this.supplierBindingSource.DataSource = this.Presenter.SuppliersTableToList();
            this.employeeBindingSource.DataSource = this.Presenter.EmployeesTableToList();

            this.partBindingSource.DataSource = this.Presenter.PartsTableToList();
            this.positionBindingSource.DataSource = this.Presenter.PositionsTableToList();
        }

        public LogisticsForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            InitializeData(Presenter, home);
        }

        public LogisticsForm(ref Presenter Presenter, MainForm home, StorageForm prev)
        {
            InitializeComponent();
            InitializeData(Presenter, home);
            this.previous = prev;
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
            this.suppliersPicker.SelectedIndex = -1;
            this.partsPicker.DataSource = null;

            this.amountInput.Value = 0;
            this.deliveryStateCheckBox.Checked = false;

            this.postDatePicker.Value = DateTime.Now;
            this.deliveryDatePicker.Value = this.postDatePicker.Value.AddDays(1);
        }

        public void Return()
        {
            this.Controls_toDefault();

            this.acceptButton.Visible = true;
            this.editButton.Visible = false;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.previous = this.previous == this.home ? this.previous : this.home;
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogisticsForm_Load(object sender, EventArgs e)
        {
            this.Controls_toDefault();
        }

        private void LogisticsForm_FormClosed(object sender, EventArgs e)
        {
            this.Presenter.ContextDispose();
            this.previous.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Controls_toDefault();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (this.suppliesTable.CurrentRow is null) return;

            this.controlsLayoutPanel.Enabled = !this.controlsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;

            int index1 = (int)this.suppliesTable
                [0, this.suppliesTable.CurrentRow.Index].Value;

            Supply supply = this.Presenter.SuppliesFind(index1);

            this.employeesPicker.SelectedValue = supply.EmployeeId;
            this.suppliersPicker.SelectedValue = supply.SupplierId;

            this.partsPicker.DataSource = supply.Parts;
            this.partsPicker.DisplayMember = "GetPart";
            this.partsPicker.ValueMember = "PartId";

            int index2 = (int)this.partsPicker.SelectedValue;

            Position position = this.Presenter.PositionsFind(index1, index2);

            this.amountInput.Value = position.Amount;

            this.postDatePicker.Value = (DateTime)supply.DateOfPost;
            this.deliveryDatePicker.Value = (DateTime)supply.DateOfDelivery;

            this.deliveryStateCheckBox.Checked = supply.Delivered;

            this.acceptButton.Visible = false;
            this.editButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.suppliesTable.CurrentRow is null) return;

            int index = (int)this.suppliesTable[0, suppliesTable.CurrentCellAddress.Y].Value;

            if (ResultDialog("Вы уверены, что хотите удалить выбранную запись о поставке?",
                "Удалить запись") == DialogResult.No) return;

            Supply supply = this.Presenter.SuppliesFind(index);

            this.Presenter.SuppliesRemove(supply);
            this.Presenter.ContextSaveChanges();

            this.suppliesTable.DataSource = this.Presenter.SuppliesTableToList();

            MessageBox.Show("Запись о поставке успешно удалена из базы данных!");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите добавить новую запись о поставке?",
                "Добавить запись") == DialogResult.No) return;

            Supply supply = new Supply();

            supply.Employee = (Employee)this.employeesPicker.SelectedItem;
            supply.Supplier = (Supplier)this.suppliersPicker.SelectedItem;

            supply.DateOfPost = this.postDatePicker.Value;
            supply.DateOfDelivery = this.deliveryDatePicker.Value;
            supply.Delivered = this.deliveryStateCheckBox.Checked;

            Position position = new Position
            {
                Supply = supply,
                Part = (Part)this.partsPicker.SelectedItem,
                Amount = Convert.ToInt32(this.amountInput.Value)
            };

            try
            {
                this.Presenter.SuppliesAdd(supply);
                this.Presenter.PositionsAdd(position);
                this.Presenter.ContextSaveChanges();
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.SuppliesRemove(supply);

                this.supplyBindingSource.DataSource = this.Presenter.SuppliesTableToList();

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                return;
            }

            this.supplyBindingSource.DataSource = this.Presenter.SuppliesTableToList();

            MessageBox.Show("Запись о поставке успешно добавлена в базу данных!");
            this.Controls_toDefault();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите изменить существующую запись о поставке?",
                "Измененить запись") == DialogResult.No) return;

            int index = (int)this.suppliesTable[0, suppliesTable.CurrentCellAddress.Y].Value;

            Supply supply = this.Presenter.SuppliesFind(index);

            supply.Employee = (Employee)this.employeesPicker.SelectedItem;
            supply.Supplier = (Supplier)this.suppliersPicker.SelectedItem;

            supply.DateOfPost = this.postDatePicker.Value;
            supply.DateOfDelivery = this.deliveryDatePicker.Value;
            supply.Delivered = this.deliveryStateCheckBox.Checked;

            Position position = new Position
            {
                Supply = supply,
                Part = (Part)this.partsPicker.SelectedItem,
                Amount = Convert.ToInt32(this.amountInput.Value)
            };

            try
            {
                this.Presenter.SuppliesEntry(supply);
                this.Presenter.PositionsEntry(position);
                this.Presenter.ContextSaveChanges();
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.SuppliesRemove(supply);

                this.supplyBindingSource.DataSource = this.Presenter.SuppliesTableToList();

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                return;
            }

            this.supplyBindingSource.DataSource = this.Presenter.SuppliesTableToList();

            MessageBox.Show("Запись о поставке успешно изменена в базе данных!");
            this.Return();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору поставок?",
                "Отмена операции") == DialogResult.No) return;

            this.Return();
        }

        private void suppliersPicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int index = (int)this.suppliersPicker.SelectedValue;
            this.partsPicker.DataSource = this.Presenter.NomenclatureToList(index);

            this.partsPicker.DisplayMember = "GetPart";
            this.partsPicker.ValueMember = "PartId";

            this.partsPicker.SelectedIndex = -1;
        }
    }
}
