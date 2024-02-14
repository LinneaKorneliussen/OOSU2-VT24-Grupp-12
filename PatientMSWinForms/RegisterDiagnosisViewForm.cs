using PatientBL;
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

namespace PatientMSWinForms
{
    public partial class RegisterDiagnosisViewForm : Form
    {
       
        private DiagnosisController diagnosisController;
        private Patient patient;

        public RegisterDiagnosisViewForm()
        {
            InitializeComponent();
            diagnosisController = new DiagnosisController();
        }

        #region Register new diagnosis clicks
        private void btnFind_Click(object sender, EventArgs e)
        {
            string ssn = txtSSN.Text;
            if (string.IsNullOrEmpty(ssn))
            {
                MessageBox.Show("Please enter the patient'select personal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            patient = diagnosisController.GetPatient(ssn);
            if (!Regex.IsMatch(ssn, @"^\d{4}-\d{2}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                return;
            }
            if (patient != null)
            {
                lbl_DisplayPInfo.Text = $"Patient found: {patient.Name} with personal number {ssn}";
            }
            else
            {
                MessageBox.Show($"Patient with personal number {ssn} not found.\nTry again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_DisplayPInfo.Text = $"Patient with personal number {ssn} not found.";
            }
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            if (patient == null)
            {
                MessageBox.Show("Please find the patient before adding a diagnosis.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = txtDescription.Text;
            string treatment = txtTreatmentplan.Text;

            if (string.IsNullOrEmpty(treatment) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please make sure all fields contain information before proceeding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            diagnosisController.AddDiagnosis(patient, description, treatment);
            MessageBox.Show($"Diagnosis registered successfully for {patient.Name}\nMain diagnosis: {description}\nExpected treatment: {treatment}");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

    }
}
