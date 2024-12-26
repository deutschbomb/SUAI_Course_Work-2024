
using System.Windows.Forms.VisualStyles;

namespace App
{
    partial class StorageForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            formLayoutPanel = new TableLayoutPanel();
            controlsLayoutPanel = new TableLayoutPanel();
            longLayoutPanel2 = new FlowLayoutPanel();
            catalogueNumberLayoutPanel = new FlowLayoutPanel();
            catalogueNumberLabel = new Label();
            catalogueNumberInput = new TextBox();
            nameLayoutPanel = new FlowLayoutPanel();
            nameLabel = new Label();
            nameInput = new TextBox();
            buttonsLayoutPanel = new FlowLayoutPanel();
            acceptButton = new Button();
            editButton = new Button();
            resetButton = new Button();
            shortLayoutPanel = new FlowLayoutPanel();
            balanceLayoutPanel = new FlowLayoutPanel();
            balanceLabel = new Label();
            balanceInput = new NumericUpDown();
            priceLayoutPanel = new FlowLayoutPanel();
            priceLabel = new Label();
            priceInput = new NumericUpDown();
            storageTable = new DataGridView();
            partIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            partDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            balanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            partPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            accountingBindingSource = new BindingSource(components);
            menuLayoutPanel = new TableLayoutPanel();
            dbLayoutPanel = new FlowLayoutPanel();
            addButton = new Button();
            openButton = new Button();
            deleteButton = new Button();
            redirectLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            partBindingSource = new BindingSource(components);
            formLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            longLayoutPanel2.SuspendLayout();
            catalogueNumberLayoutPanel.SuspendLayout();
            nameLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            shortLayoutPanel.SuspendLayout();
            balanceLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)balanceInput).BeginInit();
            priceLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storageTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountingBindingSource).BeginInit();
            menuLayoutPanel.SuspendLayout();
            dbLayoutPanel.SuspendLayout();
            redirectLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)partBindingSource).BeginInit();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 4);
            formLayoutPanel.Controls.Add(storageTable, 0, 2);
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
            formLayoutPanel.TabIndex = 1;
            // 
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            controlsLayoutPanel.ColumnCount = 5;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            controlsLayoutPanel.Controls.Add(longLayoutPanel2, 0, 0);
            controlsLayoutPanel.Controls.Add(buttonsLayoutPanel, 4, 0);
            controlsLayoutPanel.Controls.Add(shortLayoutPanel, 2, 0);
            controlsLayoutPanel.Location = new Point(20, 342);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.Size = new Size(920, 190);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // longLayoutPanel2
            // 
            longLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            longLayoutPanel2.AutoSize = true;
            longLayoutPanel2.Controls.Add(catalogueNumberLayoutPanel);
            longLayoutPanel2.Controls.Add(nameLayoutPanel);
            longLayoutPanel2.Location = new Point(0, 34);
            longLayoutPanel2.Margin = new Padding(0);
            longLayoutPanel2.Name = "longLayoutPanel2";
            longLayoutPanel2.Size = new Size(600, 122);
            longLayoutPanel2.TabIndex = 10;
            // 
            // catalogueNumberLayoutPanel
            // 
            catalogueNumberLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            catalogueNumberLayoutPanel.AutoSize = true;
            catalogueNumberLayoutPanel.Controls.Add(catalogueNumberLabel);
            catalogueNumberLayoutPanel.Controls.Add(catalogueNumberInput);
            catalogueNumberLayoutPanel.FlowDirection = FlowDirection.TopDown;
            catalogueNumberLayoutPanel.Location = new Point(0, 0);
            catalogueNumberLayoutPanel.Margin = new Padding(0);
            catalogueNumberLayoutPanel.Name = "catalogueNumberLayoutPanel";
            catalogueNumberLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            catalogueNumberLayoutPanel.Size = new Size(600, 61);
            catalogueNumberLayoutPanel.TabIndex = 1;
            // 
            // catalogueNumberLabel
            // 
            catalogueNumberLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            catalogueNumberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            catalogueNumberLabel.Location = new Point(0, 5);
            catalogueNumberLabel.Margin = new Padding(0);
            catalogueNumberLabel.Name = "catalogueNumberLabel";
            catalogueNumberLabel.Size = new Size(600, 25);
            catalogueNumberLabel.TabIndex = 0;
            catalogueNumberLabel.Text = "Каталожный номер";
            // 
            // catalogueNumberInput
            // 
            catalogueNumberInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            catalogueNumberInput.BorderStyle = BorderStyle.FixedSingle;
            catalogueNumberInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            catalogueNumberInput.Location = new Point(0, 30);
            catalogueNumberInput.Margin = new Padding(0);
            catalogueNumberInput.MaxLength = 10;
            catalogueNumberInput.Name = "catalogueNumberInput";
            catalogueNumberInput.PlaceholderText = "00 00 000 000";
            catalogueNumberInput.Size = new Size(600, 26);
            catalogueNumberInput.TabIndex = 1;
            catalogueNumberInput.Enter += catalogueNumberInput_Enter;
            catalogueNumberInput.Leave += catalogueNumberInput_Leave;
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
            nameLayoutPanel.Size = new Size(600, 61);
            nameLayoutPanel.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            nameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameLabel.Location = new Point(0, 5);
            nameLabel.Margin = new Padding(0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(600, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Наименование";
            // 
            // nameInput
            // 
            nameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            nameInput.Location = new Point(0, 30);
            nameInput.Margin = new Padding(0);
            nameInput.MaxLength = 100;
            nameInput.Name = "nameInput";
            nameInput.PlaceholderText = "Наименование";
            nameInput.Size = new Size(600, 26);
            nameInput.TabIndex = 1;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.AutoScroll = true;
            buttonsLayoutPanel.AutoSize = true;
            buttonsLayoutPanel.Controls.Add(acceptButton);
            buttonsLayoutPanel.Controls.Add(editButton);
            buttonsLayoutPanel.Controls.Add(resetButton);
            buttonsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            buttonsLayoutPanel.Location = new Point(770, 15);
            buttonsLayoutPanel.Margin = new Padding(0);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.Size = new Size(150, 160);
            buttonsLayoutPanel.TabIndex = 8;
            // 
            // acceptButton
            // 
            acceptButton.BackColor = SystemColors.Highlight;
            acceptButton.Dock = DockStyle.Fill;
            acceptButton.FlatStyle = FlatStyle.Flat;
            acceptButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            acceptButton.ForeColor = SystemColors.ButtonFace;
            acceptButton.Location = new Point(0, 0);
            acceptButton.Margin = new Padding(0);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(150, 50);
            acceptButton.TabIndex = 2;
            acceptButton.Text = "Принять";
            acceptButton.UseVisualStyleBackColor = false;
            acceptButton.Click += acceptButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = SystemColors.Highlight;
            editButton.Dock = DockStyle.Fill;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            editButton.ForeColor = SystemColors.ButtonFace;
            editButton.Location = new Point(0, 50);
            editButton.Margin = new Padding(0);
            editButton.Name = "editButton";
            editButton.Size = new Size(150, 50);
            editButton.TabIndex = 2;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = false;
            editButton.Visible = false;
            editButton.Click += editButton_Click;
            // 
            // resetButton
            // 
            resetButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            resetButton.BackColor = SystemColors.ScrollBar;
            resetButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            resetButton.ForeColor = SystemColors.ControlText;
            resetButton.Location = new Point(0, 110);
            resetButton.Margin = new Padding(0, 10, 0, 0);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(150, 50);
            resetButton.TabIndex = 3;
            resetButton.Text = "Сбросить";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // shortLayoutPanel
            // 
            shortLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            shortLayoutPanel.AutoSize = true;
            shortLayoutPanel.Controls.Add(balanceLayoutPanel);
            shortLayoutPanel.Controls.Add(priceLayoutPanel);
            shortLayoutPanel.Location = new Point(610, 34);
            shortLayoutPanel.Margin = new Padding(0);
            shortLayoutPanel.Name = "shortLayoutPanel";
            shortLayoutPanel.Size = new Size(150, 122);
            shortLayoutPanel.TabIndex = 9;
            // 
            // balanceLayoutPanel
            // 
            balanceLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            balanceLayoutPanel.AutoSize = true;
            balanceLayoutPanel.Controls.Add(balanceLabel);
            balanceLayoutPanel.Controls.Add(balanceInput);
            balanceLayoutPanel.FlowDirection = FlowDirection.TopDown;
            balanceLayoutPanel.Location = new Point(0, 0);
            balanceLayoutPanel.Margin = new Padding(0);
            balanceLayoutPanel.Name = "balanceLayoutPanel";
            balanceLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            balanceLayoutPanel.Size = new Size(150, 61);
            balanceLayoutPanel.TabIndex = 1;
            // 
            // balanceLabel
            // 
            balanceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            balanceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            balanceLabel.Location = new Point(0, 5);
            balanceLabel.Margin = new Padding(0);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(150, 25);
            balanceLabel.TabIndex = 0;
            balanceLabel.Text = "Остаток, шт.";
            // 
            // balanceInput
            // 
            balanceInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            balanceInput.BorderStyle = BorderStyle.FixedSingle;
            balanceInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            balanceInput.Location = new Point(0, 30);
            balanceInput.Margin = new Padding(0);
            balanceInput.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            balanceInput.Name = "balanceInput";
            balanceInput.Size = new Size(150, 26);
            balanceInput.TabIndex = 1;
            balanceInput.TextAlign = HorizontalAlignment.Center;
            balanceInput.ThousandsSeparator = true;
            // 
            // priceLayoutPanel
            // 
            priceLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceLayoutPanel.AutoSize = true;
            priceLayoutPanel.Controls.Add(priceLabel);
            priceLayoutPanel.Controls.Add(priceInput);
            priceLayoutPanel.FlowDirection = FlowDirection.TopDown;
            priceLayoutPanel.Location = new Point(0, 61);
            priceLayoutPanel.Margin = new Padding(0);
            priceLayoutPanel.Name = "priceLayoutPanel";
            priceLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            priceLayoutPanel.Size = new Size(150, 61);
            priceLayoutPanel.TabIndex = 2;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            priceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceLabel.Location = new Point(0, 5);
            priceLabel.Margin = new Padding(0);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(150, 25);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "Цена за штуку, руб.";
            // 
            // priceInput
            // 
            priceInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceInput.BorderStyle = BorderStyle.FixedSingle;
            priceInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceInput.Location = new Point(0, 30);
            priceInput.Margin = new Padding(0);
            priceInput.Maximum = new decimal(new int[] { -727379969, 232, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(150, 26);
            priceInput.TabIndex = 2;
            priceInput.TextAlign = HorizontalAlignment.Center;
            priceInput.ThousandsSeparator = true;
            // 
            // storageTable
            // 
            storageTable.AllowUserToAddRows = false;
            storageTable.AllowUserToDeleteRows = false;
            storageTable.AllowUserToResizeColumns = false;
            storageTable.AllowUserToResizeRows = false;
            storageTable.AutoGenerateColumns = false;
            storageTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            storageTable.BackgroundColor = Color.White;
            storageTable.BorderStyle = BorderStyle.None;
            storageTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            storageTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Padding = new Padding(12, 7, 12, 6);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            storageTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            storageTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            storageTable.Columns.AddRange(new DataGridViewColumn[] { partIdDataGridViewTextBoxColumn, partDataGridViewTextBoxColumn, balanceDataGridViewTextBoxColumn, partPriceDataGridViewTextBoxColumn });
            storageTable.Cursor = Cursors.Hand;
            storageTable.DataSource = accountingBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Padding = new Padding(12, 0, 12, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            storageTable.DefaultCellStyle = dataGridViewCellStyle2;
            storageTable.Dock = DockStyle.Fill;
            storageTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            storageTable.EnableHeadersVisualStyles = false;
            storageTable.GridColor = SystemColors.ControlDark;
            storageTable.Location = new Point(20, 80);
            storageTable.Margin = new Padding(0);
            storageTable.MultiSelect = false;
            storageTable.Name = "storageTable";
            storageTable.ReadOnly = true;
            storageTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            storageTable.RowHeadersVisible = false;
            storageTable.RowHeadersWidth = 23;
            storageTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            storageTable.RowTemplate.Height = 32;
            storageTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            storageTable.Size = new Size(920, 242);
            storageTable.TabIndex = 2;
            // 
            // partIdDataGridViewTextBoxColumn
            // 
            partIdDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            partIdDataGridViewTextBoxColumn.DataPropertyName = "PartId";
            partIdDataGridViewTextBoxColumn.HeaderText = "ИД";
            partIdDataGridViewTextBoxColumn.Name = "partIdDataGridViewTextBoxColumn";
            partIdDataGridViewTextBoxColumn.ReadOnly = true;
            partIdDataGridViewTextBoxColumn.ToolTipText = "Идентификатор запчасти в таблице";
            partIdDataGridViewTextBoxColumn.Width = 72;
            // 
            // partDataGridViewTextBoxColumn
            // 
            partDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            partDataGridViewTextBoxColumn.DataPropertyName = "Part";
            partDataGridViewTextBoxColumn.HeaderText = "Наименование";
            partDataGridViewTextBoxColumn.Name = "partDataGridViewTextBoxColumn";
            partDataGridViewTextBoxColumn.ReadOnly = true;
            partDataGridViewTextBoxColumn.ToolTipText = "Название запчасти";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            balanceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            balanceDataGridViewTextBoxColumn.HeaderText = "Остаток, шт.";
            balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            balanceDataGridViewTextBoxColumn.ReadOnly = true;
            balanceDataGridViewTextBoxColumn.ToolTipText = "Остаток запчастей на складе";
            balanceDataGridViewTextBoxColumn.Width = 124;
            // 
            // partPriceDataGridViewTextBoxColumn
            // 
            partPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            partPriceDataGridViewTextBoxColumn.DataPropertyName = "PartPrice";
            partPriceDataGridViewTextBoxColumn.HeaderText = "Цена, руб.";
            partPriceDataGridViewTextBoxColumn.Name = "partPriceDataGridViewTextBoxColumn";
            partPriceDataGridViewTextBoxColumn.ReadOnly = true;
            partPriceDataGridViewTextBoxColumn.ToolTipText = "Цена запчасти за один экземпляр";
            partPriceDataGridViewTextBoxColumn.Width = 112;
            // 
            // accountingBindingSource
            // 
            accountingBindingSource.DataSource = typeof(Accounting);
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
            menuLayoutPanel.TabIndex = 3;
            // 
            // dbLayoutPanel
            // 
            dbLayoutPanel.AutoSize = true;
            dbLayoutPanel.Controls.Add(addButton);
            dbLayoutPanel.Controls.Add(openButton);
            dbLayoutPanel.Controls.Add(deleteButton);
            dbLayoutPanel.Dock = DockStyle.Fill;
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
            addButton.Size = new Size(253, 50);
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
            openButton.Location = new Point(273, 0);
            openButton.Margin = new Padding(20, 0, 20, 0);
            openButton.Name = "openButton";
            openButton.Size = new Size(253, 50);
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
            deleteButton.Location = new Point(546, 0);
            deleteButton.Margin = new Padding(0);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(253, 50);
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
            // partBindingSource
            // 
            partBindingSource.DataSource = typeof(Part);
            // 
            // StorageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "StorageForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационная система: склад автосервиса";
            FormClosed += StorageForm_FormClosed;
            Load += StorageForm_Load;
            formLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.PerformLayout();
            longLayoutPanel2.ResumeLayout(false);
            longLayoutPanel2.PerformLayout();
            catalogueNumberLayoutPanel.ResumeLayout(false);
            catalogueNumberLayoutPanel.PerformLayout();
            nameLayoutPanel.ResumeLayout(false);
            nameLayoutPanel.PerformLayout();
            buttonsLayoutPanel.ResumeLayout(false);
            shortLayoutPanel.ResumeLayout(false);
            shortLayoutPanel.PerformLayout();
            balanceLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)balanceInput).EndInit();
            priceLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)storageTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountingBindingSource).EndInit();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            dbLayoutPanel.ResumeLayout(false);
            dbLayoutPanel.PerformLayout();
            redirectLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)partBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formLayoutPanel;
        private TableLayoutPanel controlsLayoutPanel;
        private DataGridView storageTable;
        private FlowLayoutPanel buttonsLayoutPanel;
        private Button acceptButton;
        private Button resetButton;
        private FlowLayoutPanel shortLayoutPanel;
        private FlowLayoutPanel balanceLayoutPanel;
        private Label balanceLabel;
        private NumericUpDown balanceInput;
        private FlowLayoutPanel priceLayoutPanel;
        private Label priceLabel;
        private NumericUpDown priceInput;
        private FlowLayoutPanel longLayoutPanel2;
        private FlowLayoutPanel catalogueNumberLayoutPanel;
        private Label catalogueNumberLabel;
        private TextBox catalogueNumberInput;
        private FlowLayoutPanel nameLayoutPanel;
        private Label nameLabel;
        private TextBox nameInput;
        private BindingSource accountingBindingSource;
        private BindingSource partBindingSource;
        private TableLayoutPanel menuLayoutPanel;
        private FlowLayoutPanel dbLayoutPanel;
        private Button addButton;
        private Button openButton;
        private Button deleteButton;
        private FlowLayoutPanel redirectLayoutPanel;
        private Button homeButton;
        private Button returnButton;
        private DataGridViewTextBoxColumn partIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn partPriceDataGridViewTextBoxColumn;
        private Button editButton;
    }
}
