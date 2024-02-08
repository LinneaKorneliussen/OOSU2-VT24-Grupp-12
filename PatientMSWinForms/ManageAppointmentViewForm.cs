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

        public ManageAppointmentViewForm()
        {
            InitializeComponent();
            appointmentController = new AppointmentController();
        }

        #region Click appointments
        private void btnShowAppointments_Click(object sender, EventArgs e)
        {
            lbxAppointments.Items.Clear();

            string personalNumber = txtGetPersonalNumber.Text;
            appointment = appointmentController.GetAppointmentListPersonalNumber(personalNumber);

            if (appointment != null)
            {
                lbxAppointments.Items.Clear();
                DisplayAppointmentInfo(appointment);
            }
            else
            {
                MessageBox.Show($"Appointment with personal number {personalNumber} not found.\nPlease try again!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbxAppointments.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an appointment.");
                return;
            }
            Appointment selectedItem = appointment[lbxAppointments.SelectedIndex];
            UpdateAppointmentViewForm updateAppointment = new UpdateAppointmentViewForm(selectedItem, appointmentController);
            updateAppointment.Show();
            this.Close();
        }

        private void btnRemoveAppointment_Click(object sender, EventArgs e)
        {
            if (lbxAppointments.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an appointment.");
                return;
            }
            Appointment selectedItem = appointment[lbxAppointments.SelectedIndex];
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
            lbxAppointments.Items.Clear();

            for (int i = 0; i < appointments.Count; i++)
            {
                string appointmentInfo = $"{i + 1,-40} {appointments[i].AppointmentId,-40}" +
                                    $" {appointments[i].DateAndTime,-40} {appointments[i].ReasonForVisit,-40}";
                lbxAppointments.Items.Add(appointmentInfo);
            }
        }
        #endregion


    }
}
