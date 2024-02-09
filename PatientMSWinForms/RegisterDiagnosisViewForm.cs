using PatientBL;
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
    public partial class RegisterDiagnosisViewForm : Form
    {
        private DiagnosisController diagnosisController;
        private PatientController patientController;    
        private Patient patient; 
        public RegisterDiagnosisViewForm()
        {   
            InitializeComponent();
            patientController = new PatientController();    
            diagnosisController = new DiagnosisController();
        }

        #region Register new diagnosis clicks
        private void btnFind_Click(object sender, EventArgs e)
        {
            string ssn = txtSSN.Text;
            patient = patientController.GetPatient(ssn);
            if (patient != null)
            {
                lbl_DisplayPInfo.Text = $"Patient found: {patient.Name} with personal number {ssn}";
            }
            else
            {
                MessageBox.Show($"Patient with personal number {ssn} not found.\nTry again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_DisplayPInfo.Text = $"Patient with personal number {ssn} not found.";
            }

        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text;   
            string treatment = txtTreatmentplan.Text;
            
            diagnosisController.AddDiagnosis(patient, description, treatment);
            MessageBox.Show($"Diagnosis registerd successfully for {patient.Name}\nMain diagnosis: {description}\nExpected treatment: {treatment}");
            this.Close();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

    }
}
