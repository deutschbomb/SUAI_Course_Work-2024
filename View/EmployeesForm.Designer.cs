﻿
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
            formLayoutPanel = new TableLayoutPanel();
            menuLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            employeesPicker = new ComboBox();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            tableLayoutPanel = new FlowLayoutPanel();
            divider1 = new Label();
            controlsLayoutPanel = new TableLayoutPanel();
            inputsLayoutPanel = new TableLayoutPanel();
            specialtyLayoutPanel = new FlowLayoutPanel();
            specialtiesLabel = new Label();
            specialtiesPicker = new ComboBox();
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
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            buttonsLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            formLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            inputsLayoutPanel.SuspendLayout();
            specialtyLayoutPanel.SuspendLayout();
            textsLayoutPanel.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            birthDateLayoutPanel.SuspendLayout();
            passportLayoutPanel.SuspendLayout();
            addressLayoutPanel.SuspendLayout();
            telephoneLayoutPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            surnameLayoutPanel.SuspendLayout();
            nameLayoutPanel.SuspendLayout();
            patronymicLayoutPanel.SuspendLayout();
            employmentDateLayoutPane.SuspendLayout();
            buttonsLayoutPanel2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 1);
            formLayoutPanel.Controls.Add(tableLayoutPanel, 0, 2);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 3);
            formLayoutPanel.Dock = DockStyle.Fill;
            formLayoutPanel.Location = new Point(0, 0);
            formLayoutPanel.Margin = new Padding(0);
            formLayoutPanel.Name = "formLayoutPanel";
            formLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            formLayoutPanel.RowCount = 5;
            formLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            formLayoutPanel.Size = new Size(960, 540);
            formLayoutPanel.TabIndex = 3;
            // 
            // menuLayoutPanel
            // 
            menuLayoutPanel.AutoSize = true;
            menuLayoutPanel.Controls.Add(homeButton);
            menuLayoutPanel.Controls.Add(returnButton);
            menuLayoutPanel.Controls.Add(employeesPicker);
            menuLayoutPanel.Controls.Add(addButton);
            menuLayoutPanel.Controls.Add(editButton);
            menuLayoutPanel.Controls.Add(deleteButton);
            menuLayoutPanel.Dock = DockStyle.Fill;
            menuLayoutPanel.Location = new Point(20, 10);
            menuLayoutPanel.Margin = new Padding(0);
            menuLayoutPanel.Name = "menuLayoutPanel";
            menuLayoutPanel.Size = new Size(920, 50);
            menuLayoutPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            homeButton.BackColor = Color.Transparent;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            homeButton.ForeColor = SystemColors.WindowFrame;
            homeButton.Location = new Point(0, 5);
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
            returnButton.Location = new Point(60, 5);
            returnButton.Margin = new Padding(10, 0, 10, 0);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(40, 40);
            returnButton.TabIndex = 5;
            returnButton.Text = "";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // employeesPicker
            // 
            employeesPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employeesPicker.BackColor = Color.White;
            employeesPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            employeesPicker.FlatStyle = FlatStyle.System;
            employeesPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeesPicker.FormattingEnabled = true;
            employeesPicker.Location = new Point(120, 11);
            employeesPicker.Margin = new Padding(10, 0, 10, 0);
            employeesPicker.Name = "employeesPicker";
            employeesPicker.Size = new Size(296, 27);
            employeesPicker.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = SystemColors.MenuHighlight;
            addButton.Dock = DockStyle.Left;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(436, 0);
            addButton.Margin = new Padding(10, 0, 10, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(148, 50);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.BackColor = SystemColors.MenuHighlight;
            editButton.Dock = DockStyle.Left;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            editButton.ForeColor = SystemColors.ButtonFace;
            editButton.Location = new Point(604, 0);
            editButton.Margin = new Padding(10, 0, 10, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(148, 50);
            editButton.TabIndex = 2;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = SystemColors.MenuHighlight;
            deleteButton.Dock = DockStyle.Left;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deleteButton.ForeColor = SystemColors.ButtonFace;
            deleteButton.Location = new Point(772, 0);
            deleteButton.Margin = new Padding(10, 0, 0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(148, 50);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Controls.Add(divider1);
            tableLayoutPanel.FlowDirection = FlowDirection.TopDown;
            tableLayoutPanel.Location = new Point(20, 60);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Size = new Size(920, 21);
            tableLayoutPanel.TabIndex = 0;
            // 
            // divider1
            // 
            divider1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            divider1.BackColor = SystemColors.ControlDark;
            divider1.Location = new Point(0, 10);
            divider1.Margin = new Padding(0, 10, 0, 10);
            divider1.Name = "divider1";
            divider1.Size = new Size(920, 1);
            divider1.TabIndex = 4;
            // 
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.ColumnCount = 2;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            controlsLayoutPanel.Controls.Add(inputsLayoutPanel, 0, 0);
            controlsLayoutPanel.Controls.Add(buttonsLayoutPanel2, 1, 0);
            controlsLayoutPanel.Dock = DockStyle.Fill;
            controlsLayoutPanel.Location = new Point(20, 81);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.Size = new Size(920, 429);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // inputsLayoutPanel
            // 
            inputsLayoutPanel.ColumnCount = 1;
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inputsLayoutPanel.Controls.Add(specialtyLayoutPanel, 0, 1);
            inputsLayoutPanel.Controls.Add(textsLayoutPanel, 0, 2);
            inputsLayoutPanel.Dock = DockStyle.Fill;
            inputsLayoutPanel.Location = new Point(0, 0);
            inputsLayoutPanel.Margin = new Padding(0, 0, 10, 0);
            inputsLayoutPanel.Name = "inputsLayoutPanel";
            inputsLayoutPanel.RowCount = 4;
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            inputsLayoutPanel.RowStyles.Add(new RowStyle());
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 254F));
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            inputsLayoutPanel.Size = new Size(760, 429);
            inputsLayoutPanel.TabIndex = 1;
            // 
            // specialtyLayoutPanel
            // 
            specialtyLayoutPanel.AutoSize = true;
            specialtyLayoutPanel.Controls.Add(specialtiesLabel);
            specialtyLayoutPanel.Controls.Add(specialtiesPicker);
            specialtyLayoutPanel.FlowDirection = FlowDirection.TopDown;
            specialtyLayoutPanel.Location = new Point(0, 56);
            specialtyLayoutPanel.Margin = new Padding(0);
            specialtyLayoutPanel.Name = "specialtyLayoutPanel";
            specialtyLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            specialtyLayoutPanel.Size = new Size(760, 62);
            specialtyLayoutPanel.TabIndex = 3;
            // 
            // specialtiesLabel
            // 
            specialtiesLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            specialtiesLabel.Location = new Point(0, 5);
            specialtiesLabel.Margin = new Padding(0);
            specialtiesLabel.Name = "specialtiesLabel";
            specialtiesLabel.Size = new Size(760, 25);
            specialtiesLabel.TabIndex = 0;
            specialtiesLabel.Text = "Запчасть";
            // 
            // specialtiesPicker
            // 
            specialtiesPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            specialtiesPicker.BackColor = Color.White;
            specialtiesPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            specialtiesPicker.FlatStyle = FlatStyle.System;
            specialtiesPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            specialtiesPicker.FormattingEnabled = true;
            specialtiesPicker.Location = new Point(0, 30);
            specialtiesPicker.Margin = new Padding(0);
            specialtiesPicker.Name = "specialtiesPicker";
            specialtiesPicker.Size = new Size(760, 27);
            specialtiesPicker.TabIndex = 1;
            // 
            // textsLayoutPanel
            // 
            textsLayoutPanel.ColumnCount = 2;
            textsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            textsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            textsLayoutPanel.Controls.Add(flowLayoutPanel4, 1, 0);
            textsLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 0);
            textsLayoutPanel.Dock = DockStyle.Fill;
            textsLayoutPanel.Location = new Point(0, 118);
            textsLayoutPanel.Margin = new Padding(0);
            textsLayoutPanel.Name = "textsLayoutPanel";
            textsLayoutPanel.RowCount = 1;
            textsLayoutPanel.RowStyles.Add(new RowStyle());
            textsLayoutPanel.Size = new Size(760, 254);
            textsLayoutPanel.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(birthDateLayoutPanel);
            flowLayoutPanel4.Controls.Add(passportLayoutPanel);
            flowLayoutPanel4.Controls.Add(addressLayoutPanel);
            flowLayoutPanel4.Controls.Add(telephoneLayoutPanel);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(385, 0);
            flowLayoutPanel4.Margin = new Padding(5, 0, 0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(375, 254);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // birthDateLayoutPanel
            // 
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
            birthDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            birthDatePicker.Location = new Point(0, 30);
            birthDatePicker.Margin = new Padding(0);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(375, 26);
            birthDatePicker.TabIndex = 1;
            // 
            // passportLayoutPanel
            // 
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
            passportLabel.Text = "Паспорт (серия, номер)";
            // 
            // passportInput
            // 
            passportInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passportInput.BorderStyle = BorderStyle.FixedSingle;
            passportInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            passportInput.Location = new Point(0, 30);
            passportInput.Margin = new Padding(0);
            passportInput.Name = "passportInput";
            passportInput.Size = new Size(375, 26);
            passportInput.TabIndex = 1;
            // 
            // addressLayoutPanel
            // 
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
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(375, 26);
            addressInput.TabIndex = 1;
            // 
            // telephoneLayoutPanel
            // 
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
            telephoneLabel.Text = "Контактный телефон";
            // 
            // telephoneInput
            // 
            telephoneInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            telephoneInput.BorderStyle = BorderStyle.FixedSingle;
            telephoneInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            telephoneInput.Location = new Point(0, 30);
            telephoneInput.Margin = new Padding(0);
            telephoneInput.Name = "telephoneInput";
            telephoneInput.Size = new Size(375, 26);
            telephoneInput.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(surnameLayoutPanel);
            flowLayoutPanel1.Controls.Add(nameLayoutPanel);
            flowLayoutPanel1.Controls.Add(patronymicLayoutPanel);
            flowLayoutPanel1.Controls.Add(employmentDateLayoutPane);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0, 0, 5, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(375, 254);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // surnameLayoutPanel
            // 
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
            surnameLabel.Text = "Фамилия";
            // 
            // surnameInput
            // 
            surnameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            surnameInput.BorderStyle = BorderStyle.FixedSingle;
            surnameInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            surnameInput.Location = new Point(0, 30);
            surnameInput.Margin = new Padding(0);
            surnameInput.Name = "surnameInput";
            surnameInput.Size = new Size(375, 26);
            surnameInput.TabIndex = 1;
            // 
            // nameLayoutPanel
            // 
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
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(375, 26);
            nameInput.TabIndex = 1;
            // 
            // patronymicLayoutPanel
            // 
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
            patronymicInput.Name = "patronymicInput";
            patronymicInput.Size = new Size(375, 26);
            patronymicInput.TabIndex = 1;
            // 
            // employmentDateLayoutPane
            // 
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
            employmentDateLabel.Text = "Дата приёма на работу";
            // 
            // employmentDatePicker
            // 
            employmentDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employmentDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employmentDatePicker.Location = new Point(0, 30);
            employmentDatePicker.Margin = new Padding(0);
            employmentDatePicker.Name = "employmentDatePicker";
            employmentDatePicker.Size = new Size(375, 26);
            employmentDatePicker.TabIndex = 1;
            // 
            // buttonsLayoutPanel2
            // 
            buttonsLayoutPanel2.ColumnCount = 1;
            buttonsLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsLayoutPanel2.Controls.Add(flowLayoutPanel5, 0, 1);
            buttonsLayoutPanel2.Dock = DockStyle.Fill;
            buttonsLayoutPanel2.Location = new Point(770, 0);
            buttonsLayoutPanel2.Margin = new Padding(0);
            buttonsLayoutPanel2.Name = "buttonsLayoutPanel2";
            buttonsLayoutPanel2.RowCount = 3;
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle());
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonsLayoutPanel2.Size = new Size(150, 429);
            buttonsLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(acceptButton);
            flowLayoutPanel5.Controls.Add(resetButton);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(0, 159);
            flowLayoutPanel5.Margin = new Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(150, 110);
            flowLayoutPanel5.TabIndex = 0;
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
            resetButton.Text = "Сбросить";
            resetButton.UseVisualStyleBackColor = false;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "EmployeesForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сотрудники автосервиса";
            FormClosed += EmployeesForm_FormClosed;
            Load += EmployeesForm_Load;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.PerformLayout();
            specialtyLayoutPanel.ResumeLayout(false);
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
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            surnameLayoutPanel.ResumeLayout(false);
            surnameLayoutPanel.PerformLayout();
            nameLayoutPanel.ResumeLayout(false);
            nameLayoutPanel.PerformLayout();
            patronymicLayoutPanel.ResumeLayout(false);
            patronymicLayoutPanel.PerformLayout();
            employmentDateLayoutPane.ResumeLayout(false);
            buttonsLayoutPanel2.ResumeLayout(false);
            buttonsLayoutPanel2.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private TableLayoutPanel formLayoutPanel;
        private FlowLayoutPanel menuLayoutPanel;
        private Button homeButton;
        private Button returnButton;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private FlowLayoutPanel tableLayoutPanel;
        private TableLayoutPanel controlsLayoutPanel;
        private ComboBox employeesPicker;
        private Label divider1;
        private TableLayoutPanel buttonsLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button acceptButton;
        private Button resetButton;
        private TableLayoutPanel inputsLayoutPanel;
        private FlowLayoutPanel specialtyLayoutPanel;
        private Label specialtiesLabel;
        private ComboBox specialtiesPicker;
        private TableLayoutPanel textsLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel1;
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
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel passportLayoutPanel;
        private Label passportLabel;
        private TextBox passportInput;
        private FlowLayoutPanel addressLayoutPanel;
        private Label addressLabel;
        private TextBox addressInput;
        private FlowLayoutPanel telephoneLayoutPanel;
        private Label telephoneLabel;
        private TextBox telephoneInput;
        private FlowLayoutPanel birthDateLayoutPanel;
        private Label birthDateLabel;
        private DateTimePicker birthDatePicker;
    }
}
