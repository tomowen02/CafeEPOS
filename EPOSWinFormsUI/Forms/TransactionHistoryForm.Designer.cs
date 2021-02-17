
namespace EPOSWinFormsUI.Forms
{
    partial class TransactionHistoryForm
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
            this.DeleteTypeButton = new System.Windows.Forms.Button();
            this.CloseFormButton = new System.Windows.Forms.Button();
            this.TransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.ShoppingCart = new EPOSWinFormsUI.UserControls.ShoppingCartUserControl();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteTypeButton
            // 
            this.DeleteTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTypeButton.Location = new System.Drawing.Point(12, 545);
            this.DeleteTypeButton.Name = "DeleteTypeButton";
            this.DeleteTypeButton.Size = new System.Drawing.Size(990, 54);
            this.DeleteTypeButton.TabIndex = 45;
            this.DeleteTypeButton.Text = "Delete";
            this.DeleteTypeButton.UseVisualStyleBackColor = true;
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
            // TransactionsDataGridView
            // 
            this.TransactionsDataGridView.AllowUserToAddRows = false;
            this.TransactionsDataGridView.AllowUserToDeleteRows = false;
            this.TransactionsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransactionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TransactionsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsDataGridView.Location = new System.Drawing.Point(12, 59);
            this.TransactionsDataGridView.MultiSelect = false;
            this.TransactionsDataGridView.Name = "TransactionsDataGridView";
            this.TransactionsDataGridView.ReadOnly = true;
            this.TransactionsDataGridView.RowHeadersWidth = 82;
            this.TransactionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionsDataGridView.Size = new System.Drawing.Size(642, 467);
            this.TransactionsDataGridView.TabIndex = 37;
            this.TransactionsDataGridView.SelectionChanged += new System.EventHandler(this.TransactionsDataGridView_SelectionChanged);
            // 
            // ShoppingCart
            // 
            this.ShoppingCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShoppingCart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ShoppingCart.Location = new System.Drawing.Point(674, 59);
            this.ShoppingCart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShoppingCart.Name = "ShoppingCart";
            this.ShoppingCart.Size = new System.Drawing.Size(327, 434);
            this.ShoppingCart.TabIndex = 46;
            this.ShoppingCart.Total = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(845, 504);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(39, 17);
            this.TotalLabel.TabIndex = 48;
            this.TotalLabel.Text = "Total:";
            // 
            // TotalTextbox
            // 
            this.TotalTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextbox.Location = new System.Drawing.Point(890, 501);
            this.TotalTextbox.Name = "TotalTextbox";
            this.TotalTextbox.Size = new System.Drawing.Size(111, 25);
            this.TotalTextbox.TabIndex = 47;
            this.TotalTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 35);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(178, 21);
            this.InfoLabel.TabIndex = 49;
            this.InfoLabel.Text = "Today\'s transactions are:";
            // 
            // TransactionHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.ShoppingCart);
            this.Controls.Add(this.DeleteTypeButton);
            this.Controls.Add(this.CloseFormButton);
            this.Controls.Add(this.TransactionsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TransactionHistoryForm";
            this.Text = "TransactionHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteTypeButton;
        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.DataGridView TransactionsDataGridView;
        private UserControls.ShoppingCartUserControl ShoppingCart;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.Label InfoLabel;
    }
}