namespace EPOSWinFormsUI.Forms
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.SideBarNavPanel = new System.Windows.Forms.Panel();
            this.AdminControlsButton = new System.Windows.Forms.Button();
            this.CalculatorButton = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.TransactionHistoryButton = new System.Windows.Forms.Button();
            this.StockManagementSubPanel = new System.Windows.Forms.Panel();
            this.ManageProductTypesButton = new System.Windows.Forms.Button();
            this.ManageProductsButton = new System.Windows.Forms.Button();
            this.ShowStockManagementSubButton = new System.Windows.Forms.Button();
            this.OpenTillButton = new System.Windows.Forms.Button();
            this.SessionPanel = new System.Windows.Forms.Panel();
            this.ShowUserOptionsButton = new System.Windows.Forms.Button();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIconPictureBox = new System.Windows.Forms.PictureBox();
            this.UnderSideLogoPanel = new System.Windows.Forms.Panel();
            this.SideLogoPicture = new System.Windows.Forms.PictureBox();
            this.ChildFormPanel = new System.Windows.Forms.Panel();
            this.MainLogoPicture = new System.Windows.Forms.PictureBox();
            this.LogOutContextButton = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LogOutStripButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SideBarPanel.SuspendLayout();
            this.SideBarNavPanel.SuspendLayout();
            this.StockManagementSubPanel.SuspendLayout();
            this.SessionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideLogoPicture)).BeginInit();
            this.ChildFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainLogoPicture)).BeginInit();
            this.LogOutContextButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.SideBarPanel.Controls.Add(this.SideBarNavPanel);
            this.SideBarPanel.Controls.Add(this.SessionPanel);
            this.SideBarPanel.Controls.Add(this.UnderSideLogoPanel);
            this.SideBarPanel.Controls.Add(this.SideLogoPicture);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(270, 611);
            this.SideBarPanel.TabIndex = 1;
            // 
            // SideBarNavPanel
            // 
            this.SideBarNavPanel.AutoScroll = true;
            this.SideBarNavPanel.Controls.Add(this.AdminControlsButton);
            this.SideBarNavPanel.Controls.Add(this.CalculatorButton);
            this.SideBarNavPanel.Controls.Add(this.StatsButton);
            this.SideBarNavPanel.Controls.Add(this.TransactionHistoryButton);
            this.SideBarNavPanel.Controls.Add(this.StockManagementSubPanel);
            this.SideBarNavPanel.Controls.Add(this.ShowStockManagementSubButton);
            this.SideBarNavPanel.Controls.Add(this.OpenTillButton);
            this.SideBarNavPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SideBarNavPanel.Location = new System.Drawing.Point(0, 201);
            this.SideBarNavPanel.Name = "SideBarNavPanel";
            this.SideBarNavPanel.Size = new System.Drawing.Size(270, 345);
            this.SideBarNavPanel.TabIndex = 7;
            // 
            // AdminControlsButton
            // 
            this.AdminControlsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminControlsButton.FlatAppearance.BorderSize = 0;
            this.AdminControlsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminControlsButton.ForeColor = System.Drawing.Color.White;
            this.AdminControlsButton.Location = new System.Drawing.Point(0, 325);
            this.AdminControlsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AdminControlsButton.Name = "AdminControlsButton";
            this.AdminControlsButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.AdminControlsButton.Size = new System.Drawing.Size(253, 46);
            this.AdminControlsButton.TabIndex = 13;
            this.AdminControlsButton.Text = "Admin Controls";
            this.AdminControlsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminControlsButton.UseVisualStyleBackColor = true;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CalculatorButton.FlatAppearance.BorderSize = 0;
            this.CalculatorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalculatorButton.ForeColor = System.Drawing.Color.White;
            this.CalculatorButton.Location = new System.Drawing.Point(0, 279);
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.CalculatorButton.Size = new System.Drawing.Size(253, 46);
            this.CalculatorButton.TabIndex = 12;
            this.CalculatorButton.Text = "Calculator";
            this.CalculatorButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculatorButton.UseVisualStyleBackColor = true;
            this.CalculatorButton.Click += new System.EventHandler(this.CalculatorButton_Click);
            // 
            // StatsButton
            // 
            this.StatsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatsButton.FlatAppearance.BorderSize = 0;
            this.StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsButton.ForeColor = System.Drawing.Color.White;
            this.StatsButton.Location = new System.Drawing.Point(0, 233);
            this.StatsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.StatsButton.Size = new System.Drawing.Size(253, 46);
            this.StatsButton.TabIndex = 11;
            this.StatsButton.Text = "Statistics";
            this.StatsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatsButton.UseVisualStyleBackColor = true;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // TransactionHistoryButton
            // 
            this.TransactionHistoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.TransactionHistoryButton.FlatAppearance.BorderSize = 0;
            this.TransactionHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionHistoryButton.ForeColor = System.Drawing.Color.White;
            this.TransactionHistoryButton.Location = new System.Drawing.Point(0, 187);
            this.TransactionHistoryButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TransactionHistoryButton.Name = "TransactionHistoryButton";
            this.TransactionHistoryButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.TransactionHistoryButton.Size = new System.Drawing.Size(253, 46);
            this.TransactionHistoryButton.TabIndex = 10;
            this.TransactionHistoryButton.Text = "Transaction History";
            this.TransactionHistoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionHistoryButton.UseVisualStyleBackColor = true;
            this.TransactionHistoryButton.Click += new System.EventHandler(this.TransactionHistoryButton_Click);
            // 
            // StockManagementSubPanel
            // 
            this.StockManagementSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.StockManagementSubPanel.Controls.Add(this.ManageProductTypesButton);
            this.StockManagementSubPanel.Controls.Add(this.ManageProductsButton);
            this.StockManagementSubPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StockManagementSubPanel.Location = new System.Drawing.Point(0, 92);
            this.StockManagementSubPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.StockManagementSubPanel.Name = "StockManagementSubPanel";
            this.StockManagementSubPanel.Size = new System.Drawing.Size(253, 95);
            this.StockManagementSubPanel.TabIndex = 7;
            // 
            // ManageProductTypesButton
            // 
            this.ManageProductTypesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageProductTypesButton.FlatAppearance.BorderSize = 0;
            this.ManageProductTypesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageProductTypesButton.ForeColor = System.Drawing.Color.White;
            this.ManageProductTypesButton.Location = new System.Drawing.Point(0, 46);
            this.ManageProductTypesButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ManageProductTypesButton.Name = "ManageProductTypesButton";
            this.ManageProductTypesButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.ManageProductTypesButton.Size = new System.Drawing.Size(253, 46);
            this.ManageProductTypesButton.TabIndex = 5;
            this.ManageProductTypesButton.Text = "Manage Product Types";
            this.ManageProductTypesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageProductTypesButton.UseVisualStyleBackColor = true;
            this.ManageProductTypesButton.Click += new System.EventHandler(this.ManageProductTypesButton_Click);
            // 
            // ManageProductsButton
            // 
            this.ManageProductsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ManageProductsButton.FlatAppearance.BorderSize = 0;
            this.ManageProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageProductsButton.ForeColor = System.Drawing.Color.White;
            this.ManageProductsButton.Location = new System.Drawing.Point(0, 0);
            this.ManageProductsButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ManageProductsButton.Name = "ManageProductsButton";
            this.ManageProductsButton.Padding = new System.Windows.Forms.Padding(29, 0, 0, 0);
            this.ManageProductsButton.Size = new System.Drawing.Size(253, 46);
            this.ManageProductsButton.TabIndex = 4;
            this.ManageProductsButton.Text = "Manage products";
            this.ManageProductsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageProductsButton.UseVisualStyleBackColor = true;
            this.ManageProductsButton.Click += new System.EventHandler(this.ManageProductsButton_Click);
            // 
            // ShowStockManagementSubButton
            // 
            this.ShowStockManagementSubButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ShowStockManagementSubButton.FlatAppearance.BorderSize = 0;
            this.ShowStockManagementSubButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowStockManagementSubButton.ForeColor = System.Drawing.Color.White;
            this.ShowStockManagementSubButton.Location = new System.Drawing.Point(0, 46);
            this.ShowStockManagementSubButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ShowStockManagementSubButton.Name = "ShowStockManagementSubButton";
            this.ShowStockManagementSubButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.ShowStockManagementSubButton.Size = new System.Drawing.Size(253, 46);
            this.ShowStockManagementSubButton.TabIndex = 9;
            this.ShowStockManagementSubButton.Text = "Stock Management";
            this.ShowStockManagementSubButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowStockManagementSubButton.UseVisualStyleBackColor = true;
            this.ShowStockManagementSubButton.Click += new System.EventHandler(this.ShowStockManagementSubButton_Click);
            // 
            // OpenTillButton
            // 
            this.OpenTillButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.OpenTillButton.FlatAppearance.BorderSize = 0;
            this.OpenTillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenTillButton.ForeColor = System.Drawing.Color.White;
            this.OpenTillButton.Location = new System.Drawing.Point(0, 0);
            this.OpenTillButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OpenTillButton.Name = "OpenTillButton";
            this.OpenTillButton.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.OpenTillButton.Size = new System.Drawing.Size(253, 46);
            this.OpenTillButton.TabIndex = 8;
            this.OpenTillButton.Text = "Open Till";
            this.OpenTillButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenTillButton.UseVisualStyleBackColor = true;
            this.OpenTillButton.Click += new System.EventHandler(this.OpenTillButton_Click);
            // 
            // SessionPanel
            // 
            this.SessionPanel.Controls.Add(this.ShowUserOptionsButton);
            this.SessionPanel.Controls.Add(this.EmployeeNameLabel);
            this.SessionPanel.Controls.Add(this.EmployeeIconPictureBox);
            this.SessionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SessionPanel.Location = new System.Drawing.Point(0, 546);
            this.SessionPanel.Name = "SessionPanel";
            this.SessionPanel.Size = new System.Drawing.Size(270, 65);
            this.SessionPanel.TabIndex = 13;
            // 
            // ShowUserOptionsButton
            // 
            this.ShowUserOptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowUserOptionsButton.ForeColor = System.Drawing.Color.White;
            this.ShowUserOptionsButton.Location = new System.Drawing.Point(214, 17);
            this.ShowUserOptionsButton.Name = "ShowUserOptionsButton";
            this.ShowUserOptionsButton.Size = new System.Drawing.Size(39, 31);
            this.ShowUserOptionsButton.TabIndex = 2;
            this.ShowUserOptionsButton.Text = "☰";
            this.ShowUserOptionsButton.UseVisualStyleBackColor = true;
            this.ShowUserOptionsButton.Click += new System.EventHandler(this.ShowUserOptionsButton_Click);
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(58, 22);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(121, 21);
            this.EmployeeNameLabel.TabIndex = 1;
            this.EmployeeNameLabel.Text = "James Timpson";
            // 
            // EmployeeIconPictureBox
            // 
            this.EmployeeIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("EmployeeIconPictureBox.Image")));
            this.EmployeeIconPictureBox.Location = new System.Drawing.Point(12, 15);
            this.EmployeeIconPictureBox.Name = "EmployeeIconPictureBox";
            this.EmployeeIconPictureBox.Size = new System.Drawing.Size(40, 40);
            this.EmployeeIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EmployeeIconPictureBox.TabIndex = 0;
            this.EmployeeIconPictureBox.TabStop = false;
            // 
            // UnderSideLogoPanel
            // 
            this.UnderSideLogoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UnderSideLogoPanel.Location = new System.Drawing.Point(0, 143);
            this.UnderSideLogoPanel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.UnderSideLogoPanel.Name = "UnderSideLogoPanel";
            this.UnderSideLogoPanel.Size = new System.Drawing.Size(270, 58);
            this.UnderSideLogoPanel.TabIndex = 3;
            // 
            // SideLogoPicture
            // 
            this.SideLogoPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.SideLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("SideLogoPicture.Image")));
            this.SideLogoPicture.Location = new System.Drawing.Point(0, 0);
            this.SideLogoPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SideLogoPicture.Name = "SideLogoPicture";
            this.SideLogoPicture.Size = new System.Drawing.Size(270, 143);
            this.SideLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SideLogoPicture.TabIndex = 3;
            this.SideLogoPicture.TabStop = false;
            // 
            // ChildFormPanel
            // 
            this.ChildFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.ChildFormPanel.Controls.Add(this.MainLogoPicture);
            this.ChildFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildFormPanel.Location = new System.Drawing.Point(270, 0);
            this.ChildFormPanel.Name = "ChildFormPanel";
            this.ChildFormPanel.Size = new System.Drawing.Size(1014, 611);
            this.ChildFormPanel.TabIndex = 1;
            // 
            // MainLogoPicture
            // 
            this.MainLogoPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("MainLogoPicture.Image")));
            this.MainLogoPicture.Location = new System.Drawing.Point(369, 167);
            this.MainLogoPicture.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MainLogoPicture.Name = "MainLogoPicture";
            this.MainLogoPicture.Size = new System.Drawing.Size(277, 277);
            this.MainLogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainLogoPicture.TabIndex = 3;
            this.MainLogoPicture.TabStop = false;
            // 
            // LogOutContextButton
            // 
            this.LogOutContextButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LogOutStripButton});
            this.LogOutContextButton.Name = "LogOutContextButton";
            this.LogOutContextButton.Size = new System.Drawing.Size(181, 48);
            // 
            // LogOutStripButton
            // 
            this.LogOutStripButton.Name = "LogOutStripButton";
            this.LogOutStripButton.Size = new System.Drawing.Size(180, 22);
            this.LogOutStripButton.Text = "Log out";
            this.LogOutStripButton.Click += new System.EventHandler(this.LogOutStripButton_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.ChildFormPanel);
            this.Controls.Add(this.SideBarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1014, 550);
            this.Name = "MainWindowForm";
            this.Text = "Cafe EPOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindowForm_FormClosing);
            this.SideBarPanel.ResumeLayout(false);
            this.SideBarNavPanel.ResumeLayout(false);
            this.StockManagementSubPanel.ResumeLayout(false);
            this.SessionPanel.ResumeLayout(false);
            this.SessionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeIconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SideLogoPicture)).EndInit();
            this.ChildFormPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainLogoPicture)).EndInit();
            this.LogOutContextButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SideBarPanel;
        private System.Windows.Forms.PictureBox SideLogoPicture;
        private System.Windows.Forms.Panel UnderSideLogoPanel;
        private System.Windows.Forms.Panel ChildFormPanel;
        private System.Windows.Forms.Panel SideBarNavPanel;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.Button TransactionHistoryButton;
        private System.Windows.Forms.Panel StockManagementSubPanel;
        private System.Windows.Forms.Button ManageProductTypesButton;
        private System.Windows.Forms.Button ManageProductsButton;
        private System.Windows.Forms.Button ShowStockManagementSubButton;
        private System.Windows.Forms.Button OpenTillButton;
        private System.Windows.Forms.PictureBox MainLogoPicture;
        private System.Windows.Forms.Button CalculatorButton;
        private System.Windows.Forms.Panel SessionPanel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.PictureBox EmployeeIconPictureBox;
        private System.Windows.Forms.Button AdminControlsButton;
        private System.Windows.Forms.ContextMenuStrip LogOutContextButton;
        private System.Windows.Forms.ToolStripMenuItem LogOutStripButton;
        private System.Windows.Forms.Button ShowUserOptionsButton;
    }
}