namespace PatientMSWinForms
{
    partial class DisplayAppointmentViewForm
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
            label1 = new System.Windows.Forms.Label();
            txtPersonalNumber = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            listBox_Appointments = new System.Windows.Forms.ListBox();
            btnBack = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lblPatientFound = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(59, 116);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 17);
            label1.TabIndex = 0;
            label1.Text = "Enter personal number:";
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new System.Drawing.Point(209, 111);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new System.Drawing.Size(373, 27);
            txtPersonalNumber.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(601, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBox_Appointments
            // 
            listBox_Appointments.FormattingEnabled = true;
            listBox_Appointments.ItemHeight = 20;
            listBox_Appointments.Location = new System.Drawing.Point(59, 172);
            listBox_Appointments.Name = "listBox_Appointments";
            listBox_Appointments.Size = new System.Drawing.Size(951, 264);
            listBox_Appointments.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(831, 463);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(179, 56);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(359, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(290, 35);
            label2.TabIndex = 6;
            label2.Text = "Display appointments";
            // 
            // lblPatientFound
            // 
            lblPatientFound.AutoSize = true;
            lblPatientFound.Location = new System.Drawing.Point(59, 149);
            lblPatientFound.Name = "lblPatientFound";
            lblPatientFound.Size = new System.Drawing.Size(13, 20);
            lblPatientFound.TabIndex = 7;
            lblPatientFound.Text = "l";
            // 
            // DisplayAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1073, 560);
            Controls.Add(lblPatientFound);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(listBox_Appointments);
            Controls.Add(btnSearch);
            Controls.Add(txtPersonalNumber);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "DisplayAppointmentViewForm";
            Text = "DisplayAppointmentViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonalNumber;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox listBox_Appointments;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatientFound;
    }
}