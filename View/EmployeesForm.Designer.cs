
namespace App
{
    partial class EmployeesForm
    {
        /// <summary>
        ///  Требуемая переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">TRUE, если управляемые ресурсы должны быть удалены; иначе, FALSE.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Сгенерированный код Конструктора Windows Form

        /// <summary>
        ///  Требуемый метод для поддержки Конструктора - не модифицировать
        ///  содержимое этого метода в редакторе кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            formLayoutPanel = new TableLayoutPanel();
            divider = new Label();
            controlsLayoutPanel = new TableLayoutPanel();
            buttonsLayoutPanel = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            inputsLayoutPanel = new FlowLayoutPanel();
            specialtyLayoutPanel = new FlowLayoutPanel();
            specialtiesLabel = new Label();
            specialtiesPicker = new ComboBox();
            specialtyBindingSource = new BindingSource(components);
            textsLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            birthDateLayoutPanel = new FlowLayoutPanel();
            birthDateLabel = new Label();
            birthDatePicker = new DateTimePicker();
            passportLayoutPanel = new FlowLayoutPanel();
            passportLabel = new Label();
            passportInput = new TextBox();
            addressLayoutPanel = new FlowLayoutPanel();
            addressLabel = new Label();
            addressInput = new TextBox();
            telephoneLayoutPanel = new FlowLayoutPanel();
            telephoneLabel = new Label();
            telephoneInput = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            surnameLayoutPanel = new FlowLayoutPanel();
            surnameLabel = new Label();
            surnameInput = new TextBox();
            nameLayoutPanel = new FlowLayoutPanel();
            nameLabel = new Label();
            nameInput = new TextBox();
            patronymicLayoutPanel = new FlowLayoutPanel();
            patronymicLabel = new Label();
            patronymicInput = new TextBox();
            employmentDateLayoutPane = new FlowLayoutPanel();
            employmentDateLabel = new Label();
            employmentDatePicker = new DateTimePicker();
            menuLayoutPanel = new TableLayoutPanel();
            dbLayoutPanel = new FlowLayoutPanel();
            employeesPicker = new ComboBox();
            employeeBindingSource = new BindingSource(components);
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            redirectLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            formLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            inputsLayoutPanel.SuspendLayout();
            specialtyLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)specialtyBindingSource).BeginInit();
            textsLayoutPanel.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            birthDateLayoutPanel.SuspendLayout();
            passportLayoutPanel.SuspendLayout();
            addressLayoutPanel.SuspendLayout();
            telephoneLayoutPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            surnameLayoutPanel.SuspendLayout();
            nameLayoutPanel.SuspendLayout();
            patronymicLayoutPanel.SuspendLayout();
            employmentDateLayoutPane.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            dbLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            redirectLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(divider, 0, 1);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 2);
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
            formLayoutPanel.Dock = DockStyle.Fill;
            formLayoutPanel.Location = new Point(0, 0);
            formLayoutPanel.Margin = new Padding(0);
            formLayoutPanel.Name = "formLayoutPanel";
            formLayoutPanel.Padding = new Padding(20, 10, 20, 10);
            formLayoutPanel.RowCount = 3;
            formLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.Size = new Size(960, 540);
            formLayoutPanel.TabIndex = 3;
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            divider.BackColor = SystemColors.ControlDark;
            divider.Location = new Point(20, 80);
            divider.Margin = new Padding(0, 20, 0, 20);
            divider.Name = "divider";
            divider.Size = new Size(920, 1);
            divider.TabIndex = 5;
            // 
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            controlsLayoutPanel.ColumnCount = 3;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            controlsLayoutPanel.Controls.Add(buttonsLayoutPanel, 2, 0);
            controlsLayoutPanel.Controls.Add(inputsLayoutPanel, 0, 0);
            controlsLayoutPanel.Location = new Point(20, 106);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.Size = new Size(920, 419);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.AutoSize = true;
            buttonsLayoutPanel.Controls.Add(acceptButton);
            buttonsLayoutPanel.Controls.Add(resetButton);
            buttonsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            buttonsLayoutPanel.Location = new Point(770, 154);
            buttonsLayoutPanel.Margin = new Padding(0);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.Size = new Size(150, 110);
            buttonsLayoutPanel.TabIndex = 2;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = SystemColors.MenuHighlight;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            acceptButton.ForeColor = SystemColors.ButtonFace;
            acceptButton.Location = new Point(0, 0);
            acceptButton.Margin = new Padding(0, 0, 0, 10);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(150, 50);
            acceptButton.TabIndex = 6;
            acceptButton.Text = "Принять";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = SystemColors.ScrollBar;
            resetButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            resetButton.ForeColor = SystemColors.ControlText;
            resetButton.Location = new Point(0, 60);
            resetButton.Margin = new Padding(0);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(150, 50);
            resetButton.TabIndex = 7;
            resetButton.Text = "Отменить";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // inputsLayoutPanel
            // 
            inputsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputsLayoutPanel.AutoSize = true;
            inputsLayoutPanel.Controls.Add(specialtyLayoutPanel);
            inputsLayoutPanel.Controls.Add(textsLayoutPanel);
            inputsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            inputsLayoutPanel.Location = new Point(0, 56);
            inputsLayoutPanel.Margin = new Padding(0);
            inputsLayoutPanel.Name = "inputsLayoutPanel";
            inputsLayoutPanel.Size = new Size(760, 306);
            inputsLayoutPanel.TabIndex = 3;
            // 
            // specialtyLayoutPanel
            // 
            specialtyLayoutPanel.AutoSize = true;
            specialtyLayoutPanel.Controls.Add(specialtiesLabel);
            specialtyLayoutPanel.Controls.Add(specialtiesPicker);
            specialtyLayoutPanel.FlowDirection = FlowDirection.TopDown;
            specialtyLayoutPanel.Location = new Point(0, 0);
            specialtyLayoutPanel.Margin = new Padding(0);
            specialtyLayoutPanel.Name = "specialtyLayoutPanel";
            specialtyLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            specialtyLayoutPanel.Size = new Size(760, 62);
            specialtyLayoutPanel.TabIndex = 5;
            // 
            // specialtiesLabel
            // 
            specialtiesLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            specialtiesLabel.Location = new Point(0, 5);
            specialtiesLabel.Margin = new Padding(0);
            specialtiesLabel.Name = "specialtiesLabel";
            specialtiesLabel.Size = new Size(760, 25);
            specialtiesLabel.TabIndex = 0;
            specialtiesLabel.Text = "Должность *";
            // 
            // specialtiesPicker
            // 
            specialtiesPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            specialtiesPicker.BackColor = Color.White;
            specialtiesPicker.DataSource = specialtyBindingSource;
            specialtiesPicker.DisplayMember = "SpecialtyName";
            specialtiesPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            specialtiesPicker.FlatStyle = FlatStyle.System;
            specialtiesPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            specialtiesPicker.FormattingEnabled = true;
            specialtiesPicker.Location = new Point(0, 30);
            specialtiesPicker.Margin = new Padding(0);
            specialtiesPicker.Name = "specialtiesPicker";
            specialtiesPicker.Size = new Size(760, 27);
            specialtiesPicker.TabIndex = 1;
            specialtiesPicker.ValueMember = "SpecialtyId";
            // 
            // specialtyBindingSource
            // 
            specialtyBindingSource.DataSource = typeof(Specialty);
            // 
            // textsLayoutPanel
            // 
            textsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textsLayoutPanel.AutoSize = true;
            textsLayoutPanel.ColumnCount = 3;
            textsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            textsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            textsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            textsLayoutPanel.Controls.Add(flowLayoutPanel4, 2, 0);
            textsLayoutPanel.Controls.Add(flowLayoutPanel2, 0, 0);
            textsLayoutPanel.Location = new Point(0, 62);
            textsLayoutPanel.Margin = new Padding(0);
            textsLayoutPanel.Name = "textsLayoutPanel";
            textsLayoutPanel.RowCount = 1;
            textsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            textsLayoutPanel.Size = new Size(760, 244);
            textsLayoutPanel.TabIndex = 6;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(birthDateLayoutPanel);
            flowLayoutPanel4.Controls.Add(passportLayoutPanel);
            flowLayoutPanel4.Controls.Add(addressLayoutPanel);
            flowLayoutPanel4.Controls.Add(telephoneLayoutPanel);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(385, 0);
            flowLayoutPanel4.Margin = new Padding(0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(375, 244);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // birthDateLayoutPanel
            // 
            birthDateLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            birthDateLayoutPanel.AutoSize = true;
            birthDateLayoutPanel.Controls.Add(birthDateLabel);
            birthDateLayoutPanel.Controls.Add(birthDatePicker);
            birthDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            birthDateLayoutPanel.Location = new Point(0, 0);
            birthDateLayoutPanel.Margin = new Padding(0);
            birthDateLayoutPanel.Name = "birthDateLayoutPanel";
            birthDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            birthDateLayoutPanel.Size = new Size(375, 61);
            birthDateLayoutPanel.TabIndex = 5;
            // 
            // birthDateLabel
            // 
            birthDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            birthDateLabel.Location = new Point(0, 5);
            birthDateLabel.Margin = new Padding(0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(375, 25);
            birthDateLabel.TabIndex = 0;
            birthDateLabel.Text = "Дата рождения";
            // 
            // birthDatePicker
            // 
            birthDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            birthDatePicker.CustomFormat = "не указано";
            birthDatePicker.DropDownAlign = LeftRightAlignment.Right;
            birthDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            birthDatePicker.Location = new Point(0, 30);
            birthDatePicker.Margin = new Padding(0);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.ShowCheckBox = true;
            birthDatePicker.Size = new Size(375, 26);
            birthDatePicker.TabIndex = 1;
            birthDatePicker.ValueChanged += dateTimePicker_ValueChanged;
            birthDatePicker.Leave += dateTimePicker_Leave;
            // 
            // passportLayoutPanel
            // 
            passportLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passportLayoutPanel.AutoSize = true;
            passportLayoutPanel.Controls.Add(passportLabel);
            passportLayoutPanel.Controls.Add(passportInput);
            passportLayoutPanel.FlowDirection = FlowDirection.TopDown;
            passportLayoutPanel.Location = new Point(0, 61);
            passportLayoutPanel.Margin = new Padding(0);
            passportLayoutPanel.Name = "passportLayoutPanel";
            passportLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            passportLayoutPanel.Size = new Size(375, 61);
            passportLayoutPanel.TabIndex = 2;
            // 
            // passportLabel
            // 
            passportLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            passportLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passportLabel.Location = new Point(0, 5);
            passportLabel.Margin = new Padding(0);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new Size(375, 25);
            passportLabel.TabIndex = 0;
            passportLabel.Text = "Паспорт (серия, номер) *";
            // 
            // passportInput
            // 
            passportInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passportInput.BorderStyle = BorderStyle.FixedSingle;
            passportInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passportInput.Location = new Point(0, 30);
            passportInput.Margin = new Padding(0);
            passportInput.MaxLength = 10;
            passportInput.Name = "passportInput";
            passportInput.PlaceholderText = "0000 000000";
            passportInput.Size = new Size(375, 26);
            passportInput.TabIndex = 1;
            passportInput.Enter += passportInput_Enter;
            passportInput.Leave += passportInput_Leave;
            // 
            // addressLayoutPanel
            // 
            addressLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addressLayoutPanel.AutoSize = true;
            addressLayoutPanel.Controls.Add(addressLabel);
            addressLayoutPanel.Controls.Add(addressInput);
            addressLayoutPanel.FlowDirection = FlowDirection.TopDown;
            addressLayoutPanel.Location = new Point(0, 122);
            addressLayoutPanel.Margin = new Padding(0);
            addressLayoutPanel.Name = "addressLayoutPanel";
            addressLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            addressLayoutPanel.Size = new Size(375, 61);
            addressLayoutPanel.TabIndex = 3;
            // 
            // addressLabel
            // 
            addressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addressLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addressLabel.Location = new Point(0, 5);
            addressLabel.Margin = new Padding(0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(375, 25);
            addressLabel.TabIndex = 0;
            addressLabel.Text = "Адрес проживания";
            // 
            // addressInput
            // 
            addressInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addressInput.BorderStyle = BorderStyle.FixedSingle;
            addressInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addressInput.Location = new Point(0, 30);
            addressInput.Margin = new Padding(0);
            addressInput.MaxLength = 50;
            addressInput.Name = "addressInput";
            addressInput.PlaceholderText = "ул. Большая Морская, д. 0";
            addressInput.Size = new Size(375, 26);
            addressInput.TabIndex = 1;
            // 
            // telephoneLayoutPanel
            // 
            telephoneLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            telephoneLayoutPanel.AutoSize = true;
            telephoneLayoutPanel.Controls.Add(telephoneLabel);
            telephoneLayoutPanel.Controls.Add(telephoneInput);
            telephoneLayoutPanel.FlowDirection = FlowDirection.TopDown;
            telephoneLayoutPanel.Location = new Point(0, 183);
            telephoneLayoutPanel.Margin = new Padding(0);
            telephoneLayoutPanel.Name = "telephoneLayoutPanel";
            telephoneLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            telephoneLayoutPanel.Size = new Size(375, 61);
            telephoneLayoutPanel.TabIndex = 4;
            // 
            // telephoneLabel
            // 
            telephoneLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            telephoneLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            telephoneLabel.Location = new Point(0, 5);
            telephoneLabel.Margin = new Padding(0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new Size(375, 25);
            telephoneLabel.TabIndex = 0;
            telephoneLabel.Text = "Контактный телефон *";
            // 
            // telephoneInput
            // 
            telephoneInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            telephoneInput.BorderStyle = BorderStyle.FixedSingle;
            telephoneInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            telephoneInput.Location = new Point(0, 30);
            telephoneInput.Margin = new Padding(0);
            telephoneInput.MaxLength = 12;
            telephoneInput.Name = "telephoneInput";
            telephoneInput.PlaceholderText = "+7 (___) ___-__-__";
            telephoneInput.Size = new Size(375, 26);
            telephoneInput.TabIndex = 1;
            telephoneInput.Enter += telephoneInput_Enter;
            telephoneInput.Leave += telephoneInput_Leave;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(surnameLayoutPanel);
            flowLayoutPanel2.Controls.Add(nameLayoutPanel);
            flowLayoutPanel2.Controls.Add(patronymicLayoutPanel);
            flowLayoutPanel2.Controls.Add(employmentDateLayoutPane);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(375, 244);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // surnameLayoutPanel
            // 
            surnameLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            surnameLayoutPanel.AutoSize = true;
            surnameLayoutPanel.Controls.Add(surnameLabel);
            surnameLayoutPanel.Controls.Add(surnameInput);
            surnameLayoutPanel.FlowDirection = FlowDirection.TopDown;
            surnameLayoutPanel.Location = new Point(0, 0);
            surnameLayoutPanel.Margin = new Padding(0);
            surnameLayoutPanel.Name = "surnameLayoutPanel";
            surnameLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            surnameLayoutPanel.Size = new Size(375, 61);
            surnameLayoutPanel.TabIndex = 2;
            // 
            // surnameLabel
            // 
            surnameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            surnameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            surnameLabel.Location = new Point(0, 5);
            surnameLabel.Margin = new Padding(0);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(375, 25);
            surnameLabel.TabIndex = 0;
            surnameLabel.Text = "Фамилия *";
            // 
            // surnameInput
            // 
            surnameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            surnameInput.BorderStyle = BorderStyle.FixedSingle;
            surnameInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            surnameInput.Location = new Point(0, 30);
            surnameInput.Margin = new Padding(0);
            surnameInput.MaxLength = 50;
            surnameInput.Name = "surnameInput";
            surnameInput.PlaceholderText = "Иванов";
            surnameInput.Size = new Size(375, 26);
            surnameInput.TabIndex = 1;
            // 
            // nameLayoutPanel
            // 
            nameLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameLayoutPanel.AutoSize = true;
            nameLayoutPanel.Controls.Add(nameLabel);
            nameLayoutPanel.Controls.Add(nameInput);
            nameLayoutPanel.FlowDirection = FlowDirection.TopDown;
            nameLayoutPanel.Location = new Point(0, 61);
            nameLayoutPanel.Margin = new Padding(0);
            nameLayoutPanel.Name = "nameLayoutPanel";
            nameLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            nameLayoutPanel.Size = new Size(375, 61);
            nameLayoutPanel.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameLabel.Location = new Point(0, 5);
            nameLabel.Margin = new Padding(0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(375, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Имя";
            // 
            // nameInput
            // 
            nameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameInput.Location = new Point(0, 30);
            nameInput.Margin = new Padding(0);
            nameInput.MaxLength = 50;
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Иван";
            nameInput.Size = new Size(375, 26);
            nameInput.TabIndex = 1;
            // 
            // patronymicLayoutPanel
            // 
            patronymicLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            patronymicLayoutPanel.AutoSize = true;
            patronymicLayoutPanel.Controls.Add(patronymicLabel);
            patronymicLayoutPanel.Controls.Add(patronymicInput);
            patronymicLayoutPanel.FlowDirection = FlowDirection.TopDown;
            patronymicLayoutPanel.Location = new Point(0, 122);
            patronymicLayoutPanel.Margin = new Padding(0);
            patronymicLayoutPanel.Name = "patronymicLayoutPanel";
            patronymicLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            patronymicLayoutPanel.Size = new Size(375, 61);
            patronymicLayoutPanel.TabIndex = 4;
            // 
            // patronymicLabel
            // 
            patronymicLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            patronymicLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            patronymicLabel.Location = new Point(0, 5);
            patronymicLabel.Margin = new Padding(0);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new Size(375, 25);
            patronymicLabel.TabIndex = 0;
            patronymicLabel.Text = "Отчество";
            // 
            // patronymicInput
            // 
            patronymicInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            patronymicInput.BorderStyle = BorderStyle.FixedSingle;
            patronymicInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            patronymicInput.Location = new Point(0, 30);
            patronymicInput.Margin = new Padding(0);
            patronymicInput.MaxLength = 50;
            patronymicInput.Name = "patronymicInput";
            patronymicInput.PlaceholderText = "Иванович";
            patronymicInput.Size = new Size(375, 26);
            patronymicInput.TabIndex = 1;
            // 
            // employmentDateLayoutPane
            // 
            employmentDateLayoutPane.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employmentDateLayoutPane.AutoSize = true;
            employmentDateLayoutPane.Controls.Add(employmentDateLabel);
            employmentDateLayoutPane.Controls.Add(employmentDatePicker);
            employmentDateLayoutPane.FlowDirection = FlowDirection.TopDown;
            employmentDateLayoutPane.Location = new Point(0, 183);
            employmentDateLayoutPane.Margin = new Padding(0);
            employmentDateLayoutPane.Name = "employmentDateLayoutPane";
            employmentDateLayoutPane.Padding = new Padding(0, 5, 0, 5);
            employmentDateLayoutPane.Size = new Size(375, 61);
            employmentDateLayoutPane.TabIndex = 5;
            // 
            // employmentDateLabel
            // 
            employmentDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employmentDateLabel.Location = new Point(0, 5);
            employmentDateLabel.Margin = new Padding(0);
            employmentDateLabel.Name = "employmentDateLabel";
            employmentDateLabel.Size = new Size(375, 25);
            employmentDateLabel.TabIndex = 0;
            employmentDateLabel.Text = "Дата приёма на работу *";
            // 
            // employmentDatePicker
            // 
            employmentDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employmentDatePicker.CustomFormat = "не указано";
            employmentDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employmentDatePicker.Location = new Point(0, 30);
            employmentDatePicker.Margin = new Padding(0);
            employmentDatePicker.Name = "employmentDatePicker";
            employmentDatePicker.ShowCheckBox = true;
            employmentDatePicker.Size = new Size(375, 26);
            employmentDatePicker.TabIndex = 1;
            employmentDatePicker.ValueChanged += dateTimePicker_ValueChanged;
            employmentDatePicker.Leave += dateTimePicker_Leave;
            // 
            // menuLayoutPanel
            // 
            menuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            menuLayoutPanel.ColumnCount = 3;
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            menuLayoutPanel.Controls.Add(dbLayoutPanel, 2, 0);
            menuLayoutPanel.Controls.Add(redirectLayoutPanel, 0, 0);
            menuLayoutPanel.Location = new Point(20, 10);
            menuLayoutPanel.Margin = new Padding(0);
            menuLayoutPanel.Name = "menuLayoutPanel";
            menuLayoutPanel.RowCount = 1;
            menuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            menuLayoutPanel.Size = new Size(920, 50);
            menuLayoutPanel.TabIndex = 6;
            // 
            // dbLayoutPanel
            // 
            dbLayoutPanel.AutoSize = true;
            dbLayoutPanel.Controls.Add(employeesPicker);
            dbLayoutPanel.Controls.Add(addButton);
            dbLayoutPanel.Controls.Add(editButton);
            dbLayoutPanel.Controls.Add(deleteButton);
            dbLayoutPanel.Dock = DockStyle.Fill;
            dbLayoutPanel.Location = new Point(120, 0);
            dbLayoutPanel.Margin = new Padding(0);
            dbLayoutPanel.Name = "dbLayoutPanel";
            dbLayoutPanel.Size = new Size(800, 50);
            dbLayoutPanel.TabIndex = 2;
            // 
            // employeesPicker
            // 
            employeesPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employeesPicker.BackColor = Color.White;
            employeesPicker.DataSource = employeeBindingSource;
            employeesPicker.DisplayMember = "EmployeeSurname";
            employeesPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            employeesPicker.FlatStyle = FlatStyle.System;
            employeesPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeesPicker.FormattingEnabled = true;
            employeesPicker.Location = new Point(0, 11);
            employeesPicker.Margin = new Padding(0, 0, 10, 0);
            employeesPicker.Name = "employeesPicker";
            employeesPicker.Size = new Size(200, 27);
            employeesPicker.TabIndex = 2;
            employeesPicker.ValueMember = "EmployeeId";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Employee);
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = SystemColors.MenuHighlight;
            addButton.Dock = DockStyle.Left;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(220, 0);
            addButton.Margin = new Padding(10, 0, 10, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(180, 50);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.BackColor = SystemColors.MenuHighlight;
            editButton.Dock = DockStyle.Left;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            editButton.ForeColor = SystemColors.ButtonFace;
            editButton.Location = new Point(420, 0);
            editButton.Margin = new Padding(10, 0, 10, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(180, 50);
            editButton.TabIndex = 2;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = SystemColors.MenuHighlight;
            deleteButton.Dock = DockStyle.Left;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deleteButton.ForeColor = SystemColors.ButtonFace;
            deleteButton.Location = new Point(620, 0);
            deleteButton.Margin = new Padding(10, 0, 0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(180, 50);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // redirectLayoutPanel
            // 
            redirectLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            redirectLayoutPanel.AutoSize = true;
            redirectLayoutPanel.Controls.Add(homeButton);
            redirectLayoutPanel.Controls.Add(returnButton);
            redirectLayoutPanel.Location = new Point(0, 5);
            redirectLayoutPanel.Margin = new Padding(0);
            redirectLayoutPanel.Name = "redirectLayoutPanel";
            redirectLayoutPanel.Size = new Size(100, 40);
            redirectLayoutPanel.TabIndex = 1;
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            homeButton.BackColor = Color.Transparent;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            homeButton.ForeColor = SystemColors.WindowFrame;
            homeButton.Location = new Point(0, 0);
            homeButton.Margin = new Padding(0, 0, 10, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(40, 40);
            homeButton.TabIndex = 4;
            homeButton.Text = "";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // returnButton
            // 
            returnButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            returnButton.BackColor = Color.Transparent;
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            returnButton.ForeColor = SystemColors.WindowFrame;
            returnButton.Location = new Point(60, 0);
            returnButton.Margin = new Padding(10, 0, 0, 0);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(40, 40);
            returnButton.TabIndex = 5;
            returnButton.Text = "";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "EmployeesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационная система: сотрудники автосервиса";
            FormClosed += EmployeesForm_FormClosed;
            Load += EmployeesForm_Load;
            formLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.PerformLayout();
            buttonsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.PerformLayout();
            specialtyLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)specialtyBindingSource).EndInit();
            textsLayoutPanel.ResumeLayout(false);
            textsLayoutPanel.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            birthDateLayoutPanel.ResumeLayout(false);
            passportLayoutPanel.ResumeLayout(false);
            passportLayoutPanel.PerformLayout();
            addressLayoutPanel.ResumeLayout(false);
            addressLayoutPanel.PerformLayout();
            telephoneLayoutPanel.ResumeLayout(false);
            telephoneLayoutPanel.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            surnameLayoutPanel.ResumeLayout(false);
            surnameLayoutPanel.PerformLayout();
            nameLayoutPanel.ResumeLayout(false);
            nameLayoutPanel.PerformLayout();
            patronymicLayoutPanel.ResumeLayout(false);
            patronymicLayoutPanel.PerformLayout();
            employmentDateLayoutPane.ResumeLayout(false);
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            dbLayoutPanel.ResumeLayout(false);
            dbLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            redirectLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel formLayoutPanel;
        private TableLayoutPanel controlsLayoutPanel;
        private FlowLayoutPanel buttonsLayoutPanel;
        private Button acceptButton;
        private Button resetButton;
        private FlowLayoutPanel inputsLayoutPanel;
        private FlowLayoutPanel specialtyLayoutPanel;
        private Label specialtiesLabel;
        private ComboBox specialtiesPicker;
        private TableLayoutPanel textsLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel birthDateLayoutPanel;
        private Label birthDateLabel;
        private DateTimePicker birthDatePicker;
        private FlowLayoutPanel passportLayoutPanel;
        private Label passportLabel;
        private TextBox passportInput;
        private FlowLayoutPanel addressLayoutPanel;
        private Label addressLabel;
        private TextBox addressInput;
        private FlowLayoutPanel telephoneLayoutPanel;
        private Label telephoneLabel;
        private TextBox telephoneInput;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel surnameLayoutPanel;
        private Label surnameLabel;
        private TextBox surnameInput;
        private FlowLayoutPanel nameLayoutPanel;
        private Label nameLabel;
        private TextBox nameInput;
        private FlowLayoutPanel patronymicLayoutPanel;
        private Label patronymicLabel;
        private TextBox patronymicInput;
        private FlowLayoutPanel employmentDateLayoutPane;
        private Label employmentDateLabel;
        private DateTimePicker employmentDatePicker;
        private Label divider;
        private BindingSource employeeBindingSource;
        private BindingSource specialtyBindingSource;
        private TableLayoutPanel menuLayoutPanel;
        private FlowLayoutPanel dbLayoutPanel;
        private ComboBox employeesPicker;
        private FlowLayoutPanel redirectLayoutPanel;
        private Button homeButton;
        private Button returnButton;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
    }
}
