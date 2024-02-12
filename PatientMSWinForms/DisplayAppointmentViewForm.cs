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
        private AppointmentController appointmentController;
        private IQueryable<Appointment> appointment;
        private Patient patient;
        private JournalController journalController;


        public DisplayAppointmentViewForm()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            journalController = new JournalController();
            txtPersonalNumber.ForeColor = Color.Gray;
        }
        #region Appointment clicks
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox_Appointments.Items.Clear();

            string patientPersonalNumber = txtPersonalNumber.Text;

            patient = appointmentController.GetPatient(patientPersonalNumber);

            if (patient != null)
            {
                lblPatientFound.Text = $"Patient found: {patient.Name}";
                appointment = journalController.GetAppointmentList(patient);
                DisplayAppointmentInfo(appointment);

            }
            if (!Regex.IsMatch(patientPersonalNumber, @"^\d{12}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                lblPatientFound.Text = $"Personal number format: (yyyy-mm-dd-xxxx)";
                return;
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
