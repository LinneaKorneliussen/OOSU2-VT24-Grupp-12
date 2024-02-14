using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientBL;
using PatientEntities;


namespace PatientMSWinForms
{
    public partial class LogInForm : Form
    {
        private LoginController loginController;
        public LogInForm()
        {
            InitializeComponent();
            loginController = new LoginController();
        }

        #region Log in click
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string staffIdInput = txtStaffID.Text;
            string password = txtPassword.Text;

            if (IsValidInteger(staffIdInput))
            {
                int staffId = int.Parse(staffIdInput);
                pictureLoading.Visible = true;

                bool user = loginController.AuthorizeUser(staffId, password);
                if (user)
                {
                    MessageBox.Show($"You are logged in as Caregiver: {loginController.LoggedIn.OccupationalRole} {loginController.LoggedIn.StaffName}");

                    MenuViewForm menu = new MenuViewForm();
                    menu.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Failed to log in. Try again!");
                }
                pictureLoading.Visible = false;
            }
            else
            {
                MessageBox.Show("Invalid Staff ID. Please enter a valid integer.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffID.Clear();
            txtPassword.Clear();    
        }
        #endregion

        #region Log in validation
        private bool IsValidInteger(string input)
        {
            return int.TryParse(input, out _);
        }
        #endregion

    }
}
