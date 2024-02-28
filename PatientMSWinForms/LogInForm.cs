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

// Grupp 12: Linnea Korneliussen, Celina Linnerblom, Beata Jacobsson, Clara Hansson
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            pictureLoading.Visible = true;

            Staff user = loginController.AuthorizeUser(username, password);
            if (user != null)
            {
                if (user is Doctor)
                {
                    Doctor doctor = (Doctor)user;
                    MessageBox.Show($"You are logged in as Doctor: {doctor.StaffName}");

                    MenuViewForm doctorView = new MenuViewForm();
                    doctorView.Show();
                }
                else if (user is Nurse)
                {
                    Nurse nurse = (Nurse)user;
                    MessageBox.Show($"You are logged in as Nurse: {nurse.StaffName}");

                    MenuNurseForm nurseView = new MenuNurseForm();
                    nurseView.Show();
                }

                this.Hide();

            }
            else
            {
                MessageBox.Show($"Failed to log in. Try again!");
            }
            pictureLoading.Visible = false;



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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
