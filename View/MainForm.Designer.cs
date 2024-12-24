
namespace App
{
    partial class MainForm
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
            internalLayoutPanel = new FlowLayoutPanel();
            InternalLabel = new Label();
            employeesButton = new Button();
            serviceLayoutPanel = new FlowLayoutPanel();
            ServiceLabel = new Label();
            clientsButton = new Button();
            requestsButton = new Button();
            divider1 = new Label();
            divider2 = new Label();
            partsLayoutPanel = new FlowLayoutPanel();
            PartsLabel = new Label();
            storageButton = new Button();
            logisticsButton = new Button();
            formLayoutPanel.SuspendLayout();
            internalLayoutPanel.SuspendLayout();
            serviceLayoutPanel.SuspendLayout();
            partsLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // formLayoutPanel
            // 
            formLayoutPanel.BackColor = Color.Transparent;
            formLayoutPanel.ColumnCount = 1;
            formLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            formLayoutPanel.Controls.Add(internalLayoutPanel, 0, 0);
            formLayoutPanel.Controls.Add(serviceLayoutPanel, 0, 2);
            formLayoutPanel.Controls.Add(divider1, 0, 1);
            formLayoutPanel.Controls.Add(divider2, 0, 3);
            formLayoutPanel.Controls.Add(partsLayoutPanel, 0, 4);
            formLayoutPanel.Dock = DockStyle.Fill;
            formLayoutPanel.Location = new Point(0, 0);
            formLayoutPanel.Margin = new Padding(0);
            formLayoutPanel.Name = "formLayoutPanel";
            formLayoutPanel.Padding = new Padding(20, 5, 20, 5);
            formLayoutPanel.RowCount = 5;
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.RowStyles.Add(new RowStyle());
            formLayoutPanel.Size = new Size(960, 540);
            formLayoutPanel.TabIndex = 0;
            // 
            // internalLayoutPanel
            // 
            internalLayoutPanel.AutoSize = true;
            internalLayoutPanel.Controls.Add(InternalLabel);
            internalLayoutPanel.Controls.Add(employeesButton);
            internalLayoutPanel.Dock = DockStyle.Fill;
            internalLayoutPanel.FlowDirection = FlowDirection.TopDown;
            internalLayoutPanel.Location = new Point(20, 5);
            internalLayoutPanel.Margin = new Padding(0);
            internalLayoutPanel.Name = "internalLayoutPanel";
            internalLayoutPanel.Size = new Size(920, 102);
            internalLayoutPanel.TabIndex = 0;
            // 
            // InternalLabel
            // 
            InternalLabel.BackColor = Color.Transparent;
            InternalLabel.Dock = DockStyle.Left;
            InternalLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 204);
            InternalLabel.Location = new Point(0, 5);
            InternalLabel.Margin = new Padding(0, 5, 0, 5);
            InternalLabel.Name = "InternalLabel";
            InternalLabel.Size = new Size(920, 32);
            InternalLabel.TabIndex = 0;
            InternalLabel.Text = "Автосервис";
            // 
            // employeesButton
            // 
            employeesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            employeesButton.BackColor = SystemColors.MenuHighlight;
            employeesButton.FlatStyle = FlatStyle.Flat;
            employeesButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            employeesButton.ForeColor = SystemColors.ButtonFace;
            employeesButton.Location = new Point(385, 47);
            employeesButton.Margin = new Padding(0, 5, 0, 5);
            employeesButton.Name = "employeesButton";
            employeesButton.Size = new Size(150, 50);
            employeesButton.TabIndex = 1;
            employeesButton.Text = "Сотрудники";
            employeesButton.UseVisualStyleBackColor = false;
            employeesButton.Click += employeesButton_Click;
            // 
            // serviceLayoutPanel
            // 
            serviceLayoutPanel.AutoSize = true;
            serviceLayoutPanel.Controls.Add(ServiceLabel);
            serviceLayoutPanel.Controls.Add(clientsButton);
            serviceLayoutPanel.Controls.Add(requestsButton);
            serviceLayoutPanel.Dock = DockStyle.Fill;
            serviceLayoutPanel.FlowDirection = FlowDirection.TopDown;
            serviceLayoutPanel.Location = new Point(20, 138);
            serviceLayoutPanel.Margin = new Padding(0);
            serviceLayoutPanel.Name = "serviceLayoutPanel";
            serviceLayoutPanel.Size = new Size(920, 162);
            serviceLayoutPanel.TabIndex = 0;
            // 
            // ServiceLabel
            // 
            ServiceLabel.BackColor = Color.Transparent;
            ServiceLabel.Dock = DockStyle.Left;
            ServiceLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 204);
            ServiceLabel.Location = new Point(0, 5);
            ServiceLabel.Margin = new Padding(0, 5, 0, 5);
            ServiceLabel.Name = "ServiceLabel";
            ServiceLabel.Size = new Size(920, 32);
            ServiceLabel.TabIndex = 0;
            ServiceLabel.Text = "Ремонт";
            // 
            // clientsButton
            // 
            clientsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            clientsButton.BackColor = SystemColors.MenuHighlight;
            clientsButton.FlatStyle = FlatStyle.Flat;
            clientsButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            clientsButton.ForeColor = SystemColors.ButtonFace;
            clientsButton.Location = new Point(385, 47);
            clientsButton.Margin = new Padding(0, 5, 0, 5);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(150, 50);
            clientsButton.TabIndex = 1;
            clientsButton.Text = "Клиенты";
            clientsButton.UseVisualStyleBackColor = false;
            clientsButton.Click += clientsButton_Click;
            // 
            // requestsButton
            // 
            requestsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            requestsButton.BackColor = SystemColors.MenuHighlight;
            requestsButton.FlatStyle = FlatStyle.Flat;
            requestsButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            requestsButton.ForeColor = SystemColors.ButtonFace;
            requestsButton.Location = new Point(385, 107);
            requestsButton.Margin = new Padding(0, 5, 0, 5);
            requestsButton.Name = "requestsButton";
            requestsButton.Size = new Size(150, 50);
            requestsButton.TabIndex = 1;
            requestsButton.Text = "Заявки";
            requestsButton.UseVisualStyleBackColor = false;
            requestsButton.Click += requestsButton_Click;
            // 
            // divider1
            // 
            divider1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            divider1.BackColor = SystemColors.ControlDark;
            divider1.Location = new Point(20, 122);
            divider1.Margin = new Padding(0, 15, 0, 15);
            divider1.Name = "divider1";
            divider1.Size = new Size(919, 1);
            divider1.TabIndex = 3;
            // 
            // divider2
            // 
            divider2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            divider2.BackColor = SystemColors.ControlDark;
            divider2.Location = new Point(20, 315);
            divider2.Margin = new Padding(0, 15, 0, 15);
            divider2.Name = "divider2";
            divider2.Size = new Size(919, 1);
            divider2.TabIndex = 3;
            // 
            // partsLayoutPanel
            // 
            partsLayoutPanel.AutoSize = true;
            partsLayoutPanel.Controls.Add(PartsLabel);
            partsLayoutPanel.Controls.Add(storageButton);
            partsLayoutPanel.Controls.Add(logisticsButton);
            partsLayoutPanel.Dock = DockStyle.Fill;
            partsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            partsLayoutPanel.Location = new Point(20, 331);
            partsLayoutPanel.Margin = new Padding(0);
            partsLayoutPanel.Name = "partsLayoutPanel";
            partsLayoutPanel.Size = new Size(920, 204);
            partsLayoutPanel.TabIndex = 0;
            // 
            // PartsLabel
            // 
            PartsLabel.BackColor = Color.Transparent;
            PartsLabel.Dock = DockStyle.Left;
            PartsLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Regular, GraphicsUnit.Pixel, 204);
            PartsLabel.Location = new Point(0, 5);
            PartsLabel.Margin = new Padding(0, 5, 0, 5);
            PartsLabel.Name = "PartsLabel";
            PartsLabel.Size = new Size(920, 32);
            PartsLabel.TabIndex = 0;
            PartsLabel.Text = "Склад и запчасти";
            // 
            // storageButton
            // 
            storageButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            storageButton.BackColor = SystemColors.MenuHighlight;
            storageButton.FlatStyle = FlatStyle.Flat;
            storageButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            storageButton.ForeColor = SystemColors.ButtonFace;
            storageButton.Location = new Point(385, 47);
            storageButton.Margin = new Padding(0, 5, 0, 5);
            storageButton.Name = "storageButton";
            storageButton.Size = new Size(150, 50);
            storageButton.TabIndex = 1;
            storageButton.Text = "Склад";
            storageButton.UseVisualStyleBackColor = false;
            storageButton.Click += storageButton_Click;
            // 
            // logisticsButton
            // 
            logisticsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            logisticsButton.BackColor = SystemColors.MenuHighlight;
            logisticsButton.FlatStyle = FlatStyle.Flat;
            logisticsButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            logisticsButton.ForeColor = SystemColors.ButtonFace;
            logisticsButton.Location = new Point(385, 107);
            logisticsButton.Margin = new Padding(0, 5, 0, 5);
            logisticsButton.Name = "logisticsButton";
            logisticsButton.Size = new Size(150, 50);
            logisticsButton.TabIndex = 1;
            logisticsButton.Text = "Логистика";
            logisticsButton.UseVisualStyleBackColor = false;
            logisticsButton.Click += logisticsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.White;
            ClientSize = new Size(960, 540);
            Controls.Add(formLayoutPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            MaximizeBox = false;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информационная система: автосервис";
            formLayoutPanel.ResumeLayout(false);
            formLayoutPanel.PerformLayout();
            internalLayoutPanel.ResumeLayout(false);
            serviceLayoutPanel.ResumeLayout(false);
            partsLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel formLayoutPanel;
        private FlowLayoutPanel internalLayoutPanel;
        private FlowLayoutPanel serviceLayoutPanel;
        private FlowLayoutPanel partsLayoutPanel;
        private Button employeesButton;
        private Button clientsButton;
        private Button requestsButton;
        private Button storageButton;
        private Button logisticsButton;
        private Label InternalLabel;
        private Label ServiceLabel;
        private Label PartsLabel;
        private Label divider1;
        private Label divider2;
    }
}
