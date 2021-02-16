namespace EPOSWinFormsUI.Forms
{
    partial class CalculatorForm
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
            this.CalculatorBackPanel = new System.Windows.Forms.Panel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.CloseBacketsButton = new System.Windows.Forms.Button();
            this.OpenBacketsButton = new System.Windows.Forms.Button();
            this.PowerButton = new System.Windows.Forms.Button();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.ACButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.ExpressionTextBox = new System.Windows.Forms.TextBox();
            this.CalculatorBackPanel.SuspendLayout();
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
            this.CloseFormButton.TabIndex = 1;
            this.CloseFormButton.Text = "X";
            this.CloseFormButton.UseVisualStyleBackColor = true;
            this.CloseFormButton.Click += new System.EventHandler(this.CloseFormButton_Click);
            // 
            // CalculatorBackPanel
            // 
            this.CalculatorBackPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CalculatorBackPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CalculatorBackPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculatorBackPanel.Controls.Add(this.ResultLabel);
            this.CalculatorBackPanel.Controls.Add(this.ResultTextbox);
            this.CalculatorBackPanel.Controls.Add(this.CloseBacketsButton);
            this.CalculatorBackPanel.Controls.Add(this.OpenBacketsButton);
            this.CalculatorBackPanel.Controls.Add(this.PowerButton);
            this.CalculatorBackPanel.Controls.Add(this.SubtractButton);
            this.CalculatorBackPanel.Controls.Add(this.DivideButton);
            this.CalculatorBackPanel.Controls.Add(this.ACButton);
            this.CalculatorBackPanel.Controls.Add(this.EqualsButton);
            this.CalculatorBackPanel.Controls.Add(this.DecimalButton);
            this.CalculatorBackPanel.Controls.Add(this.ZeroButton);
            this.CalculatorBackPanel.Controls.Add(this.AddButton);
            this.CalculatorBackPanel.Controls.Add(this.ThreeButton);
            this.CalculatorBackPanel.Controls.Add(this.TwoButton);
            this.CalculatorBackPanel.Controls.Add(this.OneButton);
            this.CalculatorBackPanel.Controls.Add(this.MultiplyButton);
            this.CalculatorBackPanel.Controls.Add(this.SixButton);
            this.CalculatorBackPanel.Controls.Add(this.FiveButton);
            this.CalculatorBackPanel.Controls.Add(this.FourButton);
            this.CalculatorBackPanel.Controls.Add(this.DelButton);
            this.CalculatorBackPanel.Controls.Add(this.NineButton);
            this.CalculatorBackPanel.Controls.Add(this.EightButton);
            this.CalculatorBackPanel.Controls.Add(this.SevenButton);
            this.CalculatorBackPanel.Controls.Add(this.ExpressionTextBox);
            this.CalculatorBackPanel.Location = new System.Drawing.Point(170, 12);
            this.CalculatorBackPanel.Name = "CalculatorBackPanel";
            this.CalculatorBackPanel.Size = new System.Drawing.Size(674, 587);
            this.CalculatorBackPanel.TabIndex = 2;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(346, 66);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(56, 21);
            this.ResultLabel.TabIndex = 24;
            this.ResultLabel.Text = "Result:";
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(408, 63);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(238, 29);
            this.ResultTextbox.TabIndex = 23;
            this.ResultTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CloseBacketsButton
            // 
            this.CloseBacketsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBacketsButton.AutoSize = true;
            this.CloseBacketsButton.Location = new System.Drawing.Point(471, 202);
            this.CloseBacketsButton.Name = "CloseBacketsButton";
            this.CloseBacketsButton.Size = new System.Drawing.Size(48, 80);
            this.CloseBacketsButton.TabIndex = 22;
            this.CloseBacketsButton.Text = ")";
            this.CloseBacketsButton.UseVisualStyleBackColor = true;
            this.CloseBacketsButton.Click += new System.EventHandler(this.CloseBacketsButton_Click);
            // 
            // OpenBacketsButton
            // 
            this.OpenBacketsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenBacketsButton.AutoSize = true;
            this.OpenBacketsButton.Location = new System.Drawing.Point(408, 202);
            this.OpenBacketsButton.Name = "OpenBacketsButton";
            this.OpenBacketsButton.Size = new System.Drawing.Size(48, 80);
            this.OpenBacketsButton.TabIndex = 21;
            this.OpenBacketsButton.Text = "(";
            this.OpenBacketsButton.UseVisualStyleBackColor = true;
            this.OpenBacketsButton.Click += new System.EventHandler(this.OpenBacketsButton_Click);
            // 
            // PowerButton
            // 
            this.PowerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerButton.AutoSize = true;
            this.PowerButton.Location = new System.Drawing.Point(535, 202);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(111, 80);
            this.PowerButton.TabIndex = 20;
            this.PowerButton.Text = "^";
            this.PowerButton.UseVisualStyleBackColor = true;
            this.PowerButton.Click += new System.EventHandler(this.PowerButton_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtractButton.AutoSize = true;
            this.SubtractButton.Location = new System.Drawing.Point(535, 392);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(111, 80);
            this.SubtractButton.TabIndex = 19;
            this.SubtractButton.Text = "-";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DivideButton.AutoSize = true;
            this.DivideButton.Location = new System.Drawing.Point(535, 297);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(111, 80);
            this.DivideButton.TabIndex = 18;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // ACButton
            // 
            this.ACButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ACButton.AutoSize = true;
            this.ACButton.Location = new System.Drawing.Point(535, 107);
            this.ACButton.Name = "ACButton";
            this.ACButton.Size = new System.Drawing.Size(111, 80);
            this.ACButton.TabIndex = 17;
            this.ACButton.Text = "AC";
            this.ACButton.UseVisualStyleBackColor = true;
            this.ACButton.Click += new System.EventHandler(this.ACButton_Click);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EqualsButton.AutoSize = true;
            this.EqualsButton.Location = new System.Drawing.Point(408, 487);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(238, 80);
            this.EqualsButton.TabIndex = 16;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecimalButton.AutoSize = true;
            this.DecimalButton.Location = new System.Drawing.Point(154, 392);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(111, 80);
            this.DecimalButton.TabIndex = 14;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZeroButton.AutoSize = true;
            this.ZeroButton.Location = new System.Drawing.Point(27, 392);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(111, 80);
            this.ZeroButton.TabIndex = 13;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.AutoSize = true;
            this.AddButton.Location = new System.Drawing.Point(408, 392);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 80);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ThreeButton.AutoSize = true;
            this.ThreeButton.Location = new System.Drawing.Point(281, 297);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(111, 80);
            this.ThreeButton.TabIndex = 11;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TwoButton.AutoSize = true;
            this.TwoButton.Location = new System.Drawing.Point(154, 297);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(111, 80);
            this.TwoButton.TabIndex = 10;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneButton.AutoSize = true;
            this.OneButton.Location = new System.Drawing.Point(27, 297);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(111, 80);
            this.OneButton.TabIndex = 9;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplyButton.AutoSize = true;
            this.MultiplyButton.Location = new System.Drawing.Point(408, 297);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(111, 80);
            this.MultiplyButton.TabIndex = 8;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SixButton.AutoSize = true;
            this.SixButton.Location = new System.Drawing.Point(281, 202);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(111, 80);
            this.SixButton.TabIndex = 7;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiveButton.AutoSize = true;
            this.FiveButton.Location = new System.Drawing.Point(154, 202);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(111, 80);
            this.FiveButton.TabIndex = 6;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FourButton.AutoSize = true;
            this.FourButton.Location = new System.Drawing.Point(27, 202);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(111, 80);
            this.FourButton.TabIndex = 5;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // DelButton
            // 
            this.DelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DelButton.AutoSize = true;
            this.DelButton.Location = new System.Drawing.Point(408, 107);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(111, 80);
            this.DelButton.TabIndex = 4;
            this.DelButton.Text = "DEL";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NineButton.AutoSize = true;
            this.NineButton.Location = new System.Drawing.Point(281, 107);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(111, 80);
            this.NineButton.TabIndex = 3;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EightButton.AutoSize = true;
            this.EightButton.Location = new System.Drawing.Point(154, 107);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(111, 80);
            this.EightButton.TabIndex = 2;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SevenButton.AutoSize = true;
            this.SevenButton.Location = new System.Drawing.Point(27, 107);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(111, 80);
            this.SevenButton.TabIndex = 1;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // ExpressionTextBox
            // 
            this.ExpressionTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpressionTextBox.Location = new System.Drawing.Point(27, 18);
            this.ExpressionTextBox.Name = "ExpressionTextBox";
            this.ExpressionTextBox.Size = new System.Drawing.Size(619, 39);
            this.ExpressionTextBox.TabIndex = 0;
            this.ExpressionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1014, 611);
            this.Controls.Add(this.CalculatorBackPanel);
            this.Controls.Add(this.CloseFormButton);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.CalculatorBackPanel.ResumeLayout(false);
            this.CalculatorBackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CloseFormButton;
        private System.Windows.Forms.Panel CalculatorBackPanel;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.TextBox ExpressionTextBox;
        private System.Windows.Forms.Button SubtractButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button ACButton;
        private System.Windows.Forms.Button PowerButton;
        private System.Windows.Forms.Button CloseBacketsButton;
        private System.Windows.Forms.Button OpenBacketsButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextbox;
    }
}