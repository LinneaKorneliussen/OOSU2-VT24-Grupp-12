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
            txtGetPersonalNumber.ForeColor = Color.Gray;
        }

        #region Appointments clicks
        private void btnShowAppointments_Click(object sender, EventArgs e)
        {
            listbox_Appointments.Items.Clear();

            string personalNumber = txtGetPersonalNumber.Text;
            appointment = appointmentController.GetAppointmentListPersonalNumber(personalNumber);

            if (appointment != null)
            {
                listbox_Appointments.Items.Clear();
                DisplayAppointmentInfo(appointment);
                DisplayPatient(patient);
            }
            else
            {
                MessageBox.Show($"Patient with personal number {personalNumber} not found.\nPlease try again!");
            }

        }

        private void btnSelectAppointment_Click(object sender, EventArgs e)
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

        public void DisplayPatient(Patient patient)
        {
            string patientPersonalNumber = txtGetPersonalNumber.Text;

            patient = appointmentController.GetPatient(patientPersonalNumber);

            if (patient != null)
            {
                lblPatientFound.Text = $"Patient found: {patient.Name}";
            }
            else
            {
                MessageBox.Show($"Patient with personal number {patientPersonalNumber} not found.\nPlease try again!");
                lblPatientFound.Text = $"Patient with personal number {patientPersonalNumber} not found.";
              
            }
        }

        #endregion
    }
}
