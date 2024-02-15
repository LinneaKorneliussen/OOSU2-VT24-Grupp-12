namespace PatientMSWinForms
{
    partial class UpdateAppointmentViewForm
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
            btnUpdateAppointment = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            lblProvideNewDateAndTime = new System.Windows.Forms.Label();
            lblNewDateAndTime = new System.Windows.Forms.Label();
            txtDateTimeInfo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.BackColor = System.Drawing.Color.White;
            btnUpdateAppointment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdateAppointment.Location = new System.Drawing.Point(297, 143);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new System.Drawing.Size(118, 44);
            btnUpdateAppointment.TabIndex = 0;
            btnUpdateAppointment.Text = "Update";
            btnUpdateAppointment.UseVisualStyleBackColor = false;
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(80, 143);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(118, 44);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblProvideNewDateAndTime
            // 
            lblProvideNewDateAndTime.AutoSize = true;
            lblProvideNewDateAndTime.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblProvideNewDateAndTime.Location = new System.Drawing.Point(85, 23);
            lblProvideNewDateAndTime.Name = "lblProvideNewDateAndTime";
            lblProvideNewDateAndTime.Size = new System.Drawing.Size(330, 32);
            lblProvideNewDateAndTime.TabIndex = 2;
            lblProvideNewDateAndTime.Text = "Provide new date and time";
            // 
            // lblNewDateAndTime
            // 
            lblNewDateAndTime.AutoSize = true;
            lblNewDateAndTime.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNewDateAndTime.Location = new System.Drawing.Point(30, 87);
            lblNewDateAndTime.Name = "lblNewDateAndTime";
            lblNewDateAndTime.Size = new System.Drawing.Size(212, 17);
            lblNewDateAndTime.TabIndex = 3;
            lblNewDateAndTime.Text = "Date and time for the appointment:";
            // 
            // txtDateTimeInfo
            // 
            txtDateTimeInfo.Location = new System.Drawing.Point(256, 81);
            txtDateTimeInfo.Name = "txtDateTimeInfo";
            txtDateTimeInfo.PlaceholderText = "yyyy-mm-dd hh:mm";
            txtDateTimeInfo.Size = new System.Drawing.Size(215, 27);
            txtDateTimeInfo.TabIndex = 4;
            // 
            // UpdateAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(538, 241);
            Controls.Add(txtDateTimeInfo);
            Controls.Add(lblNewDateAndTime);
            Controls.Add(lblProvideNewDateAndTime);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateAppointment);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "UpdateAppointmentViewForm";
            Text = "UpdateAppointmentViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblProvideNewDateAndTime;
        private System.Windows.Forms.Label lblNewDateAndTime;
        private System.Windows.Forms.TextBox txtDateTimeInfo;
    }
}