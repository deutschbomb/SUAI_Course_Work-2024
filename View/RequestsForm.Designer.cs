
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
            formLayoutPanel = new TableLayoutPanel();
            menuLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonsLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            acceptButton = new Button();
            resetButton = new Button();
            button1 = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            comboBox2 = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            employeeLayoutPanel = new FlowLayoutPanel();
            employeeLabel = new Label();
            employeePicker = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            checkBox1 = new CheckBox();
            flowLayoutPanel6 = new FlowLayoutPanel();
            label5 = new Label();
            dateTimePicker3 = new DateTimePicker();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            postDateLayoutPanel = new FlowLayoutPanel();
            postDateLabel = new Label();
            postDatePicker = new DateTimePicker();
            suppliesTable = new DataGridView();
            formLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            buttonsLayoutPanel2.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            employeeLayoutPanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            postDateLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)suppliesTable).BeginInit();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
            formLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 4);
            formLayoutPanel.Controls.Add(suppliesTable, 0, 2);
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
            menuLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            menuLayoutPanel.AutoSize = true;
            menuLayoutPanel.Controls.Add(homeButton);
            menuLayoutPanel.Controls.Add(returnButton);
            menuLayoutPanel.Controls.Add(addButton);
            menuLayoutPanel.Controls.Add(editButton);
            menuLayoutPanel.Controls.Add(deleteButton);
            menuLayoutPanel.Location = new Point(20, 10);
            menuLayoutPanel.Margin = new Padding(0);
            menuLayoutPanel.Name = "menuLayoutPanel";
            menuLayoutPanel.Size = new Size(919, 50);
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
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 155F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(20, 337);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(920, 190);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(buttonsLayoutPanel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(765, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(155, 190);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonsLayoutPanel2
            // 
            buttonsLayoutPanel2.AutoSize = true;
            buttonsLayoutPanel2.ColumnCount = 1;
            buttonsLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonsLayoutPanel2.Controls.Add(flowLayoutPanel5, 0, 1);
            buttonsLayoutPanel2.Location = new Point(0, 10);
            buttonsLayoutPanel2.Margin = new Padding(0);
            buttonsLayoutPanel2.Name = "buttonsLayoutPanel2";
            buttonsLayoutPanel2.RowCount = 3;
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle());
            buttonsLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            buttonsLayoutPanel2.Size = new Size(150, 170);
            buttonsLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.AutoSize = true;
            flowLayoutPanel5.Controls.Add(acceptButton);
            flowLayoutPanel5.Controls.Add(resetButton);
            flowLayoutPanel5.Controls.Add(button1);
            flowLayoutPanel5.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel5.Location = new Point(0, 0);
            flowLayoutPanel5.Margin = new Padding(0);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(150, 170);
            flowLayoutPanel5.TabIndex = 0;
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
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(0, 120);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 6;
            button1.Text = "Заказ-наряд";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Location = new Point(0, 3);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(755, 184);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(flowLayoutPanel2, 4, 0);
            tableLayoutPanel4.Controls.Add(flowLayoutPanel1, 2, 0);
            tableLayoutPanel4.Controls.Add(employeeLayoutPanel, 0, 0);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(755, 62);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(comboBox2);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(509, 0);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel2.Size = new Size(245, 62);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.Location = new Point(0, 5);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(245, 25);
            label2.TabIndex = 0;
            label2.Text = "Автомобиль";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox2.BackColor = Color.White;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.System;
            comboBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(0, 30);
            comboBox2.Margin = new Padding(0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(245, 27);
            comboBox2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(comboBox1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(254, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel1.Size = new Size(245, 62);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(0, 5);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 0;
            label1.Text = "Владелец";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.System;
            comboBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(0, 30);
            comboBox1.Margin = new Padding(0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(245, 27);
            comboBox1.TabIndex = 1;
            // 
            // employeeLayoutPanel
            // 
            employeeLayoutPanel.AutoSize = true;
            employeeLayoutPanel.Controls.Add(employeeLabel);
            employeeLayoutPanel.Controls.Add(employeePicker);
            employeeLayoutPanel.FlowDirection = FlowDirection.TopDown;
            employeeLayoutPanel.Location = new Point(0, 0);
            employeeLayoutPanel.Margin = new Padding(0);
            employeeLayoutPanel.Name = "employeeLayoutPanel";
            employeeLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            employeeLayoutPanel.Size = new Size(244, 62);
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
            employeePicker.DropDownStyle = ComboBoxStyle.DropDownList;
            employeePicker.FlatStyle = FlatStyle.System;
            employeePicker.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeePicker.FormattingEnabled = true;
            employeePicker.Location = new Point(0, 30);
            employeePicker.Margin = new Padding(0);
            employeePicker.Name = "employeePicker";
            employeePicker.Size = new Size(245, 27);
            employeePicker.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 2, 0);
            tableLayoutPanel5.Controls.Add(flowLayoutPanel6, 2, 1);
            tableLayoutPanel5.Controls.Add(flowLayoutPanel4, 0, 1);
            tableLayoutPanel5.Controls.Add(postDateLayoutPanel, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 62);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle());
            tableLayoutPanel5.Size = new Size(755, 122);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.AutoSize = true;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(382, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(373, 61);
            tableLayoutPanel6.TabIndex = 11;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            checkBox1.ImageAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(0, 34);
            checkBox1.Margin = new Padding(0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(373, 23);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Завершено";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.AutoSize = true;
            flowLayoutPanel6.Controls.Add(label5);
            flowLayoutPanel6.Controls.Add(dateTimePicker3);
            flowLayoutPanel6.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel6.Location = new Point(382, 61);
            flowLayoutPanel6.Margin = new Padding(0);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel6.Size = new Size(372, 61);
            flowLayoutPanel6.TabIndex = 8;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(0, 5);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(372, 25);
            label5.TabIndex = 0;
            label5.Text = "Дата завершения работы";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePicker3.Location = new Point(0, 30);
            dateTimePicker3.Margin = new Padding(0);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(372, 26);
            dateTimePicker3.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.AutoSize = true;
            flowLayoutPanel4.Controls.Add(label4);
            flowLayoutPanel4.Controls.Add(dateTimePicker2);
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(0, 61);
            flowLayoutPanel4.Margin = new Padding(0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Padding = new Padding(0, 5, 0, 5);
            flowLayoutPanel4.Size = new Size(372, 61);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.Location = new Point(0, 5);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(372, 25);
            label4.TabIndex = 0;
            label4.Text = "Дата начала работы";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dateTimePicker2.Location = new Point(0, 30);
            dateTimePicker2.Margin = new Padding(0);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(372, 26);
            dateTimePicker2.TabIndex = 1;
            // 
            // postDateLayoutPanel
            // 
            postDateLayoutPanel.AutoSize = true;
            postDateLayoutPanel.Controls.Add(postDateLabel);
            postDateLayoutPanel.Controls.Add(postDatePicker);
            postDateLayoutPanel.FlowDirection = FlowDirection.TopDown;
            postDateLayoutPanel.Location = new Point(0, 0);
            postDateLayoutPanel.Margin = new Padding(0);
            postDateLayoutPanel.Name = "postDateLayoutPanel";
            postDateLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            postDateLayoutPanel.Size = new Size(372, 61);
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
            // suppliesTable
            // 
            suppliesTable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            suppliesTable.BackgroundColor = Color.White;
            suppliesTable.BorderStyle = BorderStyle.None;
            suppliesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suppliesTable.Cursor = Cursors.Hand;
            suppliesTable.GridColor = SystemColors.ControlDark;
            suppliesTable.Location = new Point(20, 80);
            suppliesTable.Margin = new Padding(0);
            suppliesTable.Name = "suppliesTable";
            suppliesTable.Size = new Size(920, 235);
            suppliesTable.TabIndex = 2;
            // 
            // RequestsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RequestsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заявки на ремонт";
            FormClosed += RequestsForm_FormClosed;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            buttonsLayoutPanel2.ResumeLayout(false);
            buttonsLayoutPanel2.PerformLayout();
            flowLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            employeeLayoutPanel.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            postDateLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)suppliesTable).EndInit();
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel buttonsLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel5;
        private Button acceptButton;
        private Button resetButton;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private ComboBox comboBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox comboBox1;
        private FlowLayoutPanel employeeLayoutPanel;
        private Label employeeLabel;
        private ComboBox employeePicker;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label5;
        private DateTimePicker dateTimePicker3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private FlowLayoutPanel postDateLayoutPanel;
        private Label postDateLabel;
        private DateTimePicker postDatePicker;
        private DataGridView suppliesTable;
    }
}
