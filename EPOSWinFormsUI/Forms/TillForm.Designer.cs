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
            this.RemoveButton = new System.Windows.Forms.Button();
            this.CancelTransactionButton = new System.Windows.Forms.Button();
            this.PayButton = new System.Windows.Forms.Button();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ShoppingCart = new EPOSWinFormsUI.UserControls.ShoppingCartUserControl();
            this.ProductsTabs = new EPOSWinFormsUI.UserControls.ProductsTabsUserControl();
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
            // ProductsTabs
            // 
            this.ProductsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsTabs.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProductsTabs.Location = new System.Drawing.Point(24, 14);
            this.ProductsTabs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductsTabs.Name = "ProductsTabs";
            this.ProductsTabs.Size = new System.Drawing.Size(634, 580);
            this.ProductsTabs.TabIndex = 10;
            // 
            // TillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.ProductsTabs);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.CancelTransactionButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ShoppingCart);
            this.Controls.Add(this.CloseFormButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TillForm";
            this.Text = "Till";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton;
        private UserControls.ShoppingCartUserControl ShoppingCart;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button CancelTransactionButton;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.Label TotalLabel;
        private UserControls.ProductsTabsUserControl ProductsTabs;
    }
}