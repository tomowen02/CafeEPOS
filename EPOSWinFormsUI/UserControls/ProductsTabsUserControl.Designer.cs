
namespace EPOSWinFormsUI.UserControls
{
    partial class ProductsTabsUserControl
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
            this.TillTabControl = new MetroFramework.Controls.MetroTabControl();
            this.search = new MetroFramework.Controls.MetroTabPage();
            this.FilterByTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.ProductTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchProductsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TillTabControl.SuspendLayout();
            this.search.SuspendLayout();
            this.SuspendLayout();
            // 
            // TillTabControl
            // 
            this.TillTabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.TillTabControl.Controls.Add(this.search);
            this.TillTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TillTabControl.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.TillTabControl.Location = new System.Drawing.Point(0, 0);
            this.TillTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TillTabControl.Name = "TillTabControl";
            this.TillTabControl.SelectedIndex = 0;
            this.TillTabControl.Size = new System.Drawing.Size(634, 565);
            this.TillTabControl.TabIndex = 4;
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
            this.search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(626, 520);
            this.search.TabIndex = 0;
            this.search.Text = "All items/ search";
            this.search.VerticalScrollbarBarColor = true;
            this.search.VerticalScrollbarHighlightOnWheel = false;
            this.search.VerticalScrollbarSize = 1;
            // 
            // FilterByTypeCheckBox
            // 
            this.FilterByTypeCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterByTypeCheckBox.AutoSize = true;
            this.FilterByTypeCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterByTypeCheckBox.Location = new System.Drawing.Point(502, 40);
            this.FilterByTypeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FilterByTypeCheckBox.Name = "FilterByTypeCheckBox";
            this.FilterByTypeCheckBox.Size = new System.Drawing.Size(12, 11);
            this.FilterByTypeCheckBox.TabIndex = 7;
            this.FilterByTypeCheckBox.UseVisualStyleBackColor = true;
            this.FilterByTypeCheckBox.CheckedChanged += new System.EventHandler(this.FilterByTypeCheckBox_CheckedChanged);
            // 
            // ProductTypeComboBox
            // 
            this.ProductTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductTypeComboBox.FormattingEnabled = true;
            this.ProductTypeComboBox.Location = new System.Drawing.Point(522, 28);
            this.ProductTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductTypeComboBox.Name = "ProductTypeComboBox";
            this.ProductTypeComboBox.Size = new System.Drawing.Size(97, 29);
            this.ProductTypeComboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(393, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.SearchProductsFlowPanel.Location = new System.Drawing.Point(0, 67);
            this.SearchProductsFlowPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchProductsFlowPanel.Name = "SearchProductsFlowPanel";
            this.SearchProductsFlowPanel.Size = new System.Drawing.Size(619, 447);
            this.SearchProductsFlowPanel.TabIndex = 4;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Location = new System.Drawing.Point(72, 28);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(313, 29);
            this.SearchTextBox.TabIndex = 3;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchBox_Changed);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.BackColor = System.Drawing.Color.Transparent;
            this.SearchLabel.Location = new System.Drawing.Point(4, 31);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(60, 21);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search:";
            // 
            // ProductsTabsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TillTabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductsTabsUserControl";
            this.Size = new System.Drawing.Size(634, 565);
            this.TillTabControl.ResumeLayout(false);
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TillTabControl;
        private MetroFramework.Controls.MetroTabPage search;
        private System.Windows.Forms.CheckBox FilterByTypeCheckBox;
        private System.Windows.Forms.ComboBox ProductTypeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel SearchProductsFlowPanel;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Label SearchLabel;
    }
}
