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
    public partial class BookAppointmentViewForm : Form
    {
        private AppointmentController appointmentController;
        private PatientController patientController;
        private Patient patient;
        private List<Staff> allDoctors;
        private DateTime appointmentDateTime;

        public BookAppointmentViewForm()
        {
            InitializeComponent();
            appointmentController  = new AppointmentController();
            patientController = new PatientController();    
            txtPersonalnumber.ForeColor = Color.Gray;
            txtDateTime.ForeColor = Color.Gray;
        }

        #region Appointment clicks
        private void btnSearch_Click(object sender, EventArgs e)
        {
            listBox_Doctor.Items.Clear();
            string patientPersonalNumber = txtPersonalnumber.Text;

            patient = patientController.GetPatient(patientPersonalNumber);

            if (!Regex.IsMatch(patientPersonalNumber, @"^\d{4}-\d{2}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                return;
            }
            if (patient != null)
            {
                lblSearchInfo.Text = $"Patient found: {patient.Name}";
            }
            else
            {
                lblSearchInfo.Text = $"Patient with personal number {patientPersonalNumber} not found.";
            }
        }
        private void btnFindDoctor_Click(object sender, EventArgs e)
        {
            if (patient != null)
            {
                string inputDateTime = txtDateTime.Text;

                if (!DateTime.TryParseExact(inputDateTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDateTime))
                {
                    MessageBox.Show("Invalid date and time format. \nPlease enter the date and time in the format yyyy-mm-dd hh:mm.");
                    return;
                }
                if (appointmentDateTime.Date < DateTime.Today)
                {
                    MessageBox.Show("You cannot book appointments for past dates.");
                    return;
                }

                allDoctors = appointmentController.GetAllAvailableDoctors(appointmentDateTime);
                DisplayAvailableDoctors(allDoctors);
                lblDoctorNumber.Text = $"Number of doctors: {allDoctors.Count}";
            }
        }
        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            string reasonForVisit = txtReason.Text;
            if (listBox_Doctor.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a doctor from the list.");
                return;
            }
            if (string.IsNullOrWhiteSpace(reasonForVisit))
            {
                MessageBox.Show("Please make sure all fields contain information before proceeding", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Staff selectedDoctor = allDoctors[listBox_Doctor.SelectedIndex];

            appointmentController.BookAppointment(patient, appointmentDateTime, reasonForVisit, selectedDoctor);
            MessageBox.Show("Appointment successfully booked.");
            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDateTime.Clear();
            txtReason.Clear();
            listBox_Doctor.Items.Clear();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Appointment Methods
        private void DisplayAvailableDoctors(List<Staff> availableDoctors)
        {
            listBox_Doctor.Items.Clear();

            for (int i = 0; i < availableDoctors.Count; i++)
            {
                string appointmentInfo = $"Staffnumber: {availableDoctors[i].StaffId,-10} Occupational Role: {availableDoctors[i].OccupationalRole,-25} Name: {availableDoctors[i].StaffName,-35} Specialization: {availableDoctors[i].Specialization,-10}";
                listBox_Doctor.Items.Add(appointmentInfo);
            }

        }
        #endregion
    }
}
