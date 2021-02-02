﻿using System;
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
using EPOSLibrary.Models;

namespace EPOSWinFormsUI.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Trim() != "")
            {
                string username = UsernameTextBox.Text.Trim();
                string password = PasswordTextBox.Text;

                EmployeeModel user = EmployeeDataAccess.Load(username);

                if (user != null)
                {
                    string salt = user.Salt;

                    string hashFromDatabase = user.HashedPass;
                    string hash = Hashing.Hash(password, salt);

                    if (hash == hashFromDatabase)
                    {
                        Form mainWindow = new MainWindowForm(this);
                        mainWindow.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please provide valid credentials");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide valid username");
                }
                
            }
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
