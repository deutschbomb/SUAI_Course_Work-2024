
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
            components = new System.ComponentModel.Container();
            formLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel = new FlowLayoutPanel();
            divider = new Label();
            controlsLayoutPanel = new TableLayoutPanel();
            inputsLayoutPanel = new TableLayoutPanel();
            rightLayoutPanel = new FlowLayoutPanel();
            brandLayoutPanel = new FlowLayoutPanel();
            brandLabel = new Label();
            brandInput = new TextBox();
            modelLayoutPanel = new FlowLayoutPanel();
            modelLabel = new Label();
            modelInput = new TextBox();
            VINLayoutPanel1 = new FlowLayoutPanel();
            VINLabel = new Label();
            VINInput = new TextBox();
            licenseLayoutPanel = new FlowLayoutPanel();
            licenseLabel = new Label();
            licenseInput = new TextBox();
            yearLayoutPanel = new FlowLayoutPanel();
            yearDateLabel = new Label();
            yearInput = new NumericUpDown();
            priceLayoutPanel = new FlowLayoutPanel();
            priceLabel = new Label();
            priceInput = new NumericUpDown();
            leftLayoutPanel = new FlowLayoutPanel();
            surnameNumberLayoutPanel = new FlowLayoutPanel();
            surnameLabel = new Label();
            surnameInput = new TextBox();
            nameLayoutPanel = new FlowLayoutPanel();
            nameLabel = new Label();
            nameInput = new TextBox();
            patronymicLayoutPanel = new FlowLayoutPanel();
            patronymicLabel = new Label();
            patronymicInput = new TextBox();
            passportLayoutPanel = new FlowLayoutPanel();
            passportLabel = new Label();
            passportInput = new TextBox();
            telephoneLayoutPanel = new FlowLayoutPanel();
            telephoneLabel = new Label();
            telephoneInput = new TextBox();
            addressLayoutPanel = new FlowLayoutPanel();
            addressLabel = new Label();
            addressInput = new TextBox();
            buttonsLayoutPanel = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            menuLayoutPanel = new TableLayoutPanel();
            dbLayoutPanel = new FlowLayoutPanel();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            clientsLayoutPanel = new FlowLayoutPanel();
            ownersPicker = new ComboBox();
            ownerBindingSource = new BindingSource(components);
            carsPicker = new ComboBox();
            carBindingSource = new BindingSource(components);
            redirectLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            formLayoutPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            inputsLayoutPanel.SuspendLayout();
            rightLayoutPanel.SuspendLayout();
            brandLayoutPanel.SuspendLayout();
            modelLayoutPanel.SuspendLayout();
            VINLayoutPanel1.SuspendLayout();
            licenseLayoutPanel.SuspendLayout();
            yearLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearInput).BeginInit();
            priceLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            leftLayoutPanel.SuspendLayout();
            surnameNumberLayoutPanel.SuspendLayout();
            nameLayoutPanel.SuspendLayout();
            patronymicLayoutPanel.SuspendLayout();
            passportLayoutPanel.SuspendLayout();
            telephoneLayoutPanel.SuspendLayout();
            addressLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            dbLayoutPanel.SuspendLayout();
            clientsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ownerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            redirectLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(tableLayoutPanel, 0, 1);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 2);
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
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
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel.AutoSize = true;
            tableLayoutPanel.Controls.Add(divider);
            tableLayoutPanel.FlowDirection = FlowDirection.TopDown;
            tableLayoutPanel.Location = new Point(20, 66);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Size = new Size(920, 21);
            tableLayoutPanel.TabIndex = 0;
            // 
            // divider
            // 
            divider.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            divider.BackColor = SystemColors.ControlDark;
            divider.Location = new Point(0, 10);
            divider.Margin = new Padding(0, 10, 0, 10);
            divider.Name = "divider";
            divider.Size = new Size(920, 1);
            divider.TabIndex = 4;
            // 
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.ColumnCount = 3;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            controlsLayoutPanel.Controls.Add(inputsLayoutPanel, 0, 0);
            controlsLayoutPanel.Controls.Add(buttonsLayoutPanel, 2, 0);
            controlsLayoutPanel.Dock = DockStyle.Fill;
            controlsLayoutPanel.Location = new Point(20, 87);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.Size = new Size(920, 449);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // inputsLayoutPanel
            // 
            inputsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputsLayoutPanel.AutoSize = true;
            inputsLayoutPanel.ColumnCount = 3;
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            inputsLayoutPanel.Controls.Add(rightLayoutPanel, 2, 0);
            inputsLayoutPanel.Controls.Add(leftLayoutPanel, 0, 0);
            inputsLayoutPanel.Location = new Point(0, 41);
            inputsLayoutPanel.Margin = new Padding(0);
            inputsLayoutPanel.Name = "inputsLayoutPanel";
            inputsLayoutPanel.RowCount = 1;
            inputsLayoutPanel.RowStyles.Add(new RowStyle());
            inputsLayoutPanel.Size = new Size(760, 366);
            inputsLayoutPanel.TabIndex = 5;
            // 
            // rightLayoutPanel
            // 
            rightLayoutPanel.AutoSize = true;
            rightLayoutPanel.Controls.Add(brandLayoutPanel);
            rightLayoutPanel.Controls.Add(modelLayoutPanel);
            rightLayoutPanel.Controls.Add(VINLayoutPanel1);
            rightLayoutPanel.Controls.Add(licenseLayoutPanel);
            rightLayoutPanel.Controls.Add(yearLayoutPanel);
            rightLayoutPanel.Controls.Add(priceLayoutPanel);
            rightLayoutPanel.FlowDirection = FlowDirection.TopDown;
            rightLayoutPanel.Location = new Point(385, 0);
            rightLayoutPanel.Margin = new Padding(0);
            rightLayoutPanel.Name = "rightLayoutPanel";
            rightLayoutPanel.Size = new Size(375, 366);
            rightLayoutPanel.TabIndex = 1;
            // 
            // brandLayoutPanel
            // 
            brandLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            brandLayoutPanel.AutoSize = true;
            brandLayoutPanel.Controls.Add(brandLabel);
            brandLayoutPanel.Controls.Add(brandInput);
            brandLayoutPanel.FlowDirection = FlowDirection.TopDown;
            brandLayoutPanel.Location = new Point(0, 0);
            brandLayoutPanel.Margin = new Padding(0);
            brandLayoutPanel.Name = "brandLayoutPanel";
            brandLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            brandLayoutPanel.Size = new Size(375, 61);
            brandLayoutPanel.TabIndex = 2;
            // 
            // brandLabel
            // 
            brandLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            brandLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            brandLabel.Location = new Point(0, 5);
            brandLabel.Margin = new Padding(0);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(375, 25);
            brandLabel.TabIndex = 0;
            brandLabel.Text = "Марка";
            // 
            // brandInput
            // 
            brandInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            brandInput.BorderStyle = BorderStyle.FixedSingle;
            brandInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            brandInput.Location = new Point(0, 30);
            brandInput.Margin = new Padding(0);
            brandInput.MaxLength = 25;
            brandInput.Name = "brandInput";
            brandInput.PlaceholderText = "Марка";
            brandInput.Size = new Size(375, 26);
            brandInput.TabIndex = 1;
            // 
            // modelLayoutPanel
            // 
            modelLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            modelLayoutPanel.AutoSize = true;
            modelLayoutPanel.Controls.Add(modelLabel);
            modelLayoutPanel.Controls.Add(modelInput);
            modelLayoutPanel.FlowDirection = FlowDirection.TopDown;
            modelLayoutPanel.Location = new Point(0, 61);
            modelLayoutPanel.Margin = new Padding(0);
            modelLayoutPanel.Name = "modelLayoutPanel";
            modelLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            modelLayoutPanel.Size = new Size(375, 61);
            modelLayoutPanel.TabIndex = 2;
            // 
            // modelLabel
            // 
            modelLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            modelLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            modelLabel.Location = new Point(0, 5);
            modelLabel.Margin = new Padding(0);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(375, 25);
            modelLabel.TabIndex = 0;
            modelLabel.Text = "Модель";
            // 
            // modelInput
            // 
            modelInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            modelInput.BorderStyle = BorderStyle.FixedSingle;
            modelInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            modelInput.Location = new Point(0, 30);
            modelInput.Margin = new Padding(0);
            modelInput.MaxLength = 25;
            modelInput.Name = "modelInput";
            modelInput.PlaceholderText = "Модель";
            modelInput.Size = new Size(375, 26);
            modelInput.TabIndex = 1;
            // 
            // VINLayoutPanel1
            // 
            VINLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            VINLayoutPanel1.AutoSize = true;
            VINLayoutPanel1.Controls.Add(VINLabel);
            VINLayoutPanel1.Controls.Add(VINInput);
            VINLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            VINLayoutPanel1.Location = new Point(0, 122);
            VINLayoutPanel1.Margin = new Padding(0);
            VINLayoutPanel1.Name = "VINLayoutPanel1";
            VINLayoutPanel1.Padding = new Padding(0, 5, 0, 5);
            VINLayoutPanel1.Size = new Size(375, 61);
            VINLayoutPanel1.TabIndex = 4;
            // 
            // VINLabel
            // 
            VINLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            VINLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            VINLabel.Location = new Point(0, 5);
            VINLabel.Margin = new Padding(0);
            VINLabel.Name = "VINLabel";
            VINLabel.Size = new Size(375, 25);
            VINLabel.TabIndex = 0;
            VINLabel.Text = "VIN";
            // 
            // VINInput
            // 
            VINInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            VINInput.BorderStyle = BorderStyle.FixedSingle;
            VINInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            VINInput.Location = new Point(0, 30);
            VINInput.Margin = new Padding(0);
            VINInput.MaxLength = 17;
            VINInput.Name = "VINInput";
            VINInput.PlaceholderText = "000 000000 00000000";
            VINInput.Size = new Size(375, 26);
            VINInput.TabIndex = 1;
            // 
            // licenseLayoutPanel
            // 
            licenseLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            licenseLayoutPanel.AutoSize = true;
            licenseLayoutPanel.Controls.Add(licenseLabel);
            licenseLayoutPanel.Controls.Add(licenseInput);
            licenseLayoutPanel.FlowDirection = FlowDirection.TopDown;
            licenseLayoutPanel.Location = new Point(0, 183);
            licenseLayoutPanel.Margin = new Padding(0);
            licenseLayoutPanel.Name = "licenseLayoutPanel";
            licenseLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            licenseLayoutPanel.Size = new Size(375, 61);
            licenseLayoutPanel.TabIndex = 3;
            // 
            // licenseLabel
            // 
            licenseLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            licenseLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            licenseLabel.Location = new Point(0, 5);
            licenseLabel.Margin = new Padding(0);
            licenseLabel.Name = "licenseLabel";
            licenseLabel.Size = new Size(375, 25);
            licenseLabel.TabIndex = 0;
            licenseLabel.Text = "Регистрационный номер";
            // 
            // licenseInput
            // 
            licenseInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            licenseInput.BorderStyle = BorderStyle.FixedSingle;
            licenseInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            licenseInput.Location = new Point(0, 30);
            licenseInput.Margin = new Padding(0);
            licenseInput.MaxLength = 6;
            licenseInput.Name = "licenseInput";
            licenseInput.PlaceholderText = "A000AA";
            licenseInput.Size = new Size(375, 26);
            licenseInput.TabIndex = 1;
            // 
            // yearLayoutPanel
            // 
            yearLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yearLayoutPanel.AutoSize = true;
            yearLayoutPanel.Controls.Add(yearDateLabel);
            yearLayoutPanel.Controls.Add(yearInput);
            yearLayoutPanel.FlowDirection = FlowDirection.TopDown;
            yearLayoutPanel.Location = new Point(0, 244);
            yearLayoutPanel.Margin = new Padding(0);
            yearLayoutPanel.Name = "yearLayoutPanel";
            yearLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            yearLayoutPanel.Size = new Size(375, 61);
            yearLayoutPanel.TabIndex = 5;
            // 
            // yearDateLabel
            // 
            yearDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            yearDateLabel.Location = new Point(0, 5);
            yearDateLabel.Margin = new Padding(0);
            yearDateLabel.Name = "yearDateLabel";
            yearDateLabel.Size = new Size(375, 25);
            yearDateLabel.TabIndex = 0;
            yearDateLabel.Text = "Год выпуска";
            // 
            // yearInput
            // 
            yearInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            yearInput.BorderStyle = BorderStyle.FixedSingle;
            yearInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            yearInput.Location = new Point(0, 30);
            yearInput.Margin = new Padding(0);
            yearInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            yearInput.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            yearInput.Name = "yearInput";
            yearInput.Size = new Size(375, 26);
            yearInput.TabIndex = 2;
            yearInput.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            // 
            // priceLayoutPanel
            // 
            priceLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            priceLabel.Text = "Стоимость автомобиля, руб.";
            // 
            // priceInput
            // 
            priceInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceInput.BorderStyle = BorderStyle.FixedSingle;
            priceInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceInput.Location = new Point(0, 30);
            priceInput.Margin = new Padding(0);
            priceInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(375, 26);
            priceInput.TabIndex = 2;
            priceInput.ThousandsSeparator = true;
            // 
            // leftLayoutPanel
            // 
            leftLayoutPanel.AutoSize = true;
            leftLayoutPanel.Controls.Add(surnameNumberLayoutPanel);
            leftLayoutPanel.Controls.Add(nameLayoutPanel);
            leftLayoutPanel.Controls.Add(patronymicLayoutPanel);
            leftLayoutPanel.Controls.Add(passportLayoutPanel);
            leftLayoutPanel.Controls.Add(telephoneLayoutPanel);
            leftLayoutPanel.Controls.Add(addressLayoutPanel);
            leftLayoutPanel.FlowDirection = FlowDirection.TopDown;
            leftLayoutPanel.Location = new Point(0, 0);
            leftLayoutPanel.Margin = new Padding(0);
            leftLayoutPanel.Name = "leftLayoutPanel";
            leftLayoutPanel.Size = new Size(375, 366);
            leftLayoutPanel.TabIndex = 0;
            // 
            // surnameNumberLayoutPanel
            // 
            surnameNumberLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            // passportLayoutPanel
            // 
            passportLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passportLayoutPanel.AutoSize = true;
            passportLayoutPanel.Controls.Add(passportLabel);
            passportLayoutPanel.Controls.Add(passportInput);
            passportLayoutPanel.FlowDirection = FlowDirection.TopDown;
            passportLayoutPanel.Location = new Point(0, 183);
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
            passportInput.MaxLength = 10;
            passportInput.Name = "passportInput";
            passportInput.PlaceholderText = "0000 000000";
            passportInput.Size = new Size(375, 26);
            passportInput.TabIndex = 1;
            passportInput.Enter += passportInput_Enter;
            passportInput.Leave += passportInput_Leave;
            // 
            // telephoneLayoutPanel
            // 
            telephoneLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            telephoneLayoutPanel.AutoSize = true;
            telephoneLayoutPanel.Controls.Add(telephoneLabel);
            telephoneLayoutPanel.Controls.Add(telephoneInput);
            telephoneLayoutPanel.FlowDirection = FlowDirection.TopDown;
            telephoneLayoutPanel.Location = new Point(0, 244);
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
            telephoneInput.MaxLength = 12;
            telephoneInput.Name = "telephoneInput";
            telephoneInput.PlaceholderText = "+7 (___) ___-__-__";
            telephoneInput.Size = new Size(375, 26);
            telephoneInput.TabIndex = 1;
            telephoneInput.Enter += telephoneInput_Enter;
            telephoneInput.Leave += telephoneInput_Leave;
            // 
            // addressLayoutPanel
            // 
            addressLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addressLayoutPanel.AutoSize = true;
            addressLayoutPanel.Controls.Add(addressLabel);
            addressLayoutPanel.Controls.Add(addressInput);
            addressLayoutPanel.FlowDirection = FlowDirection.TopDown;
            addressLayoutPanel.Location = new Point(0, 305);
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
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.AutoSize = true;
            buttonsLayoutPanel.Controls.Add(acceptButton);
            buttonsLayoutPanel.Controls.Add(resetButton);
            buttonsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            buttonsLayoutPanel.Location = new Point(770, 169);
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
            // menuLayoutPanel
            // 
            menuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            menuLayoutPanel.AutoSize = true;
            menuLayoutPanel.ColumnCount = 5;
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            menuLayoutPanel.Controls.Add(dbLayoutPanel, 4, 0);
            menuLayoutPanel.Controls.Add(clientsLayoutPanel, 2, 0);
            menuLayoutPanel.Controls.Add(redirectLayoutPanel, 0, 0);
            menuLayoutPanel.Location = new Point(23, 13);
            menuLayoutPanel.Name = "menuLayoutPanel";
            menuLayoutPanel.RowCount = 1;
            menuLayoutPanel.RowStyles.Add(new RowStyle());
            menuLayoutPanel.Size = new Size(914, 50);
            menuLayoutPanel.TabIndex = 2;
            // 
            // dbLayoutPanel
            // 
            dbLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dbLayoutPanel.AutoSize = true;
            dbLayoutPanel.Controls.Add(addButton);
            dbLayoutPanel.Controls.Add(editButton);
            dbLayoutPanel.Controls.Add(deleteButton);
            dbLayoutPanel.Location = new Point(454, 0);
            dbLayoutPanel.Margin = new Padding(0);
            dbLayoutPanel.Name = "dbLayoutPanel";
            dbLayoutPanel.Size = new Size(460, 50);
            dbLayoutPanel.TabIndex = 6;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = SystemColors.MenuHighlight;
            addButton.Dock = DockStyle.Left;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(0, 0);
            addButton.Margin = new Padding(0);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 50);
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
            editButton.Location = new Point(160, 0);
            editButton.Margin = new Padding(20, 0, 20, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(140, 50);
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
            deleteButton.Location = new Point(320, 0);
            deleteButton.Margin = new Padding(0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 50);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // clientsLayoutPanel
            // 
            clientsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            clientsLayoutPanel.AutoSize = true;
            clientsLayoutPanel.Controls.Add(ownersPicker);
            clientsLayoutPanel.Controls.Add(carsPicker);
            clientsLayoutPanel.Location = new Point(120, 11);
            clientsLayoutPanel.Margin = new Padding(0);
            clientsLayoutPanel.Name = "clientsLayoutPanel";
            clientsLayoutPanel.Size = new Size(314, 27);
            clientsLayoutPanel.TabIndex = 3;
            // 
            // ownersPicker
            // 
            ownersPicker.BackColor = Color.White;
            ownersPicker.DataSource = ownerBindingSource;
            ownersPicker.DisplayMember = "OwnerSurname";
            ownersPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            ownersPicker.FlatStyle = FlatStyle.System;
            ownersPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ownersPicker.FormattingEnabled = true;
            ownersPicker.Location = new Point(0, 0);
            ownersPicker.Margin = new Padding(0, 0, 10, 0);
            ownersPicker.Name = "ownersPicker";
            ownersPicker.Size = new Size(147, 27);
            ownersPicker.TabIndex = 1;
            ownersPicker.ValueMember = "Id";
            // 
            // ownerBindingSource
            // 
            ownerBindingSource.DataSource = typeof(Owner);
            // 
            // carsPicker
            // 
            carsPicker.BackColor = Color.White;
            carsPicker.DataSource = carBindingSource;
            carsPicker.DisplayMember = "LicensePlate";
            carsPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            carsPicker.FlatStyle = FlatStyle.System;
            carsPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            carsPicker.FormattingEnabled = true;
            carsPicker.Location = new Point(167, 0);
            carsPicker.Margin = new Padding(10, 0, 0, 0);
            carsPicker.Name = "carsPicker";
            carsPicker.Size = new Size(147, 27);
            carsPicker.TabIndex = 2;
            carsPicker.ValueMember = "Id";
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
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
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "ClientsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационная система: клиенты автосервиса";
            FormClosed += ClientsForm_FormClosed;
            Load += ClientsForm_Load;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.PerformLayout();
            inputsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.PerformLayout();
            rightLayoutPanel.ResumeLayout(false);
            rightLayoutPanel.PerformLayout();
            brandLayoutPanel.ResumeLayout(false);
            brandLayoutPanel.PerformLayout();
            modelLayoutPanel.ResumeLayout(false);
            modelLayoutPanel.PerformLayout();
            VINLayoutPanel1.ResumeLayout(false);
            VINLayoutPanel1.PerformLayout();
            licenseLayoutPanel.ResumeLayout(false);
            licenseLayoutPanel.PerformLayout();
            yearLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)yearInput).EndInit();
            priceLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            leftLayoutPanel.ResumeLayout(false);
            leftLayoutPanel.PerformLayout();
            surnameNumberLayoutPanel.ResumeLayout(false);
            surnameNumberLayoutPanel.PerformLayout();
            nameLayoutPanel.ResumeLayout(false);
            nameLayoutPanel.PerformLayout();
            patronymicLayoutPanel.ResumeLayout(false);
            patronymicLayoutPanel.PerformLayout();
            passportLayoutPanel.ResumeLayout(false);
            passportLayoutPanel.PerformLayout();
            telephoneLayoutPanel.ResumeLayout(false);
            telephoneLayoutPanel.PerformLayout();
            addressLayoutPanel.ResumeLayout(false);
            addressLayoutPanel.PerformLayout();
            buttonsLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            dbLayoutPanel.ResumeLayout(false);
            dbLayoutPanel.PerformLayout();
            clientsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ownerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            redirectLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formLayoutPanel;
        private FlowLayoutPanel tableLayoutPanel;
        private Label divider;
        private TableLayoutPanel controlsLayoutPanel;
        private FlowLayoutPanel buttonsLayoutPanel;
        private Button acceptButton;
        private Button resetButton;
        private TableLayoutPanel inputsLayoutPanel;
        private FlowLayoutPanel rightLayoutPanel;
        private FlowLayoutPanel brandLayoutPanel;
        private Label brandLabel;
        private TextBox brandInput;
        private FlowLayoutPanel modelLayoutPanel;
        private Label modelLabel;
        private TextBox modelInput;
        private FlowLayoutPanel VINLayoutPanel1;
        private Label VINLabel;
        private TextBox VINInput;
        private FlowLayoutPanel licenseLayoutPanel;
        private Label licenseLabel;
        private TextBox licenseInput;
        private FlowLayoutPanel yearLayoutPanel;
        private Label yearDateLabel;
        private FlowLayoutPanel priceLayoutPanel;
        private Label priceLabel;
        private NumericUpDown priceInput;
        private FlowLayoutPanel leftLayoutPanel;
        private FlowLayoutPanel surnameNumberLayoutPanel;
        private Label surnameLabel;
        private TextBox surnameInput;
        private FlowLayoutPanel nameLayoutPanel;
        private Label nameLabel;
        private TextBox nameInput;
        private FlowLayoutPanel patronymicLayoutPanel;
        private Label patronymicLabel;
        private TextBox patronymicInput;
        private FlowLayoutPanel passportLayoutPanel;
        private Label passportLabel;
        private TextBox passportInput;
        private FlowLayoutPanel telephoneLayoutPanel;
        private Label telephoneLabel;
        private TextBox telephoneInput;
        private FlowLayoutPanel addressLayoutPanel;
        private Label addressLabel;
        private TextBox addressInput;
        private BindingSource ownerBindingSource;
        private TableLayoutPanel menuLayoutPanel;
        private FlowLayoutPanel dbLayoutPanel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private FlowLayoutPanel clientsLayoutPanel;
        private ComboBox ownersPicker;
        private ComboBox carsPicker;
        private FlowLayoutPanel redirectLayoutPanel;
        private Button homeButton;
        private Button returnButton;
        private BindingSource carBindingSource;
        private NumericUpDown yearInput;
    }
}
