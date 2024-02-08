using PatientBL;
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

            if (!Validation.ValidatePersonalNumber(personalNumber)) 
            {
                MessageBox.Show("Incorrect format for personalnumber","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            patientController.CreateNewPatient(name, personalNumber, address, phonenumber, emailAddress);
            MessageBox.Show($"Patient registered successfully, See details below:\n Name: {name}\n SSN: {personalNumber}\n Address: {address}\n Phone: {phonenumber}\n Email: {emailAddress}");
            this.Hide();    
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
