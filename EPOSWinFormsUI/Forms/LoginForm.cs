using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EPOSLibrary;
using EPOSLibrary.DataAccess;
using EPOSLibrary.LoginSystem;
using EPOSLibrary.Models;

namespace EPOSWinFormsUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            UsernameTextBox.Select();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignIn();
        }

        private void SignIn()
        {
            string username = UsernameTextBox.Text.Trim(); // Ignores the spaces before or after the username
            string password = PasswordTextBox.Text;

            if (username != "") // Make sure that there is text inside of the input box
            {
                EmployeeModel user = EmployeeDataAccess.Load(username); // Load the user profile to see if the user exists

                if (UserLogin.AuthenticateUserCreds(username, password)) // The AuthenticateUserCreds method returns true if the credentials are correct
                {
                    // The login credentials are correct

                    Session.Employee = user;

                    // Open this main window, hide this login screen, and reset the login screen so that it's ready for use if a user logs out
                    Form mainWindow = new MainWindowForm(this);
                    mainWindow.Show();
                    ResetForm();
                    this.Hide(); // Hide the login form
                }
                else
                {
                    MessageBox.Show("Please provide valid login credentials");
                }
            }
        }

        private void ResetForm()
        {
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            UsernameTextBox.Select();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Move form when dragged
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MoveForm(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void BackgroundPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }

        private void LogoPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(e);
        }
        #endregion
    }
}
