namespace EPOSWinFormsUI
{
    partial class TillForm
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
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.TillTabControl = new MetroFramework.Controls.MetroTabControl();
            this.search = new MetroFramework.Controls.MetroTabPage();
            this.FilterByTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CancelTransactionButton = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ShoppingCart = new EPOSWinFormsUI.UserControls.ShoppingCartUserControl();
            this.TillTabControl.SuspendLayout();
            this.search.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseFormButton
            // 
            this.CloseFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseFormButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseFormButton.Location = new System.Drawing.Point(972, 12);
            this.CloseFormButton.Name = "CloseFormButton";
            this.CloseFormButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloseFormButton.Size = new System.Drawing.Size(30, 30);
            this.CloseFormButton.TabIndex = 0;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // TillTabControl
            // 
            this.TillTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TillTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TillTabControl.Controls.Add(this.search);
            this.TillTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.TillTabControl.Location = new System.Drawing.Point(12, 24);
            this.TillTabControl.Name = "TillTabControl";
            this.TillTabControl.SelectedIndex = 0;
            this.TillTabControl.Size = new System.Drawing.Size(644, 575);
            this.TillTabControl.TabIndex = 3;
            this.TillTabControl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TillTabControl.UseSelectable = true;
            // 
            // search
            // 
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Controls.Add(this.FilterByTypeCheckBox);
            this.search.Controls.Add(this.ProductTypeComboBox);
            this.search.Controls.Add(this.label1);
            this.search.Controls.Add(this.SearchProductsFlowPanel);
            this.search.Controls.Add(this.SearchTextBox);
            this.search.Controls.Add(this.SearchLabel);
            this.search.HorizontalScrollbarBarColor = true;
            this.search.HorizontalScrollbarHighlightOnWheel = false;
            this.search.HorizontalScrollbarSize = 1;
            this.search.Location = new System.Drawing.Point(4, 41);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(636, 530);
            this.search.TabIndex = 0;
            this.search.Text = "All items/ search";
            this.search.VerticalScrollbarBarColor = true;
            this.search.VerticalScrollbarHighlightOnWheel = false;
            this.search.VerticalScrollbarSize = 1;
            // 
            // FilterByTypeCheckBox
            // 
            this.FilterByTypeCheckBox.AutoSize = true;
            this.FilterByTypeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterByTypeCheckBox.Location = new System.Drawing.Point(449, 26);
            this.FilterByTypeCheckBox.Name = "FilterByTypeCheckBox";
            this.FilterByTypeCheckBox.Size = new System.Drawing.Size(12, 11);
            this.FilterByTypeCheckBox.TabIndex = 7;
            this.FilterByTypeCheckBox.UseVisualStyleBackColor = true;
            this.FilterByTypeCheckBox.CheckedChanged += new System.EventHandler(this.FilterByTypeCheckBox_Changed);
            // 
            // ProductTypeComboBox
            // 
            this.ProductTypeComboBox.FormattingEnabled = true;
            this.ProductTypeComboBox.Location = new System.Drawing.Point(468, 16);
            this.ProductTypeComboBox.Name = "ProductTypeComboBox";
            this.ProductTypeComboBox.Size = new System.Drawing.Size(163, 29);
            this.ProductTypeComboBox.TabIndex = 6;
            this.ProductTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductTypeComboBox_Changed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(342, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Product type:";
            // 
            // SearchProductsFlowPanel
            // 
            this.SearchProductsFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchProductsFlowPanel.AutoScroll = true;
            this.SearchProductsFlowPanel.BackColor = System.Drawing.Color.Transparent;
            this.SearchProductsFlowPanel.Location = new System.Drawing.Point(0, 63);
            this.SearchProductsFlowPanel.Name = "SearchProductsFlowPanel";
            this.SearchProductsFlowPanel.Size = new System.Drawing.Size(634, 465);
            this.SearchProductsFlowPanel.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(69, 16);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(197, 29);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchBox_Changed);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Location = new System.Drawing.Point(3, 19);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(60, 21);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Location = new System.Drawing.Point(674, 474);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(122, 57);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Remove item";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // CancelTransactionButton
            // 
            this.CancelTransactionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelTransactionButton.BackColor = System.Drawing.Color.IndianRed;
            this.CancelTransactionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelTransactionButton.Location = new System.Drawing.Point(674, 537);
            this.CancelTransactionButton.Name = "CancelTransactionButton";
            this.CancelTransactionButton.Size = new System.Drawing.Size(122, 57);
            this.CancelTransactionButton.TabIndex = 6;
            this.CancelTransactionButton.Text = "Cancel transaction";
            this.CancelTransactionButton.UseVisualStyleBackColor = false;
            this.CancelTransactionButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PayButton
            // 
            this.PayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PayButton.BackColor = System.Drawing.Color.LightGreen;
            this.PayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayButton.Location = new System.Drawing.Point(802, 474);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(199, 120);
            this.PayButton.TabIndex = 7;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextbox.Location = new System.Drawing.Point(890, 434);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.Size = new System.Drawing.Size(111, 25);
            this.TotalTextbox.TabIndex = 8;
            this.TotalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(845, 437);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(39, 17);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total:";
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShoppingCart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShoppingCart.Location = new System.Drawing.Point(674, 65);
            this.ShoppingCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Size = new System.Drawing.Size(327, 361);
            this.ShoppingCart.TabIndex = 4;
            this.ShoppingCart.Total = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.CancelTransactionButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ShoppingCart);
            this.Controls.Add(this.TillTabControl);
            this.Controls.Add(this.CloseFormButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TillForm";
            this.Text = "Till";
            this.TillTabControl.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton;
        private MetroFramework.Controls.MetroTabControl TillTabControl;
        private MetroFramework.Controls.MetroTabPage search;
        private System.Windows.Forms.FlowLayoutPanel SearchProductsFlowPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.ComboBox ProductTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox FilterByTypeCheckBox;
        private UserControls.ShoppingCartUserControl ShoppingCart;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CancelTransactionButton;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.Label TotalLabel;
    }
}