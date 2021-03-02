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
    public partial class AdminControlsForm : Form
    {
        EmployeeModel currentlySelectedEmployee = null;

        public AdminControlsForm()
        {
            InitializeComponent();

            ShowGridData();
        }

        private void ShowGridData()
        {
            List<EmployeeModel> employees = EmployeeDataAccess.LoadAll();

            UsersDataGridView.DataSource = employees;

            // Make the table more readable, and remove some of the columns
            UsersDataGridView.Columns["EmployeeUsername"].HeaderText = "Username";
            UsersDataGridView.Columns["HashedPass"].Visible = false;
            UsersDataGridView.Columns["Salt"].Visible = false;
        }

        private void UsersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // An employees information needs to be displayed in the textboxes
            // These values can then be edited
            try
            {
                if (UsersDataGridView.SelectedRows.Count > 0)
                {
                    string username = UsersDataGridView.SelectedRows[0].Cells["EmployeeUsername"].Value.ToString();
                    EmployeeModel employee = EmployeeDataAccess.Load(username);

                    currentlySelectedEmployee = employee;

                    FirstnameTextBox.Text = employee.Firstname;
                    LastnameTextBox.Text = employee.Lastname;
                    EmailTextBox.Text = employee.Email;
                    PhoneTextBox.Text = employee.Phone;
                    RoleTextBox.Text = employee.RoleID.ToString();

                    // Ensure that the correct account toggling button is visable
                    if (employee.isActive)
                    {
                        DisableUserButton.Text = "Disable User";
                    }
                    else
                    {
                        DisableUserButton.Text = "Enable User";
                    }
                }
                
            }
            catch (Exception) { }
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            // Launch the form used to create a new account
            NewEmployeeForm form = new NewEmployeeForm();
            form.ShowDialog();
            ShowGridData();
        }

        private void SaveEditsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the currently selected employee
                EmployeeModel employee = currentlySelectedEmployee;

                // Change password if a new password is specified
                string newPass = NewPassTextBox.Text;
                if (newPass != "")
                {
                    // Check if the 'confirm password' box is different
                    if (newPass != ConfirmPassTextBox.Text)
                    {
                        MessageBox.Show("The passwords do not match");
                        return;
                    }

                    // Validate the password
                    try { Validation.ValidatePassword(newPass); }
                    catch (Exception ex)
                    { 
                        // The password is not value
                        MessageBox.Show(ex.Message); // Display the reason
                        return; // Exit the method
                    }
                    // The new password is valid

                    string salt = Hashing.GenerateSalt();
                    employee.Salt = salt;
                    employee.HashedPass = Hashing.Hash(newPass, salt);
                }

                // Update the rest of the information
                employee.Firstname = FirstnameTextBox.Text;
                employee.Lastname = LastnameTextBox.Text;
                employee.Email = EmailTextBox.Text;
                employee.Phone = PhoneTextBox.Text;
                employee.RoleID = int.Parse(RoleTextBox.Text);

                EmployeeDataAccess.Update(employee);

                MessageBox.Show("Success! User updated.");
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured!");
            }

            ClearFields();
            ShowGridData();
        }

        private void ClearFields()
        {
            FirstnameTextBox.Text = "";
            LastnameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            RoleTextBox.Text = "";

            NewPassTextBox.Text = "";
            ConfirmPassTextBox.Text = "";

            currentlySelectedEmployee = null;
        }

        private void DisableUserButton_Click(object sender, EventArgs e)
        {
            // If the user profile is currently disabled, it should be enabled
            // If the user profile is currently enabled, it should be disabled
            try
            {
                if (currentlySelectedEmployee != null)
                {
                    EmployeeModel employee = currentlySelectedEmployee;

                    if (employee.isActive)
                    {
                        employee.isActive = false;
                    }
                    else
                    {
                        employee.isActive = true;
                    }
                    EmployeeDataAccess.Update(employee);
                }
            } catch (Exception) { throw; }

            ShowGridData();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
