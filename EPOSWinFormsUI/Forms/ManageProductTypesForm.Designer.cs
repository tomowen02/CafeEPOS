namespace EPOSWinFormsUI.Forms
{
    partial class ManageProductTypesForm
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
            this.SortByComboBox = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.TypeSearchTextBox = new System.Windows.Forms.TextBox();
            this.TypeSearchLabel = new System.Windows.Forms.Label();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ProductTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.EditTypeButton = new System.Windows.Forms.Button();
            this.DeleteTypeButton = new System.Windows.Forms.Button();
            this.NewTypeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SortByComboBox
            // 
            this.SortByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.SortByComboBox.TabIndex = 33;
            // 
            // SortByLabel
            // 
            this.SortByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Location = new System.Drawing.Point(736, 59);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(63, 21);
            this.SortByLabel.TabIndex = 32;
            this.SortByLabel.Text = "Sort by:";
            // 
            // TypeSearchTextBox
            // 
            this.TypeSearchTextBox.Location = new System.Drawing.Point(128, 53);
            this.TypeSearchTextBox.Name = "TypeSearchTextBox";
            this.TypeSearchTextBox.Size = new System.Drawing.Size(180, 29);
            this.TypeSearchTextBox.TabIndex = 27;
            this.TypeSearchTextBox.TextChanged += new System.EventHandler(this.Search);
            // 
            // TypeSearchLabel
            // 
            this.TypeSearchLabel.AutoSize = true;
            this.TypeSearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeSearchLabel.Location = new System.Drawing.Point(12, 56);
            this.TypeSearchLabel.Name = "TypeSearchLabel";
            this.TypeSearchLabel.Size = new System.Drawing.Size(101, 21);
            this.TypeSearchLabel.TabIndex = 26;
            this.TypeSearchLabel.Text = "Product type:";
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.Location = new System.Drawing.Point(972, 12);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseFormButton.Size = new System.Drawing.Size(30, 30);
            this.CloseFormButton.TabIndex = 23;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(12, 21);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(63, 21);
            this.SearchLabel.TabIndex = 22;
            this.SearchLabel.Text = "Search:";
            // 
            // ProductTypesDataGridView
            // 
            this.ProductTypesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductTypesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductTypesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductTypesDataGridView.Location = new System.Drawing.Point(12, 96);
            this.ProductTypesDataGridView.MultiSelect = false;
            this.ProductTypesDataGridView.Name = "ProductTypesDataGridView";
            this.ProductTypesDataGridView.ReadOnly = true;
            this.ProductTypesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductTypesDataGridView.Size = new System.Drawing.Size(990, 432);
            this.ProductTypesDataGridView.TabIndex = 21;
            // 
            // EditTypeButton
            // 
            this.EditTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditTypeButton.Location = new System.Drawing.Point(349, 545);
            this.EditTypeButton.Name = "EditTypeButton";
            this.EditTypeButton.Size = new System.Drawing.Size(316, 54);
            this.EditTypeButton.TabIndex = 36;
            this.EditTypeButton.Text = "Edit";
            this.EditTypeButton.UseVisualStyleBackColor = true;
            this.EditTypeButton.Click += new System.EventHandler(this.EditTypeButton_Click);
            // 
            // DeleteTypeButton
            // 
            this.DeleteTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTypeButton.Location = new System.Drawing.Point(686, 545);
            this.DeleteTypeButton.Name = "DeleteTypeButton";
            this.DeleteTypeButton.Size = new System.Drawing.Size(316, 54);
            this.DeleteTypeButton.TabIndex = 35;
            this.DeleteTypeButton.Text = "Delete";
            this.DeleteTypeButton.UseVisualStyleBackColor = true;
            this.DeleteTypeButton.Click += new System.EventHandler(this.DeleteTypeButton_Click);
            // 
            // NewTypeButton
            // 
            this.NewTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewTypeButton.Location = new System.Drawing.Point(12, 545);
            this.NewTypeButton.Name = "NewTypeButton";
            this.NewTypeButton.Size = new System.Drawing.Size(316, 54);
            this.NewTypeButton.TabIndex = 34;
            this.NewTypeButton.Text = "New";
            this.NewTypeButton.UseVisualStyleBackColor = true;
            this.NewTypeButton.Click += new System.EventHandler(this.NewTypeButton_Click);
            // 
            // ManageProductTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.EditTypeButton);
            this.Controls.Add(this.DeleteTypeButton);
            this.Controls.Add(this.NewTypeButton);
            this.Controls.Add(this.SortByComboBox);
            this.Controls.Add(this.SortByLabel);
            this.Controls.Add(this.TypeSearchTextBox);
            this.Controls.Add(this.TypeSearchLabel);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ProductTypesDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageProductTypesForm";
            this.Text = "ManageProductTypesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SortByComboBox;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.TextBox TypeSearchTextBox;
        private System.Windows.Forms.Label TypeSearchLabel;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.DataGridView ProductTypesDataGridView;
        private System.Windows.Forms.Button EditTypeButton;
        private System.Windows.Forms.Button DeleteTypeButton;
        private System.Windows.Forms.Button NewTypeButton;
    }
}