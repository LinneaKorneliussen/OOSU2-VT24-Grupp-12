namespace PatientMSWinForms
{
    partial class ManageAppointmentViewForm
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
            lblPersonalNumber = new System.Windows.Forms.Label();
            btnShowAppointments = new System.Windows.Forms.Button();
            txtGetPersonalNumber = new System.Windows.Forms.TextBox();
            btnUpdateAppointment = new System.Windows.Forms.Button();
            btnRemoveAppointment = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            listbox_Appointments = new System.Windows.Forms.ListBox();
            lblPatientFound = new System.Windows.Forms.Label();
            lblManageAppointment = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblPersonalNumber
            // 
            lblPersonalNumber.AutoSize = true;
            lblPersonalNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPersonalNumber.Location = new System.Drawing.Point(64, 144);
            lblPersonalNumber.Name = "lblPersonalNumber";
            lblPersonalNumber.Size = new System.Drawing.Size(144, 17);
            lblPersonalNumber.TabIndex = 0;
            lblPersonalNumber.Text = "Enter personal number:";
            // 
            // btnShowAppointments
            // 
            btnShowAppointments.BackColor = System.Drawing.Color.White;
            btnShowAppointments.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnShowAppointments.Location = new System.Drawing.Point(569, 134);
            btnShowAppointments.Name = "btnShowAppointments";
            btnShowAppointments.Size = new System.Drawing.Size(155, 34);
            btnShowAppointments.TabIndex = 1;
            btnShowAppointments.Text = "Show appointments";
            btnShowAppointments.UseVisualStyleBackColor = false;
            btnShowAppointments.Click += btnShowAppointments_Click;
            // 
            // txtGetPersonalNumber
            // 
            txtGetPersonalNumber.Location = new System.Drawing.Point(214, 138);
            txtGetPersonalNumber.Name = "txtGetPersonalNumber";
            txtGetPersonalNumber.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtGetPersonalNumber.Size = new System.Drawing.Size(317, 27);
            txtGetPersonalNumber.TabIndex = 2;
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.BackColor = System.Drawing.Color.White;
            btnUpdateAppointment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdateAppointment.Location = new System.Drawing.Point(558, 389);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new System.Drawing.Size(166, 34);
            btnUpdateAppointment.TabIndex = 4;
            btnUpdateAppointment.Text = "Update appointment";
            btnUpdateAppointment.UseVisualStyleBackColor = false;
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // btnRemoveAppointment
            // 
            btnRemoveAppointment.BackColor = System.Drawing.Color.White;
            btnRemoveAppointment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRemoveAppointment.Location = new System.Drawing.Point(345, 389);
            btnRemoveAppointment.Name = "btnRemoveAppointment";
            btnRemoveAppointment.Size = new System.Drawing.Size(166, 34);
            btnRemoveAppointment.TabIndex = 5;
            btnRemoveAppointment.Text = "Remove appointment";
            btnRemoveAppointment.UseVisualStyleBackColor = false;
            btnRemoveAppointment.Click += btnRemoveAppointment_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(12, 389);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(166, 34);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(55, 196);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(0, 20);
            label2.TabIndex = 8;
            // 
            // listbox_Appointments
            // 
            listbox_Appointments.FormattingEnabled = true;
            listbox_Appointments.ItemHeight = 20;
            listbox_Appointments.Location = new System.Drawing.Point(86, 198);
            listbox_Appointments.Name = "listbox_Appointments";
            listbox_Appointments.Size = new System.Drawing.Size(638, 164);
            listbox_Appointments.TabIndex = 10;
            // 
            // lblPatientFound
            // 
            lblPatientFound.AutoSize = true;
            lblPatientFound.Location = new System.Drawing.Point(86, 175);
            lblPatientFound.Name = "lblPatientFound";
            lblPatientFound.Size = new System.Drawing.Size(0, 20);
            lblPatientFound.TabIndex = 11;
            // 
            // lblManageAppointment
            // 
            lblManageAppointment.AutoSize = true;
            lblManageAppointment.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblManageAppointment.Location = new System.Drawing.Point(193, 56);
            lblManageAppointment.Name = "lblManageAppointment";
            lblManageAppointment.Size = new System.Drawing.Size(387, 35);
            lblManageAppointment.TabIndex = 12;
            lblManageAppointment.Text = "Manage existing appointment";
            // 
            // ManageAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblManageAppointment);
            Controls.Add(lblPatientFound);
            Controls.Add(listbox_Appointments);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateAppointment);
            Controls.Add(btnRemoveAppointment);
            Controls.Add(txtGetPersonalNumber);
            Controls.Add(btnShowAppointments);
            Controls.Add(lblPersonalNumber);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ManageAppointmentViewForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ManageAppointmentViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPersonalNumber;
        private System.Windows.Forms.Button btnShowAppointments;
        private System.Windows.Forms.TextBox txtGetPersonalNumber;
        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnRemoveAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listbox_Appointments;
        private System.Windows.Forms.Label lblPatientFound;
        private System.Windows.Forms.Label lblManageAppointment;
    }
}