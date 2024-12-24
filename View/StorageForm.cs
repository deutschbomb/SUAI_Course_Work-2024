
using EntityFramework.Exceptions.Common;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace App
{
    public partial class StorageForm : Form, IView, IViewPages
    {
        private bool ADD_FLAG;
        private bool EDIT_FLAG;

        Presenter Presenter;
        MainForm home;

        public StorageForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.Presenter.db = new Context();
            this.Presenter.db.Database.EnsureCreated();
            this.home = home;

            this.Presenter.db.StorageParts.Load();
            this.accountingBindingSource.DataSource = this.Presenter.db.StorageParts.Local.ToList();
            this.Presenter.db.Parts.Load();
            this.partBindingSource.DataSource = this.Presenter.db.Parts.Local.ToList();
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
            this.catalogueNumberInput.Text =
                this.nameInput.Text = null;

            this.balanceInput.Value =
                this.priceInput.Value = 0;
        }

        public void Reset()
        {
            this.Controls_toDefault();

            this.ADD_FLAG = this.EDIT_FLAG = false;

            this.controlsLayoutPanel.Enabled = false;
            this.dbLayoutPanel.Enabled = true;
            this.storageTable.Enabled = true;
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
            this.controlsLayoutPanel.Enabled = false;

            this.balanceInput.Maximum =
                this.priceInput.Maximum = int.MaxValue;

            this.Controls_toDefault();
        }

        private void StorageForm_FormClosed(object sender, EventArgs e)
        {
            this.Presenter.db.Dispose();
            this.Presenter.db = null;
            this.home.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.controlsLayoutPanel.Enabled = true;
            this.dbLayoutPanel.Enabled = false;
            this.storageTable.Enabled = false;

            this.Controls_toDefault();

            this.ADD_FLAG = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.storageTable.CurrentCell.ColumnIndex != this.storageTable.Columns[0].DisplayIndex) return;

            this.controlsLayoutPanel.Enabled = true;
            this.dbLayoutPanel.Enabled = false;
            this.storageTable.Enabled = false;

            int index = (int)this.storageTable
                [storageTable.CurrentCellAddress.X, storageTable.CurrentCellAddress.Y].Value;

            Accounting storagePart = this.Presenter.db.StorageParts.Find(index);

            this.catalogueNumberInput.Text = storagePart.Part.CatalogueNumber;
            this.nameInput.Text = storagePart.Part.PartName;
            this.balanceInput.Value = Convert.ToInt32(storagePart.Balance);
            this.priceInput.Value = Convert.ToInt32(storagePart.PartPrice);

            this.EDIT_FLAG = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.storageTable.CurrentCell.ColumnIndex != this.storageTable.Columns[0].DisplayIndex) return;
            int index = (int)this.storageTable
                [storageTable.CurrentCellAddress.X, storageTable.CurrentCellAddress.Y].Value;

            if (ResultDialog("Вы уверены, что хотите удалить выбранную запись?",
                "Удалить запись") == DialogResult.No) return;

            Accounting accounting = this.Presenter.db.StorageParts.Find(index);

            this.Presenter.db.StorageParts.Remove(accounting);
            this.Presenter.db.Parts.Remove(accounting.Part);
            this.Presenter.db.SaveChanges();

            this.partBindingSource.DataSource = this.Presenter.db.Parts.Local.ToList();
            this.accountingBindingSource.DataSource = this.Presenter.db.StorageParts.Local.ToList();

            MessageBox.Show("Запись успешно удалена из базы данных!");
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ADD_FLAG)
            {
                if (ResultDialog("Вы уверены, что хотите добавить новую запись?",
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
                    this.Presenter.db.StorageParts.Add(accounting);
                    this.Presenter.db.SaveChanges();

                    this.partBindingSource.DataSource = this.Presenter.db.Parts.Local.ToList();
                    this.accountingBindingSource.DataSource = this.Presenter.db.StorageParts.Local.ToList();

                    MessageBox.Show("Запись успешно добавлена в базу данных!");
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.StorageParts.Remove(accounting);
                    this.Presenter.db.Parts.Remove(accounting.Part);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.StorageParts.Remove(accounting);
                    this.Presenter.db.Parts.Remove(accounting.Part);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }

                this.Controls_toDefault();
            }

            if (EDIT_FLAG)
            {

                if (this.storageTable.CurrentCell.ColumnIndex != this.storageTable.Columns[0].DisplayIndex) return;
                int index = (int)this.storageTable
                    [storageTable.CurrentCellAddress.X, storageTable.CurrentCellAddress.Y].Value;

                if (ResultDialog("Вы уверены, что хотите изменить существующую запись?",
                    "Измененить запись") == DialogResult.No) return;

                Accounting accounting = this.Presenter.db.StorageParts.Find(index);

                accounting.Part.CatalogueNumber = this.catalogueNumberInput.Text != "" ?
                        Regex.Replace(this.catalogueNumberInput.Text, @"(\W)", @"") : null;

                accounting.Part.PartName = this.nameInput.Text != "" ? this.nameInput.Text : null;

                accounting.Balance = Convert.ToInt32(this.balanceInput.Value);
                accounting.PartPrice = Convert.ToInt32(this.priceInput.Value);

                try
                {
                    this.Presenter.db.Entry(accounting).State = EntityState.Modified;
                    this.Presenter.db.SaveChanges();

                    this.partBindingSource.DataSource = this.Presenter.db.Parts.Local.ToList();
                    this.accountingBindingSource.DataSource = this.Presenter.db.StorageParts.Local.ToList();

                    MessageBox.Show("Запись успешно изменена в базе данных!");
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.StorageParts.Remove(accounting);
                    this.Presenter.db.Parts.Remove(accounting.Part);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.StorageParts.Remove(accounting);
                    this.Presenter.db.Parts.Remove(accounting.Part);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору запчастей?",
                "Отмена операции") == DialogResult.No) return;

            this.Reset();
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
