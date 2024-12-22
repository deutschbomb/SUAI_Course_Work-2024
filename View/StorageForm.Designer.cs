
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
            formLayoutPanel = new TableLayoutPanel();
            menuLayoutPanel = new FlowLayoutPanel();
            homeButton = new Button();
            returnButton = new Button();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            controlsLayoutPanel = new TableLayoutPanel();
            shortLayoutPanel = new TableLayoutPanel();
            shortLayoutPanel2 = new FlowLayoutPanel();
            balanceLayoutPanel = new FlowLayoutPanel();
            balanceLabel = new Label();
            balanceInput = new NumericUpDown();
            priceLayoutPanel = new FlowLayoutPanel();
            priceLabel = new Label();
            priceInput = new NumericUpDown();
            longLayoutPanel = new TableLayoutPanel();
            longLayoutPanel2 = new FlowLayoutPanel();
            catalogueNumberLayoutPanel = new FlowLayoutPanel();
            catalogueNumberLabel = new Label();
            catalogueNumberInput = new TextBox();
            NameLayoutPanel = new FlowLayoutPanel();
            nameLabel = new Label();
            nameInput = new TextBox();
            storageTable = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            formLayoutPanel.SuspendLayout();
            menuLayoutPanel.SuspendLayout();
            controlsLayoutPanel.SuspendLayout();
            shortLayoutPanel.SuspendLayout();
            shortLayoutPanel2.SuspendLayout();
            balanceLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)balanceInput).BeginInit();
            priceLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            longLayoutPanel.SuspendLayout();
            longLayoutPanel2.SuspendLayout();
            catalogueNumberLayoutPanel.SuspendLayout();
            NameLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storageTable).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(menuLayoutPanel, 0, 0);
            formLayoutPanel.Controls.Add(controlsLayoutPanel, 0, 4);
            formLayoutPanel.Controls.Add(storageTable, 0, 2);
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
            // controlsLayoutPanel
            // 
            controlsLayoutPanel.ColumnCount = 5;
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 600F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
            controlsLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            controlsLayoutPanel.Controls.Add(flowLayoutPanel2, 4, 0);
            controlsLayoutPanel.Controls.Add(shortLayoutPanel, 2, 0);
            controlsLayoutPanel.Controls.Add(longLayoutPanel, 0, 0);
            controlsLayoutPanel.Dock = DockStyle.Fill;
            controlsLayoutPanel.Location = new Point(20, 340);
            controlsLayoutPanel.Margin = new Padding(0);
            controlsLayoutPanel.Name = "controlsLayoutPanel";
            controlsLayoutPanel.RowCount = 1;
            controlsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            controlsLayoutPanel.Size = new Size(920, 190);
            controlsLayoutPanel.TabIndex = 1;
            // 
            // shortLayoutPanel
            // 
            shortLayoutPanel.ColumnCount = 1;
            shortLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            shortLayoutPanel.Controls.Add(shortLayoutPanel2, 0, 1);
            shortLayoutPanel.Dock = DockStyle.Fill;
            shortLayoutPanel.Location = new Point(610, 0);
            shortLayoutPanel.Margin = new Padding(0);
            shortLayoutPanel.Name = "shortLayoutPanel";
            shortLayoutPanel.RowCount = 3;
            shortLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            shortLayoutPanel.RowStyles.Add(new RowStyle());
            shortLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            shortLayoutPanel.Size = new Size(150, 190);
            shortLayoutPanel.TabIndex = 5;
            // 
            // shortLayoutPanel2
            // 
            shortLayoutPanel2.Controls.Add(balanceLayoutPanel);
            shortLayoutPanel2.Controls.Add(priceLayoutPanel);
            shortLayoutPanel2.Dock = DockStyle.Fill;
            shortLayoutPanel2.Location = new Point(0, 30);
            shortLayoutPanel2.Margin = new Padding(0);
            shortLayoutPanel2.Name = "shortLayoutPanel2";
            shortLayoutPanel2.Size = new Size(150, 130);
            shortLayoutPanel2.TabIndex = 0;
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
            balanceLabel.Text = "Остаток";
            // 
            // balanceInput
            // 
            balanceInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            balanceInput.BorderStyle = BorderStyle.FixedSingle;
            balanceInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            balanceInput.Location = new Point(0, 30);
            balanceInput.Margin = new Padding(0);
            balanceInput.Name = "balanceInput";
            balanceInput.Size = new Size(150, 26);
            balanceInput.TabIndex = 1;
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
            priceLabel.Text = "Цена за штуку";
            // 
            // priceInput
            // 
            priceInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            priceInput.BorderStyle = BorderStyle.FixedSingle;
            priceInput.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            priceInput.Location = new Point(0, 30);
            priceInput.Margin = new Padding(0);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(150, 26);
            priceInput.TabIndex = 2;
            // 
            // longLayoutPanel
            // 
            longLayoutPanel.ColumnCount = 1;
            longLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            longLayoutPanel.Controls.Add(longLayoutPanel2, 0, 1);
            longLayoutPanel.Location = new Point(0, 0);
            longLayoutPanel.Margin = new Padding(0);
            longLayoutPanel.Name = "longLayoutPanel";
            longLayoutPanel.RowCount = 3;
            longLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            longLayoutPanel.RowStyles.Add(new RowStyle());
            longLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            longLayoutPanel.Size = new Size(600, 170);
            longLayoutPanel.TabIndex = 4;
            // 
            // longLayoutPanel2
            // 
            longLayoutPanel2.Controls.Add(catalogueNumberLayoutPanel);
            longLayoutPanel2.Controls.Add(NameLayoutPanel);
            longLayoutPanel2.Location = new Point(0, 22);
            longLayoutPanel2.Margin = new Padding(0);
            longLayoutPanel2.Name = "longLayoutPanel2";
            longLayoutPanel2.Size = new Size(600, 125);
            longLayoutPanel2.TabIndex = 0;
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
            catalogueNumberInput.Name = "catalogueNumberInput";
            catalogueNumberInput.Size = new Size(600, 26);
            catalogueNumberInput.TabIndex = 1;
            // 
            // NameLayoutPanel
            // 
            NameLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NameLayoutPanel.AutoSize = true;
            NameLayoutPanel.Controls.Add(nameLabel);
            NameLayoutPanel.Controls.Add(nameInput);
            NameLayoutPanel.FlowDirection = FlowDirection.TopDown;
            NameLayoutPanel.Location = new Point(0, 61);
            NameLayoutPanel.Margin = new Padding(0);
            NameLayoutPanel.Name = "NameLayoutPanel";
            NameLayoutPanel.Padding = new Padding(0, 5, 0, 5);
            NameLayoutPanel.Size = new Size(600, 61);
            NameLayoutPanel.TabIndex = 2;
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
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(600, 26);
            nameInput.TabIndex = 1;
            // 
            // storageTable
            // 
            storageTable.BackgroundColor = Color.White;
            storageTable.BorderStyle = BorderStyle.None;
            storageTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            storageTable.Cursor = Cursors.Hand;
            storageTable.GridColor = SystemColors.ControlDark;
            storageTable.Location = new Point(20, 80);
            storageTable.Margin = new Padding(0);
            storageTable.Name = "storageTable";
            storageTable.Size = new Size(920, 240);
            storageTable.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(button4);
            flowLayoutPanel2.Controls.Add(button5);
            flowLayoutPanel2.Controls.Add(button6);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(770, 10);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(150, 170);
            flowLayoutPanel2.TabIndex = 8;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button4.BackColor = SystemColors.MenuHighlight;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(150, 50);
            button4.TabIndex = 2;
            button4.Text = "Принять";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button5.BackColor = SystemColors.ScrollBar;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            button5.ForeColor = SystemColors.ControlText;
            button5.Location = new Point(0, 60);
            button5.Margin = new Padding(0, 10, 0, 10);
            button5.Name = "button5";
            button5.Size = new Size(150, 50);
            button5.TabIndex = 3;
            button5.Text = "Сбросить";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button6.BackColor = SystemColors.MenuHighlight;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            button6.ForeColor = SystemColors.ButtonFace;
            button6.Location = new Point(0, 120);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(150, 50);
            button6.TabIndex = 4;
            button6.Text = "Заказать";
            button6.UseVisualStyleBackColor = false;
            // 
            // StorageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "StorageForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склад автосервиса";
            FormClosed += StorageForm_FormClosed;
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            menuLayoutPanel.ResumeLayout(false);
            menuLayoutPanel.PerformLayout();
            controlsLayoutPanel.ResumeLayout(false);
            shortLayoutPanel.ResumeLayout(false);
            shortLayoutPanel2.ResumeLayout(false);
            shortLayoutPanel2.PerformLayout();
            balanceLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)balanceInput).EndInit();
            priceLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            longLayoutPanel.ResumeLayout(false);
            longLayoutPanel2.ResumeLayout(false);
            longLayoutPanel2.PerformLayout();
            catalogueNumberLayoutPanel.ResumeLayout(false);
            catalogueNumberLayoutPanel.PerformLayout();
            NameLayoutPanel.ResumeLayout(false);
            NameLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)storageTable).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formLayoutPanel;
        private FlowLayoutPanel menuLayoutPanel;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Button homeButton;
        private Button returnButton;
        private TableLayoutPanel controlsLayoutPanel;
        private TableLayoutPanel longLayoutPanel;
        private FlowLayoutPanel catalogueNumberLayoutPanel;
        private Label catalogueNumberLabel;
        private TextBox catalogueNumberInput;
        private FlowLayoutPanel longLayoutPanel2;
        private FlowLayoutPanel NameLayoutPanel;
        private Label nameLabel;
        private TextBox nameInput;
        private TableLayoutPanel shortLayoutPanel;
        private FlowLayoutPanel shortLayoutPanel2;
        private FlowLayoutPanel balanceLayoutPanel;
        private Label balanceLabel;
        private FlowLayoutPanel priceLayoutPanel;
        private Label priceLabel;
        private NumericUpDown balanceInput;
        private NumericUpDown priceInput;
        private DataGridView storageTable;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
