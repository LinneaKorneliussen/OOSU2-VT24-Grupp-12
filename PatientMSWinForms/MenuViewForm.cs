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
    public partial class MenuViewForm : Form
    {
        public MenuViewForm()
        {
            InitializeComponent();
        }
        #region Menu view clicks
        private void btnRegisterNewPatient_Click(object sender, EventArgs e)
        {
            RegisterPatientViewForm rp = new RegisterPatientViewForm();
            rp.Show();

        }

        private void btnUpdatePatientInformation_Click(object sender, EventArgs e)
        {
            UpdatePatientViewForm up = new UpdatePatientViewForm();
            up.Show();
        }

        private void btnBookNewAppointment_Click(object sender, EventArgs e)
        {
            BookAppointmentViewForm ba = new BookAppointmentViewForm();
            ba.Show();
        }

        private void btnManageAppointment_Click(object sender, EventArgs e)
        {
            ManageAppointmentViewForm ma = new ManageAppointmentViewForm();
            ma.Show();
        }

        private void btnRegisterNewDiagnosis_Click(object sender, EventArgs e)
        {
            RegisterDiagnosisViewForm rd = new RegisterDiagnosisViewForm();
            rd.Show();
        }

        private void btnRegisterPrescription_Click(object sender, EventArgs e)
        {
            RegisterPrescriptionViewForm rp = new RegisterPrescriptionViewForm();
            rp.Show();
        }

        private void btnDisplayAppointments_Click(object sender, EventArgs e)
        {
            DisplayAppointmentViewForm da = new DisplayAppointmentViewForm();
            da.Show();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

    }
}
