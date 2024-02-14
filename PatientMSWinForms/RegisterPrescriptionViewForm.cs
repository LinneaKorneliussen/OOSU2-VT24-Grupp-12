using PatientBL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PatientMSWinForms
{
    public partial class RegisterPrescriptionViewForm : Form
    {
        private Patient patient;
        private PrescriptionController prescriptionController;

        public RegisterPrescriptionViewForm()
        {
            InitializeComponent();
            prescriptionController = new PrescriptionController();
            txtPersonalNumber.ForeColor = Color.Gray;
            txtMedicineName.ForeColor = Color.Gray;
            txtDose.ForeColor = Color.Gray;
            txtPrescriptionDate.ForeColor = Color.Gray;
        }

        #region Prescription clicks
        private void btnFind_Click(object sender, EventArgs e)
        {
            string patientPersonalNumber = txtPersonalNumber.Text;

            patient = prescriptionController.GetPatient(patientPersonalNumber);

            if (!Regex.IsMatch(patientPersonalNumber, @"^\d{4}-\d{2}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                return;
            }
            if (patient != null)
            {
                lblPatientFound.Text = $"Patient found: {patient.Name}";
            }
            else
            {
                lblPersonalNumber.Text = $"Patient with personal number {patientPersonalNumber} not found.";
            }

        }
        

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            string medicineName = txtMedicineName.Text;
            string dose = txtDose.Text;
            string inputDateTime = txtPrescriptionDate.Text;
            DateTime prescriptionDate;

            if (!DateTime.TryParseExact(inputDateTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out prescriptionDate))
            {
                MessageBox.Show("Invalid date and time format. \nPlease enter the date and time in the format yyyy-mm-dd hh:mm.");
                return;
            }
            if (string.IsNullOrWhiteSpace(medicineName) ||string.IsNullOrWhiteSpace(dose)) 
            {
                MessageBox.Show("Please make sure all fields contain information before proceeding", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            prescriptionController.AddPrescription(patient, medicineName, dose, prescriptionDate);
            MessageBox.Show($"Prescription registered successfully. See details below:\n Medicine name: {medicineName}\n Dose: {dose}\n Prescription date: {prescriptionDate}");
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedicineName.Clear();
            txtDose.Clear();
            txtPrescriptionDate.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

    }
}
