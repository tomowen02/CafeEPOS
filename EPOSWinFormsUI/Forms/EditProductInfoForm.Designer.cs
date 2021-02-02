
namespace EPOSWinFormsUI.Forms
{
    partial class EditProductInfoForm
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
            this.ProductTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ProductDescriptionTextbox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.PriceTextbox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.ProductTypeLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductTypeComboBox
            // 
            this.ProductTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductTypeComboBox.FormattingEnabled = true;
            this.ProductTypeComboBox.Location = new System.Drawing.Point(161, 60);
            this.ProductTypeComboBox.Name = "ProductTypeComboBox";
            this.ProductTypeComboBox.Size = new System.Drawing.Size(173, 53);
            this.ProductTypeComboBox.TabIndex = 16;
            // 
            // ProductDescriptionTextbox
            // 
            this.ProductDescriptionTextbox.Location = new System.Drawing.Point(161, 16);
            this.ProductDescriptionTextbox.Name = "ProductDescriptionTextbox";
            this.ProductDescriptionTextbox.Size = new System.Drawing.Size(173, 50);
            this.ProductDescriptionTextbox.TabIndex = 15;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.White;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(49, 148);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(285, 47);
            this.SubmitButton.TabIndex = 21;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // PriceTextbox
            // 
            this.PriceTextbox.Location = new System.Drawing.Point(161, 104);
            this.PriceTextbox.Name = "PriceTextbox";
            this.PriceTextbox.Size = new System.Drawing.Size(173, 50);
            this.PriceTextbox.TabIndex = 17;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(108, 107);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(96, 45);
            this.PriceLabel.TabIndex = 20;
            this.PriceLabel.Text = "Price:";
            // 
            // ProductTypeLabel
            // 
            this.ProductTypeLabel.AutoSize = true;
            this.ProductTypeLabel.Location = new System.Drawing.Point(54, 63);
            this.ProductTypeLabel.Name = "ProductTypeLabel";
            this.ProductTypeLabel.Size = new System.Drawing.Size(209, 45);
            this.ProductTypeLabel.TabIndex = 19;
            this.ProductTypeLabel.Text = "Product type:";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(45, 19);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(226, 45);
            this.ProductNameLabel.TabIndex = 18;
            this.ProductNameLabel.Text = "Product name:";
            // 
            // EditProductInfoForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(379, 211);
            this.Controls.Add(this.ProductTypeComboBox);
            this.Controls.Add(this.ProductDescriptionTextbox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PriceTextbox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ProductTypeLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductInfoForm";
            this.Text = "Product Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductTypeComboBox;
        private System.Windows.Forms.TextBox ProductDescriptionTextbox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox PriceTextbox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label ProductTypeLabel;
        private System.Windows.Forms.Label ProductNameLabel;
    }
}