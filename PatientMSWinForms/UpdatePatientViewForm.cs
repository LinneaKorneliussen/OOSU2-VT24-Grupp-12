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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string patientPersonalNumber = textPersonalnumber.Text;

            patient = patientController.GetPatient(patientPersonalNumber);

            if (patient != null)
            {
                listbox_Patient.Items.Clear();

                listbox_Patient.Items.Add($"Personal Number:{patient.PersonalNumber}");

                DisplayPatientInfo(patient);
            }
            else
            {
                MessageBox.Show($"Patient with personal number {patientPersonalNumber} not found.\nPlease try again!");
                lblPatientInfo.Text = $"Patient with personal number {patientPersonalNumber} not found.";
            }

        }
        public void DisplayPatientInfo(Patient patientToUpdate)
        {
            // Rensa ListBoxen först
            listbox_Patient.Items.Clear();

            // Skapa en lista med valen och den nuvarande informationen
            List<string> options = new List<string>
            
            {$"1. Name: {patientToUpdate.Name}", $"2. Address: {patientToUpdate.Address}", $"3. Phone number: {patientToUpdate.Phonenumber}", $"4. Email Address: {patientToUpdate.EmailAddress}"};

            // Lägg till varje val i ListBoxen
            foreach (string option in options)
            {
                listbox_Patient.Items.Add(option);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listbox_Patient.SelectedItem != null)
            {
                // Hämta det valda objektet från listboxen
                int selectedItem = listbox_Patient.SelectedIndex;

                // Öppna UpdateViewForm och skicka med den valda patienten
                UpdateViewForm updateForm = new UpdateViewForm(patient,selectedItem);
                updateForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient from the list before updating.");
            }

        }

    }
}

            
        
    

