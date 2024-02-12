namespace PatientMSWinForms
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
            lblFindPatient = new System.Windows.Forms.Label();
            txtPersonalnumber = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lblSearchInfo = new System.Windows.Forms.Label();
            lblDateTime = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtDateTime = new System.Windows.Forms.TextBox();
            txtReason = new System.Windows.Forms.TextBox();
            btnFindDoctor = new System.Windows.Forms.Button();
            listBox_Doctor = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
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
            lblBookappointment.Size = new System.Drawing.Size(217, 31);
            lblBookappointment.TabIndex = 0;
            lblBookappointment.Text = "Book appointment";
            // 
            // lblFindPatient
            // 
            lblFindPatient.AutoSize = true;
            lblFindPatient.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFindPatient.Location = new System.Drawing.Point(61, 82);
            lblFindPatient.Name = "lblFindPatient";
            lblFindPatient.Size = new System.Drawing.Size(191, 17);
            lblFindPatient.TabIndex = 1;
            lblFindPatient.Text = "Enter patient personalnumber:  ";
            // 
            // txtPersonalnumber
            // 
            txtPersonalnumber.Location = new System.Drawing.Point(302, 74);
            txtPersonalnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtPersonalnumber.Name = "txtPersonalnumber";
            txtPersonalnumber.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtPersonalnumber.Size = new System.Drawing.Size(369, 25);
            txtPersonalnumber.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(702, 74);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(126, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblSearchInfo
            // 
            lblSearchInfo.AutoSize = true;
            lblSearchInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSearchInfo.Location = new System.Drawing.Point(61, 122);
            lblSearchInfo.Name = "lblSearchInfo";
            lblSearchInfo.Size = new System.Drawing.Size(0, 17);
            lblSearchInfo.TabIndex = 4;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new System.Drawing.Point(61, 172);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new System.Drawing.Size(147, 17);
            lblDateTime.TabIndex = 6;
            lblDateTime.Text = "Enter appointment date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(58, 437);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 17);
            label1.TabIndex = 7;
            label1.Text = "Enter reason for visit:";
            // 
            // txtDateTime
            // 
            txtDateTime.Location = new System.Drawing.Point(302, 164);
            txtDateTime.Name = "txtDateTime";
            txtDateTime.PlaceholderText = "yyyy-mm-dd 00:00";
            txtDateTime.Size = new System.Drawing.Size(369, 25);
            txtDateTime.TabIndex = 8;
            // 
            // txtReason
            // 
            txtReason.Location = new System.Drawing.Point(429, 429);
            txtReason.Name = "txtReason";
            txtReason.Size = new System.Drawing.Size(397, 25);
            txtReason.TabIndex = 9;
            // 
            // btnFindDoctor
            // 
            btnFindDoctor.Location = new System.Drawing.Point(702, 160);
            btnFindDoctor.Name = "btnFindDoctor";
            btnFindDoctor.Size = new System.Drawing.Size(126, 35);
            btnFindDoctor.TabIndex = 10;
            btnFindDoctor.Text = "Find doctor";
            btnFindDoctor.UseVisualStyleBackColor = true;
            btnFindDoctor.Click += btnFindDoctor_Click;
            // 
            // listBox_Doctor
            // 
            listBox_Doctor.FormattingEnabled = true;
            listBox_Doctor.ItemHeight = 17;
            listBox_Doctor.Location = new System.Drawing.Point(58, 256);
            listBox_Doctor.Name = "listBox_Doctor";
            listBox_Doctor.Size = new System.Drawing.Size(770, 123);
            listBox_Doctor.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(58, 224);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(116, 17);
            label2.TabIndex = 12;
            label2.Text = "Available Doctors:";
            // 
            // lblDoctorNumber
            // 
            lblDoctorNumber.AutoSize = true;
            lblDoctorNumber.Location = new System.Drawing.Point(58, 383);
            lblDoctorNumber.Name = "lblDoctorNumber";
            lblDoctorNumber.Size = new System.Drawing.Size(122, 17);
            lblDoctorNumber.TabIndex = 13;
            lblDoctorNumber.Text = "Number of doctors:";
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.Location = new System.Drawing.Point(650, 518);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new System.Drawing.Size(178, 52);
            btnBookAppointment.TabIndex = 14;
            btnBookAppointment.Text = "Book appointment";
            btnBookAppointment.UseVisualStyleBackColor = true;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(61, 534);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(150, 36);
            btnBack.TabIndex = 15;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(242, 531);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(150, 39);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // BookAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(903, 596);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(btnBookAppointment);
            Controls.Add(lblDoctorNumber);
            Controls.Add(label2);
            Controls.Add(listBox_Doctor);
            Controls.Add(btnFindDoctor);
            Controls.Add(txtReason);
            Controls.Add(txtDateTime);
            Controls.Add(label1);
            Controls.Add(lblDateTime);
            Controls.Add(lblSearchInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtPersonalnumber);
            Controls.Add(lblFindPatient);
            Controls.Add(lblBookappointment);
            Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "BookAppointmentViewForm";
            Text = "BookAppointmentViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblBookappointment;
        private System.Windows.Forms.Label lblFindPatient;
        private System.Windows.Forms.TextBox txtPersonalnumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchInfo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDateTime;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnFindDoctor;
        private System.Windows.Forms.ListBox listBox_Doctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoctorNumber;
        private System.Windows.Forms.Button btnBookAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
    }
}