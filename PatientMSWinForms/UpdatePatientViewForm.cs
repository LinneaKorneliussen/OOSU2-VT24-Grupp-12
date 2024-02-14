using Microsoft.EntityFrameworkCore;
using PatientBL;
using PatientDL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PatientMSWinForms
{
    public partial class UpdatePatientViewForm : Form
    {

        private PatientController patientController;  
        private Patient patient;


        public UpdatePatientViewForm()
        {
            InitializeComponent();
            patientController = new PatientController();

        }
        #region Update Patient Clicks
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string patientPersonalNumber = txtPersonalnumber.Text;

            patient = patientController.GetPatient(patientPersonalNumber);

            if (patient != null)
            {
                listbox_Patient.Items.Clear();
                listbox_Patient.Items.Add($"Personal Number:{patient.PersonalNumber}");
                DisplayPatientInfo(patient);
            }
            if (!Regex.IsMatch(patientPersonalNumber, @"^\d{4}-\d{2}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                return;
            }
            else
            {
                lblPatientInfo.Text = $"Patient with personal number {patientPersonalNumber} not found.";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listbox_Patient.SelectedItem != null)
            {
                int selectedItem = listbox_Patient.SelectedIndex;
                UpdateViewForm updateForm = new UpdateViewForm(patient, selectedItem);
                updateForm.Show();
            }
            else
            {
                MessageBox.Show("Please select an option from the list before updating.");
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            int shakeDistance = 10;
            for (int i = 0; i < 5; i++)
            {
                this.Left += shakeDistance;
                System.Threading.Thread.Sleep(20);
                this.Left -= shakeDistance;
                System.Threading.Thread.Sleep(20);
            }

            this.Close();
        }
        #endregion

        #region Update Patient Method
        public void DisplayPatientInfo(Patient patientToUpdate)
        {
            listbox_Patient.Items.Clear();
            List<string> options = new List<string>
            
            {$"1. Name: {patientToUpdate.Name}", $"2. Address: {patientToUpdate.Address}", $"3. Phone number: {patientToUpdate.Phonenumber}", $"4. Email Address: {patientToUpdate.EmailAddress}"};

            foreach (string option in options)
            {
                listbox_Patient.Items.Add(option);
            }
        }
        #endregion

    }
}

            
        
    

