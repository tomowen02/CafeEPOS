using EPOSWinFormsUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOSWinFormsUI.Forms
{
    public partial class MainWindowForm : Form
    {

        // TODO - Login system

        private LoginForm _loginForm;

        public MainWindowForm()
        {
            InitializeComponent();
            InitializeSubmenus();
        }

        public MainWindowForm(LoginForm login)
        {
            InitializeComponent();
            InitializeSubmenus();

            _loginForm = login;
        }

        // Possibly redundant
        private void InitializeSubmenus()
        {
            HideSubmenus();
        }

        private void HideSubmenus()
        {
            foreach (var submenu in SideBarNavPanel.Controls)
            {
                if (submenu is Panel sub)
                {
                    sub.Visible = false;
                }
            }
        }

        private void ShowSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenus();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void OpenChildForm(Form newForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = newForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            ChildFormPanel.Controls.Add(activeForm);
            activeForm.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();
            HideSubmenus();
        }

        #region Click events
        private void OpenTillButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TillForm());
        }

        private void ShowStockManagementSubButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(StockManagementSubPanel);
        }

        #region Stock management submenu
        private void ManageProductsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageProductsForm());
        }

        private void ManageProductTypesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageProductTypesForm());
        }
        #endregion

        private void TransactionHistoryButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TransactionHistoryForm());
        }

        private void StatsButton_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CalculatorForm());
        }
        #endregion

        private void MainWindowForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_loginForm != null)
            {
                _loginForm.Close();
            }
        }
    }
}
