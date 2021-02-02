namespace EPOSWinFormsUI.Forms
{
    partial class ManageUsersForm
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
            this.EnableFiltersGroupBox = new System.Windows.Forms.GroupBox();
            this.UsernameameCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceCheckBox = new System.Windows.Forms.CheckBox();
            this.SortByComboBox = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.UsernameSearchTextBox = new System.Windows.Forms.TextBox();
            this.UserNameSearchLable = new System.Windows.Forms.Label();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.SeachLabel = new System.Windows.Forms.Label();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.DeactivateUserButton = new System.Windows.Forms.Button();
            this.EnableFiltersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EnableFiltersGroupBox
            // 
            this.EnableFiltersGroupBox.Controls.Add(this.UsernameameCheckBox);
            this.EnableFiltersGroupBox.Controls.Add(this.ProductTypeCheckBox);
            this.EnableFiltersGroupBox.Controls.Add(this.PriceCheckBox);
            this.EnableFiltersGroupBox.Location = new System.Drawing.Point(314, 21);
            this.EnableFiltersGroupBox.Name = "EnableFiltersGroupBox";
            this.EnableFiltersGroupBox.Size = new System.Drawing.Size(107, 69);
            this.EnableFiltersGroupBox.TabIndex = 43;
            this.EnableFiltersGroupBox.TabStop = false;
            this.EnableFiltersGroupBox.Text = "Enable filter";
            // 
            // UsernameameCheckBox
            // 
            this.UsernameameCheckBox.AutoSize = true;
            this.UsernameameCheckBox.Location = new System.Drawing.Point(15, 42);
            this.UsernameameCheckBox.Name = "UsernameameCheckBox";
            this.UsernameameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.UsernameameCheckBox.TabIndex = 16;
            this.UsernameameCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProductTypeCheckBox
            // 
            this.ProductTypeCheckBox.AutoSize = true;
            this.ProductTypeCheckBox.Location = new System.Drawing.Point(15, 77);
            this.ProductTypeCheckBox.Name = "ProductTypeCheckBox";
            this.ProductTypeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ProductTypeCheckBox.TabIndex = 18;
            this.ProductTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // PriceCheckBox
            // 
            this.PriceCheckBox.AutoSize = true;
            this.PriceCheckBox.Location = new System.Drawing.Point(15, 112);
            this.PriceCheckBox.Name = "PriceCheckBox";
            this.PriceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.PriceCheckBox.TabIndex = 17;
            this.PriceCheckBox.UseVisualStyleBackColor = true;
            // 
            // SortByComboBox
            // 
            this.SortByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortByComboBox.FormattingEnabled = true;
            this.SortByComboBox.Items.AddRange(new object[] {
            "Default",
            "Price: Low to high",
            "Price: High to low",
            "A --> Z"});
            this.SortByComboBox.Location = new System.Drawing.Point(805, 56);
            this.SortByComboBox.Name = "SortByComboBox";
            this.SortByComboBox.Size = new System.Drawing.Size(197, 29);
            this.SortByComboBox.TabIndex = 42;
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Location = new System.Drawing.Point(736, 59);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(63, 21);
            this.SortByLabel.TabIndex = 41;
            this.SortByLabel.Text = "Sort by:";
            // 
            // UsernameSearchTextBox
            // 
            this.UsernameSearchTextBox.Location = new System.Drawing.Point(128, 53);
            this.UsernameSearchTextBox.Name = "UsernameSearchTextBox";
            this.UsernameSearchTextBox.Size = new System.Drawing.Size(180, 29);
            this.UsernameSearchTextBox.TabIndex = 40;
            // 
            // UserNameSearchLable
            // 
            this.UserNameSearchLable.AutoSize = true;
            this.UserNameSearchLable.BackColor = System.Drawing.Color.Transparent;
            this.UserNameSearchLable.Location = new System.Drawing.Point(12, 56);
            this.UserNameSearchLable.Name = "UserNameSearchLable";
            this.UserNameSearchLable.Size = new System.Drawing.Size(84, 21);
            this.UserNameSearchLable.TabIndex = 39;
            this.UserNameSearchLable.Text = "Username:";
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.Location = new System.Drawing.Point(972, 12);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseFormButton.Size = new System.Drawing.Size(30, 30);
            this.CloseFormButton.TabIndex = 38;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            // 
            // SeachLabel
            // 
            this.SeachLabel.AutoSize = true;
            this.SeachLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeachLabel.Location = new System.Drawing.Point(12, 21);
            this.SeachLabel.Name = "SeachLabel";
            this.SeachLabel.Size = new System.Drawing.Size(63, 21);
            this.SeachLabel.TabIndex = 37;
            this.SeachLabel.Text = "Search:";
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(12, 96);
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.Size = new System.Drawing.Size(990, 426);
            this.UsersDataGridView.TabIndex = 36;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(14, 536);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(260, 56);
            this.AddUserButton.TabIndex = 44;
            this.AddUserButton.Text = "Add user";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Location = new System.Drawing.Point(298, 536);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(260, 56);
            this.ChangePasswordButton.TabIndex = 45;
            this.ChangePasswordButton.Text = "Change password";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // DeactivateUserButton
            // 
            this.DeactivateUserButton.Location = new System.Drawing.Point(580, 536);
            this.DeactivateUserButton.Name = "DeactivateUserButton";
            this.DeactivateUserButton.Size = new System.Drawing.Size(260, 56);
            this.DeactivateUserButton.TabIndex = 46;
            this.DeactivateUserButton.Text = "Deactivate user";
            this.DeactivateUserButton.UseVisualStyleBackColor = true;
            this.DeactivateUserButton.Click += new System.EventHandler(this.DeactivateUserButton_Click);
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.DeactivateUserButton);
            this.Controls.Add(this.ChangePasswordButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.EnableFiltersGroupBox);
            this.Controls.Add(this.SortByComboBox);
            this.Controls.Add(this.SortByLabel);
            this.Controls.Add(this.UsernameSearchTextBox);
            this.Controls.Add(this.UserNameSearchLable);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.SeachLabel);
            this.Controls.Add(this.UsersDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageUsersForm";
            this.Text = "ManageUsersForm";
            this.EnableFiltersGroupBox.ResumeLayout(false);
            this.EnableFiltersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EnableFiltersGroupBox;
        private System.Windows.Forms.CheckBox UsernameameCheckBox;
        private System.Windows.Forms.CheckBox ProductTypeCheckBox;
        private System.Windows.Forms.CheckBox PriceCheckBox;
        private System.Windows.Forms.ComboBox SortByComboBox;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.TextBox UsernameSearchTextBox;
        private System.Windows.Forms.Label UserNameSearchLable;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label SeachLabel;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.Button DeactivateUserButton;
    }
}