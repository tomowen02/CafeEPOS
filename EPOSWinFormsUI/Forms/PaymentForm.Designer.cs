namespace EPOSWinFormsUI.Forms
{
    partial class PaymentForm
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
            this.PaymentDueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentDueTextbox = new System.Windows.Forms.TextBox();
            this.AmountGivenTextbox = new System.Windows.Forms.TextBox();
            this.CashButton = new System.Windows.Forms.Button();
            this.VisaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaymentDueLabel
            // 
            this.PaymentDueLabel.AutoSize = true;
            this.PaymentDueLabel.Location = new System.Drawing.Point(43, 37);
            this.PaymentDueLabel.Name = "PaymentDueLabel";
            this.PaymentDueLabel.Size = new System.Drawing.Size(103, 21);
            this.PaymentDueLabel.TabIndex = 0;
            this.PaymentDueLabel.Text = "Payment due:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount given:";
            // 
            // PaymentDueTextbox
            // 
            this.PaymentDueTextbox.Location = new System.Drawing.Point(153, 37);
            this.PaymentDueTextbox.Name = "PaymentDueTextbox";
            this.PaymentDueTextbox.ReadOnly = true;
            this.PaymentDueTextbox.Size = new System.Drawing.Size(173, 29);
            this.PaymentDueTextbox.TabIndex = 2;
            // 
            // AmountGivenTextbox
            // 
            this.AmountGivenTextbox.Location = new System.Drawing.Point(153, 81);
            this.AmountGivenTextbox.Name = "AmountGivenTextbox";
            this.AmountGivenTextbox.Size = new System.Drawing.Size(173, 29);
            this.AmountGivenTextbox.TabIndex = 1;
            // 
            // CashButton
            // 
            this.CashButton.BackColor = System.Drawing.Color.LightGreen;
            this.CashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CashButton.Location = new System.Drawing.Point(43, 125);
            this.CashButton.Name = "CashButton";
            this.CashButton.Size = new System.Drawing.Size(130, 60);
            this.CashButton.TabIndex = 4;
            this.CashButton.Text = "Cash";
            this.CashButton.UseVisualStyleBackColor = false;
            this.CashButton.Click += new System.EventHandler(this.CashButton_Click);
            // 
            // VisaButton
            // 
            this.VisaButton.BackColor = System.Drawing.Color.LightGreen;
            this.VisaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VisaButton.Location = new System.Drawing.Point(188, 125);
            this.VisaButton.Name = "VisaButton";
            this.VisaButton.Size = new System.Drawing.Size(130, 60);
            this.VisaButton.TabIndex = 5;
            this.VisaButton.Text = "Visa";
            this.VisaButton.UseVisualStyleBackColor = false;
            this.VisaButton.Click += new System.EventHandler(this.VisaButton_Click);
            // 
            // PaymentForm
            // 
            this.AcceptButton = this.CashButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 212);
            this.Controls.Add(this.VisaButton);
            this.Controls.Add(this.CashButton);
            this.Controls.Add(this.AmountGivenTextbox);
            this.Controls.Add(this.PaymentDueTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PaymentDueLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PaymentDueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PaymentDueTextbox;
        private System.Windows.Forms.TextBox AmountGivenTextbox;
        private System.Windows.Forms.Button CashButton;
        private System.Windows.Forms.Button VisaButton;
    }
}