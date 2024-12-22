
namespace App
{
    partial class LogisticsForm
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
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            tableLayoutPanel = new FlowLayoutPanel();
            suppliesTable = new DataGridView();
            controlsLayoutPanel = new TableLayoutPanel();
            buttonsLayoutPanel = new FlowLayoutPanel();
            buttonsLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            amountLayoutPane = new FlowLayoutPanel();
            amountLabel = new Label();
            amountInput = new NumericUpDown();
            partLayoutPanel = new FlowLayoutPanel();
            partsLabel = new Label();
            partsPicker = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            supplierLayoutPanel = new FlowLayoutPanel();
            suppliersLabel = new Label();
            suppliersPicker = new ComboBox();
            employeeLayoutPanel = new FlowLayoutPanel();
            employeeLabel = new Label();
            employeePicker = new ComboBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            deliveryDateLayoutPanel = new FlowLayoutPanel();
            deliveryDateLabel = new Label();
            deliveryDatePicker = new DateTimePicker();
            postDateLayoutPanel = new FlowLayoutPanel();
            postDateLabel = new Label();
            postDatePicker = new DateTimePicker();
            deliveryStateLayoutPanel = new TableLayoutPanel();
            deliveryStateCheckBox = new CheckBox();
            formLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliesTable).BeginInit();
            controlsLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            buttonsLayoutPanel2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            amountLayoutPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            partLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            supplierLayoutPanel.SuspendLayout();
            employeeLayoutPanel.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            deliveryDateLayoutPanel.SuspendLayout();
            postDateLayoutPanel.SuspendLayout();
            deliveryStateLayoutPanel.SuspendLayout();
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
            formLayoutPanel.Padding = new Padding(20, 0, 20, 0);
            formLayoutPanel.RowCount = 3;
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.Size = new Size(960, 540);
            formLayoutPanel.TabIndex = 2;
            // 
            // menuLayoutPanel
            // 
            menuLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            menuLayoutPanel.AutoSize = true;
            menuLayoutPanel.Controls.Add(homeButton);
            menuLayoutPanel.Controls.Add(returnButton);
            menuLayoutPanel.Controls.Add(addButton);
            menuLayoutPanel.Controls.Add(editButton);
            menuLayoutPanel.Controls.Add(deleteButton);
            menuLayoutPanel.Location = new Point(21, 10);
            menuLayoutPanel.Margin = new Padding(0, 10, 0, 10);
            menuLayoutPanel.Name = "menuLayoutPanel";
            menuLayoutPanel.Size = new Size(918, 50);
            menuLayoutPanel.TabIndex = 0;
            // 
            // homeButton
            // 
            homeButton.BackColor = Color.Transparent;
            homeButton.FlatAppearance.BorderSize = 0;
            homeButton.FlatStyle = FlatStyle.Flat;
            homeButton.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            homeButton.ForeColor = SystemColors.WindowFrame;
            homeButton.Location = new Point(0, 0);
            homeButton.Margin = new Padding(0, 0, 10, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(50, 50);
            homeButton.TabIndex = 4;
            homeButton.Text = "";
            homeButton.UseVisualStyleBackColor = false;
            homeButton.Click += homeButton_Click;
            // 
            // returnButton
            // 
            returnButton.BackColor = Color.Transparent;
            returnButton.FlatAppearance.BorderSize = 0;
            returnButton.FlatStyle = FlatStyle.Flat;
            returnButton.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            returnButton.ForeColor = SystemColors.WindowFrame;
            returnButton.Location = new Point(70, 0);
            returnButton.Margin = new Padding(10, 0, 10, 0);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(50, 50);
            returnButton.TabIndex = 5;
            returnButton.Text = "";
            returnButton.UseVisualStyleBackColor = false;
            returnButton.Click += returnButton_Click;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = SystemColors.MenuHighlight;
            addButton.Dock = DockStyle.Left;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(140, 0);
            addButton.Margin = new Padding(10, 0, 10, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(246, 50);
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
            editButton.Location = new Point(406, 0);
            editButton.Margin = new Padding(10, 0, 10, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(246, 50);
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
            deleteButton.Location = new Point(672, 0);
            deleteButton.Margin = new Padding(10, 0, 0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(246, 50);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel.Controls.Add(suppliesTable);
            tableLayoutPanel.FlowDirection = FlowDirection.TopDown;
            tableLayoutPanel.Location = new Point(20, 80);
            tableLayoutPanel.Margin = new Padding(0, 10, 0, 10);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Size = new Size(919, 240);
            tableLayoutPanel.TabIndex = 0;
            // 
            // suppliesTable
            // 
            suppliesTable.BackgroundColor = Color.White;
            suppliesTable.BorderStyle = BorderStyle.None;
            suppliesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliesTable.Cursor = Cursors.Hand;
            suppliesTable.GridColor = SystemColors.ControlDark;
            suppliesTable.Location = new Point(0, 0);
            suppliesTable.Margin = new Padding(0);
            suppliesTable.Name = "suppliesTable";
            suppliesTable.Size = new Size(920, 240);
            suppliesTable.TabIndex = 0;
            // 
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.ColumnCount = 2;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            controlsLayoutPanel.Controls.Add(buttonsLayoutPanel, 1, 0);
            controlsLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            controlsLayoutPanel.Location = new Point(20, 340);
            controlsLayoutPanel.Margin = new Padding(0, 10, 0, 10);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.Size = new Size(919, 190);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Controls.Add(buttonsLayoutPanel2);
            buttonsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            buttonsLayoutPanel.Location = new Point(769, 0);
            buttonsLayoutPanel.Margin = new Padding(0);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.Size = new Size(150, 180);
            buttonsLayoutPanel.TabIndex = 0;
            // 
            // buttonsLayoutPanel2
            // 
            buttonsLayoutPanel2.ColumnCount = 1;
            buttonsLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsLayoutPanel2.Controls.Add(flowLayoutPanel5, 0, 1);
            buttonsLayoutPanel2.Location = new Point(0, 0);
            buttonsLayoutPanel2.Margin = new Padding(0);
            buttonsLayoutPanel2.Name = "buttonsLayoutPanel2";
            buttonsLayoutPanel2.RowCount = 3;
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle());
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonsLayoutPanel2.Size = new Size(150, 190);
            buttonsLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(acceptButton);
            flowLayoutPanel5.Controls.Add(resetButton);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(0, 40);
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
            acceptButton.Text = "Отправить";
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
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0, 0, 10, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(759, 190);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.02631F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.9736843F));
            tableLayoutPanel3.Controls.Add(amountLayoutPane, 1, 0);
            tableLayoutPanel3.Controls.Add(partLayoutPanel, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 63);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(759, 63);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // amountLayoutPane
            // 
            amountLayoutPane.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            amountLayoutPane.AutoSize = true;
            amountLayoutPane.Controls.Add(amountLabel);
            amountLayoutPane.Controls.Add(amountInput);
            amountLayoutPane.FlowDirection = FlowDirection.TopDown;
            amountLayoutPane.Location = new Point(556, 0);
            amountLayoutPane.Margin = new Padding(0);
            amountLayoutPane.Name = "amountLayoutPane";
            amountLayoutPane.Padding = new Padding(0, 5, 0, 5);
            amountLayoutPane.Size = new Size(200, 63);
            amountLayoutPane.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            amountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            amountLabel.Location = new Point(0, 5);
            amountLabel.Margin = new Padding(0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(200, 25);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Количество";
            // 
            // amountInput
            // 
            amountInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            amountInput.BorderStyle = BorderStyle.FixedSingle;
            amountInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            amountInput.Location = new Point(0, 30);
            amountInput.Margin = new Padding(0);
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(200, 26);
            amountInput.TabIndex = 1;
            // 
            // partLayoutPanel
            // 
            partLayoutPanel.AutoSize = true;
            partLayoutPanel.Controls.Add(partsLabel);
            partLayoutPanel.Controls.Add(partsPicker);
            partLayoutPanel.Dock = DockStyle.Fill;
            partLayoutPanel.FlowDirection = FlowDirection.TopDown;
            partLayoutPanel.Location = new Point(0, 0);
            partLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            partLayoutPanel.Name = "partLayoutPanel";
            partLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            partLayoutPanel.Size = new Size(549, 63);
            partLayoutPanel.TabIndex = 2;
            // 
            // partsLabel
            // 
            partsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            partsLabel.Location = new Point(0, 5);
            partsLabel.Margin = new Padding(0);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(550, 25);
            partsLabel.TabIndex = 0;
            partsLabel.Text = "Запчасть";
            // 
            // partsPicker
            // 
            partsPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            partsPicker.BackColor = Color.White;
            partsPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            partsPicker.FlatStyle = FlatStyle.System;
            partsPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            partsPicker.FormattingEnabled = true;
            partsPicker.Location = new Point(0, 30);
            partsPicker.Margin = new Padding(0);
            partsPicker.Name = "partsPicker";
            partsPicker.Size = new Size(550, 27);
            partsPicker.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(supplierLayoutPanel, 1, 0);
            tableLayoutPanel2.Controls.Add(employeeLayoutPanel, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(759, 63);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // supplierLayoutPanel
            // 
            supplierLayoutPanel.AutoSize = true;
            supplierLayoutPanel.Controls.Add(suppliersLabel);
            supplierLayoutPanel.Controls.Add(suppliersPicker);
            supplierLayoutPanel.Dock = DockStyle.Fill;
            supplierLayoutPanel.FlowDirection = FlowDirection.TopDown;
            supplierLayoutPanel.Location = new Point(384, 0);
            supplierLayoutPanel.Margin = new Padding(5, 0, 0, 0);
            supplierLayoutPanel.Name = "supplierLayoutPanel";
            supplierLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            supplierLayoutPanel.Size = new Size(375, 63);
            supplierLayoutPanel.TabIndex = 3;
            // 
            // suppliersLabel
            // 
            suppliersLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            suppliersLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            suppliersLabel.Location = new Point(0, 5);
            suppliersLabel.Margin = new Padding(0);
            suppliersLabel.Name = "suppliersLabel";
            suppliersLabel.Size = new Size(375, 25);
            suppliersLabel.TabIndex = 0;
            suppliersLabel.Text = "Поставщик";
            // 
            // suppliersPicker
            // 
            suppliersPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            suppliersPicker.BackColor = Color.White;
            suppliersPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            suppliersPicker.FlatStyle = FlatStyle.System;
            suppliersPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            suppliersPicker.FormattingEnabled = true;
            suppliersPicker.Location = new Point(0, 30);
            suppliersPicker.Margin = new Padding(0);
            suppliersPicker.Name = "suppliersPicker";
            suppliersPicker.Size = new Size(375, 27);
            suppliersPicker.TabIndex = 1;
            // 
            // employeeLayoutPanel
            // 
            employeeLayoutPanel.AutoSize = true;
            employeeLayoutPanel.Controls.Add(employeeLabel);
            employeeLayoutPanel.Controls.Add(employeePicker);
            employeeLayoutPanel.Dock = DockStyle.Fill;
            employeeLayoutPanel.FlowDirection = FlowDirection.TopDown;
            employeeLayoutPanel.Location = new Point(0, 0);
            employeeLayoutPanel.Margin = new Padding(0, 0, 5, 0);
            employeeLayoutPanel.Name = "employeeLayoutPanel";
            employeeLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            employeeLayoutPanel.Size = new Size(374, 63);
            employeeLayoutPanel.TabIndex = 2;
            // 
            // employeeLabel
            // 
            employeeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeeLabel.Location = new Point(0, 5);
            employeeLabel.Margin = new Padding(0);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new Size(375, 25);
            employeeLabel.TabIndex = 0;
            employeeLabel.Text = "Ответственный";
            // 
            // employeePicker
            // 
            employeePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employeePicker.BackColor = Color.White;
            employeePicker.DropDownStyle = ComboBoxStyle.DropDownList;
            employeePicker.FlatStyle = FlatStyle.System;
            employeePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeePicker.FormattingEnabled = true;
            employeePicker.Location = new Point(0, 30);
            employeePicker.Margin = new Padding(0);
            employeePicker.Name = "employeePicker";
            employeePicker.Size = new Size(375, 27);
            employeePicker.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel4.Controls.Add(deliveryDateLayoutPanel, 2, 0);
            tableLayoutPanel4.Controls.Add(postDateLayoutPanel, 0, 0);
            tableLayoutPanel4.Controls.Add(deliveryStateLayoutPanel, 1, 0);
            tableLayoutPanel4.Location = new Point(0, 126);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(759, 64);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // deliveryDateLayoutPanel
            // 
            deliveryDateLayoutPanel.AutoSize = true;
            deliveryDateLayoutPanel.Controls.Add(deliveryDateLabel);
            deliveryDateLayoutPanel.Controls.Add(deliveryDatePicker);
            deliveryDateLayoutPanel.Dock = DockStyle.Fill;
            deliveryDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            deliveryDateLayoutPanel.Location = new Point(439, 0);
            deliveryDateLayoutPanel.Margin = new Padding(0);
            deliveryDateLayoutPanel.Name = "deliveryDateLayoutPanel";
            deliveryDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            deliveryDateLayoutPanel.Size = new Size(320, 64);
            deliveryDateLayoutPanel.TabIndex = 6;
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            deliveryDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deliveryDateLabel.Location = new Point(0, 5);
            deliveryDateLabel.Margin = new Padding(0);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new Size(320, 25);
            deliveryDateLabel.TabIndex = 0;
            deliveryDateLabel.Text = "Дата прибытия";
            // 
            // deliveryDatePicker
            // 
            deliveryDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deliveryDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deliveryDatePicker.Location = new Point(0, 30);
            deliveryDatePicker.Margin = new Padding(0);
            deliveryDatePicker.Name = "deliveryDatePicker";
            deliveryDatePicker.Size = new Size(320, 26);
            deliveryDatePicker.TabIndex = 1;
            // 
            // postDateLayoutPanel
            // 
            postDateLayoutPanel.AutoSize = true;
            postDateLayoutPanel.Controls.Add(postDateLabel);
            postDateLayoutPanel.Controls.Add(postDatePicker);
            postDateLayoutPanel.Dock = DockStyle.Fill;
            postDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            postDateLayoutPanel.Location = new Point(0, 0);
            postDateLayoutPanel.Margin = new Padding(0);
            postDateLayoutPanel.Name = "postDateLayoutPanel";
            postDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            postDateLayoutPanel.Size = new Size(320, 64);
            postDateLayoutPanel.TabIndex = 4;
            // 
            // postDateLabel
            // 
            postDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            postDateLabel.Location = new Point(0, 5);
            postDateLabel.Margin = new Padding(0);
            postDateLabel.Name = "postDateLabel";
            postDateLabel.Size = new Size(320, 25);
            postDateLabel.TabIndex = 0;
            postDateLabel.Text = "Дата оформления";
            // 
            // postDatePicker
            // 
            postDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            postDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            postDatePicker.Location = new Point(0, 30);
            postDatePicker.Margin = new Padding(0);
            postDatePicker.Name = "postDatePicker";
            postDatePicker.Size = new Size(320, 26);
            postDatePicker.TabIndex = 1;
            // 
            // deliveryStateLayoutPanel
            // 
            deliveryStateLayoutPanel.ColumnCount = 1;
            deliveryStateLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            deliveryStateLayoutPanel.Controls.Add(deliveryStateCheckBox, 0, 1);
            deliveryStateLayoutPanel.Dock = DockStyle.Fill;
            deliveryStateLayoutPanel.Location = new Point(330, 0);
            deliveryStateLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            deliveryStateLayoutPanel.Name = "deliveryStateLayoutPanel";
            deliveryStateLayoutPanel.RowCount = 2;
            deliveryStateLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            deliveryStateLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            deliveryStateLayoutPanel.Size = new Size(99, 64);
            deliveryStateLayoutPanel.TabIndex = 7;
            // 
            // deliveryStateCheckBox
            // 
            deliveryStateCheckBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deliveryStateCheckBox.AutoSize = true;
            deliveryStateCheckBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deliveryStateCheckBox.ImageAlign = ContentAlignment.MiddleRight;
            deliveryStateCheckBox.Location = new Point(0, 34);
            deliveryStateCheckBox.Margin = new Padding(0);
            deliveryStateCheckBox.Name = "deliveryStateCheckBox";
            deliveryStateCheckBox.Padding = new Padding(0, 0, 0, 5);
            deliveryStateCheckBox.Size = new Size(99, 28);
            deliveryStateCheckBox.TabIndex = 0;
            deliveryStateCheckBox.Text = "Прибыла";
            deliveryStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // LogisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "LogisticsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Логистика: поставки запчастей";
            Load += LogisticsForm_Load;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)suppliesTable).EndInit();
            controlsLayoutPanel.ResumeLayout(false);
            buttonsLayoutPanel.ResumeLayout(false);
            buttonsLayoutPanel2.ResumeLayout(false);
            buttonsLayoutPanel2.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            amountLayoutPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            partLayoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            supplierLayoutPanel.ResumeLayout(false);
            employeeLayoutPanel.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            deliveryDateLayoutPanel.ResumeLayout(false);
            postDateLayoutPanel.ResumeLayout(false);
            deliveryStateLayoutPanel.ResumeLayout(false);
            deliveryStateLayoutPanel.PerformLayout();
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
        private DataGridView suppliesTable;
        private TableLayoutPanel controlsLayoutPanel;
        private FlowLayoutPanel buttonsLayoutPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel employeeLayoutPanel;
        private Label employeeLabel;
        private ComboBox employeePicker;
        private FlowLayoutPanel supplierLayoutPanel;
        private Label suppliersLabel;
        private ComboBox suppliersPicker;
        private TableLayoutPanel tableLayoutPanel3;
        private FlowLayoutPanel partLayoutPanel;
        private Label partsLabel;
        private ComboBox partsPicker;
        private FlowLayoutPanel amountLayoutPane;
        private Label amountLabel;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel postDateLayoutPanel;
        private Label postDateLabel;
        private DateTimePicker postDatePicker;
        private FlowLayoutPanel deliveryDateLayoutPanel;
        private Label deliveryDateLabel;
        private DateTimePicker deliveryDatePicker;
        private TableLayoutPanel deliveryStateLayoutPanel;
        private CheckBox deliveryStateCheckBox;
        private TableLayoutPanel buttonsLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button acceptButton;
        private Button resetButton;
        private NumericUpDown amountInput;
    }
}
