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
    public partial class MenuNurseForm : Form
    {
        public MenuNurseForm()
        {
            InitializeComponent();
        }

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

        private void btnDisplayAppointments_Click(object sender, EventArgs e)
        {
            DisplayAppointmentViewForm da = new DisplayAppointmentViewForm();
            da.Show();
        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            int shakeDistance = 10;
            for (int i = 0; i < 5; i++)
            {
                this.Left += shakeDistance;
                System.Threading.Thread.Sleep(20);
                this.Left -= shakeDistance;
                System.Threading.Thread.Sleep(20);
            }
            this.Close();
            LogInForm log = new LogInForm();
            log.Show();

        }
    }
}
