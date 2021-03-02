using EPOSLibrary.DataAccess;
using EPOSLibrary.LoginSystem;
using EPOSLibrary.Models;
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
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Check values
            if (!isAllFilled())
            {
                MessageBox.Show("Please check that all values have been filled out");
                return;
            }

            // Validate password
            try
            {
                Validation.ValidatePassword(PassTextBox.Text);

                if (PassTextBox.Text != ConfirmPassTextBox.Text)
                { throw new Exception("The passwords do not match"); }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); // Display what the user needs to change
                return; // Do not let the account be saved
            }
            
            // Saving the account
            try
            {
                // Generate a random salt value
                string salt = Hashing.GenerateSalt();

                // Hash the password
                string hashedPassword = EPOSLibrary.LoginSystem.Hashing.Hash(PassTextBox.Text, salt);

                // Create the employee object
                EmployeeModel employee = new EmployeeModel()
                {
                    EmployeeUsername = UsernameTextBox.Text,
                    Firstname = FirstnameTextBox.Text,
                    Lastname = LastnameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Phone = PhoneTextBox.Text,
                    RoleID = int.Parse(RoleTextBox.Text),
                    HashedPass = hashedPassword,
                    Salt = salt,
                    isActive = true
                };

                EmployeeDataAccess.Save(employee);

                MessageBox.Show($"Success! {employee.Firstname}'s account has been added");
                this.Close();
            } catch (Exception) { throw; }
        }

        private bool isAllFilled()
        {
            bool username = UsernameTextBox.Text.Trim() != "";
            bool firstName = FirstnameTextBox.Text.Trim() != "";
            bool lastName = LastnameTextBox.Text.Trim() != "";
            bool email = EmailTextBox.Text.Trim() != "";
            bool phone = PhoneTextBox.Text.Trim() != "";
            bool role = RoleTextBox.Text.Trim() != "";
            return username && firstName && lastName && email && phone && role;
        }
    }
}
