
using EntityFramework.Exceptions.Common;
using System.Text.RegularExpressions;

namespace App
{
    public partial class StorageForm : Form, IView, IViewDefault
    {
        Presenter Presenter;
        MainForm home;

        public StorageForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.home = home;
            this.Presenter.ContextLoad();

            this.Presenter.StoragePartsTableLoad();
            this.Presenter.PartsTableLoad();

            this.accountingBindingSource.DataSource = this.Presenter.StoragePartsTableToList();
            this.partBindingSource.DataSource = this.Presenter.PartsTableToList();
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

            this.catalogueNumberInput.Text =
                this.nameInput.Text = null;

            this.balanceInput.Value =
                this.priceInput.Value = 0;
        }

        public void Return()
        {
            this.Controls_toDefault();

            this.acceptButton.Visible = true;
            this.editButton.Visible = false;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toLogisticsButton_Click(object sender, EventArgs e)
        {
            LogisticsForm logistics = new LogisticsForm(ref Presenter, home, this);
            this.Hide();
            logistics.Show();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            this.balanceInput.Maximum =
                this.priceInput.Maximum = int.MaxValue;

            this.Controls_toDefault();
        }

        private void StorageForm_FormClosed(object sender, EventArgs e)
        {
            this.Presenter.ContextDispose();
            this.home.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Controls_toDefault();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (this.storageTable.CurrentRow is null) return;

            this.controlsLayoutPanel.Enabled = !this.controlsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;

            int index = (int)this.storageTable
                [0, this.storageTable.CurrentRow.Index].Value;

            Accounting accounting = this.Presenter.StoragePartsFind(index);

            this.catalogueNumberInput.Text = accounting.Part.CatalogueNumber;
            this.nameInput.Text = accounting.Part.PartName;
            this.balanceInput.Value = Convert.ToInt32(accounting.Balance);
            this.priceInput.Value = Convert.ToInt32(accounting.PartPrice);

            this.acceptButton.Visible = false;
            this.editButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.storageTable.CurrentRow is null) return;
            
            if (ResultDialog("Вы уверены, что хотите удалить выбранную запись о запчасти?",
                "Удалить запись") == DialogResult.No) return;

            int index = (int)this.storageTable[0, storageTable.CurrentCellAddress.Y].Value;

            Accounting accounting = this.Presenter.db.StorageParts.Find(index);

            this.Presenter.StoragePartsRemove(accounting);
            this.Presenter.PartsRemove(accounting.Part);
            this.Presenter.ContextSaveChanges();

            this.accountingBindingSource.DataSource = this.Presenter.StoragePartsTableToList();
            this.partBindingSource.DataSource = this.Presenter.PartsTableToList();

            MessageBox.Show("Запись успешно удалена из базы данных!");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите добавить новую запись о запчасти?",
                "Добавить запись") == DialogResult.No) return;

            Accounting accounting = new Accounting();

            accounting.Part = new Part
            {
                CatalogueNumber = this.catalogueNumberInput.Text != "" ?
                    Regex.Replace(this.catalogueNumberInput.Text, @"(\W)", @"") : null,

                PartName = this.nameInput.Text != "" ? this.nameInput.Text : null
            };

            accounting.Balance = Convert.ToInt32(this.balanceInput.Value);
            accounting.PartPrice = Convert.ToInt32(this.priceInput.Value);

            try
            {
                this.Presenter.StoragePartsAdd(accounting);
                this.Presenter.ContextSaveChanges();

                this.accountingBindingSource.DataSource = this.Presenter.StoragePartsTableToList();
                this.partBindingSource.DataSource = this.Presenter.PartsTableToList();

                MessageBox.Show("Запись о запчасти успешно добавлена в базу данных!");
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.StoragePartsRemove(accounting);
                this.Presenter.PartsRemove(accounting.Part);

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
            }

            this.Controls_toDefault();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.storageTable.CurrentRow is null) return;
            
            if (ResultDialog("Вы уверены, что хотите изменить существующую запись о запчасти?",
                "Измененить запись") == DialogResult.No) return;

            int index = (int)this.storageTable[0, storageTable.CurrentCellAddress.Y].Value;

            Accounting accounting = this.Presenter.db.StorageParts.Find(index);

            accounting.Part.CatalogueNumber = this.catalogueNumberInput.Text != "" ?
                    Regex.Replace(this.catalogueNumberInput.Text, @"(\W)", @"") : null;

            accounting.Part.PartName = this.nameInput.Text != "" ? this.nameInput.Text : null;

            accounting.Balance = Convert.ToInt32(this.balanceInput.Value);
            accounting.PartPrice = Convert.ToInt32(this.priceInput.Value);

            try
            {
                this.Presenter.StoragePartsEntry(accounting);
                this.Presenter.ContextSaveChanges();

                this.accountingBindingSource.DataSource = this.Presenter.StoragePartsTableToList();
                this.partBindingSource.DataSource = this.Presenter.PartsTableToList();

                MessageBox.Show("Запись о запчасти успешно изменена в базе данных!");
            }
            catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
            {
                this.Presenter.StoragePartsRemove(accounting);
                this.Presenter.PartsRemove(accounting.Part);

                if (ex is CannotInsertNullException)
                    ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                if (ex is ReferenceConstraintException)
                    ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
            }

            this.Return();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору запчастей?",
                "Отмена операции") == DialogResult.No) return;

            this.Return();
        }

        private void catalogueNumberInput_Enter(object sender, EventArgs e)
        {
            this.catalogueNumberInput.Text = Regex.Replace(this.catalogueNumberInput.Text, @"(\W)", @"");
        }

        private void catalogueNumberInput_Leave(object sender, EventArgs e)
        {
            this.catalogueNumberInput.Text = Regex.Replace(this.catalogueNumberInput.Text,
                @"(\w{2})(\w{2})(\w{3})(\w{3})", @"$1 $2 $3 $4");
        }
    }
}
