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
    public partial class DisplayAppointmentViewForm : Form
    {
        private JournalController journalController;
        private PatientController patientController;

        public DisplayAppointmentViewForm()
        {
            InitializeComponent();
            patientController = new PatientController();
            journalController = new JournalController();
            txtPersonalNumber.ForeColor = Color.Gray;
        }

        #region Appointment clicks
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox_Appointments.Items.Clear();

            string patientPersonalNumber = txtPersonalNumber.Text;

            Patient patient = patientController.GetPatient(patientPersonalNumber);

            if (!Regex.IsMatch(patientPersonalNumber, @"^\d{4}-\d{2}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                lblPatientFound.Text = $"Personal number format: (yyyy-mm-dd-xxxx)";
                return;
            }
            if (patient != null)
            {
                lblPatientFound.Text = $"Patient found: {patient.Name}";
                IQueryable<Appointment> appointment = journalController.GetAppointmentList(patient);
                DisplayAppointmentInfo(appointment);
            }
            else
            {
                lblPatientFound.Text = $"Patient with personal number {patientPersonalNumber} not found.";
            }

          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Appointment methods
        public void DisplayAppointmentInfo(IQueryable<Appointment> appointments)
        {
            listBox_Appointments.Items.Clear();

            foreach (var appointment in appointments)
            {
                string appointmentInfo = $"AppointmentID: {appointment.AppointmentId,-30}" +
                                         $"Start time: {appointment.DateAndTime,-30}" +
                                         $"End time: {appointment.EndDateTime,-30}" +
                                         $"Reason: {appointment.ReasonForVisit,-30}";
                listBox_Appointments.Items.Add(appointmentInfo);
            }
            
        }
        #endregion
    }
}
