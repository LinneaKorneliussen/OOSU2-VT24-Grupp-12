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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuViewForm));
            btnRegisterNewPatient = new System.Windows.Forms.Button();
            btnUpdatePatientInformation = new System.Windows.Forms.Button();
            btnManageAppointment = new System.Windows.Forms.Button();
            btnRegisterNewDiagnosis = new System.Windows.Forms.Button();
            btnBookNewAppointment = new System.Windows.Forms.Button();
            btnDisplayAppointments = new System.Windows.Forms.Button();
            btnRegisterPrescription = new System.Windows.Forms.Button();
            btnLogOff = new System.Windows.Forms.Button();
            FlowLayoutPanel_menu = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            lblMenubar = new System.Windows.Forms.Label();
            PictureBox_bar = new System.Windows.Forms.PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            PictureBox_logo = new System.Windows.Forms.PictureBox();
            lblText = new System.Windows.Forms.Label();
            FlowLayoutPanel_menu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_bar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_logo).BeginInit();
            SuspendLayout();
            // 
            // btnRegisterNewPatient
            // 
            btnRegisterNewPatient.BackColor = System.Drawing.Color.RosyBrown;
            btnRegisterNewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegisterNewPatient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegisterNewPatient.Location = new System.Drawing.Point(3, 86);
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
            btnUpdatePatientInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdatePatientInformation.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdatePatientInformation.Location = new System.Drawing.Point(3, 140);
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
            btnManageAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnManageAppointment.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnManageAppointment.Location = new System.Drawing.Point(3, 248);
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
            btnRegisterNewDiagnosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegisterNewDiagnosis.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegisterNewDiagnosis.Location = new System.Drawing.Point(3, 301);
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
            btnBookNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBookNewAppointment.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBookNewAppointment.Location = new System.Drawing.Point(3, 195);
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
            btnDisplayAppointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDisplayAppointments.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnDisplayAppointments.Location = new System.Drawing.Point(3, 417);
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
            btnRegisterPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRegisterPrescription.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegisterPrescription.Location = new System.Drawing.Point(3, 353);
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
            btnLogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogOff.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogOff.Location = new System.Drawing.Point(3, 481);
            btnLogOff.Name = "btnLogOff";
            btnLogOff.Size = new System.Drawing.Size(208, 58);
            btnLogOff.TabIndex = 8;
            btnLogOff.Text = "Log Off";
            btnLogOff.UseVisualStyleBackColor = false;
            btnLogOff.Click += btnLogOff_Click;
            // 
            // FlowLayoutPanel_menu
            // 
            FlowLayoutPanel_menu.BackColor = System.Drawing.Color.RosyBrown;
            FlowLayoutPanel_menu.Controls.Add(panel1);
            FlowLayoutPanel_menu.Controls.Add(btnRegisterNewPatient);
            FlowLayoutPanel_menu.Controls.Add(btnUpdatePatientInformation);
            FlowLayoutPanel_menu.Controls.Add(btnBookNewAppointment);
            FlowLayoutPanel_menu.Controls.Add(btnManageAppointment);
            FlowLayoutPanel_menu.Controls.Add(btnRegisterNewDiagnosis);
            FlowLayoutPanel_menu.Controls.Add(btnRegisterPrescription);
            FlowLayoutPanel_menu.Controls.Add(btnDisplayAppointments);
            FlowLayoutPanel_menu.Controls.Add(btnLogOff);
            FlowLayoutPanel_menu.Location = new System.Drawing.Point(0, -1);
            FlowLayoutPanel_menu.MaximumSize = new System.Drawing.Size(217, 543);
            FlowLayoutPanel_menu.MinimumSize = new System.Drawing.Size(76, 543);
            FlowLayoutPanel_menu.Name = "FlowLayoutPanel_menu";
            FlowLayoutPanel_menu.Size = new System.Drawing.Size(217, 543);
            FlowLayoutPanel_menu.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblText);
            panel1.Controls.Add(lblMenubar);
            panel1.Controls.Add(PictureBox_bar);
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(214, 77);
            panel1.TabIndex = 0;
            // 
            // lblMenubar
            // 
            lblMenubar.AutoSize = true;
            lblMenubar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMenubar.Location = new System.Drawing.Point(73, 13);
            lblMenubar.Name = "lblMenubar";
            lblMenubar.Size = new System.Drawing.Size(101, 26);
            lblMenubar.TabIndex = 0;
            lblMenubar.Text = "Menu bar";
            // 
            // PictureBox_bar
            // 
            PictureBox_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            PictureBox_bar.Image = (System.Drawing.Image)resources.GetObject("PictureBox_bar.Image");
            PictureBox_bar.Location = new System.Drawing.Point(3, 10);
            PictureBox_bar.Name = "PictureBox_bar";
            PictureBox_bar.Size = new System.Drawing.Size(64, 62);
            PictureBox_bar.TabIndex = 9;
            PictureBox_bar.TabStop = false;
            PictureBox_bar.Click += menuSlide_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.Connection = null;
            sqlCommand1.Notification = null;
            sqlCommand1.Transaction = null;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // PictureBox_logo
            // 
            PictureBox_logo.Image = (System.Drawing.Image)resources.GetObject("PictureBox_logo.Image");
            PictureBox_logo.Location = new System.Drawing.Point(370, 77);
            PictureBox_logo.Margin = new System.Windows.Forms.Padding(2);
            PictureBox_logo.Name = "PictureBox_logo";
            PictureBox_logo.Size = new System.Drawing.Size(500, 500);
            PictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            PictureBox_logo.TabIndex = 10;
            PictureBox_logo.TabStop = false;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblText.Location = new System.Drawing.Point(73, 39);
            lblText.Name = "lblText";
            lblText.Size = new System.Drawing.Size(76, 26);
            lblText.TabIndex = 11;
            lblText.Text = "Doctor";
            // 
            // MenuViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(947, 543);
            Controls.Add(PictureBox_logo);
            Controls.Add(FlowLayoutPanel_menu);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "MenuViewForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MenuViewForm";
            FlowLayoutPanel_menu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_bar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBox_logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnRegisterNewPatient;
        private System.Windows.Forms.Button btnUpdatePatientInformation;
        private System.Windows.Forms.Button btnBookNewAppointment;
        private System.Windows.Forms.Button btnManageAppointment;
        private System.Windows.Forms.Button btnRegisterNewDiagnosis;
        private System.Windows.Forms.Button btnDisplayAppointments;
        private System.Windows.Forms.Button btnRegisterPrescription;
        private System.Windows.Forms.Button btnLogOff;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_menu;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label lblMenubar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PictureBox_bar;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.PictureBox PictureBox_logo;
        private System.Windows.Forms.Label lblText;
    }
}