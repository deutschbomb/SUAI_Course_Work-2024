
namespace App
{
    partial class RequestsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            formLayoutPanel = new TableLayoutPanel();
            controlsLayoutPanel = new TableLayoutPanel();
            inputsLayoutPanel = new TableLayoutPanel();
            pickersLayoutPanel = new TableLayoutPanel();
            carLayoutPanel = new FlowLayoutPanel();
            carLabel = new Label();
            carsPicker = new ComboBox();
            carBindingSource = new BindingSource(components);
            ownerLayoutPanel = new FlowLayoutPanel();
            ownerLabel = new Label();
            ownersPicker = new ComboBox();
            ownerBindingSource = new BindingSource(components);
            employeeLayoutPanel = new FlowLayoutPanel();
            employeeLabel = new Label();
            employeesPicker = new ComboBox();
            employeeBindingSource = new BindingSource(components);
            datesLayoutPanel = new TableLayoutPanel();
            completeDateLayoutPanel = new FlowLayoutPanel();
            completeDateLabel = new Label();
            completeDatePicker = new DateTimePicker();
            startDateLayoutPanel = new FlowLayoutPanel();
            startDateLabel = new Label();
            startDatePicker = new DateTimePicker();
            postDateLayoutPanel = new FlowLayoutPanel();
            postDateLabel = new Label();
            postDatePicker = new DateTimePicker();
            completedCheckBox = new CheckBox();
            buttonsLayoutPanel = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            toOrdersButton = new Button();
            requestBindingSource = new BindingSource(components);
            menuLayoutPanel = new TableLayoutPanel();
            dbLayoutPanel = new FlowLayoutPanel();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            redirectLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            requestsTable = new DataGridView();
            requestIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ownerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            completeDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            inputsLayoutPanel.SuspendLayout();
            pickersLayoutPanel.SuspendLayout();
            carLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carBindingSource).BeginInit();
            ownerLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ownerBindingSource).BeginInit();
            employeeLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            datesLayoutPanel.SuspendLayout();
            completeDateLayoutPanel.SuspendLayout();
            startDateLayoutPanel.SuspendLayout();
            postDateLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).BeginInit();
            menuLayoutPanel.SuspendLayout();
            dbLayoutPanel.SuspendLayout();
            redirectLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestsTable).BeginInit();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(requestsTable, 0, 2);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 4);
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
            formLayoutPanel.Dock = DockStyle.Fill;
            formLayoutPanel.Location = new Point(0, 0);
            formLayoutPanel.Margin = new Padding(0);
            formLayoutPanel.Name = "formLayoutPanel";
            formLayoutPanel.Padding = new Padding(20, 10, 20, 10);
            formLayoutPanel.RowCount = 5;
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.Size = new Size(960, 540);
            formLayoutPanel.TabIndex = 3;
            // 
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            controlsLayoutPanel.ColumnCount = 3;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            controlsLayoutPanel.Controls.Add(inputsLayoutPanel, 0, 0);
            controlsLayoutPanel.Controls.Add(buttonsLayoutPanel, 2, 0);
            controlsLayoutPanel.Location = new Point(20, 348);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle());
            controlsLayoutPanel.Size = new Size(920, 190);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // inputsLayoutPanel
            // 
            inputsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputsLayoutPanel.AutoSize = true;
            inputsLayoutPanel.ColumnCount = 1;
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            inputsLayoutPanel.Controls.Add(pickersLayoutPanel, 0, 0);
            inputsLayoutPanel.Controls.Add(datesLayoutPanel, 0, 1);
            inputsLayoutPanel.Location = new Point(0, 3);
            inputsLayoutPanel.Margin = new Padding(0);
            inputsLayoutPanel.Name = "inputsLayoutPanel";
            inputsLayoutPanel.RowCount = 2;
            inputsLayoutPanel.RowStyles.Add(new RowStyle());
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            inputsLayoutPanel.Size = new Size(760, 184);
            inputsLayoutPanel.TabIndex = 1;
            // 
            // pickersLayoutPanel
            // 
            pickersLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pickersLayoutPanel.AutoSize = true;
            pickersLayoutPanel.ColumnCount = 5;
            pickersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            pickersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            pickersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            pickersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            pickersLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            pickersLayoutPanel.Controls.Add(carLayoutPanel, 4, 0);
            pickersLayoutPanel.Controls.Add(ownerLayoutPanel, 2, 0);
            pickersLayoutPanel.Controls.Add(employeeLayoutPanel, 0, 0);
            pickersLayoutPanel.Location = new Point(0, 0);
            pickersLayoutPanel.Margin = new Padding(0);
            pickersLayoutPanel.Name = "pickersLayoutPanel";
            pickersLayoutPanel.RowCount = 1;
            pickersLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pickersLayoutPanel.Size = new Size(760, 62);
            pickersLayoutPanel.TabIndex = 0;
            // 
            // carLayoutPanel
            // 
            carLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            carLayoutPanel.AutoSize = true;
            carLayoutPanel.Controls.Add(carLabel);
            carLayoutPanel.Controls.Add(carsPicker);
            carLayoutPanel.FlowDirection = FlowDirection.TopDown;
            carLayoutPanel.Location = new Point(512, 0);
            carLayoutPanel.Margin = new Padding(0);
            carLayoutPanel.Name = "carLayoutPanel";
            carLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            carLayoutPanel.Size = new Size(248, 62);
            carLayoutPanel.TabIndex = 5;
            // 
            // carLabel
            // 
            carLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            carLabel.Location = new Point(0, 5);
            carLabel.Margin = new Padding(0);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(245, 25);
            carLabel.TabIndex = 0;
            carLabel.Text = "Автомобиль";
            // 
            // carsPicker
            // 
            carsPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            carsPicker.BackColor = Color.White;
            carsPicker.DataSource = carBindingSource;
            carsPicker.DisplayMember = "LicensePlate";
            carsPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            carsPicker.FlatStyle = FlatStyle.System;
            carsPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            carsPicker.FormattingEnabled = true;
            carsPicker.Location = new Point(0, 30);
            carsPicker.Margin = new Padding(0);
            carsPicker.Name = "carsPicker";
            carsPicker.Size = new Size(245, 27);
            carsPicker.TabIndex = 1;
            carsPicker.ValueMember = "Id";
            // 
            // carBindingSource
            // 
            carBindingSource.DataSource = typeof(Car);
            // 
            // ownerLayoutPanel
            // 
            ownerLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ownerLayoutPanel.AutoSize = true;
            ownerLayoutPanel.Controls.Add(ownerLabel);
            ownerLayoutPanel.Controls.Add(ownersPicker);
            ownerLayoutPanel.FlowDirection = FlowDirection.TopDown;
            ownerLayoutPanel.Location = new Point(256, 0);
            ownerLayoutPanel.Margin = new Padding(0);
            ownerLayoutPanel.Name = "ownerLayoutPanel";
            ownerLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            ownerLayoutPanel.Size = new Size(246, 62);
            ownerLayoutPanel.TabIndex = 4;
            // 
            // ownerLabel
            // 
            ownerLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ownerLabel.Location = new Point(0, 5);
            ownerLabel.Margin = new Padding(0);
            ownerLabel.Name = "ownerLabel";
            ownerLabel.Size = new Size(245, 25);
            ownerLabel.TabIndex = 0;
            ownerLabel.Text = "Владелец";
            // 
            // ownersPicker
            // 
            ownersPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ownersPicker.BackColor = Color.White;
            ownersPicker.DataSource = ownerBindingSource;
            ownersPicker.DisplayMember = "OwnerPassportNumber";
            ownersPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            ownersPicker.FlatStyle = FlatStyle.System;
            ownersPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ownersPicker.FormattingEnabled = true;
            ownersPicker.Location = new Point(0, 30);
            ownersPicker.Margin = new Padding(0);
            ownersPicker.Name = "ownersPicker";
            ownersPicker.Size = new Size(245, 27);
            ownersPicker.TabIndex = 1;
            ownersPicker.ValueMember = "Id";
            // 
            // ownerBindingSource
            // 
            ownerBindingSource.DataSource = typeof(Owner);
            // 
            // employeeLayoutPanel
            // 
            employeeLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employeeLayoutPanel.AutoSize = true;
            employeeLayoutPanel.Controls.Add(employeeLabel);
            employeeLayoutPanel.Controls.Add(employeesPicker);
            employeeLayoutPanel.FlowDirection = FlowDirection.TopDown;
            employeeLayoutPanel.Location = new Point(0, 0);
            employeeLayoutPanel.Margin = new Padding(0);
            employeeLayoutPanel.Name = "employeeLayoutPanel";
            employeeLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            employeeLayoutPanel.Size = new Size(246, 62);
            employeeLayoutPanel.TabIndex = 3;
            // 
            // employeeLabel
            // 
            employeeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeeLabel.Location = new Point(0, 5);
            employeeLabel.Margin = new Padding(0);
            employeeLabel.Name = "employeeLabel";
            employeeLabel.Size = new Size(245, 25);
            employeeLabel.TabIndex = 0;
            employeeLabel.Text = "Заявку принял";
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
            employeesPicker.Location = new Point(0, 30);
            employeesPicker.Margin = new Padding(0);
            employeesPicker.Name = "employeesPicker";
            employeesPicker.Size = new Size(245, 27);
            employeesPicker.TabIndex = 1;
            employeesPicker.ValueMember = "EmployeeId";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Employee);
            // 
            // datesLayoutPanel
            // 
            datesLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            datesLayoutPanel.ColumnCount = 3;
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            datesLayoutPanel.Controls.Add(completeDateLayoutPanel, 2, 1);
            datesLayoutPanel.Controls.Add(startDateLayoutPanel, 0, 1);
            datesLayoutPanel.Controls.Add(postDateLayoutPanel, 0, 0);
            datesLayoutPanel.Controls.Add(completedCheckBox, 2, 0);
            datesLayoutPanel.Location = new Point(0, 62);
            datesLayoutPanel.Margin = new Padding(0);
            datesLayoutPanel.Name = "datesLayoutPanel";
            datesLayoutPanel.RowCount = 2;
            datesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            datesLayoutPanel.RowStyles.Add(new RowStyle());
            datesLayoutPanel.Size = new Size(760, 122);
            datesLayoutPanel.TabIndex = 1;
            // 
            // completeDateLayoutPanel
            // 
            completeDateLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            completeDateLayoutPanel.AutoSize = true;
            completeDateLayoutPanel.Controls.Add(completeDateLabel);
            completeDateLayoutPanel.Controls.Add(completeDatePicker);
            completeDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            completeDateLayoutPanel.Location = new Point(385, 61);
            completeDateLayoutPanel.Margin = new Padding(0);
            completeDateLayoutPanel.Name = "completeDateLayoutPanel";
            completeDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            completeDateLayoutPanel.Size = new Size(375, 61);
            completeDateLayoutPanel.TabIndex = 8;
            // 
            // completeDateLabel
            // 
            completeDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            completeDateLabel.Location = new Point(0, 5);
            completeDateLabel.Margin = new Padding(0);
            completeDateLabel.Name = "completeDateLabel";
            completeDateLabel.Size = new Size(372, 25);
            completeDateLabel.TabIndex = 0;
            completeDateLabel.Text = "Дата завершения работы";
            // 
            // completeDatePicker
            // 
            completeDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            completeDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            completeDatePicker.Location = new Point(0, 30);
            completeDatePicker.Margin = new Padding(0);
            completeDatePicker.Name = "completeDatePicker";
            completeDatePicker.Size = new Size(372, 26);
            completeDatePicker.TabIndex = 1;
            // 
            // startDateLayoutPanel
            // 
            startDateLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            startDateLayoutPanel.AutoSize = true;
            startDateLayoutPanel.Controls.Add(startDateLabel);
            startDateLayoutPanel.Controls.Add(startDatePicker);
            startDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            startDateLayoutPanel.Location = new Point(0, 61);
            startDateLayoutPanel.Margin = new Padding(0);
            startDateLayoutPanel.Name = "startDateLayoutPanel";
            startDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            startDateLayoutPanel.Size = new Size(375, 61);
            startDateLayoutPanel.TabIndex = 7;
            // 
            // startDateLabel
            // 
            startDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            startDateLabel.Location = new Point(0, 5);
            startDateLabel.Margin = new Padding(0);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(372, 25);
            startDateLabel.TabIndex = 0;
            startDateLabel.Text = "Дата начала работы";
            // 
            // startDatePicker
            // 
            startDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            startDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            startDatePicker.Location = new Point(0, 30);
            startDatePicker.Margin = new Padding(0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(372, 26);
            startDatePicker.TabIndex = 1;
            // 
            // postDateLayoutPanel
            // 
            postDateLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            postDateLayoutPanel.AutoSize = true;
            postDateLayoutPanel.Controls.Add(postDateLabel);
            postDateLayoutPanel.Controls.Add(postDatePicker);
            postDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            postDateLayoutPanel.Location = new Point(0, 0);
            postDateLayoutPanel.Margin = new Padding(0);
            postDateLayoutPanel.Name = "postDateLayoutPanel";
            postDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            postDateLayoutPanel.Size = new Size(375, 61);
            postDateLayoutPanel.TabIndex = 5;
            // 
            // postDateLabel
            // 
            postDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            postDateLabel.Location = new Point(0, 5);
            postDateLabel.Margin = new Padding(0);
            postDateLabel.Name = "postDateLabel";
            postDateLabel.Size = new Size(372, 25);
            postDateLabel.TabIndex = 0;
            postDateLabel.Text = "Дата поступления";
            // 
            // postDatePicker
            // 
            postDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            postDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            postDatePicker.Location = new Point(0, 30);
            postDatePicker.Margin = new Padding(0);
            postDatePicker.Name = "postDatePicker";
            postDatePicker.Size = new Size(372, 26);
            postDatePicker.TabIndex = 1;
            // 
            // completedCheckBox
            // 
            completedCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            completedCheckBox.AutoSize = true;
            completedCheckBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            completedCheckBox.ImageAlign = ContentAlignment.MiddleRight;
            completedCheckBox.Location = new Point(385, 28);
            completedCheckBox.Margin = new Padding(0);
            completedCheckBox.Name = "completedCheckBox";
            completedCheckBox.Padding = new Padding(0, 5, 0, 5);
            completedCheckBox.Size = new Size(375, 33);
            completedCheckBox.TabIndex = 9;
            completedCheckBox.Text = "Завершено";
            completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.AutoSize = true;
            buttonsLayoutPanel.Controls.Add(acceptButton);
            buttonsLayoutPanel.Controls.Add(resetButton);
            buttonsLayoutPanel.Controls.Add(toOrdersButton);
            buttonsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            buttonsLayoutPanel.Location = new Point(770, 10);
            buttonsLayoutPanel.Margin = new Padding(0);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.Size = new Size(150, 170);
            buttonsLayoutPanel.TabIndex = 2;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = SystemColors.Highlight;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            acceptButton.ForeColor = SystemColors.ButtonFace;
            acceptButton.Location = new Point(0, 0);
            acceptButton.Margin = new Padding(0);
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
            resetButton.Margin = new Padding(0, 10, 0, 10);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(150, 50);
            resetButton.TabIndex = 7;
            resetButton.Text = "Отменить";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // toOrdersButton
            // 
            toOrdersButton.BackColor = SystemColors.MenuHighlight;
            toOrdersButton.FlatStyle = FlatStyle.Flat;
            toOrdersButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            toOrdersButton.ForeColor = SystemColors.ButtonFace;
            toOrdersButton.Location = new Point(0, 120);
            toOrdersButton.Margin = new Padding(0);
            toOrdersButton.Name = "toOrdersButton";
            toOrdersButton.Size = new Size(150, 50);
            toOrdersButton.TabIndex = 6;
            toOrdersButton.Text = "К заказ-наряду";
            toOrdersButton.UseVisualStyleBackColor = false;
            toOrdersButton.Click += toOrdersButton_Click;
            // 
            // requestBindingSource
            // 
            requestBindingSource.DataSource = typeof(Request);
            // 
            // menuLayoutPanel
            // 
            menuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            menuLayoutPanel.AutoSize = true;
            menuLayoutPanel.ColumnCount = 3;
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            menuLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            menuLayoutPanel.Controls.Add(dbLayoutPanel, 2, 0);
            menuLayoutPanel.Controls.Add(redirectLayoutPanel, 0, 0);
            menuLayoutPanel.Location = new Point(23, 13);
            menuLayoutPanel.Name = "menuLayoutPanel";
            menuLayoutPanel.RowCount = 1;
            menuLayoutPanel.RowStyles.Add(new RowStyle());
            menuLayoutPanel.Size = new Size(914, 50);
            menuLayoutPanel.TabIndex = 3;
            // 
            // dbLayoutPanel
            // 
            dbLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dbLayoutPanel.AutoSize = true;
            dbLayoutPanel.Controls.Add(addButton);
            dbLayoutPanel.Controls.Add(editButton);
            dbLayoutPanel.Controls.Add(deleteButton);
            dbLayoutPanel.Location = new Point(120, 0);
            dbLayoutPanel.Margin = new Padding(0);
            dbLayoutPanel.Name = "dbLayoutPanel";
            dbLayoutPanel.Size = new Size(794, 50);
            dbLayoutPanel.TabIndex = 3;
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = SystemColors.Highlight;
            addButton.Dock = DockStyle.Left;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(0, 0);
            addButton.Margin = new Padding(0);
            addButton.Name = "addButton";
            addButton.Size = new Size(251, 50);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.BackColor = SystemColors.Highlight;
            editButton.Dock = DockStyle.Left;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            editButton.ForeColor = SystemColors.ButtonFace;
            editButton.Location = new Point(271, 0);
            editButton.Margin = new Padding(20, 0, 20, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(251, 50);
            editButton.TabIndex = 2;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += openButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = SystemColors.Highlight;
            deleteButton.Dock = DockStyle.Left;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deleteButton.ForeColor = SystemColors.ButtonFace;
            deleteButton.Location = new Point(542, 0);
            deleteButton.Margin = new Padding(0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(251, 50);
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
            // requestsTable
            // 
            requestsTable.AllowUserToAddRows = false;
            requestsTable.AllowUserToDeleteRows = false;
            requestsTable.AllowUserToResizeColumns = false;
            requestsTable.AllowUserToResizeRows = false;
            requestsTable.AutoGenerateColumns = false;
            requestsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            requestsTable.BackgroundColor = Color.White;
            requestsTable.BorderStyle = BorderStyle.None;
            requestsTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            requestsTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            requestsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            requestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsTable.Columns.AddRange(new DataGridViewColumn[] { requestIdDataGridViewTextBoxColumn, ownerIdDataGridViewTextBoxColumn, carIdDataGridViewTextBoxColumn, employeeIdDataGridViewTextBoxColumn, requestDateDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, completedDataGridViewCheckBoxColumn, completeDateDataGridViewTextBoxColumn });
            requestsTable.Cursor = Cursors.Hand;
            requestsTable.DataSource = requestBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            requestsTable.DefaultCellStyle = dataGridViewCellStyle3;
            requestsTable.Dock = DockStyle.Fill;
            requestsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            requestsTable.EnableHeadersVisualStyles = false;
            requestsTable.GridColor = SystemColors.ControlDark;
            requestsTable.Location = new Point(20, 86);
            requestsTable.Margin = new Padding(0);
            requestsTable.MultiSelect = false;
            requestsTable.Name = "requestsTable";
            requestsTable.ReadOnly = true;
            requestsTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            requestsTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            requestsTable.RowHeadersVisible = false;
            requestsTable.RowHeadersWidth = 23;
            requestsTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            requestsTable.RowTemplate.Height = 32;
            requestsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            requestsTable.Size = new Size(920, 242);
            requestsTable.TabIndex = 5;
            // 
            // requestIdDataGridViewTextBoxColumn
            // 
            requestIdDataGridViewTextBoxColumn.DataPropertyName = "RequestId";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            requestIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            requestIdDataGridViewTextBoxColumn.HeaderText = "ИД";
            requestIdDataGridViewTextBoxColumn.Name = "requestIdDataGridViewTextBoxColumn";
            requestIdDataGridViewTextBoxColumn.ReadOnly = true;
            requestIdDataGridViewTextBoxColumn.ToolTipText = "Идентификатор заявки";
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            ownerIdDataGridViewTextBoxColumn.HeaderText = "Владелец";
            ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            ownerIdDataGridViewTextBoxColumn.ReadOnly = true;
            ownerIdDataGridViewTextBoxColumn.ToolTipText = "Владелец автомобиля";
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            carIdDataGridViewTextBoxColumn.HeaderText = "Автомобиль";
            carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            carIdDataGridViewTextBoxColumn.ReadOnly = true;
            carIdDataGridViewTextBoxColumn.ToolTipText = "Ремонтируемый автомобиль";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "Менеджер";
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            employeeIdDataGridViewTextBoxColumn.ReadOnly = true;
            employeeIdDataGridViewTextBoxColumn.ToolTipText = "Работник, принявший заявку";
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            requestDateDataGridViewTextBoxColumn.HeaderText = "Дата поступления";
            requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            requestDateDataGridViewTextBoxColumn.ReadOnly = true;
            requestDateDataGridViewTextBoxColumn.ToolTipText = "Дата обращения на сервис";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "Дата начала";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.ReadOnly = true;
            startDateDataGridViewTextBoxColumn.ToolTipText = "Дата начала ремонтных работ";
            // 
            // completedDataGridViewCheckBoxColumn
            // 
            completedDataGridViewCheckBoxColumn.DataPropertyName = "Completed";
            completedDataGridViewCheckBoxColumn.HeaderText = "Завершено";
            completedDataGridViewCheckBoxColumn.Name = "completedDataGridViewCheckBoxColumn";
            completedDataGridViewCheckBoxColumn.ReadOnly = true;
            completedDataGridViewCheckBoxColumn.ToolTipText = "Статус работы";
            // 
            // completeDateDataGridViewTextBoxColumn
            // 
            completeDateDataGridViewTextBoxColumn.DataPropertyName = "CompleteDate";
            completeDateDataGridViewTextBoxColumn.HeaderText = "Дата завершения";
            completeDateDataGridViewTextBoxColumn.Name = "completeDateDataGridViewTextBoxColumn";
            completeDateDataGridViewTextBoxColumn.ReadOnly = true;
            completeDateDataGridViewTextBoxColumn.ToolTipText = "Дата завершения ремонтных работ";
            // 
            // RequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RequestsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационная система: заявки на ремонт";
            FormClosed += RequestsForm_FormClosed;
            Load += RequestsForm_Load;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            controlsLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.PerformLayout();
            inputsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.PerformLayout();
            pickersLayoutPanel.ResumeLayout(false);
            pickersLayoutPanel.PerformLayout();
            carLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)carBindingSource).EndInit();
            ownerLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ownerBindingSource).EndInit();
            employeeLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            datesLayoutPanel.ResumeLayout(false);
            datesLayoutPanel.PerformLayout();
            completeDateLayoutPanel.ResumeLayout(false);
            startDateLayoutPanel.ResumeLayout(false);
            postDateLayoutPanel.ResumeLayout(false);
            buttonsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).EndInit();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            dbLayoutPanel.ResumeLayout(false);
            dbLayoutPanel.PerformLayout();
            redirectLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestsTable).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formLayoutPanel;
        private TableLayoutPanel controlsLayoutPanel;
        private TableLayoutPanel inputsLayoutPanel;
        private TableLayoutPanel pickersLayoutPanel;
        private FlowLayoutPanel carLayoutPanel;
        private Label carLabel;
        private ComboBox carsPicker;
        private FlowLayoutPanel ownerLayoutPanel;
        private Label ownerLabel;
        private ComboBox ownersPicker;
        private FlowLayoutPanel employeeLayoutPanel;
        private Label employeeLabel;
        private ComboBox employeesPicker;
        private TableLayoutPanel datesLayoutPanel;
        private FlowLayoutPanel completeDateLayoutPanel;
        private Label completeDateLabel;
        private DateTimePicker completeDatePicker;
        private FlowLayoutPanel startDateLayoutPanel;
        private Label startDateLabel;
        private DateTimePicker startDatePicker;
        private FlowLayoutPanel postDateLayoutPanel;
        private Label postDateLabel;
        private DateTimePicker postDatePicker;
        private FlowLayoutPanel buttonsLayoutPanel;
        private Button acceptButton;
        private Button resetButton;
        private Button toOrdersButton;
        private CheckBox completedCheckBox;
        private BindingSource requestBindingSource;
        private BindingSource ownerBindingSource;
        private BindingSource employeeBindingSource;
        private BindingSource carBindingSource;
        private TableLayoutPanel menuLayoutPanel;
        private FlowLayoutPanel dbLayoutPanel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private FlowLayoutPanel redirectLayoutPanel;
        private Button homeButton;
        private Button returnButton;
        private DataGridView requestsTable;
        private DataGridViewTextBoxColumn requestIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn completedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn completeDateDataGridViewTextBoxColumn;
    }
}
