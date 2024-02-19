using PatientBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientMSWinForms
{
    public partial class RegisterPatientViewForm : Form
    {
        private PatientController patientController;
        public RegisterPatientViewForm()
        {
            InitializeComponent();
            patientController = new PatientController();    
        }

        #region Register new patient clicks
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string personalNumber = txtSSN.Text;
            string address = txtAddress.Text;
            string phonenumber = txtPhone.Text;
            string emailAddress = txtMail.Text;

            // Klientvalidering
            if (!Regex.IsMatch(personalNumber, @"^\d{4}-\d{2}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                return;
            }
            if (string.IsNullOrWhiteSpace(name) ||  string.IsNullOrWhiteSpace(personalNumber) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(phonenumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                MessageBox.Show("Please make sure all fields contain information before proceeding", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Servervalidering
            if (patientController.IsPersonalNumberUnique(personalNumber))
            {
                // Skapa ny patient om personnumret är unikt
                patientController.CreateNewPatient(name, personalNumber, address, phonenumber, emailAddress);
                MessageBox.Show($"Patient registered successfully, See details below:\n Name: {name}\n SSN: {personalNumber}\n Address: {address}\n Phone: {phonenumber}\n Email: {emailAddress}");
                this.Hide();
            }
            else
            {
                MessageBox.Show("A patient with this personal number already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMail.Clear();    
            txtAddress.Clear(); 
            txtName.Clear();
            txtPhone.Clear();   
            txtSSN.Clear(); 

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
