
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
            formLayoutPanel = new TableLayoutPanel();
            menuLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
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
            employeePicker = new ComboBox();
            employeeBindingSource = new BindingSource(components);
            datesLayoutPanel = new TableLayoutPanel();
            endDateLayoutPanel = new FlowLayoutPanel();
            endDateLabel = new Label();
            endDatePicker = new DateTimePicker();
            startDateLayoutPanel = new FlowLayoutPanel();
            startDateLabel = new Label();
            startDatePicker = new DateTimePicker();
            postDateLayoutPanel = new FlowLayoutPanel();
            postDateLabel = new Label();
            postDatePicker = new DateTimePicker();
            endedCheckBox = new CheckBox();
            buttonsLayoutPanel = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            toOrdersButton = new Button();
            requestsTable = new DataGridView();
            ownerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            carIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            completedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            completeDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            requestBindingSource = new BindingSource(components);
            formLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
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
            endDateLayoutPanel.SuspendLayout();
            startDateLayoutPanel.SuspendLayout();
            postDateLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)requestsTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).BeginInit();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 4);
            formLayoutPanel.Controls.Add(requestsTable, 0, 2);
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
            // menuLayoutPanel
            // 
            menuLayoutPanel.AutoSize = true;
            menuLayoutPanel.Controls.Add(homeButton);
            menuLayoutPanel.Controls.Add(returnButton);
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
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.BackColor = SystemColors.MenuHighlight;
            addButton.Dock = DockStyle.Left;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            addButton.ForeColor = SystemColors.ButtonFace;
            addButton.Location = new Point(120, 0);
            addButton.Margin = new Padding(10, 0, 10, 0);
            addButton.Name = "addButton";
            addButton.Size = new Size(253, 50);
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
            editButton.Location = new Point(393, 0);
            editButton.Margin = new Padding(10, 0, 10, 0);
            editButton.Name = "editButton";
            editButton.Size = new Size(253, 50);
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
            deleteButton.Location = new Point(666, 0);
            deleteButton.Margin = new Padding(10, 0, 0, 0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(253, 50);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
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
            controlsLayoutPanel.Location = new Point(20, 340);
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
            employeeLayoutPanel.Controls.Add(employeePicker);
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
            // employeePicker
            // 
            employeePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employeePicker.BackColor = Color.White;
            employeePicker.DataSource = employeeBindingSource;
            employeePicker.DisplayMember = "EmployeePassportNumber";
            employeePicker.DropDownStyle = ComboBoxStyle.DropDownList;
            employeePicker.FlatStyle = FlatStyle.System;
            employeePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeePicker.FormattingEnabled = true;
            employeePicker.Location = new Point(0, 30);
            employeePicker.Margin = new Padding(0);
            employeePicker.Name = "employeePicker";
            employeePicker.Size = new Size(245, 27);
            employeePicker.TabIndex = 1;
            employeePicker.ValueMember = "EmployeeId";
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
            datesLayoutPanel.Controls.Add(endDateLayoutPanel, 2, 1);
            datesLayoutPanel.Controls.Add(startDateLayoutPanel, 0, 1);
            datesLayoutPanel.Controls.Add(postDateLayoutPanel, 0, 0);
            datesLayoutPanel.Controls.Add(endedCheckBox, 2, 0);
            datesLayoutPanel.Location = new Point(0, 62);
            datesLayoutPanel.Margin = new Padding(0);
            datesLayoutPanel.Name = "datesLayoutPanel";
            datesLayoutPanel.RowCount = 2;
            datesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            datesLayoutPanel.RowStyles.Add(new RowStyle());
            datesLayoutPanel.Size = new Size(760, 122);
            datesLayoutPanel.TabIndex = 1;
            // 
            // endDateLayoutPanel
            // 
            endDateLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            endDateLayoutPanel.AutoSize = true;
            endDateLayoutPanel.Controls.Add(endDateLabel);
            endDateLayoutPanel.Controls.Add(endDatePicker);
            endDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            endDateLayoutPanel.Location = new Point(385, 61);
            endDateLayoutPanel.Margin = new Padding(0);
            endDateLayoutPanel.Name = "endDateLayoutPanel";
            endDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            endDateLayoutPanel.Size = new Size(375, 61);
            endDateLayoutPanel.TabIndex = 8;
            // 
            // endDateLabel
            // 
            endDateLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            endDateLabel.Location = new Point(0, 5);
            endDateLabel.Margin = new Padding(0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(372, 25);
            endDateLabel.TabIndex = 0;
            endDateLabel.Text = "Дата завершения работы";
            // 
            // endDatePicker
            // 
            endDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            endDatePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            endDatePicker.Location = new Point(0, 30);
            endDatePicker.Margin = new Padding(0);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(372, 26);
            endDatePicker.TabIndex = 1;
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
            // endedCheckBox
            // 
            endedCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            endedCheckBox.AutoSize = true;
            endedCheckBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            endedCheckBox.ImageAlign = ContentAlignment.MiddleRight;
            endedCheckBox.Location = new Point(385, 28);
            endedCheckBox.Margin = new Padding(0);
            endedCheckBox.Name = "endedCheckBox";
            endedCheckBox.Padding = new Padding(0, 5, 0, 5);
            endedCheckBox.Size = new Size(375, 33);
            endedCheckBox.TabIndex = 9;
            endedCheckBox.Text = "Завершено";
            endedCheckBox.UseVisualStyleBackColor = true;
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
            acceptButton.BackColor = SystemColors.MenuHighlight;
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
            resetButton.Text = "Сбросить";
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
            toOrdersButton.Text = "Заказ-наряд";
            toOrdersButton.UseVisualStyleBackColor = false;
            toOrdersButton.Click += toOrdersButton_Click;
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
            requestsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            requestsTable.Columns.AddRange(new DataGridViewColumn[] { ownerIdDataGridViewTextBoxColumn, carIdDataGridViewTextBoxColumn, employeeIdDataGridViewTextBoxColumn, requestDateDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, completedDataGridViewCheckBoxColumn, completeDateDataGridViewTextBoxColumn });
            requestsTable.Cursor = Cursors.Hand;
            requestsTable.DataSource = requestBindingSource;
            requestsTable.Dock = DockStyle.Top;
            requestsTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            requestsTable.GridColor = SystemColors.ControlDark;
            requestsTable.Location = new Point(20, 80);
            requestsTable.Margin = new Padding(0);
            requestsTable.Name = "requestsTable";
            requestsTable.Size = new Size(920, 240);
            requestsTable.TabIndex = 2;
            // 
            // ownerIdDataGridViewTextBoxColumn
            // 
            ownerIdDataGridViewTextBoxColumn.DataPropertyName = "OwnerId";
            ownerIdDataGridViewTextBoxColumn.HeaderText = "OwnerId";
            ownerIdDataGridViewTextBoxColumn.Name = "ownerIdDataGridViewTextBoxColumn";
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            // 
            // employeeIdDataGridViewTextBoxColumn
            // 
            employeeIdDataGridViewTextBoxColumn.DataPropertyName = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.HeaderText = "EmployeeId";
            employeeIdDataGridViewTextBoxColumn.Name = "employeeIdDataGridViewTextBoxColumn";
            // 
            // requestDateDataGridViewTextBoxColumn
            // 
            requestDateDataGridViewTextBoxColumn.DataPropertyName = "RequestDate";
            requestDateDataGridViewTextBoxColumn.HeaderText = "RequestDate";
            requestDateDataGridViewTextBoxColumn.Name = "requestDateDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // completedDataGridViewCheckBoxColumn
            // 
            completedDataGridViewCheckBoxColumn.DataPropertyName = "Completed";
            completedDataGridViewCheckBoxColumn.HeaderText = "Completed";
            completedDataGridViewCheckBoxColumn.Name = "completedDataGridViewCheckBoxColumn";
            // 
            // completeDateDataGridViewTextBoxColumn
            // 
            completeDateDataGridViewTextBoxColumn.DataPropertyName = "CompleteDate";
            completeDateDataGridViewTextBoxColumn.HeaderText = "CompleteDate";
            completeDateDataGridViewTextBoxColumn.Name = "completeDateDataGridViewTextBoxColumn";
            // 
            // requestBindingSource
            // 
            requestBindingSource.DataSource = typeof(Request);
            // 
            // RequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
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
            endDateLayoutPanel.ResumeLayout(false);
            startDateLayoutPanel.ResumeLayout(false);
            postDateLayoutPanel.ResumeLayout(false);
            buttonsLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)requestsTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)requestBindingSource).EndInit();
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
        private ComboBox employeePicker;
        private TableLayoutPanel datesLayoutPanel;
        private FlowLayoutPanel endDateLayoutPanel;
        private Label endDateLabel;
        private DateTimePicker endDatePicker;
        private FlowLayoutPanel startDateLayoutPanel;
        private Label startDateLabel;
        private DateTimePicker startDatePicker;
        private FlowLayoutPanel postDateLayoutPanel;
        private Label postDateLabel;
        private DateTimePicker postDatePicker;
        private DataGridView requestsTable;
        private FlowLayoutPanel buttonsLayoutPanel;
        private Button acceptButton;
        private Button resetButton;
        private Button toOrdersButton;
        private CheckBox endedCheckBox;
        private BindingSource requestBindingSource;
        private DataGridViewTextBoxColumn ownerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn requestDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn completedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn completeDateDataGridViewTextBoxColumn;
        private BindingSource ownerBindingSource;
        private BindingSource employeeBindingSource;
        private BindingSource carBindingSource;
    }
}
