﻿namespace PatientMSWinForms
{
    partial class BookAppointmentViewForm
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
            lblBookappointment = new System.Windows.Forms.Label();
            lblPatientPersonalnumber = new System.Windows.Forms.Label();
            txtPersonalnumber = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lblSearchInfo = new System.Windows.Forms.Label();
            lblDateTime = new System.Windows.Forms.Label();
            lblReason = new System.Windows.Forms.Label();
            txtDateTime = new System.Windows.Forms.TextBox();
            txtReason = new System.Windows.Forms.TextBox();
            btnFindDoctor = new System.Windows.Forms.Button();
            listBox_Doctor = new System.Windows.Forms.ListBox();
            lblAvailableDoctors = new System.Windows.Forms.Label();
            lblDoctorNumber = new System.Windows.Forms.Label();
            btnBookAppointment = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblBookappointment
            // 
            lblBookappointment.AutoSize = true;
            lblBookappointment.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBookappointment.Location = new System.Drawing.Point(23, 18);
            lblBookappointment.Name = "lblBookappointment";
            lblBookappointment.Size = new System.Drawing.Size(248, 36);
            lblBookappointment.TabIndex = 0;
            lblBookappointment.Text = "Book appointment";
            // 
            // lblPatientPersonalnumber
            // 
            lblPatientPersonalnumber.AutoSize = true;
            lblPatientPersonalnumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPatientPersonalnumber.Location = new System.Drawing.Point(61, 82);
            lblPatientPersonalnumber.Name = "lblPatientPersonalnumber";
            lblPatientPersonalnumber.Size = new System.Drawing.Size(235, 20);
            lblPatientPersonalnumber.TabIndex = 1;
            lblPatientPersonalnumber.Text = "Enter patient personalnumber:  ";
            // 
            // txtPersonalnumber
            // 
            txtPersonalnumber.Location = new System.Drawing.Point(302, 74);
            txtPersonalnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPersonalnumber.Name = "txtPersonalnumber";
            txtPersonalnumber.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtPersonalnumber.Size = new System.Drawing.Size(657, 28);
            txtPersonalnumber.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.White;
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(995, 73);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(142, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearchInfo
            // 
            lblSearchInfo.AutoSize = true;
            lblSearchInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSearchInfo.Location = new System.Drawing.Point(61, 122);
            lblSearchInfo.Name = "lblSearchInfo";
            lblSearchInfo.Size = new System.Drawing.Size(0, 20);
            lblSearchInfo.TabIndex = 4;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new System.Drawing.Point(61, 172);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(181, 20);
            lblDateTime.TabIndex = 6;
            lblDateTime.Text = "Enter appointment date:";
            // 
            // lblReason
            // 
            lblReason.AutoSize = true;
            lblReason.Location = new System.Drawing.Point(58, 437);
            lblReason.Name = "lblReason";
            lblReason.Size = new System.Drawing.Size(164, 20);
            lblReason.TabIndex = 7;
            lblReason.Text = "Enter reason for visit:";
            // 
            // txtDateTime
            // 
            txtDateTime.Location = new System.Drawing.Point(302, 164);
            txtDateTime.Name = "txtDateTime";
            txtDateTime.PlaceholderText = "yyyy-mm-dd 00:00";
            txtDateTime.Size = new System.Drawing.Size(572, 28);
            txtDateTime.TabIndex = 8;
            // 
            // txtReason
            // 
            txtReason.Location = new System.Drawing.Point(429, 429);
            txtReason.Name = "txtReason";
            txtReason.Size = new System.Drawing.Size(708, 28);
            txtReason.TabIndex = 9;
            // 
            // btnFindDoctor
            // 
            btnFindDoctor.BackColor = System.Drawing.Color.White;
            btnFindDoctor.Location = new System.Drawing.Point(918, 160);
            btnFindDoctor.Name = "btnFindDoctor";
            btnFindDoctor.Size = new System.Drawing.Size(221, 35);
            btnFindDoctor.TabIndex = 10;
            btnFindDoctor.Text = "Find doctor";
            btnFindDoctor.UseVisualStyleBackColor = false;
            btnFindDoctor.Click += btnFindDoctor_Click;
            // 
            // listBox_Doctor
            // 
            listBox_Doctor.FormattingEnabled = true;
            listBox_Doctor.ItemHeight = 20;
            listBox_Doctor.Location = new System.Drawing.Point(58, 256);
            listBox_Doctor.Name = "listBox_Doctor";
            listBox_Doctor.Size = new System.Drawing.Size(1081, 124);
            listBox_Doctor.TabIndex = 11;
            // 
            // lblAvailableDoctors
            // 
            lblAvailableDoctors.AutoSize = true;
            lblAvailableDoctors.Location = new System.Drawing.Point(58, 224);
            lblAvailableDoctors.Name = "lblAvailableDoctors";
            lblAvailableDoctors.Size = new System.Drawing.Size(140, 20);
            lblAvailableDoctors.TabIndex = 12;
            lblAvailableDoctors.Text = "Available Doctors:";
            // 
            // lblDoctorNumber
            // 
            lblDoctorNumber.AutoSize = true;
            lblDoctorNumber.Location = new System.Drawing.Point(58, 397);
            lblDoctorNumber.Name = "lblDoctorNumber";
            lblDoctorNumber.Size = new System.Drawing.Size(150, 20);
            lblDoctorNumber.TabIndex = 13;
            lblDoctorNumber.Text = "Number of doctors:";
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.BackColor = System.Drawing.Color.White;
            btnBookAppointment.Location = new System.Drawing.Point(842, 518);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new System.Drawing.Size(297, 52);
            btnBookAppointment.TabIndex = 14;
            btnBookAppointment.Text = "Book appointment";
            btnBookAppointment.UseVisualStyleBackColor = false;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Location = new System.Drawing.Point(61, 534);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(150, 36);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            btnClear.Location = new System.Drawing.Point(242, 534);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(148, 36);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // BookAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(1247, 596);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnBookAppointment);
            Controls.Add(lblDoctorNumber);
            Controls.Add(lblAvailableDoctors);
            Controls.Add(listBox_Doctor);
            Controls.Add(btnFindDoctor);
            Controls.Add(txtReason);
            Controls.Add(txtDateTime);
            Controls.Add(lblReason);
            Controls.Add(lblDateTime);
            Controls.Add(lblSearchInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtPersonalnumber);
            Controls.Add(lblPatientPersonalnumber);
            Controls.Add(lblBookappointment);
            Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "BookAppointmentViewForm";
            Text = "Book new appointment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBookappointment;
        private System.Windows.Forms.Label lblPatientPersonalnumber;
        private System.Windows.Forms.TextBox txtPersonalnumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnFindDoctor;
        private System.Windows.Forms.ListBox listBox_Doctor;
        private System.Windows.Forms.Label lblAvailableDoctors;
        private System.Windows.Forms.Label lblDoctorNumber;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}