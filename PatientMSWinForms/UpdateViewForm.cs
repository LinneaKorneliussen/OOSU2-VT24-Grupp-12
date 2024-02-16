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
    public partial class UpdateViewForm : Form
    {
        private PatientController patientController;
        private Patient patient;
        private int select;

        public UpdateViewForm(Patient p, int selectedItem)
        {
            InitializeComponent();
            patientController = new PatientController();
            patient = p;
            select = selectedItem;

        }
        #region Update Patient Clicks
        private void btnBack_Click(object sender, EventArgs e)
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
        }
        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            string newName = txtNewvalue.Text;
            patientController.UpdatePatientInfo(patient, select, newName);
            MessageBox.Show("Patient information updated successfully!\n\n" + $"New value: {newName}\n");
            this.Close();
        }
        #endregion

    }
}
