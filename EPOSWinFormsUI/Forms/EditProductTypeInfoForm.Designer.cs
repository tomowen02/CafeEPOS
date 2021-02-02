
namespace EPOSWinFormsUI.Forms
{
    partial class EditProductTypeInfoForm
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
            this.ProductTypeTextbox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ColourTextbox = new System.Windows.Forms.TextBox();
            this.ColourLabel = new System.Windows.Forms.Label();
            this.ProductTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProductTypeTextbox
            // 
            this.ProductTypeTextbox.Location = new System.Drawing.Point(161, 16);
            this.ProductTypeTextbox.Name = "ProductTypeTextbox";
            this.ProductTypeTextbox.Size = new System.Drawing.Size(173, 29);
            this.ProductTypeTextbox.TabIndex = 22;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.White;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Location = new System.Drawing.Point(49, 104);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(285, 47);
            this.SubmitButton.TabIndex = 28;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ColourTextbox
            // 
            this.ColourTextbox.Location = new System.Drawing.Point(161, 60);
            this.ColourTextbox.Name = "ColourTextbox";
            this.ColourTextbox.Size = new System.Drawing.Size(173, 29);
            this.ColourTextbox.TabIndex = 24;
            // 
            // ColourLabel
            // 
            this.ColourLabel.AutoSize = true;
            this.ColourLabel.Location = new System.Drawing.Point(95, 63);
            this.ColourLabel.Name = "ColourLabel";
            this.ColourLabel.Size = new System.Drawing.Size(60, 21);
            this.ColourLabel.TabIndex = 27;
            this.ColourLabel.Text = "Colour:";
            // 
            // ProductTypeLabel
            // 
            this.ProductTypeLabel.AutoSize = true;
            this.ProductTypeLabel.Location = new System.Drawing.Point(54, 19);
            this.ProductTypeLabel.Name = "ProductTypeLabel";
            this.ProductTypeLabel.Size = new System.Drawing.Size(101, 21);
            this.ProductTypeLabel.TabIndex = 25;
            this.ProductTypeLabel.Text = "Product type:";
            // 
            // EditProductTypeInfoForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 170);
            this.Controls.Add(this.ProductTypeTextbox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.ColourTextbox);
            this.Controls.Add(this.ColourLabel);
            this.Controls.Add(this.ProductTypeLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditProductTypeInfoForm";
            this.Text = "EditTypeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductTypeTextbox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.TextBox ColourTextbox;
        private System.Windows.Forms.Label ColourLabel;
        private System.Windows.Forms.Label ProductTypeLabel;
    }
}