
namespace EPOSWinFormsUI.Forms
{
    partial class AdminControlsForm
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
            this.SaveEditsButton = new System.Windows.Forms.Button();
            this.DisableUserButton = new System.Windows.Forms.Button();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.UsersDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ConfirmPassTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPassLabel = new System.Windows.Forms.Label();
            this.NewPassTextBox = new System.Windows.Forms.TextBox();
            this.NewPassLabel = new System.Windows.Forms.Label();
            this.ChangePassLabel = new System.Windows.Forms.Label();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.LastnameTextBox = new System.Windows.Forms.TextBox();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastnameLabel = new System.Windows.Forms.Label();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
            this.EmployeeInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveEditsButton
            // 
            this.SaveEditsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveEditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEditsButton.Location = new System.Drawing.Point(672, 545);
            this.SaveEditsButton.Name = "SaveEditsButton";
            this.SaveEditsButton.Size = new System.Drawing.Size(158, 54);
            this.SaveEditsButton.TabIndex = 46;
            this.SaveEditsButton.Text = "Save changes";
            this.SaveEditsButton.UseVisualStyleBackColor = true;
            this.SaveEditsButton.Click += new System.EventHandler(this.SaveEditsButton_Click);
            // 
            // DisableUserButton
            // 
            this.DisableUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DisableUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisableUserButton.Location = new System.Drawing.Point(844, 545);
            this.DisableUserButton.Name = "DisableUserButton";
            this.DisableUserButton.Size = new System.Drawing.Size(158, 54);
            this.DisableUserButton.TabIndex = 45;
            this.DisableUserButton.Text = "Disable User";
            this.DisableUserButton.UseVisualStyleBackColor = true;
            this.DisableUserButton.Click += new System.EventHandler(this.DisableUserButton_Click);
            // 
            // NewUserButton
            // 
            this.NewUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUserButton.Location = new System.Drawing.Point(12, 545);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(642, 54);
            this.NewUserButton.TabIndex = 44;
            this.NewUserButton.Text = "New";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.Location = new System.Drawing.Point(972, 12);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseFormButton.Size = new System.Drawing.Size(30, 30);
            this.CloseFormButton.TabIndex = 39;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // UsersDataGridView
            // 
            this.UsersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGridView.Location = new System.Drawing.Point(12, 48);
            this.UsersDataGridView.MultiSelect = false;
            this.UsersDataGridView.Name = "UsersDataGridView";
            this.UsersDataGridView.ReadOnly = true;
            this.UsersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGridView.Size = new System.Drawing.Size(642, 482);
            this.UsersDataGridView.TabIndex = 37;
            this.UsersDataGridView.SelectionChanged += new System.EventHandler(this.UsersDataGridView_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "User information:";
            // 
            // EmployeeInfoGroupBox
            // 
            this.EmployeeInfoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeInfoGroupBox.Controls.Add(this.ConfirmPassTextBox);
            this.EmployeeInfoGroupBox.Controls.Add(this.ConfirmPassLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.NewPassTextBox);
            this.EmployeeInfoGroupBox.Controls.Add(this.NewPassLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.ChangePassLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.RoleTextBox);
            this.EmployeeInfoGroupBox.Controls.Add(this.PhoneTextBox);
            this.EmployeeInfoGroupBox.Controls.Add(this.EmailTextBox);
            this.EmployeeInfoGroupBox.Controls.Add(this.LastnameTextBox);
            this.EmployeeInfoGroupBox.Controls.Add(this.FirstnameTextBox);
            this.EmployeeInfoGroupBox.Controls.Add(this.RoleLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.PhoneLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.EmailLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.LastnameLabel);
            this.EmployeeInfoGroupBox.Controls.Add(this.FirstnameLabel);
            this.EmployeeInfoGroupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeInfoGroupBox.Location = new System.Drawing.Point(672, 48);
            this.EmployeeInfoGroupBox.Name = "EmployeeInfoGroupBox";
            this.EmployeeInfoGroupBox.Size = new System.Drawing.Size(330, 482);
            this.EmployeeInfoGroupBox.TabIndex = 50;
            this.EmployeeInfoGroupBox.TabStop = false;
            this.EmployeeInfoGroupBox.Text = "Employee Account Information:";
            // 
            // ConfirmPassTextBox
            // 
            this.ConfirmPassTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ConfirmPassTextBox.Location = new System.Drawing.Point(12, 422);
            this.ConfirmPassTextBox.Name = "ConfirmPassTextBox";
            this.ConfirmPassTextBox.Size = new System.Drawing.Size(312, 29);
            this.ConfirmPassTextBox.TabIndex = 16;
            // 
            // ConfirmPassLabel
            // 
            this.ConfirmPassLabel.AutoSize = true;
            this.ConfirmPassLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ConfirmPassLabel.Location = new System.Drawing.Point(8, 398);
            this.ConfirmPassLabel.Name = "ConfirmPassLabel";
            this.ConfirmPassLabel.Size = new System.Drawing.Size(141, 21);
            this.ConfirmPassLabel.TabIndex = 15;
            this.ConfirmPassLabel.Text = "Confirm password:";
            // 
            // NewPassTextBox
            // 
            this.NewPassTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NewPassTextBox.Location = new System.Drawing.Point(12, 357);
            this.NewPassTextBox.Name = "NewPassTextBox";
            this.NewPassTextBox.Size = new System.Drawing.Size(312, 29);
            this.NewPassTextBox.TabIndex = 14;
            // 
            // NewPassLabel
            // 
            this.NewPassLabel.AutoSize = true;
            this.NewPassLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NewPassLabel.Location = new System.Drawing.Point(8, 333);
            this.NewPassLabel.Name = "NewPassLabel";
            this.NewPassLabel.Size = new System.Drawing.Size(116, 21);
            this.NewPassLabel.TabIndex = 13;
            this.NewPassLabel.Text = "New password:";
            // 
            // ChangePassLabel
            // 
            this.ChangePassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePassLabel.AutoSize = true;
            this.ChangePassLabel.Location = new System.Drawing.Point(6, 303);
            this.ChangePassLabel.Name = "ChangePassLabel";
            this.ChangePassLabel.Size = new System.Drawing.Size(142, 21);
            this.ChangePassLabel.TabIndex = 10;
            this.ChangePassLabel.Text = "Change Password:";
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RoleTextBox.Location = new System.Drawing.Point(98, 178);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(226, 29);
            this.RoleTextBox.TabIndex = 9;
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PhoneTextBox.Location = new System.Drawing.Point(98, 143);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(226, 29);
            this.PhoneTextBox.TabIndex = 8;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmailTextBox.Location = new System.Drawing.Point(98, 108);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(226, 29);
            this.EmailTextBox.TabIndex = 7;
            // 
            // LastnameTextBox
            // 
            this.LastnameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LastnameTextBox.Location = new System.Drawing.Point(98, 73);
            this.LastnameTextBox.Name = "LastnameTextBox";
            this.LastnameTextBox.Size = new System.Drawing.Size(226, 29);
            this.LastnameTextBox.TabIndex = 6;
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FirstnameTextBox.Location = new System.Drawing.Point(98, 38);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(226, 29);
            this.FirstnameTextBox.TabIndex = 5;
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.RoleLabel.Location = new System.Drawing.Point(48, 181);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(44, 21);
            this.RoleLabel.TabIndex = 4;
            this.RoleLabel.Text = "Role:";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PhoneLabel.Location = new System.Drawing.Point(35, 146);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(57, 21);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmailLabel.Location = new System.Drawing.Point(41, 111);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(51, 21);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email:";
            // 
            // LastnameLabel
            // 
            this.LastnameLabel.AutoSize = true;
            this.LastnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LastnameLabel.Location = new System.Drawing.Point(8, 76);
            this.LastnameLabel.Name = "LastnameLabel";
            this.LastnameLabel.Size = new System.Drawing.Size(84, 21);
            this.LastnameLabel.TabIndex = 1;
            this.LastnameLabel.Text = "Last name:";
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FirstnameLabel.Location = new System.Drawing.Point(6, 41);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(86, 21);
            this.FirstnameLabel.TabIndex = 0;
            this.FirstnameLabel.Text = "First name:";
            // 
            // AdminControlsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.EmployeeInfoGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveEditsButton);
            this.Controls.Add(this.DisableUserButton);
            this.Controls.Add(this.NewUserButton);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.UsersDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminControlsForm";
            this.Text = "AdminControlsForm";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
            this.EmployeeInfoGroupBox.ResumeLayout(false);
            this.EmployeeInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveEditsButton;
        private System.Windows.Forms.Button DisableUserButton;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.DataGridView UsersDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox EmployeeInfoGroupBox;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label ChangePassLabel;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastnameLabel;
        private System.Windows.Forms.TextBox ConfirmPassTextBox;
        private System.Windows.Forms.Label ConfirmPassLabel;
        private System.Windows.Forms.TextBox NewPassTextBox;
        private System.Windows.Forms.Label NewPassLabel;
    }
}