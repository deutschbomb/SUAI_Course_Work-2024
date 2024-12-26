
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            formLayoutPanel = new TableLayoutPanel();
            suppliesTable = new DataGridView();
            supplyBindingSource = new BindingSource(components);
            controlsLayoutPanel = new TableLayoutPanel();
            inputsLayoutPanel = new TableLayoutPanel();
            partsLayoutPanel = new TableLayoutPanel();
            amountLayoutPane = new FlowLayoutPanel();
            amountLabel = new Label();
            amountInput = new NumericUpDown();
            partLayoutPanel = new FlowLayoutPanel();
            partsLabel = new Label();
            partsPicker = new ComboBox();
            personsLayoutPanel = new TableLayoutPanel();
            supplierLayoutPanel = new FlowLayoutPanel();
            suppliersLabel = new Label();
            suppliersPicker = new ComboBox();
            supplierBindingSource = new BindingSource(components);
            employeeLayoutPanel = new FlowLayoutPanel();
            employeeLabel = new Label();
            employeesPicker = new ComboBox();
            employeeBindingSource = new BindingSource(components);
            datesLayoutPanel = new TableLayoutPanel();
            deliveryDateLayoutPanel = new FlowLayoutPanel();
            deliveryDateLabel = new Label();
            deliveryDatePicker = new DateTimePicker();
            postDateLayoutPanel = new FlowLayoutPanel();
            postDateLabel = new Label();
            postDatePicker = new DateTimePicker();
            deliveryStateCheckBox = new CheckBox();
            buttonsLayoutPanel = new FlowLayoutPanel();
            editButton = new Button();
            acceptButton = new Button();
            resetButton = new Button();
            menuLayoutPanel = new TableLayoutPanel();
            dbLayoutPanel = new FlowLayoutPanel();
            addButton = new Button();
            openButton = new Button();
            deleteButton = new Button();
            redirectLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            positionBindingSource = new BindingSource(components);
            partBindingSource = new BindingSource(components);
            supplyIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            supplierDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfPostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deliveredDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            dateOfDeliveryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            formLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliesTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplyBindingSource).BeginInit();
            controlsLayoutPanel.SuspendLayout();
            inputsLayoutPanel.SuspendLayout();
            partsLayoutPanel.SuspendLayout();
            amountLayoutPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amountInput).BeginInit();
            partLayoutPanel.SuspendLayout();
            personsLayoutPanel.SuspendLayout();
            supplierLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            employeeLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            datesLayoutPanel.SuspendLayout();
            deliveryDateLayoutPanel.SuspendLayout();
            postDateLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            dbLayoutPanel.SuspendLayout();
            redirectLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)positionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).BeginInit();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(suppliesTable, 0, 2);
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
            formLayoutPanel.TabIndex = 2;
            // 
            // suppliesTable
            // 
            suppliesTable.AllowUserToAddRows = false;
            suppliesTable.AllowUserToDeleteRows = false;
            suppliesTable.AllowUserToResizeColumns = false;
            suppliesTable.AllowUserToResizeRows = false;
            suppliesTable.AutoGenerateColumns = false;
            suppliesTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            suppliesTable.BackgroundColor = Color.White;
            suppliesTable.BorderStyle = BorderStyle.None;
            suppliesTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            suppliesTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Padding = new Padding(12, 7, 12, 6);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            suppliesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            suppliesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliesTable.Columns.AddRange(new DataGridViewColumn[] { supplyIdDataGridViewTextBoxColumn, employeeDataGridViewTextBoxColumn, supplierDataGridViewTextBoxColumn, dateOfPostDataGridViewTextBoxColumn, deliveredDataGridViewCheckBoxColumn, dateOfDeliveryDataGridViewTextBoxColumn });
            suppliesTable.Cursor = Cursors.Hand;
            suppliesTable.DataSource = supplyBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Padding = new Padding(12, 0, 12, 0);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            suppliesTable.DefaultCellStyle = dataGridViewCellStyle8;
            suppliesTable.Dock = DockStyle.Fill;
            suppliesTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            suppliesTable.EnableHeadersVisualStyles = false;
            suppliesTable.GridColor = SystemColors.ControlDark;
            suppliesTable.Location = new Point(20, 80);
            suppliesTable.Margin = new Padding(0);
            suppliesTable.MultiSelect = false;
            suppliesTable.Name = "suppliesTable";
            suppliesTable.ReadOnly = true;
            suppliesTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            suppliesTable.RowHeadersVisible = false;
            suppliesTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            suppliesTable.RowTemplate.Height = 32;
            suppliesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            suppliesTable.Size = new Size(920, 225);
            suppliesTable.TabIndex = 2;
            // 
            // supplyBindingSource
            // 
            supplyBindingSource.DataSource = typeof(Supply);
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
            controlsLayoutPanel.Location = new Point(20, 329);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.Size = new Size(920, 197);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // inputsLayoutPanel
            // 
            inputsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputsLayoutPanel.ColumnCount = 1;
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inputsLayoutPanel.Controls.Add(partsLayoutPanel, 0, 1);
            inputsLayoutPanel.Controls.Add(personsLayoutPanel, 0, 0);
            inputsLayoutPanel.Controls.Add(datesLayoutPanel, 0, 2);
            inputsLayoutPanel.Location = new Point(0, 3);
            inputsLayoutPanel.Margin = new Padding(0);
            inputsLayoutPanel.Name = "inputsLayoutPanel";
            inputsLayoutPanel.RowCount = 3;
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            inputsLayoutPanel.Size = new Size(760, 190);
            inputsLayoutPanel.TabIndex = 2;
            // 
            // partsLayoutPanel
            // 
            partsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            partsLayoutPanel.ColumnCount = 3;
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            partsLayoutPanel.Controls.Add(amountLayoutPane, 2, 0);
            partsLayoutPanel.Controls.Add(partLayoutPanel, 0, 0);
            partsLayoutPanel.Location = new Point(0, 63);
            partsLayoutPanel.Margin = new Padding(0);
            partsLayoutPanel.Name = "partsLayoutPanel";
            partsLayoutPanel.RowCount = 1;
            partsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            partsLayoutPanel.Size = new Size(760, 63);
            partsLayoutPanel.TabIndex = 1;
            // 
            // amountLayoutPane
            // 
            amountLayoutPane.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            amountLayoutPane.AutoSize = true;
            amountLayoutPane.Controls.Add(amountLabel);
            amountLayoutPane.Controls.Add(amountInput);
            amountLayoutPane.FlowDirection = FlowDirection.TopDown;
            amountLayoutPane.Location = new Point(630, 1);
            amountLayoutPane.Margin = new Padding(0);
            amountLayoutPane.Name = "amountLayoutPane";
            amountLayoutPane.Padding = new Padding(0, 5, 0, 5);
            amountLayoutPane.Size = new Size(130, 61);
            amountLayoutPane.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            amountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            amountLabel.Location = new Point(0, 5);
            amountLabel.Margin = new Padding(0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(130, 25);
            amountLabel.TabIndex = 0;
            amountLabel.Text = "Количество, шт. *";
            // 
            // amountInput
            // 
            amountInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            amountInput.BorderStyle = BorderStyle.FixedSingle;
            amountInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            amountInput.Location = new Point(0, 30);
            amountInput.Margin = new Padding(0);
            amountInput.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            amountInput.Name = "amountInput";
            amountInput.Size = new Size(130, 26);
            amountInput.TabIndex = 1;
            amountInput.TextAlign = HorizontalAlignment.Center;
            amountInput.ThousandsSeparator = true;
            // 
            // partLayoutPanel
            // 
            partLayoutPanel.AutoSize = true;
            partLayoutPanel.Controls.Add(partsLabel);
            partLayoutPanel.Controls.Add(partsPicker);
            partLayoutPanel.Dock = DockStyle.Top;
            partLayoutPanel.FlowDirection = FlowDirection.TopDown;
            partLayoutPanel.Location = new Point(0, 0);
            partLayoutPanel.Margin = new Padding(0);
            partLayoutPanel.Name = "partLayoutPanel";
            partLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            partLayoutPanel.Size = new Size(620, 62);
            partLayoutPanel.TabIndex = 2;
            // 
            // partsLabel
            // 
            partsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            partsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            partsLabel.Location = new Point(0, 5);
            partsLabel.Margin = new Padding(0);
            partsLabel.Name = "partsLabel";
            partsLabel.Size = new Size(620, 25);
            partsLabel.TabIndex = 0;
            partsLabel.Text = "Запчасти *";
            // 
            // partsPicker
            // 
            partsPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            partsPicker.BackColor = Color.White;
            partsPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            partsPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            partsPicker.FormattingEnabled = true;
            partsPicker.Location = new Point(0, 30);
            partsPicker.Margin = new Padding(0);
            partsPicker.Name = "partsPicker";
            partsPicker.Size = new Size(620, 27);
            partsPicker.TabIndex = 1;
            // 
            // personsLayoutPanel
            // 
            personsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            personsLayoutPanel.ColumnCount = 3;
            personsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            personsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            personsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            personsLayoutPanel.Controls.Add(supplierLayoutPanel, 2, 0);
            personsLayoutPanel.Controls.Add(employeeLayoutPanel, 0, 0);
            personsLayoutPanel.Location = new Point(0, 0);
            personsLayoutPanel.Margin = new Padding(0);
            personsLayoutPanel.Name = "personsLayoutPanel";
            personsLayoutPanel.RowCount = 1;
            personsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            personsLayoutPanel.Size = new Size(760, 63);
            personsLayoutPanel.TabIndex = 0;
            // 
            // supplierLayoutPanel
            // 
            supplierLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            supplierLayoutPanel.AutoSize = true;
            supplierLayoutPanel.Controls.Add(suppliersLabel);
            supplierLayoutPanel.Controls.Add(suppliersPicker);
            supplierLayoutPanel.FlowDirection = FlowDirection.TopDown;
            supplierLayoutPanel.Location = new Point(385, 0);
            supplierLayoutPanel.Margin = new Padding(0);
            supplierLayoutPanel.Name = "supplierLayoutPanel";
            supplierLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            supplierLayoutPanel.Size = new Size(375, 62);
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
            suppliersLabel.Text = "Поставщик *";
            // 
            // suppliersPicker
            // 
            suppliersPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            suppliersPicker.BackColor = Color.White;
            suppliersPicker.DataSource = supplierBindingSource;
            suppliersPicker.DisplayMember = "GetSupplier";
            suppliersPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            suppliersPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            suppliersPicker.FormattingEnabled = true;
            suppliersPicker.Location = new Point(0, 30);
            suppliersPicker.Margin = new Padding(0);
            suppliersPicker.Name = "suppliersPicker";
            suppliersPicker.Size = new Size(375, 27);
            suppliersPicker.TabIndex = 1;
            suppliersPicker.ValueMember = "SupplierId";
            suppliersPicker.SelectionChangeCommitted += suppliersPicker_SelectionChangeCommitted;
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Supplier);
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
            employeeLayoutPanel.Size = new Size(375, 62);
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
            employeeLabel.Text = "Ответственный *";
            // 
            // employeesPicker
            // 
            employeesPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employeesPicker.BackColor = Color.White;
            employeesPicker.DataSource = employeeBindingSource;
            employeesPicker.DisplayMember = "GetEmployee";
            employeesPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            employeesPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeesPicker.FormattingEnabled = true;
            employeesPicker.Location = new Point(0, 30);
            employeesPicker.Margin = new Padding(0);
            employeesPicker.Name = "employeesPicker";
            employeesPicker.Size = new Size(375, 27);
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
            datesLayoutPanel.ColumnCount = 5;
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            datesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            datesLayoutPanel.Controls.Add(deliveryDateLayoutPanel, 4, 0);
            datesLayoutPanel.Controls.Add(postDateLayoutPanel, 0, 0);
            datesLayoutPanel.Controls.Add(deliveryStateCheckBox, 2, 0);
            datesLayoutPanel.Location = new Point(0, 126);
            datesLayoutPanel.Margin = new Padding(0);
            datesLayoutPanel.Name = "datesLayoutPanel";
            datesLayoutPanel.RowCount = 1;
            datesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            datesLayoutPanel.Size = new Size(760, 64);
            datesLayoutPanel.TabIndex = 2;
            // 
            // deliveryDateLayoutPanel
            // 
            deliveryDateLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            deliveryDateLayoutPanel.AutoSize = true;
            deliveryDateLayoutPanel.Controls.Add(deliveryDateLabel);
            deliveryDateLayoutPanel.Controls.Add(deliveryDatePicker);
            deliveryDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            deliveryDateLayoutPanel.Location = new Point(440, 1);
            deliveryDateLayoutPanel.Margin = new Padding(0);
            deliveryDateLayoutPanel.Name = "deliveryDateLayoutPanel";
            deliveryDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            deliveryDateLayoutPanel.Size = new Size(320, 61);
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
            deliveryDateLabel.Text = "Дата прибытия *";
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
            postDateLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            postDateLayoutPanel.AutoSize = true;
            postDateLayoutPanel.Controls.Add(postDateLabel);
            postDateLayoutPanel.Controls.Add(postDatePicker);
            postDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            postDateLayoutPanel.Location = new Point(0, 1);
            postDateLayoutPanel.Margin = new Padding(0);
            postDateLayoutPanel.Name = "postDateLayoutPanel";
            postDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            postDateLayoutPanel.Size = new Size(320, 61);
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
            postDateLabel.Text = "Дата оформления *";
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
            // deliveryStateCheckBox
            // 
            deliveryStateCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deliveryStateCheckBox.AutoSize = true;
            deliveryStateCheckBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deliveryStateCheckBox.ImageAlign = ContentAlignment.MiddleRight;
            deliveryStateCheckBox.Location = new Point(330, 31);
            deliveryStateCheckBox.Margin = new Padding(0);
            deliveryStateCheckBox.Name = "deliveryStateCheckBox";
            deliveryStateCheckBox.Padding = new Padding(0, 5, 0, 5);
            deliveryStateCheckBox.Size = new Size(100, 33);
            deliveryStateCheckBox.TabIndex = 7;
            deliveryStateCheckBox.Text = "Прибыла";
            deliveryStateCheckBox.UseVisualStyleBackColor = true;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.AutoSize = true;
            buttonsLayoutPanel.Controls.Add(editButton);
            buttonsLayoutPanel.Controls.Add(acceptButton);
            buttonsLayoutPanel.Controls.Add(resetButton);
            buttonsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            buttonsLayoutPanel.Location = new Point(770, 18);
            buttonsLayoutPanel.Margin = new Padding(0);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.Size = new Size(150, 160);
            buttonsLayoutPanel.TabIndex = 3;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.Highlight;
            editButton.Dock = DockStyle.Fill;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            editButton.ForeColor = SystemColors.ButtonFace;
            editButton.Location = new Point(0, 0);
            editButton.Margin = new Padding(0);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 50);
            editButton.TabIndex = 6;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = false;
            editButton.Visible = false;
            editButton.Click += editButton_Click;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = SystemColors.Highlight;
            acceptButton.Dock = DockStyle.Fill;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            acceptButton.ForeColor = SystemColors.ButtonFace;
            acceptButton.Location = new Point(0, 50);
            acceptButton.Margin = new Padding(0);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(150, 50);
            acceptButton.TabIndex = 6;
            acceptButton.Text = "Отправить";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resetButton.AutoSize = true;
            resetButton.BackColor = SystemColors.ScrollBar;
            resetButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            resetButton.ForeColor = SystemColors.ControlText;
            resetButton.Location = new Point(0, 110);
            resetButton.Margin = new Padding(0, 10, 0, 0);
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
            menuLayoutPanel.RowStyles.Add(new RowStyle());
            menuLayoutPanel.Size = new Size(920, 50);
            menuLayoutPanel.TabIndex = 3;
            // 
            // dbLayoutPanel
            // 
            dbLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dbLayoutPanel.AutoSize = true;
            dbLayoutPanel.Controls.Add(addButton);
            dbLayoutPanel.Controls.Add(openButton);
            dbLayoutPanel.Controls.Add(deleteButton);
            dbLayoutPanel.Enabled = false;
            dbLayoutPanel.Location = new Point(120, 0);
            dbLayoutPanel.Margin = new Padding(0);
            dbLayoutPanel.Name = "dbLayoutPanel";
            dbLayoutPanel.Size = new Size(800, 50);
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
            addButton.Size = new Size(250, 50);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // openButton
            // 
            openButton.AutoSize = true;
            openButton.BackColor = SystemColors.Highlight;
            openButton.Dock = DockStyle.Left;
            openButton.FlatStyle = FlatStyle.Flat;
            openButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            openButton.ForeColor = SystemColors.ButtonFace;
            openButton.Location = new Point(270, 0);
            openButton.Margin = new Padding(20, 0, 20, 0);
            openButton.Name = "openButton";
            openButton.Size = new Size(250, 50);
            openButton.TabIndex = 2;
            openButton.Text = "Просмотр";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.BackColor = SystemColors.Highlight;
            deleteButton.Dock = DockStyle.Left;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            deleteButton.ForeColor = SystemColors.ButtonFace;
            deleteButton.Location = new Point(540, 0);
            deleteButton.Margin = new Padding(0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(250, 50);
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
            // positionBindingSource
            // 
            positionBindingSource.DataSource = typeof(Position);
            // 
            // partBindingSource
            // 
            partBindingSource.DataSource = typeof(Part);
            // 
            // supplyIdDataGridViewTextBoxColumn
            // 
            supplyIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            supplyIdDataGridViewTextBoxColumn.DataPropertyName = "SupplyId";
            supplyIdDataGridViewTextBoxColumn.HeaderText = "ИД";
            supplyIdDataGridViewTextBoxColumn.Name = "supplyIdDataGridViewTextBoxColumn";
            supplyIdDataGridViewTextBoxColumn.ReadOnly = true;
            supplyIdDataGridViewTextBoxColumn.ToolTipText = "Идентификатор поставки в таблице";
            supplyIdDataGridViewTextBoxColumn.Width = 72;
            // 
            // employeeDataGridViewTextBoxColumn
            // 
            employeeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee";
            employeeDataGridViewTextBoxColumn.HeaderText = "Ответственный";
            employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn";
            employeeDataGridViewTextBoxColumn.ReadOnly = true;
            employeeDataGridViewTextBoxColumn.ToolTipText = "Кладовщик, ответственный за поставку";
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            supplierDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            supplierDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            supplierDataGridViewTextBoxColumn.ReadOnly = true;
            supplierDataGridViewTextBoxColumn.ToolTipText = "Поставщик, доставляющий запчасть";
            // 
            // dateOfPostDataGridViewTextBoxColumn
            // 
            dateOfPostDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateOfPostDataGridViewTextBoxColumn.DataPropertyName = "DateOfPost";
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dateOfPostDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            dateOfPostDataGridViewTextBoxColumn.HeaderText = "Дата оформления";
            dateOfPostDataGridViewTextBoxColumn.Name = "dateOfPostDataGridViewTextBoxColumn";
            dateOfPostDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfPostDataGridViewTextBoxColumn.ToolTipText = "Дата оформления поставки";
            dateOfPostDataGridViewTextBoxColumn.Width = 155;
            // 
            // deliveredDataGridViewCheckBoxColumn
            // 
            deliveredDataGridViewCheckBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            deliveredDataGridViewCheckBoxColumn.DataPropertyName = "Delivered";
            deliveredDataGridViewCheckBoxColumn.HeaderText = "Доставлено";
            deliveredDataGridViewCheckBoxColumn.Name = "deliveredDataGridViewCheckBoxColumn";
            deliveredDataGridViewCheckBoxColumn.ReadOnly = true;
            deliveredDataGridViewCheckBoxColumn.ToolTipText = "Состояние поставки";
            deliveredDataGridViewCheckBoxColumn.Width = 101;
            // 
            // dateOfDeliveryDataGridViewTextBoxColumn
            // 
            dateOfDeliveryDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateOfDeliveryDataGridViewTextBoxColumn.DataPropertyName = "DateOfDelivery";
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dateOfDeliveryDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            dateOfDeliveryDataGridViewTextBoxColumn.HeaderText = "Дата доставки";
            dateOfDeliveryDataGridViewTextBoxColumn.Name = "dateOfDeliveryDataGridViewTextBoxColumn";
            dateOfDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            dateOfDeliveryDataGridViewTextBoxColumn.ToolTipText = "Дата доставки запчасти на склад";
            dateOfDeliveryDataGridViewTextBoxColumn.Width = 132;
            // 
            // LogisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "LogisticsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационная система: логистика - поставки запчастей";
            FormClosed += LogisticsForm_FormClosed;
            Load += LogisticsForm_Load;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)suppliesTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplyBindingSource).EndInit();
            controlsLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.PerformLayout();
            inputsLayoutPanel.ResumeLayout(false);
            partsLayoutPanel.ResumeLayout(false);
            partsLayoutPanel.PerformLayout();
            amountLayoutPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)amountInput).EndInit();
            partLayoutPanel.ResumeLayout(false);
            personsLayoutPanel.ResumeLayout(false);
            personsLayoutPanel.PerformLayout();
            supplierLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            employeeLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            datesLayoutPanel.ResumeLayout(false);
            datesLayoutPanel.PerformLayout();
            deliveryDateLayoutPanel.ResumeLayout(false);
            postDateLayoutPanel.ResumeLayout(false);
            buttonsLayoutPanel.ResumeLayout(false);
            buttonsLayoutPanel.PerformLayout();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            dbLayoutPanel.ResumeLayout(false);
            dbLayoutPanel.PerformLayout();
            redirectLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)positionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formLayoutPanel;
        private TableLayoutPanel controlsLayoutPanel;
        private TableLayoutPanel inputsLayoutPanel;
        private TableLayoutPanel partsLayoutPanel;
        private FlowLayoutPanel amountLayoutPane;
        private Label amountLabel;
        private NumericUpDown amountInput;
        private FlowLayoutPanel partLayoutPanel;
        private Label partsLabel;
        private ComboBox partsPicker;
        private TableLayoutPanel personsLayoutPanel;
        private FlowLayoutPanel supplierLayoutPanel;
        private Label suppliersLabel;
        private ComboBox suppliersPicker;
        private FlowLayoutPanel employeeLayoutPanel;
        private Label employeeLabel;
        private ComboBox employeesPicker;
        private TableLayoutPanel datesLayoutPanel;
        private FlowLayoutPanel deliveryDateLayoutPanel;
        private Label deliveryDateLabel;
        private DateTimePicker deliveryDatePicker;
        private FlowLayoutPanel postDateLayoutPanel;
        private Label postDateLabel;
        private DateTimePicker postDatePicker;
        private DataGridView suppliesTable;
        private FlowLayoutPanel buttonsLayoutPanel;
        private Button acceptButton;
        private Button resetButton;
        private CheckBox deliveryStateCheckBox;
        private BindingSource employeeBindingSource;
        private BindingSource partBindingSource;
        private TableLayoutPanel menuLayoutPanel;
        private FlowLayoutPanel dbLayoutPanel;
        private Button addButton;
        private Button openButton;
        private Button deleteButton;
        private FlowLayoutPanel redirectLayoutPanel;
        private Button homeButton;
        private Button returnButton;
        private DataGridViewTextBoxColumn employeeIdDataGridViewTextBoxColumn;
        private BindingSource supplyBindingSource;
        private BindingSource positionBindingSource;
        private Button editButton;
        private BindingSource supplierBindingSource;
        private DataGridViewTextBoxColumn supplyIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfPostDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn deliveredDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn dateOfDeliveryDataGridViewTextBoxColumn;
    }
}
