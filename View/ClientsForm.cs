
using EntityFramework.Exceptions.Common;
using System.Reflection;
using System.Text.RegularExpressions;

namespace App
{
    public partial class ClientsForm : Form, IView, IViewDefault, IViewDefaultClients, IViewControls
    {
        Presenter Presenter;
        MainForm home;

        public void InitializeData(Presenter? presenter = null, MainForm? home = null)
        {
            this.Presenter = presenter;
            this.home = home;
            this.Presenter.ContextLoad();

            this.Presenter.OwnersTableLoad();
            this.Presenter.CarsTableLoad();

            this.ownerBindingSource.DataSource = this.Presenter.OwnersTableToList();
            this.carBindingSource.DataSource = this.Presenter.CarsTableToList();
        }

        public ClientsForm(ref Presenter Presenter, MainForm home)
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

        public void ownerControls_toDefault()
        {
            this.ownerLayoutPanel.Enabled = false;

            this.ownersPicker.SelectedIndex = -1;

            this.nameInput.Text =
                this.surnameInput.Text =
                this.patronymicInput.Text =
                this.passportInput.Text =
                this.addressInput.Text =
                this.telephoneInput.Text = null;
        }

        public void carControls_toDefault()
        {
            this.carLayoutPanel.Enabled = false;

            this.carsPicker.SelectedIndex = -1;

            this.brandInput.Text =
                this.modelInput.Text =
                this.VINInput.Text =
                this.licenseInput.Text = null;

            this.yearInput.Value = yearInput.Minimum;
            this.priceInput.Value = 0;
        }

        public void Controls_toDefault()
        {
            this.buttonsLayoutPanel.Enabled = !this.buttonsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;
            ownerControls_toDefault();
            carControls_toDefault();
        }

        public void Return()
        {
            this.Controls_toDefault();

            this.acceptButton.Visible = true;
            this.editButton.Visible = false;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            this.yearInput.Maximum = DateTime.Now.Year;
            this.priceInput.Maximum = int.MaxValue;

            this.Controls_toDefault();
        }

        private void ClientsForm_FormClosed(object sender, EventArgs e)
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
            if (this.ownersPicker.SelectedIndex == -1 && this.carsPicker.SelectedIndex == -1) return;

            this.buttonsLayoutPanel.Enabled = !this.buttonsLayoutPanel.Enabled;
            this.dbLayoutPanel.Enabled = !this.dbLayoutPanel.Enabled;

            if (this.ownersPicker.SelectedIndex != -1)
            {
                this.ownerLayoutPanel.Enabled = !this.ownerLayoutPanel.Enabled;

                int index = (int)this.ownersPicker.SelectedValue;

                Owner owner = this.Presenter.OwnersFind(index);

                this.nameInput.Text = owner.OwnerName;
                this.surnameInput.Text = owner.OwnerSurname;
                this.patronymicInput.Text = owner.OwnerPatronymic;
                this.passportInput.Text = owner.OwnerPassportNumber;
                this.addressInput.Text = owner.OwnerAddress;
                this.telephoneInput.Text = owner.OwnerTelephone;
            }

            if (this.carsPicker.SelectedIndex != -1)
            {
                this.carLayoutPanel.Enabled = !this.carLayoutPanel.Enabled;

                int index = (int)this.carsPicker.SelectedValue;

                Car car = this.Presenter.CarsFind(index);

                this.brandInput.Text = car.BrandName;
                this.modelInput.Text = car.ModelName;
                this.VINInput.Text = car.VehicleIdentificationNumber;
                this.licenseInput.Text = car.LicensePlate;

                this.yearInput.Value = Convert.ToInt32(car.Year);
                this.priceInput.Value = Convert.ToInt32(car.Price);
            }

            this.acceptButton.Visible = false;
            this.editButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (this.ownersPicker.SelectedIndex == -1 && this.carsPicker.SelectedIndex == -1) return;

            if (this.ownersPicker.SelectedIndex != -1)
            {
                if (ResultDialog("Вы уверены, что хотите удалить выбранную запись о владельце?",
                    "Удалить запись") == DialogResult.No) return;

                int index = (int)this.ownersPicker.SelectedValue;

                Owner owner = this.Presenter.OwnersFind(index);

                this.Presenter.OwnersRemove(owner);
                this.Presenter.ContextSaveChanges();

                this.ownerBindingSource.DataSource = this.Presenter.OwnersTableToList();

                this.ownersPicker.SelectedIndex = -1;

                MessageBox.Show("Запись о владельце успешно удалена из базы данных!");
            }

            if (this.carsPicker.SelectedIndex != -1)
            {
                if (ResultDialog("Вы уверены, что хотите удалить выбранную запись об автомобиле?",
                    "Удалить запись") == DialogResult.No) return;

                int index = (int)this.ownersPicker.SelectedValue;

                Car car = this.Presenter.CarsFind(index);

                this.Presenter.CarsRemove(car);
                this.Presenter.ContextSaveChanges();

                this.ownerBindingSource.DataSource = this.Presenter.CarsTableToList();

                this.carsPicker.SelectedIndex = -1;

                MessageBox.Show("Запись об автомобиле успешно удалена из базы данных!");
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (this.ownerLayoutPanel.Enabled)
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
                    this.Presenter.OwnersAdd(owner);
                    this.Presenter.ContextSaveChanges();
                }
                catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
                {
                    this.Presenter.OwnersRemove(owner);

                    if (ex is CannotInsertNullException)
                        ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                    if (ex is ReferenceConstraintException)
                        ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                    return;
                }

                this.ownersPicker.DataSource = this.Presenter.OwnersTableToList();

                MessageBox.Show("Запись о владельце успешно добавлена в базу данных!");
                this.ownerControls_toDefault();
            }

            if (this.carLayoutPanel.Enabled)
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
                    this.Presenter.CarsAdd(car);
                    this.Presenter.ContextSaveChanges();
                }
                catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
                {
                    this.Presenter.CarsRemove(car);

                    if (ex is CannotInsertNullException)
                        ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                    if (ex is ReferenceConstraintException)
                        ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                    return;
                }

                this.carsPicker.DataSource = this.Presenter.CarsTableToList();

                MessageBox.Show("Запись об автомобиле успешно добавлена в базу данных!");
                this.carControls_toDefault();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (this.ownerLayoutPanel.Enabled)
            {
                if (ResultDialog("Вы уверены, что хотите изменить существующую запись о владельце?",
                    "Измененить запись") == DialogResult.No) return;

                int index = (int)this.ownersPicker.SelectedValue;

                Owner owner = this.Presenter.OwnersFind(index);

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
                    this.Presenter.OwnersEntry(owner);
                    this.Presenter.ContextSaveChanges();
                }
                catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
                {
                    this.Presenter.OwnersRemove(owner);

                    if (ex is CannotInsertNullException)
                        ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                    if (ex is ReferenceConstraintException)
                        ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                    return;
                }

                this.ownersPicker.DataSource = this.Presenter.OwnersTableToList();

                MessageBox.Show("Запись о владельце успешно изменена в базе данных!");
            }

            if (this.carLayoutPanel.Enabled)
            {
                if (ResultDialog("Вы уверены, что хотите изменить существующую запись об автомобиле?",
                    "Измененить запись") == DialogResult.No) return;

                int index = (int)this.carsPicker.SelectedValue;

                Car car = this.Presenter.CarsFind(index);

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
                    this.Presenter.CarsEntry(car);
                    this.Presenter.ContextSaveChanges();
                }
                catch (Exception ex) when (ex is CannotInsertNullException || ex is ReferenceConstraintException)
                {
                    this.Presenter.CarsRemove(car);

                    if (ex is CannotInsertNullException)
                        ErrorDialog(ex.InnerException.Message, "Обязательное поле не заполнено!");
                    if (ex is ReferenceConstraintException)
                        ErrorDialog(ex.InnerException.Message, "Значение указано неверно!");
                    return;
                }

                this.carsPicker.DataSource = this.Presenter.CarsTableToList();

                MessageBox.Show("Запись об автомобиле успешно изменена в базе данных!");
            }

            this.Return();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (ResultDialog("Вы уверены, что хотите отменить операцию и вернуться к выбору клиентов?",
                "Отмена операции") == DialogResult.No) return;

            this.Return();
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
            this.VINInput.Text = this.VINInput.Text.Replace(" ", "");
        }

        private void VINInput_Leave(object sender, EventArgs e)
        {
            this.VINInput.Text = Regex.Replace(this.VINInput.Text, @"(\d{3})(\d{6})(\d{8})", @"$1 $2 $3");
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

        private void licenseInputeInput_Enter(object sender, EventArgs e)
        {
            this.licenseInput.Text = Regex.IsMatch(this.licenseInput.Text,
                @"([АВЕКМНОРСТУХ]{1}) (\d{3}) ([АВЕКМНОРСТУХ]{2})") ?
                    this.licenseInput.Text.Replace(" ", "") : "";
        }

        private void licenseInputInput_Leave(object sender, EventArgs e)
        {
            this.licenseInput.Text = this.licenseInput.Text.ToUpper();
            this.licenseInput.Text = Regex.Replace(this.licenseInput.Text,
                    @"([АВЕКМНОРСТУХ]{1})(\d{3})([АВЕКМНОРСТУХ]{2})", @"$1 $2 $3");
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
