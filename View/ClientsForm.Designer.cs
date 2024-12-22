
namespace App
{
    partial class ClientsForm
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
            textsLayoutPanel = new TableLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel12 = new FlowLayoutPanel();
            label4 = new Label();
            textBox4 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel10 = new FlowLayoutPanel();
            label2 = new Label();
            textBox2 = new TextBox();
            flowLayoutPanel11 = new FlowLayoutPanel();
            label3 = new Label();
            textBox3 = new TextBox();
            flowLayoutPanel9 = new FlowLayoutPanel();
            birthDateLabel = new Label();
            birthDatePicker = new DateTimePicker();
            priceLayoutPanel = new FlowLayoutPanel();
            priceLabel = new Label();
            priceInput = new NumericUpDown();
            flowLayoutPanel1 = new FlowLayoutPanel();
            surnameNumberLayoutPanel = new FlowLayoutPanel();
            surnameLabel = new Label();
            surnameInput = new TextBox();
            nameLayoutPanel = new FlowLayoutPanel();
            nameLabel = new Label();
            nameInput = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            patronymicLabel = new Label();
            patronymicInput = new TextBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            passportLabel = new Label();
            passportInput = new TextBox();
            flowLayoutPanel8 = new FlowLayoutPanel();
            telephoneLabel = new Label();
            telephoneInput = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            addressLabel = new Label();
            addressInput = new TextBox();
            buttonsLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            formLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            inputsLayoutPanel.SuspendLayout();
            textsLayoutPanel.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel12.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel11.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            priceLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            surnameNumberLayoutPanel.SuspendLayout();
            nameLayoutPanel.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            buttonsLayoutPanel2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
            formLayoutPanel.Controls.Add(tableLayoutPanel, 0, 1);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 2);
            formLayoutPanel.Dock = DockStyle.Fill;
            formLayoutPanel.Location = new Point(0, 0);
            formLayoutPanel.Margin = new Padding(0);
            formLayoutPanel.Name = "formLayoutPanel";
            formLayoutPanel.Padding = new Padding(20, 10, 20, 10);
            formLayoutPanel.RowCount = 3;
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.Size = new Size(960, 540);
            formLayoutPanel.TabIndex = 4;
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
            controlsLayoutPanel.Size = new Size(920, 449);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // inputsLayoutPanel
            // 
            inputsLayoutPanel.ColumnCount = 1;
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inputsLayoutPanel.Controls.Add(textsLayoutPanel, 0, 1);
            inputsLayoutPanel.Dock = DockStyle.Fill;
            inputsLayoutPanel.Location = new Point(0, 0);
            inputsLayoutPanel.Margin = new Padding(0, 0, 10, 0);
            inputsLayoutPanel.Name = "inputsLayoutPanel";
            inputsLayoutPanel.RowCount = 3;
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 370F));
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            inputsLayoutPanel.Size = new Size(760, 449);
            inputsLayoutPanel.TabIndex = 1;
            // 
            // textsLayoutPanel
            // 
            textsLayoutPanel.ColumnCount = 2;
            textsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            textsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            textsLayoutPanel.Controls.Add(flowLayoutPanel4, 1, 0);
            textsLayoutPanel.Controls.Add(flowLayoutPanel1, 0, 0);
            textsLayoutPanel.Dock = DockStyle.Fill;
            textsLayoutPanel.Location = new Point(0, 39);
            textsLayoutPanel.Margin = new Padding(0);
            textsLayoutPanel.Name = "textsLayoutPanel";
            textsLayoutPanel.RowCount = 1;
            textsLayoutPanel.RowStyles.Add(new RowStyle());
            textsLayoutPanel.Size = new Size(760, 370);
            textsLayoutPanel.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(flowLayoutPanel12);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel10);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel11);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel9);
            flowLayoutPanel4.Controls.Add(priceLayoutPanel);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(385, 0);
            flowLayoutPanel4.Margin = new Padding(5, 0, 0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(375, 366);
            flowLayoutPanel4.TabIndex = 1;
            // 
            // flowLayoutPanel12
            // 
            flowLayoutPanel12.AutoSize = true;
            flowLayoutPanel12.Controls.Add(label4);
            flowLayoutPanel12.Controls.Add(textBox4);
            flowLayoutPanel12.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel12.Location = new Point(0, 0);
            flowLayoutPanel12.Margin = new Padding(0);
            flowLayoutPanel12.Name = "flowLayoutPanel12";
            flowLayoutPanel12.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel12.Size = new Size(375, 61);
            flowLayoutPanel12.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(0, 5);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(375, 25);
            label4.TabIndex = 0;
            label4.Text = "Марка";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox4.Location = new Point(0, 30);
            textBox4.Margin = new Padding(0);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(375, 26);
            textBox4.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 61);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel2.Size = new Size(375, 61);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(0, 5);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(375, 25);
            label1.TabIndex = 0;
            label1.Text = "Модель";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.Location = new Point(0, 30);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(375, 26);
            textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.AutoSize = true;
            flowLayoutPanel10.Controls.Add(label2);
            flowLayoutPanel10.Controls.Add(textBox2);
            flowLayoutPanel10.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel10.Location = new Point(0, 122);
            flowLayoutPanel10.Margin = new Padding(0);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel10.Size = new Size(375, 61);
            flowLayoutPanel10.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(0, 5);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(375, 25);
            label2.TabIndex = 0;
            label2.Text = "VIN";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox2.Location = new Point(0, 30);
            textBox2.Margin = new Padding(0);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(375, 26);
            textBox2.TabIndex = 1;
            // 
            // flowLayoutPanel11
            // 
            flowLayoutPanel11.AutoSize = true;
            flowLayoutPanel11.Controls.Add(label3);
            flowLayoutPanel11.Controls.Add(textBox3);
            flowLayoutPanel11.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel11.Location = new Point(0, 183);
            flowLayoutPanel11.Margin = new Padding(0);
            flowLayoutPanel11.Name = "flowLayoutPanel11";
            flowLayoutPanel11.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel11.Size = new Size(375, 61);
            flowLayoutPanel11.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.Location = new Point(0, 5);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(375, 25);
            label3.TabIndex = 0;
            label3.Text = "Регистрационный номер";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox3.Location = new Point(0, 30);
            textBox3.Margin = new Padding(0);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(375, 26);
            textBox3.TabIndex = 1;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.AutoSize = true;
            flowLayoutPanel9.Controls.Add(birthDateLabel);
            flowLayoutPanel9.Controls.Add(birthDatePicker);
            flowLayoutPanel9.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel9.Location = new Point(0, 244);
            flowLayoutPanel9.Margin = new Padding(0);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel9.Size = new Size(375, 61);
            flowLayoutPanel9.TabIndex = 5;
            // 
            // birthDateLabel
            // 
            birthDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            birthDateLabel.Location = new Point(0, 5);
            birthDateLabel.Margin = new Padding(0);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new Size(375, 25);
            birthDateLabel.TabIndex = 0;
            birthDateLabel.Text = "Год выпуска";
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
            // priceLayoutPanel
            // 
            priceLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            priceLayoutPanel.AutoSize = true;
            priceLayoutPanel.Controls.Add(priceLabel);
            priceLayoutPanel.Controls.Add(priceInput);
            priceLayoutPanel.FlowDirection = FlowDirection.TopDown;
            priceLayoutPanel.Location = new Point(0, 305);
            priceLayoutPanel.Margin = new Padding(0);
            priceLayoutPanel.Name = "priceLayoutPanel";
            priceLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            priceLayoutPanel.Size = new Size(375, 61);
            priceLayoutPanel.TabIndex = 6;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            priceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceLabel.Location = new Point(0, 5);
            priceLabel.Margin = new Padding(0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(375, 25);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "Стоимость автомобиля";
            // 
            // priceInput
            // 
            priceInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceInput.BorderStyle = BorderStyle.FixedSingle;
            priceInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceInput.Location = new Point(0, 30);
            priceInput.Margin = new Padding(0);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(375, 26);
            priceInput.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(surnameNumberLayoutPanel);
            flowLayoutPanel1.Controls.Add(nameLayoutPanel);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel3);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel8);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel7);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0, 0, 5, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(375, 366);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // surnameNumberLayoutPanel
            // 
            surnameNumberLayoutPanel.AutoSize = true;
            surnameNumberLayoutPanel.Controls.Add(surnameLabel);
            surnameNumberLayoutPanel.Controls.Add(surnameInput);
            surnameNumberLayoutPanel.FlowDirection = FlowDirection.TopDown;
            surnameNumberLayoutPanel.Location = new Point(0, 0);
            surnameNumberLayoutPanel.Margin = new Padding(0);
            surnameNumberLayoutPanel.Name = "surnameNumberLayoutPanel";
            surnameNumberLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            surnameNumberLayoutPanel.Size = new Size(375, 61);
            surnameNumberLayoutPanel.TabIndex = 2;
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
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.AutoSize = true;
            flowLayoutPanel3.Controls.Add(patronymicLabel);
            flowLayoutPanel3.Controls.Add(patronymicInput);
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(0, 122);
            flowLayoutPanel3.Margin = new Padding(0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel3.Size = new Size(375, 61);
            flowLayoutPanel3.TabIndex = 4;
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
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(passportLabel);
            flowLayoutPanel6.Controls.Add(passportInput);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(0, 183);
            flowLayoutPanel6.Margin = new Padding(0);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel6.Size = new Size(375, 61);
            flowLayoutPanel6.TabIndex = 2;
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
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.AutoSize = true;
            flowLayoutPanel8.Controls.Add(telephoneLabel);
            flowLayoutPanel8.Controls.Add(telephoneInput);
            flowLayoutPanel8.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel8.Location = new Point(0, 244);
            flowLayoutPanel8.Margin = new Padding(0);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel8.Size = new Size(375, 61);
            flowLayoutPanel8.TabIndex = 4;
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
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.AutoSize = true;
            flowLayoutPanel7.Controls.Add(addressLabel);
            flowLayoutPanel7.Controls.Add(addressInput);
            flowLayoutPanel7.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel7.Location = new Point(0, 305);
            flowLayoutPanel7.Margin = new Padding(0);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel7.Size = new Size(375, 61);
            flowLayoutPanel7.TabIndex = 3;
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
            buttonsLayoutPanel2.Size = new Size(150, 449);
            buttonsLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(acceptButton);
            flowLayoutPanel5.Controls.Add(resetButton);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(0, 169);
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
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "ClientsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Клиенты автосервиса";
            FormClosed += ClientsForm_FormClosed;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.ResumeLayout(false);
            textsLayoutPanel.ResumeLayout(false);
            textsLayoutPanel.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel12.ResumeLayout(false);
            flowLayoutPanel12.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel11.ResumeLayout(false);
            flowLayoutPanel11.PerformLayout();
            flowLayoutPanel9.ResumeLayout(false);
            priceLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            surnameNumberLayoutPanel.ResumeLayout(false);
            surnameNumberLayoutPanel.PerformLayout();
            nameLayoutPanel.ResumeLayout(false);
            nameLayoutPanel.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel7.PerformLayout();
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
        private ComboBox employeesPicker;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private FlowLayoutPanel tableLayoutPanel;
        private Label divider1;
        private TableLayoutPanel controlsLayoutPanel;
        private TableLayoutPanel inputsLayoutPanel;
        private TableLayoutPanel textsLayoutPanel;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label birthDateLabel;
        private DateTimePicker birthDatePicker;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel surnameNumberLayoutPanel;
        private Label surnameLabel;
        private TextBox surnameInput;
        private FlowLayoutPanel nameLayoutPanel;
        private Label nameLabel;
        private TextBox nameInput;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label patronymicLabel;
        private TextBox patronymicInput;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label passportLabel;
        private TextBox passportInput;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label telephoneLabel;
        private TextBox telephoneInput;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label addressLabel;
        private TextBox addressInput;
        private TableLayoutPanel buttonsLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button acceptButton;
        private Button resetButton;
        private FlowLayoutPanel flowLayoutPanel12;
        private Label label4;
        private TextBox textBox4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label label2;
        private TextBox textBox2;
        private FlowLayoutPanel flowLayoutPanel11;
        private Label label3;
        private TextBox textBox3;
        private FlowLayoutPanel priceLayoutPanel;
        private Label priceLabel;
        private NumericUpDown priceInput;
    }
}
