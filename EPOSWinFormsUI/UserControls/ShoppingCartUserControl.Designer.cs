namespace EPOSWinFormsUI.UserControls
{
    partial class ShoppingCartUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CartListView = new System.Windows.Forms.ListView();
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CartListView
            // 
            this.CartListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Item,
            this.Qty,
            this.Rate,
            this.Price});
            this.CartListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartListView.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartListView.FullRowSelect = true;
            this.CartListView.HideSelection = false;
            this.CartListView.Location = new System.Drawing.Point(0, 0);
            this.CartListView.MultiSelect = false;
            this.CartListView.Name = "CartListView";
            this.CartListView.Size = new System.Drawing.Size(327, 430);
            this.CartListView.TabIndex = 0;
            this.CartListView.UseCompatibleStateImageBehavior = false;
            this.CartListView.View = System.Windows.Forms.View.Details;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 175;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 41;
            // 
            // Rate
            // 
            this.Rate.Text = "Rate";
            this.Rate.Width = 50;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 50;
            // 
            // ShoppingCartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartListView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ShoppingCartUserControl";
            this.Size = new System.Drawing.Size(327, 430);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView CartListView;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.ColumnHeader Price;
    }
}
