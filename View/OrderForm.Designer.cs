
namespace App
{
    partial class OrderForm
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
            divider = new Label();
            ordersTable = new DataGridView();
            menuLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            requestsPicker = new ComboBox();
            printButton = new Button();
            toFileButton = new Button();
            controlsLayoutPanel = new TableLayoutPanel();
            inputsLayoutPanel = new TableLayoutPanel();
            w_priceLayoutPanel = new FlowLayoutPanel();
            w_priceLabel = new Label();
            w_priceValue = new Label();
            partsLayoutPanel = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            installedCheckBox = new CheckBox();
            p_priceLayoutPanel = new FlowLayoutPanel();
            p_priceLabel = new Label();
            p_priceValue = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            descLayoutPanel = new FlowLayoutPanel();
            descLabel = new Label();
            workDescText = new RichTextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            mechanicLayoutPanel = new FlowLayoutPanel();
            mechanicsLabel = new Label();
            mechanicsPicker = new ComboBox();
            employeeLayoutPanel = new FlowLayoutPanel();
            workLabel = new Label();
            worksPicker = new ComboBox();
            buttonsLayoutPanel = new FlowLayoutPanel();
            acceptButton = new Button();
            removeButton = new Button();
            resetButton = new Button();
            formLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ordersTable).BeginInit();
            menuLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            inputsLayoutPanel.SuspendLayout();
            w_priceLayoutPanel.SuspendLayout();
            partsLayoutPanel.SuspendLayout();
            p_priceLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            descLayoutPanel.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            mechanicLayoutPanel.SuspendLayout();
            employeeLayoutPanel.SuspendLayout();
            buttonsLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(divider, 0, 1);
            formLayoutPanel.Controls.Add(ordersTable, 0, 4);
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 2);
            formLayoutPanel.Dock = DockStyle.Fill;
            formLayoutPanel.Location = new Point(0, 0);
            formLayoutPanel.Margin = new Padding(0);
            formLayoutPanel.Name = "formLayoutPanel";
            formLayoutPanel.Padding = new Padding(20, 10, 20, 10);
            formLayoutPanel.RowCount = 5;
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            formLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 116F));
            formLayoutPanel.Size = new Size(960, 540);
            formLayoutPanel.TabIndex = 4;
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
            // ordersTable
            // 
            ordersTable.BackgroundColor = Color.White;
            ordersTable.BorderStyle = BorderStyle.None;
            ordersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ordersTable.Cursor = Cursors.Hand;
            ordersTable.Dock = DockStyle.Top;
            ordersTable.GridColor = SystemColors.ControlDark;
            ordersTable.Location = new Point(20, 316);
            ordersTable.Margin = new Padding(0);
            ordersTable.Name = "ordersTable";
            ordersTable.Size = new Size(920, 214);
            ordersTable.TabIndex = 2;
            // 
            // menuLayoutPanel
            // 
            menuLayoutPanel.AutoSize = true;
            menuLayoutPanel.Controls.Add(homeButton);
            menuLayoutPanel.Controls.Add(returnButton);
            menuLayoutPanel.Controls.Add(requestsPicker);
            menuLayoutPanel.Controls.Add(printButton);
            menuLayoutPanel.Controls.Add(toFileButton);
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
            // requestsPicker
            // 
            requestsPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            requestsPicker.BackColor = Color.White;
            requestsPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            requestsPicker.FlatStyle = FlatStyle.System;
            requestsPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            requestsPicker.FormattingEnabled = true;
            requestsPicker.Location = new Point(120, 11);
            requestsPicker.Margin = new Padding(10, 0, 10, 0);
            requestsPicker.Name = "requestsPicker";
            requestsPicker.Size = new Size(296, 27);
            requestsPicker.TabIndex = 1;
            // 
            // printButton
            // 
            printButton.AutoSize = true;
            printButton.BackColor = SystemColors.MenuHighlight;
            printButton.Dock = DockStyle.Left;
            printButton.FlatStyle = FlatStyle.Flat;
            printButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            printButton.ForeColor = SystemColors.ButtonFace;
            printButton.Location = new Point(436, 0);
            printButton.Margin = new Padding(10, 0, 10, 0);
            printButton.Name = "printButton";
            printButton.Size = new Size(232, 50);
            printButton.TabIndex = 1;
            printButton.Text = "Печать";
            printButton.UseVisualStyleBackColor = false;
            // 
            // toFileButton
            // 
            toFileButton.AutoSize = true;
            toFileButton.BackColor = SystemColors.ScrollBar;
            toFileButton.Dock = DockStyle.Left;
            toFileButton.FlatAppearance.BorderSize = 0;
            toFileButton.FlatStyle = FlatStyle.Flat;
            toFileButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            toFileButton.ForeColor = SystemColors.ControlText;
            toFileButton.Location = new Point(688, 0);
            toFileButton.Margin = new Padding(10, 0, 0, 0);
            toFileButton.Name = "toFileButton";
            toFileButton.Size = new Size(232, 50);
            toFileButton.TabIndex = 8;
            toFileButton.Text = "В файл";
            toFileButton.UseVisualStyleBackColor = false;
            // 
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            controlsLayoutPanel.AutoSize = true;
            controlsLayoutPanel.ColumnCount = 3;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            controlsLayoutPanel.Controls.Add(inputsLayoutPanel, 0, 0);
            controlsLayoutPanel.Controls.Add(buttonsLayoutPanel, 2, 0);
            controlsLayoutPanel.Location = new Point(20, 101);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle());
            controlsLayoutPanel.Size = new Size(920, 195);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // inputsLayoutPanel
            // 
            inputsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            inputsLayoutPanel.AutoSize = true;
            inputsLayoutPanel.ColumnCount = 1;
            inputsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            inputsLayoutPanel.Controls.Add(w_priceLayoutPanel, 0, 1);
            inputsLayoutPanel.Controls.Add(partsLayoutPanel, 0, 2);
            inputsLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 0);
            inputsLayoutPanel.Location = new Point(0, 0);
            inputsLayoutPanel.Margin = new Padding(0);
            inputsLayoutPanel.Name = "inputsLayoutPanel";
            inputsLayoutPanel.RowCount = 3;
            inputsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            inputsLayoutPanel.RowStyles.Add(new RowStyle());
            inputsLayoutPanel.RowStyles.Add(new RowStyle());
            inputsLayoutPanel.Size = new Size(760, 195);
            inputsLayoutPanel.TabIndex = 2;
            // 
            // w_priceLayoutPanel
            // 
            w_priceLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            w_priceLayoutPanel.AutoSize = true;
            w_priceLayoutPanel.Controls.Add(w_priceLabel);
            w_priceLayoutPanel.Controls.Add(w_priceValue);
            w_priceLayoutPanel.Location = new Point(3, 129);
            w_priceLayoutPanel.Name = "w_priceLayoutPanel";
            w_priceLayoutPanel.Size = new Size(754, 19);
            w_priceLayoutPanel.TabIndex = 13;
            // 
            // w_priceLabel
            // 
            w_priceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            w_priceLabel.AutoSize = true;
            w_priceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            w_priceLabel.Location = new Point(0, 0);
            w_priceLabel.Margin = new Padding(0);
            w_priceLabel.Name = "w_priceLabel";
            w_priceLabel.Size = new Size(121, 19);
            w_priceLabel.TabIndex = 12;
            w_priceLabel.Text = "Стоимость работ:";
            // 
            // w_priceValue
            // 
            w_priceValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            w_priceValue.AutoSize = true;
            w_priceValue.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            w_priceValue.Location = new Point(121, 0);
            w_priceValue.Margin = new Padding(0);
            w_priceValue.Name = "w_priceValue";
            w_priceValue.Size = new Size(32, 19);
            w_priceValue.TabIndex = 13;
            w_priceValue.Text = "0 р.";
            // 
            // partsLayoutPanel
            // 
            partsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            partsLayoutPanel.AutoSize = true;
            partsLayoutPanel.ColumnCount = 5;
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            partsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            partsLayoutPanel.Controls.Add(comboBox1, 2, 0);
            partsLayoutPanel.Controls.Add(installedCheckBox, 0, 0);
            partsLayoutPanel.Controls.Add(p_priceLayoutPanel, 4, 0);
            partsLayoutPanel.Location = new Point(0, 151);
            partsLayoutPanel.Margin = new Padding(0);
            partsLayoutPanel.Name = "partsLayoutPanel";
            partsLayoutPanel.RowCount = 1;
            partsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            partsLayoutPanel.Size = new Size(760, 44);
            partsLayoutPanel.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(256, 8);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 27);
            comboBox1.TabIndex = 11;
            // 
            // installedCheckBox
            // 
            installedCheckBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            installedCheckBox.AutoSize = true;
            installedCheckBox.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            installedCheckBox.Location = new Point(0, 10);
            installedCheckBox.Margin = new Padding(0);
            installedCheckBox.Name = "installedCheckBox";
            installedCheckBox.Size = new Size(246, 23);
            installedCheckBox.TabIndex = 10;
            installedCheckBox.Text = "Запчасть установлена";
            installedCheckBox.UseVisualStyleBackColor = true;
            // 
            // p_priceLayoutPanel
            // 
            p_priceLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            p_priceLayoutPanel.AutoSize = true;
            p_priceLayoutPanel.Controls.Add(p_priceLabel);
            p_priceLayoutPanel.Controls.Add(p_priceValue);
            p_priceLayoutPanel.Location = new Point(515, 12);
            p_priceLayoutPanel.Name = "p_priceLayoutPanel";
            p_priceLayoutPanel.Size = new Size(242, 19);
            p_priceLayoutPanel.TabIndex = 12;
            // 
            // p_priceLabel
            // 
            p_priceLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            p_priceLabel.AutoSize = true;
            p_priceLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            p_priceLabel.Location = new Point(0, 0);
            p_priceLabel.Margin = new Padding(0);
            p_priceLabel.Name = "p_priceLabel";
            p_priceLabel.Size = new Size(140, 19);
            p_priceLabel.TabIndex = 12;
            p_priceLabel.Text = "Стоимость запчасти:";
            // 
            // p_priceValue
            // 
            p_priceValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            p_priceValue.AutoSize = true;
            p_priceValue.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            p_priceValue.Location = new Point(140, 0);
            p_priceValue.Margin = new Padding(0);
            p_priceValue.Name = "p_priceValue";
            p_priceValue.Size = new Size(32, 19);
            p_priceValue.TabIndex = 13;
            p_priceValue.Text = "0 р.";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(descLayoutPanel, 2, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(760, 126);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // descLayoutPanel
            // 
            descLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            descLayoutPanel.Controls.Add(descLabel);
            descLayoutPanel.Controls.Add(workDescText);
            descLayoutPanel.FlowDirection = FlowDirection.TopDown;
            descLayoutPanel.Location = new Point(270, 0);
            descLayoutPanel.Margin = new Padding(0);
            descLayoutPanel.Name = "descLayoutPanel";
            descLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            descLayoutPanel.Size = new Size(490, 126);
            descLayoutPanel.TabIndex = 5;
            // 
            // descLabel
            // 
            descLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            descLabel.Location = new Point(0, 5);
            descLabel.Margin = new Padding(0);
            descLabel.Name = "descLabel";
            descLabel.Size = new Size(490, 25);
            descLabel.TabIndex = 0;
            descLabel.Text = "Описание работ";
            // 
            // workDescText
            // 
            workDescText.BorderStyle = BorderStyle.FixedSingle;
            workDescText.Dock = DockStyle.Fill;
            workDescText.Location = new Point(0, 30);
            workDescText.Margin = new Padding(0);
            workDescText.Name = "workDescText";
            workDescText.Size = new Size(490, 90);
            workDescText.TabIndex = 1;
            workDescText.Text = "";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(mechanicLayoutPanel, 0, 1);
            tableLayoutPanel4.Controls.Add(employeeLayoutPanel, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(260, 126);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // mechanicLayoutPanel
            // 
            mechanicLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mechanicLayoutPanel.AutoSize = true;
            mechanicLayoutPanel.Controls.Add(mechanicsLabel);
            mechanicLayoutPanel.Controls.Add(mechanicsPicker);
            mechanicLayoutPanel.FlowDirection = FlowDirection.TopDown;
            mechanicLayoutPanel.Location = new Point(0, 63);
            mechanicLayoutPanel.Margin = new Padding(0);
            mechanicLayoutPanel.Name = "mechanicLayoutPanel";
            mechanicLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            mechanicLayoutPanel.Size = new Size(260, 62);
            mechanicLayoutPanel.TabIndex = 5;
            // 
            // mechanicsLabel
            // 
            mechanicsLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mechanicsLabel.Location = new Point(0, 5);
            mechanicsLabel.Margin = new Padding(0);
            mechanicsLabel.Name = "mechanicsLabel";
            mechanicsLabel.Size = new Size(260, 25);
            mechanicsLabel.TabIndex = 0;
            mechanicsLabel.Text = "Работу выполнил";
            // 
            // mechanicsPicker
            // 
            mechanicsPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mechanicsPicker.BackColor = Color.White;
            mechanicsPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            mechanicsPicker.FlatStyle = FlatStyle.System;
            mechanicsPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            mechanicsPicker.FormattingEnabled = true;
            mechanicsPicker.Location = new Point(0, 30);
            mechanicsPicker.Margin = new Padding(0);
            mechanicsPicker.Name = "mechanicsPicker";
            mechanicsPicker.Size = new Size(260, 27);
            mechanicsPicker.TabIndex = 1;
            // 
            // employeeLayoutPanel
            // 
            employeeLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            employeeLayoutPanel.AutoSize = true;
            employeeLayoutPanel.Controls.Add(workLabel);
            employeeLayoutPanel.Controls.Add(worksPicker);
            employeeLayoutPanel.FlowDirection = FlowDirection.TopDown;
            employeeLayoutPanel.Location = new Point(0, 0);
            employeeLayoutPanel.Margin = new Padding(0);
            employeeLayoutPanel.Name = "employeeLayoutPanel";
            employeeLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            employeeLayoutPanel.Size = new Size(260, 62);
            employeeLayoutPanel.TabIndex = 4;
            // 
            // workLabel
            // 
            workLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            workLabel.Location = new Point(0, 5);
            workLabel.Margin = new Padding(0);
            workLabel.Name = "workLabel";
            workLabel.Size = new Size(260, 25);
            workLabel.TabIndex = 0;
            workLabel.Text = "Вид работы";
            // 
            // worksPicker
            // 
            worksPicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            worksPicker.BackColor = Color.White;
            worksPicker.DropDownStyle = ComboBoxStyle.DropDownList;
            worksPicker.FlatStyle = FlatStyle.System;
            worksPicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            worksPicker.FormattingEnabled = true;
            worksPicker.Location = new Point(0, 30);
            worksPicker.Margin = new Padding(0);
            worksPicker.Name = "worksPicker";
            worksPicker.Size = new Size(260, 27);
            worksPicker.TabIndex = 1;
            // 
            // buttonsLayoutPanel
            // 
            buttonsLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            buttonsLayoutPanel.AutoSize = true;
            buttonsLayoutPanel.Controls.Add(acceptButton);
            buttonsLayoutPanel.Controls.Add(removeButton);
            buttonsLayoutPanel.Controls.Add(resetButton);
            buttonsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            buttonsLayoutPanel.Location = new Point(770, 12);
            buttonsLayoutPanel.Margin = new Padding(0);
            buttonsLayoutPanel.Name = "buttonsLayoutPanel";
            buttonsLayoutPanel.Size = new Size(150, 170);
            buttonsLayoutPanel.TabIndex = 3;
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
            // 
            // removeButton
            // 
            removeButton.BackColor = SystemColors.MenuHighlight;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            removeButton.ForeColor = SystemColors.ButtonFace;
            removeButton.Location = new Point(0, 60);
            removeButton.Margin = new Padding(0, 10, 0, 10);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(150, 50);
            removeButton.TabIndex = 6;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = false;
            // 
            // resetButton
            // 
            resetButton.BackColor = SystemColors.ScrollBar;
            resetButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            resetButton.ForeColor = SystemColors.ControlText;
            resetButton.Location = new Point(0, 120);
            resetButton.Margin = new Padding(0);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(150, 50);
            resetButton.TabIndex = 7;
            resetButton.Text = "Сбросить";
            resetButton.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "OrderForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационная система: составление заказ-наряда";
            FormClosed += OrderForm_FormClosed;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ordersTable).EndInit();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            controlsLayoutPanel.ResumeLayout(false);
            controlsLayoutPanel.PerformLayout();
            inputsLayoutPanel.ResumeLayout(false);
            inputsLayoutPanel.PerformLayout();
            w_priceLayoutPanel.ResumeLayout(false);
            w_priceLayoutPanel.PerformLayout();
            partsLayoutPanel.ResumeLayout(false);
            partsLayoutPanel.PerformLayout();
            p_priceLayoutPanel.ResumeLayout(false);
            p_priceLayoutPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            descLayoutPanel.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            mechanicLayoutPanel.ResumeLayout(false);
            employeeLayoutPanel.ResumeLayout(false);
            buttonsLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formLayoutPanel;
        private FlowLayoutPanel menuLayoutPanel;
        private Button homeButton;
        private Button returnButton;
        private ComboBox requestsPicker;
        private Button printButton;
        private TableLayoutPanel controlsLayoutPanel;
        private TableLayoutPanel inputsLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel partsLayoutPanel;
        private CheckBox installedCheckBox;
        private ComboBox comboBox1;
        private Label p_priceLabel;
        private FlowLayoutPanel p_priceLayoutPanel;
        private Label p_priceValue;
        private FlowLayoutPanel w_priceLayoutPanel;
        private Label w_priceLabel;
        private Label w_priceValue;
        private DataGridView ordersTable;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel mechanicLayoutPanel;
        private Label mechanicsLabel;
        private ComboBox mechanicsPicker;
        private FlowLayoutPanel employeeLayoutPanel;
        private Label workLabel;
        private ComboBox worksPicker;
        private FlowLayoutPanel descLayoutPanel;
        private Label descLabel;
        private RichTextBox workDescText;
        private Button toFileButton;
        private FlowLayoutPanel buttonsLayoutPanel;
        private Button acceptButton;
        private Button removeButton;
        private Button resetButton;
        private Label divider;
    }
}
