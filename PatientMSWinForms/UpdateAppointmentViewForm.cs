using PatientBL;
using PatientEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientMSWinForms
{
    public partial class UpdateAppointmentViewForm : Form
    {
        private AppointmentController appointmentController;
        private Appointment appointment;

        public UpdateAppointmentViewForm(Appointment at, AppointmentController ac)
        {
            InitializeComponent();
            appointment = at;
            appointmentController = ac;
            txtDateTimeInfo.ForeColor = Color.Gray;

        }

        #region Update Appointments clicks
        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            string inputDateTime = txtDateTimeInfo.Text;
            DateTime appointmentDateTime;

            if (!DateTime.TryParseExact(inputDateTime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out appointmentDateTime))
            {
                MessageBox.Show("Invalid date and time format. \nPlease enter the date and time in the format yyyy-mm-dd hh:mm.");
                return;
            }
            appointmentController.UpdateDateTime(appointmentDateTime, appointment);

            MessageBox.Show($"Datetime updated: {appointmentDateTime}");
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            ManageAppointmentViewForm manageAppointmentViewForm = new ManageAppointmentViewForm();
            manageAppointmentViewForm.Show();
        }
        #endregion
    }
}
