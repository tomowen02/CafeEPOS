namespace EPOSWinFormsUI.Forms
{
    partial class ManageProductsForm
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
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.ProductTypeFilterLabel = new System.Windows.Forms.Label();
            this.ProductTypeComboBox = new System.Windows.Forms.ComboBox();
            this.NameFilterTextBox = new System.Windows.Forms.TextBox();
            this.NameFilterLabel = new System.Windows.Forms.Label();
            this.PriceFilterLabel = new System.Windows.Forms.Label();
            this.MinPriceFilterTextBox = new System.Windows.Forms.TextBox();
            this.PriceToFilterLabel = new System.Windows.Forms.Label();
            this.MaxPriceFilterTextBox = new System.Windows.Forms.TextBox();
            this.SortByComboBox = new System.Windows.Forms.ComboBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            this.ClearFiltersButton = new System.Windows.Forms.Button();
            this.ProductNameCheckBox = new System.Windows.Forms.CheckBox();
            this.PriceCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableFiltersGroupBox = new System.Windows.Forms.GroupBox();
            this.NewProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.EnableFiltersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Location = new System.Drawing.Point(12, 171);
            this.ProductsDataGridView.MultiSelect = false;
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.ReadOnly = true;
            this.ProductsDataGridView.RowHeadersWidth = 82;
            this.ProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsDataGridView.Size = new System.Drawing.Size(990, 359);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.Location = new System.Drawing.Point(12, 21);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(58, 21);
            this.FilterLabel.TabIndex = 1;
            this.FilterLabel.Text = "Filters:";
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.Location = new System.Drawing.Point(972, 12);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseFormButton.Size = new System.Drawing.Size(30, 30);
            this.CloseFormButton.TabIndex = 2;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // ProductTypeFilterLabel
            // 
            this.ProductTypeFilterLabel.AutoSize = true;
            this.ProductTypeFilterLabel.Location = new System.Drawing.Point(12, 91);
            this.ProductTypeFilterLabel.Name = "ProductTypeFilterLabel";
            this.ProductTypeFilterLabel.Size = new System.Drawing.Size(101, 21);
            this.ProductTypeFilterLabel.TabIndex = 3;
            this.ProductTypeFilterLabel.Text = "Product type:";
            // 
            // ProductTypeComboBox
            // 
            this.ProductTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductTypeComboBox.FormattingEnabled = true;
            this.ProductTypeComboBox.Location = new System.Drawing.Point(128, 88);
            this.ProductTypeComboBox.Name = "ProductTypeComboBox";
            this.ProductTypeComboBox.Size = new System.Drawing.Size(180, 29);
            this.ProductTypeComboBox.TabIndex = 4;
            this.ProductTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductTypeComboBox_SelectedIndexChanged);
            // 
            // NameFilterTextBox
            // 
            this.NameFilterTextBox.Location = new System.Drawing.Point(128, 53);
            this.NameFilterTextBox.Name = "NameFilterTextBox";
            this.NameFilterTextBox.Size = new System.Drawing.Size(180, 29);
            this.NameFilterTextBox.TabIndex = 6;
            this.NameFilterTextBox.TextChanged += new System.EventHandler(this.NameFilterTextBox_TextChanged);
            // 
            // NameFilterLabel
            // 
            this.NameFilterLabel.AutoSize = true;
            this.NameFilterLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameFilterLabel.Location = new System.Drawing.Point(12, 56);
            this.NameFilterLabel.Name = "NameFilterLabel";
            this.NameFilterLabel.Size = new System.Drawing.Size(110, 21);
            this.NameFilterLabel.TabIndex = 5;
            this.NameFilterLabel.Text = "Product name:";
            // 
            // PriceFilterLabel
            // 
            this.PriceFilterLabel.AutoSize = true;
            this.PriceFilterLabel.Location = new System.Drawing.Point(12, 126);
            this.PriceFilterLabel.Name = "PriceFilterLabel";
            this.PriceFilterLabel.Size = new System.Drawing.Size(47, 21);
            this.PriceFilterLabel.TabIndex = 7;
            this.PriceFilterLabel.Text = "Price:";
            // 
            // MinPriceFilterTextBox
            // 
            this.MinPriceFilterTextBox.Location = new System.Drawing.Point(128, 123);
            this.MinPriceFilterTextBox.Name = "MinPriceFilterTextBox";
            this.MinPriceFilterTextBox.Size = new System.Drawing.Size(72, 29);
            this.MinPriceFilterTextBox.TabIndex = 8;
            this.MinPriceFilterTextBox.TextChanged += new System.EventHandler(this.MinPriceFilterTextBox_TextChanged);
            // 
            // PriceToFilterLabel
            // 
            this.PriceToFilterLabel.AutoSize = true;
            this.PriceToFilterLabel.Location = new System.Drawing.Point(206, 126);
            this.PriceToFilterLabel.Name = "PriceToFilterLabel";
            this.PriceToFilterLabel.Size = new System.Drawing.Size(24, 21);
            this.PriceToFilterLabel.TabIndex = 9;
            this.PriceToFilterLabel.Text = "to";
            // 
            // MaxPriceFilterTextBox
            // 
            this.MaxPriceFilterTextBox.Location = new System.Drawing.Point(236, 123);
            this.MaxPriceFilterTextBox.Name = "MaxPriceFilterTextBox";
            this.MaxPriceFilterTextBox.Size = new System.Drawing.Size(72, 29);
            this.MaxPriceFilterTextBox.TabIndex = 10;
            this.MaxPriceFilterTextBox.TextChanged += new System.EventHandler(this.MaxPriceFilterTextBox_TextChanged);
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
            this.SortByComboBox.Location = new System.Drawing.Point(805, 123);
            this.SortByComboBox.Name = "SortByComboBox";
            this.SortByComboBox.Size = new System.Drawing.Size(197, 29);
            this.SortByComboBox.TabIndex = 13;
            this.SortByComboBox.SelectedIndexChanged += new System.EventHandler(this.SortByComboBox_SelectedIndexChanged);
            // 
            // SortByLabel
            // 
            this.SortByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Location = new System.Drawing.Point(736, 126);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(63, 21);
            this.SortByLabel.TabIndex = 12;
            this.SortByLabel.Text = "Sort by:";
            // 
            // ClearFiltersButton
            // 
            this.ClearFiltersButton.BackColor = System.Drawing.Color.IndianRed;
            this.ClearFiltersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFiltersButton.Location = new System.Drawing.Point(427, 53);
            this.ClearFiltersButton.Name = "ClearFiltersButton";
            this.ClearFiltersButton.Size = new System.Drawing.Size(75, 99);
            this.ClearFiltersButton.TabIndex = 15;
            this.ClearFiltersButton.Text = "Clear";
            this.ClearFiltersButton.UseVisualStyleBackColor = false;
            this.ClearFiltersButton.Click += new System.EventHandler(this.ClearFiltersButton_Click);
            // 
            // ProductNameCheckBox
            // 
            this.ProductNameCheckBox.AutoSize = true;
            this.ProductNameCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductNameCheckBox.Location = new System.Drawing.Point(15, 40);
            this.ProductNameCheckBox.Name = "ProductNameCheckBox";
            this.ProductNameCheckBox.Size = new System.Drawing.Size(12, 11);
            this.ProductNameCheckBox.TabIndex = 16;
            this.ProductNameCheckBox.UseVisualStyleBackColor = true;
            this.ProductNameCheckBox.CheckedChanged += new System.EventHandler(this.ProductNameCheckBox_CheckedChanged);
            // 
            // PriceCheckBox
            // 
            this.PriceCheckBox.AutoSize = true;
            this.PriceCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriceCheckBox.Location = new System.Drawing.Point(15, 110);
            this.PriceCheckBox.Name = "PriceCheckBox";
            this.PriceCheckBox.Size = new System.Drawing.Size(12, 11);
            this.PriceCheckBox.TabIndex = 17;
            this.PriceCheckBox.UseVisualStyleBackColor = true;
            this.PriceCheckBox.CheckedChanged += new System.EventHandler(this.PriceCheckBox_CheckedChanged);
            // 
            // ProductTypeCheckBox
            // 
            this.ProductTypeCheckBox.AutoSize = true;
            this.ProductTypeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductTypeCheckBox.Location = new System.Drawing.Point(15, 75);
            this.ProductTypeCheckBox.Name = "ProductTypeCheckBox";
            this.ProductTypeCheckBox.Size = new System.Drawing.Size(12, 11);
            this.ProductTypeCheckBox.TabIndex = 18;
            this.ProductTypeCheckBox.UseVisualStyleBackColor = true;
            this.ProductTypeCheckBox.CheckedChanged += new System.EventHandler(this.ProductTypeCheckBox_CheckedChanged);
            // 
            // EnableFiltersGroupBox
            // 
            this.EnableFiltersGroupBox.Controls.Add(this.ProductNameCheckBox);
            this.EnableFiltersGroupBox.Controls.Add(this.ProductTypeCheckBox);
            this.EnableFiltersGroupBox.Controls.Add(this.PriceCheckBox);
            this.EnableFiltersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnableFiltersGroupBox.Location = new System.Drawing.Point(314, 21);
            this.EnableFiltersGroupBox.Name = "EnableFiltersGroupBox";
            this.EnableFiltersGroupBox.Size = new System.Drawing.Size(107, 144);
            this.EnableFiltersGroupBox.TabIndex = 20;
            this.EnableFiltersGroupBox.TabStop = false;
            this.EnableFiltersGroupBox.Text = "Enable filter";
            // 
            // NewProductButton
            // 
            this.NewProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewProductButton.Location = new System.Drawing.Point(12, 545);
            this.NewProductButton.Name = "NewProductButton";
            this.NewProductButton.Size = new System.Drawing.Size(316, 54);
            this.NewProductButton.TabIndex = 21;
            this.NewProductButton.Text = "New";
            this.NewProductButton.UseVisualStyleBackColor = true;
            this.NewProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteProductButton.Location = new System.Drawing.Point(686, 545);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(316, 54);
            this.DeleteProductButton.TabIndex = 22;
            this.DeleteProductButton.Text = "Delete";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProductButton.Location = new System.Drawing.Point(349, 545);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(316, 54);
            this.EditProductButton.TabIndex = 23;
            this.EditProductButton.Text = "Edit";
            this.EditProductButton.UseVisualStyleBackColor = true;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.EditProductButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.NewProductButton);
            this.Controls.Add(this.EnableFiltersGroupBox);
            this.Controls.Add(this.ClearFiltersButton);
            this.Controls.Add(this.SortByComboBox);
            this.Controls.Add(this.SortByLabel);
            this.Controls.Add(this.MaxPriceFilterTextBox);
            this.Controls.Add(this.PriceToFilterLabel);
            this.Controls.Add(this.MinPriceFilterTextBox);
            this.Controls.Add(this.PriceFilterLabel);
            this.Controls.Add(this.NameFilterTextBox);
            this.Controls.Add(this.NameFilterLabel);
            this.Controls.Add(this.ProductTypeComboBox);
            this.Controls.Add(this.ProductTypeFilterLabel);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.ProductsDataGridView);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ManageProductsForm";
            this.Text = "ManageProductsForm";
            this.Load += new System.EventHandler(this.ManageProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.EnableFiltersGroupBox.ResumeLayout(false);
            this.EnableFiltersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsDataGridView;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Label ProductTypeFilterLabel;
        private System.Windows.Forms.ComboBox ProductTypeComboBox;
        private System.Windows.Forms.TextBox NameFilterTextBox;
        private System.Windows.Forms.Label NameFilterLabel;
        private System.Windows.Forms.Label PriceFilterLabel;
        private System.Windows.Forms.TextBox MinPriceFilterTextBox;
        private System.Windows.Forms.Label PriceToFilterLabel;
        private System.Windows.Forms.TextBox MaxPriceFilterTextBox;
        private System.Windows.Forms.ComboBox SortByComboBox;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.Button ClearFiltersButton;
        private System.Windows.Forms.CheckBox ProductNameCheckBox;
        private System.Windows.Forms.CheckBox PriceCheckBox;
        private System.Windows.Forms.CheckBox ProductTypeCheckBox;
        private System.Windows.Forms.GroupBox EnableFiltersGroupBox;
        private System.Windows.Forms.Button NewProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.Button EditProductButton;
    }
}