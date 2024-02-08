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

        //#region Display expected Value 
        //private void SetPlaceHolderText(object sender, string placeholder) 
        //{
        //    TextBox textBox = sender as TextBox;    
        //    if (textBox != null) 
        //    {
        //        textBox.Text = placeholder;
        //        textBox.ForeColor = Color.Gray; 
        //    }
        //}

        //private void TextBox_Enter(object sender, EventArgs e) 
        //{ 
        //    TextBox textBox = sender as TextBox;    
        //    if (textBox != null)
        //    {
        //        if (textBox.Text == "yyyy-mm-dd-xxxx" || textBox.Text == "First Name and Last Name")
        //        {
        //            textBox.Text = "";
        //            txtSSN.ForeColor = Color.Black;
        //        }
        //    }
        //}

        //private void TextBox_Leave(object sender, EventArgs e) 
        //{
        //    TextBox textBox = sender as TextBox;
        //    if (textBox != null)
        //    {
        //        if (string.IsNullOrWhiteSpace(textBox.Text))
        //        {
        //            if (textBox == txtSSN)
        //                SetPlaceHolderText(sender, "yyyy-mm-dd-xxxx");
        //            else if (textBox == txtName)
        //                SetPlaceHolderText(sender, "First Name and Last Name"); 
        //        }
        //    }
        //}
        //#endregion

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
