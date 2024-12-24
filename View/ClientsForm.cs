
using EntityFramework.Exceptions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Text.RegularExpressions;

namespace App
{
    public partial class ClientsForm : Form, IView, IViewPages
    {
        private bool ADD_OWNER_FLAG;
        private bool EDIT_OWNER_FLAG;

        private bool ADD_CAR_FLAG;
        private bool EDIT_CAR_FLAG;

        Presenter Presenter;
        MainForm home;

        public ClientsForm(ref Presenter Presenter, MainForm home)
        {
            InitializeComponent();
            this.Presenter = Presenter;
            this.Presenter.db = new Context();
            this.Presenter.db.Database.EnsureCreated();
            this.home = home;

            this.Presenter.db.Owners.Load();
            this.ownerBindingSource.DataSource = this.Presenter.db.Owners.Local.ToList();
            this.Presenter.db.Cars.Load();
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
            this.ownersPicker.SelectedIndex = -1;
            this.carsPicker.SelectedIndex = -1;

            this.nameInput.Text =
                this.surnameInput.Text =
                this.patronymicInput.Text =
                this.passportInput.Text =
                this.addressInput.Text =
                this.telephoneInput.Text = null;

            this.brandInput.Text =
                this.modelInput.Text =
                this.VINInput.Text =
                this.licenseInput.Text = null;

            this.yearInput.Value = yearInput.Minimum;
            this.priceInput.Value = 0;
        }

        public void Reset()
        {
            this.Controls_toDefault();

            this.ADD_OWNER_FLAG =
                this.EDIT_OWNER_FLAG =
                this.ADD_CAR_FLAG =
                this.EDIT_CAR_FLAG = false;

            this.leftLayoutPanel.Enabled = this.rightLayoutPanel.Enabled = false;
            this.dbLayoutPanel.Enabled = true;
            this.clientsLayoutPanel.Enabled = true;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            this.leftLayoutPanel.Enabled = this.rightLayoutPanel.Enabled = false;

            this.yearInput.Maximum = DateTime.Now.Year;
            this.priceInput.Maximum = int.MaxValue;

            this.Controls_toDefault();
        }

        private void ClientsForm_FormClosed(object sender, EventArgs e)
        {
            this.Presenter.db.Dispose();
            this.Presenter.db = null;
            this.home.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.leftLayoutPanel.Enabled = this.rightLayoutPanel.Enabled = true;
            this.dbLayoutPanel.Enabled = false;
            this.clientsLayoutPanel.Enabled = false;

            this.Controls_toDefault();

            this.ADD_OWNER_FLAG = this.ADD_CAR_FLAG = true;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.ownersPicker.SelectedIndex == -1 && this.carsPicker.SelectedIndex == -1) return;

            this.dbLayoutPanel.Enabled = false;
            this.clientsLayoutPanel.Enabled = false;

            if (this.carsPicker.SelectedIndex == -1)
            {
                this.leftLayoutPanel.Enabled = true;
                int index = (int)this.ownersPicker.SelectedValue;

                Owner owner = this.Presenter.db.Owners.Find(index);

                this.nameInput.Text = owner.OwnerName;
                this.surnameInput.Text = owner.OwnerSurname;
                this.patronymicInput.Text = owner.OwnerPatronymic;
                this.passportInput.Text = owner.OwnerPassportNumber;
                this.addressInput.Text = owner.OwnerAddress;
                this.telephoneInput.Text = owner.OwnerTelephone;

                this.EDIT_OWNER_FLAG = true;
            }

            if (this.ownersPicker.SelectedIndex == -1)
            {
                this.rightLayoutPanel.Enabled = true;
                int index = (int)this.carsPicker.SelectedValue;

                Car car = this.Presenter.db.Cars.Find(index);

                if (car == null) { MessageBox.Show("Объект"); }
                if (car.BrandName == null) { MessageBox.Show("Поле"); }
                return;

                this.brandInput.Text = car.BrandName;
                this.modelInput.Text = car.ModelName;
                this.VINInput.Text = car.VehicleIdentificationNumber;
                this.licenseInput.Text = car.LicensePlate;
                
                this.yearInput.Value = Convert.ToInt32(car.Year);
                this.priceInput.Value = Convert.ToInt32(car.Price);

                this.EDIT_CAR_FLAG = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.ownersPicker.SelectedIndex == -1 && this.carsPicker.SelectedIndex == -1) return;

            if (this.carsPicker.SelectedIndex == -1)
            {
                int index = (int)this.ownersPicker.SelectedValue;

                if (ResultDialog("Вы уверены, что хотите удалить выбранную запись о владельце?",
                    "Удалить запись") == DialogResult.No) return;

                Owner owner = this.Presenter.db.Owners.Find(index);

                this.Presenter.db.Owners.Remove(owner);
                this.Presenter.db.SaveChanges();

                this.ownerBindingSource.DataSource = this.Presenter.db.Owners.Local.ToList();

                this.ownersPicker.SelectedIndex = -1;

                MessageBox.Show("Запись о владельце успешно удалена из базы данных!");
            }

            if (this.ownersPicker.SelectedIndex == -1)
            {
                int index = (int)this.ownersPicker.SelectedValue;

                if (ResultDialog("Вы уверены, что хотите удалить выбранную запись об автомобиле?",
                    "Удалить запись") == DialogResult.No) return;

                Car car = this.Presenter.db.Cars.Find(index);

                this.Presenter.db.Cars.Remove(car);
                this.Presenter.db.SaveChanges();

                this.ownerBindingSource.DataSource = this.Presenter.db.Cars.Local.ToList();

                this.carsPicker.SelectedIndex = -1;

                MessageBox.Show("Запись об автомобиле успешно удалена из базы данных!");
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (ADD_OWNER_FLAG)
            {
                if (ResultDialog("Вы уверены, что хотите добавить новую запись о владельце?",
                    "Добавить запись") == DialogResult.No) return;

                Owner owner = new Owner();

                owner.OwnerName = this.nameInput.Text != "" ? this.nameInput.Text : null;
                owner.OwnerSurname = this.surnameInput.Text != "" ? this.surnameInput.Text : null;
                owner.OwnerPatronymic = this.patronymicInput.Text != "" ? this.patronymicInput.Text : null;

                owner.OwnerPassportNumber = this.passportInput.Text != "" ?
                    this.passportInput.Text.Replace(" ", "") : null;

                owner.OwnerAddress = this.addressInput.Text != "" ? this.addressInput.Text : null;

                owner.OwnerTelephone = this.telephoneInput.Text != "" ?
                    Regex.Replace(this.telephoneInput.Text, @"(\D)", @"").Insert(0, "+") : null;

                try
                {
                    this.Presenter.db.Owners.Add(owner);
                    this.Presenter.db.SaveChanges();

                    this.ownersPicker.DataSource = this.Presenter.db.Owners.Local.ToList();
                    MessageBox.Show("Запись о владельце успешно добавлена в базу данных!");
                    this.Controls_toDefault();
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Owners.Remove(owner);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Owners.Remove(owner);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }

            if (ADD_CAR_FLAG)
            {
                if (ResultDialog("Вы уверены, что хотите добавить новую запись об автомобиле?",
                    "Добавить запись") == DialogResult.No) return;

                Car car = new Car();

                car.BrandName = this.brandInput.Text != "" ? this.brandInput.Text : null;
                car.ModelName = this.modelInput.Text != "" ? this.modelInput.Text : null;

                car.VehicleIdentificationNumber = this.VINInput.Text != "" ?
                    this.VINInput.Text.Replace(" ", "") : null;

                car.LicensePlate = this.licenseInput.Text != "" ?
                    Regex.Replace(this.licenseInput.Text, @"(\W)", @"") : null;

                car.Year = Convert.ToInt32(this.yearInput.Value);
                car.Price = Convert.ToInt32(this.priceInput.Value);

                try
                {
                    this.Presenter.db.Cars.Add(car);
                    this.Presenter.db.SaveChanges();

                    this.carsPicker.DataSource = this.Presenter.db.Cars.Local.ToList();
                    MessageBox.Show("Запись об автомобиле успешно добавлена в базу данных!");
                    this.Controls_toDefault();
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Cars.Remove(car);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Cars.Remove(car);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }

            if (EDIT_OWNER_FLAG)
            {
                if (ResultDialog("Вы уверены, что хотите изменить существующую запись о владельце?",
                    "Измененить запись") == DialogResult.No) return;

                int index = (int)this.ownersPicker.SelectedValue;

                Owner owner = this.Presenter.db.Owners.Find(index);

                owner.OwnerName = this.nameInput.Text != "" ? this.nameInput.Text : null;
                owner.OwnerSurname = this.surnameInput.Text != "" ? this.surnameInput.Text : null;
                owner.OwnerPatronymic = this.patronymicInput.Text != "" ? this.patronymicInput.Text : null;

                owner.OwnerPassportNumber = this.passportInput.Text != "" ?
                    this.passportInput.Text.Replace(" ", "") : null;

                owner.OwnerAddress = this.addressInput.Text != "" ? this.addressInput.Text : null;

                owner.OwnerTelephone = this.telephoneInput.Text != "" ?
                    Regex.Replace(this.telephoneInput.Text, @"(\D)", @"").Insert(0, "+") : null;

                try
                {
                    this.Presenter.db.Entry(owner).State = EntityState.Modified;
                    this.Presenter.db.SaveChanges();

                    this.ownersPicker.DataSource = this.Presenter.db.Owners.Local.ToList();
                    MessageBox.Show("Запись о владельце успешно изменена в базе данных!");
                    this.Reset();
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Owners.Remove(owner);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Owners.Remove(owner);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }

            if (EDIT_CAR_FLAG)
            {
                if (ResultDialog("Вы уверены, что хотите изменить существующую запись об автомобиле?",
                    "Измененить запись") == DialogResult.No) return;

                int index = (int)this.carsPicker.SelectedValue;

                Car car = this.Presenter.db.Cars.Find(index);

                car.BrandName = this.brandInput.Text != "" ? this.brandInput.Text : null;
                car.ModelName = this.modelInput.Text != "" ? this.modelInput.Text : null;

                car.VehicleIdentificationNumber = this.VINInput.Text != "" ?
                    this.VINInput.Text.Replace(" ", "") : null;

                car.LicensePlate = this.licenseInput.Text != "" ?
                    Regex.Replace(this.licenseInput.Text, @"(\W)", @"") : null;

                car.Year = Convert.ToInt32(this.yearInput.Value);
                car.Price = Convert.ToInt32(this.priceInput.Value);

                try
                {
                    this.Presenter.db.Entry(car).State = EntityState.Modified;
                    this.Presenter.db.SaveChanges();

                    this.carsPicker.DataSource = this.Presenter.db.Cars.Local.ToList();
                    MessageBox.Show("Запись об автомобиле успешно изменена в базе данных!");
                    this.Reset();
                }
                catch (CannotInsertNullException cine)
                {
                    this.Presenter.db.Cars.Remove(car);
                    ErrorDialog(cine.InnerException.Message, "Обязательное поле не заполнено!");
                }
                catch (ReferenceConstraintException rce)
                {
                    this.Presenter.db.Cars.Remove(car);
                    ErrorDialog(rce.InnerException.Message, "Значение указано неверно!");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору клиентов?",
                "Отмена операции") == DialogResult.No) return;

            this.Reset();
        }

        private void passportInput_Enter(object sender, EventArgs e)
        {
            this.passportInput.Text = passportInput.Text.Replace(" ", "");
        }

        private void passportInput_Leave(object sender, EventArgs e)
        {
            this.passportInput.Text = Regex.Replace(this.passportInput.Text, @"(\d{4})(\d{6})", @"$1 $2");
        }

        private void VINInput_Enter(object sender, EventArgs e)
        {
            this.VINInput.Text = VINInput.Text.Replace(" ", "");
        }

        private void VINInput_Leave(object sender, EventArgs e)
        {
            this.VINInput.Text = Regex.Replace(this.VINInput.Text, @"(\d{3})(\d{6})(\d{8})", @"$1 $2 $3");
        }

        private void telephoneInput_Enter(object sender, EventArgs e)
        {
            this.telephoneInput.Text = Regex.Replace(this.telephoneInput.Text, @"(\D)", @"").Insert(0, "+");
        }

        private void telephoneInput_Leave(object sender, EventArgs e)
        {
            this.telephoneInput.Text = Regex.IsMatch(this.telephoneInput.Text, @"^\+$") ? "" :
                this.telephoneInput.Text = Regex.Replace(this.telephoneInput.Text,
                    @"\+(\d{1})(\d{3})(\d{3})(\d{2})(\d{2})", @"+$1 ($2) $3-$4-$5");
        }

        private void licenseInputeInput_Enter(object sender, EventArgs e)
        {
            this.licenseInput.Text = Regex.Replace(this.licenseInput.Text, @"(\W)", @"");
        }

        private void licenseInputInput_Leave(object sender, EventArgs e)
        {
            this.licenseInput.Text = Regex.Replace(this.licenseInput.Text,
                    @"([АВЕКМНОРСТУХ]{1})(\d{3})([АВЕКМНОРСТУХ]{2})", @"$1$2$3");
        }
    }
}
