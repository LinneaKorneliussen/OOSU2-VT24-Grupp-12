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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtDateTimeInfo = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnUpdateAppointment
            // 
            btnUpdateAppointment.BackColor = System.Drawing.Color.RosyBrown;
            btnUpdateAppointment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdateAppointment.Location = new System.Drawing.Point(427, 352);
            btnUpdateAppointment.Name = "btnUpdateAppointment";
            btnUpdateAppointment.Size = new System.Drawing.Size(91, 29);
            btnUpdateAppointment.TabIndex = 0;
            btnUpdateAppointment.Text = "Update";
            btnUpdateAppointment.UseVisualStyleBackColor = false;
            btnUpdateAppointment.Click += btnUpdateAppointment_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.RosyBrown;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(303, 352);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(217, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(330, 32);
            label1.TabIndex = 2;
            label1.Text = "Provide new date and time";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(74, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(212, 17);
            label2.TabIndex = 3;
            label2.Text = "Date and time for the appointment:";
            // 
            // txtDateTimeInfo
            // 
            txtDateTimeInfo.Location = new System.Drawing.Point(303, 140);
            txtDateTimeInfo.Name = "txtDateTimeInfo";
            txtDateTimeInfo.Size = new System.Drawing.Size(215, 27);
            txtDateTimeInfo.TabIndex = 4;
            // 
            // UpdateAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtDateTimeInfo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateAppointment);
            Name = "UpdateAppointmentViewForm";
            Text = "UpdateAppointmentViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDateTimeInfo;
    }
}