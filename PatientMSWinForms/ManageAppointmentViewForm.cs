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

namespace PatientMSWinForms
{
    public partial class ManageAppointmentViewForm : Form
    {
        private AppointmentController appointmentController;
        private List<Appointment> appointment;
        private Patient patient;

        public ManageAppointmentViewForm()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
            appointment = new List<Appointment>();
            txtGetPersonalNumber.ForeColor = Color.Gray;
        }

        #region Appointments clicks
        private void btnShowAppointments_Click(object sender, EventArgs e)
        {
            listbox_Appointments.Items.Clear();

            string personalNumber = txtGetPersonalNumber.Text;
            patient = appointmentController.GetPatient(personalNumber);

            if (!Regex.IsMatch(personalNumber, @"^\d{4}-\d{2}-\d{2}-\d{4}$"))
            {
                MessageBox.Show("Invalid personal number format. \nPlease enter the personal number (yyyy-mm-dd-xxxx).");
                return;
            }
            if (patient != null)
            {
                listbox_Appointments.Items.Clear();
                lblPatientFound.Text = $"Patient found: {patient.PersonalNumber}";
                appointment = appointmentController.GetAppointmentListPersonalNumber(patient);
                DisplayAppointmentInfo(appointment);
            }
            else
            {
                lblPatientFound.Text = $"Patient with personal number {personalNumber} not found.";
            }

        }

        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            if (listbox_Appointments.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an appointment.");
                return;
            }
            Appointment selectedItem = appointment[listbox_Appointments.SelectedIndex];
            UpdateAppointmentViewForm updateAppointment = new UpdateAppointmentViewForm(selectedItem, appointmentController);
            updateAppointment.Show();
            this.Close();
        }

        private void btnRemoveAppointment_Click(object sender, EventArgs e)
        {
            if (listbox_Appointments.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an appointment.");
                return;
            }
            Appointment selectedItem = appointment[listbox_Appointments.SelectedIndex];
            appointmentController.RemoveAppointment(selectedItem);
            MessageBox.Show($"Appointment removed for patient: {selectedItem.Patient.Name}");
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Display Appointments Method
        public void DisplayAppointmentInfo(IList<Appointment> appointments)
        {
            listbox_Appointments.Items.Clear();

            for (int i = 0; i < appointments.Count; i++)
            {
                string appointmentInfo = $"AppointmentID: {appointments[i].AppointmentId,-10}" +
                                    $"Date and time: {appointments[i].DateAndTime,-20}" +
                                    $"Reason: {appointments[i].ReasonForVisit,-20}";
                listbox_Appointments.Items.Add(appointmentInfo);
            }
        }
        #endregion

        
    }
}
