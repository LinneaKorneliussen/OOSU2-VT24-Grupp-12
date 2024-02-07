namespace PatientMSWinForms
{
    partial class MenuViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            lblMenubar = new System.Windows.Forms.Label();
            btnRegisterNewPatient = new System.Windows.Forms.Button();
            btnUpdatePatientInformation = new System.Windows.Forms.Button();
            btnManageAppointment = new System.Windows.Forms.Button();
            btnRegisterNewDiagnosis = new System.Windows.Forms.Button();
            btnBookNewAppointment = new System.Windows.Forms.Button();
            btnDisplayAppointments = new System.Windows.Forms.Button();
            btnRegisterPrescription = new System.Windows.Forms.Button();
            btnLogOff = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(lblMenubar);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(947, 64);
            panel1.TabIndex = 0;
            // 
            // lblMenubar
            // 
            lblMenubar.AutoSize = true;
            lblMenubar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMenubar.Location = new System.Drawing.Point(12, 20);
            lblMenubar.Name = "lblMenubar";
            lblMenubar.Size = new System.Drawing.Size(113, 25);
            lblMenubar.TabIndex = 0;
            lblMenubar.Text = "Menu bar";
            // 
            // btnRegisterNewPatient
            // 
            btnRegisterNewPatient.BackColor = System.Drawing.Color.RosyBrown;
            btnRegisterNewPatient.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegisterNewPatient.Location = new System.Drawing.Point(3, 3);
            btnRegisterNewPatient.Name = "btnRegisterNewPatient";
            btnRegisterNewPatient.Size = new System.Drawing.Size(208, 48);
            btnRegisterNewPatient.TabIndex = 3;
            btnRegisterNewPatient.Text = "Register new patient";
            btnRegisterNewPatient.UseVisualStyleBackColor = false;
            btnRegisterNewPatient.Click += btnRegisterNewPatient_Click;
            // 
            // btnUpdatePatientInformation
            // 
            btnUpdatePatientInformation.BackColor = System.Drawing.Color.RosyBrown;
            btnUpdatePatientInformation.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdatePatientInformation.Location = new System.Drawing.Point(3, 57);
            btnUpdatePatientInformation.Name = "btnUpdatePatientInformation";
            btnUpdatePatientInformation.Size = new System.Drawing.Size(208, 49);
            btnUpdatePatientInformation.TabIndex = 6;
            btnUpdatePatientInformation.Text = "Update patient information";
            btnUpdatePatientInformation.UseVisualStyleBackColor = false;
            btnUpdatePatientInformation.Click += btnUpdatePatientInformation_Click;
            // 
            // btnManageAppointment
            // 
            btnManageAppointment.BackColor = System.Drawing.Color.RosyBrown;
            btnManageAppointment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnManageAppointment.Location = new System.Drawing.Point(3, 165);
            btnManageAppointment.Name = "btnManageAppointment";
            btnManageAppointment.Size = new System.Drawing.Size(208, 47);
            btnManageAppointment.TabIndex = 4;
            btnManageAppointment.Text = "Manage existing appointment";
            btnManageAppointment.UseVisualStyleBackColor = false;
            btnManageAppointment.Click += btnManageAppointment_Click;
            // 
            // btnRegisterNewDiagnosis
            // 
            btnRegisterNewDiagnosis.BackColor = System.Drawing.Color.RosyBrown;
            btnRegisterNewDiagnosis.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegisterNewDiagnosis.Location = new System.Drawing.Point(3, 218);
            btnRegisterNewDiagnosis.Name = "btnRegisterNewDiagnosis";
            btnRegisterNewDiagnosis.Size = new System.Drawing.Size(208, 46);
            btnRegisterNewDiagnosis.TabIndex = 5;
            btnRegisterNewDiagnosis.Text = "Register new diagnosis";
            btnRegisterNewDiagnosis.UseVisualStyleBackColor = false;
            btnRegisterNewDiagnosis.Click += btnRegisterNewDiagnosis_Click;
            // 
            // btnBookNewAppointment
            // 
            btnBookNewAppointment.BackColor = System.Drawing.Color.RosyBrown;
            btnBookNewAppointment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBookNewAppointment.Location = new System.Drawing.Point(3, 112);
            btnBookNewAppointment.Name = "btnBookNewAppointment";
            btnBookNewAppointment.Size = new System.Drawing.Size(208, 47);
            btnBookNewAppointment.TabIndex = 6;
            btnBookNewAppointment.Text = "Book new appointment";
            btnBookNewAppointment.UseVisualStyleBackColor = false;
            btnBookNewAppointment.Click += btnBookNewAppointment_Click;
            // 
            // btnDisplayAppointments
            // 
            btnDisplayAppointments.BackColor = System.Drawing.Color.RosyBrown;
            btnDisplayAppointments.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDisplayAppointments.Location = new System.Drawing.Point(3, 334);
            btnDisplayAppointments.Name = "btnDisplayAppointments";
            btnDisplayAppointments.Size = new System.Drawing.Size(208, 58);
            btnDisplayAppointments.TabIndex = 5;
            btnDisplayAppointments.Text = "Display upcoming appointments";
            btnDisplayAppointments.UseVisualStyleBackColor = false;
            btnDisplayAppointments.Click += btnDisplayAppointments_Click;
            // 
            // btnRegisterPrescription
            // 
            btnRegisterPrescription.BackColor = System.Drawing.Color.RosyBrown;
            btnRegisterPrescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRegisterPrescription.Location = new System.Drawing.Point(3, 270);
            btnRegisterPrescription.Name = "btnRegisterPrescription";
            btnRegisterPrescription.Size = new System.Drawing.Size(208, 58);
            btnRegisterPrescription.TabIndex = 7;
            btnRegisterPrescription.Text = "Register new prescription";
            btnRegisterPrescription.UseVisualStyleBackColor = false;
            btnRegisterPrescription.Click += btnRegisterPrescription_Click;
            // 
            // btnLogOff
            // 
            btnLogOff.BackColor = System.Drawing.Color.RosyBrown;
            btnLogOff.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogOff.Location = new System.Drawing.Point(3, 398);
            btnLogOff.Name = "btnLogOff";
            btnLogOff.Size = new System.Drawing.Size(208, 58);
            btnLogOff.TabIndex = 8;
            btnLogOff.Text = "Log Off";
            btnLogOff.UseVisualStyleBackColor = false;
            btnLogOff.Click += btnLogOff_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown;
            flowLayoutPanel1.Controls.Add(btnRegisterNewPatient);
            flowLayoutPanel1.Controls.Add(btnUpdatePatientInformation);
            flowLayoutPanel1.Controls.Add(btnBookNewAppointment);
            flowLayoutPanel1.Controls.Add(btnManageAppointment);
            flowLayoutPanel1.Controls.Add(btnRegisterNewDiagnosis);
            flowLayoutPanel1.Controls.Add(btnRegisterPrescription);
            flowLayoutPanel1.Controls.Add(btnDisplayAppointments);
            flowLayoutPanel1.Controls.Add(btnLogOff);
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(217, 478);
            flowLayoutPanel1.TabIndex = 9;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // MenuViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(947, 543);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MenuViewForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MenuViewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenubar;
        private System.Windows.Forms.Button btnRegisterNewPatient;
        private System.Windows.Forms.Button btnUpdatePatientInformation;
        private System.Windows.Forms.Button btnBookNewAppointment;
        private System.Windows.Forms.Button btnManageAppointment;
        private System.Windows.Forms.Button btnRegisterNewDiagnosis;
        private System.Windows.Forms.Button btnDisplayAppointments;
        private System.Windows.Forms.Button btnRegisterPrescription;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}