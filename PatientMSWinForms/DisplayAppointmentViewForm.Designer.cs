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
            label1.Location = new System.Drawing.Point(74, 145);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(177, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter personal number:";
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new System.Drawing.Point(261, 139);
            txtPersonalNumber.Margin = new System.Windows.Forms.Padding(4);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new System.Drawing.Size(465, 31);
            txtPersonalNumber.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(751, 139);
            btnSearch.Margin = new System.Windows.Forms.Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(118, 36);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listBox_Appointments
            // 
            listBox_Appointments.FormattingEnabled = true;
            listBox_Appointments.ItemHeight = 25;
            listBox_Appointments.Location = new System.Drawing.Point(74, 215);
            listBox_Appointments.Margin = new System.Windows.Forms.Padding(4);
            listBox_Appointments.Name = "listBox_Appointments";
            listBox_Appointments.Size = new System.Drawing.Size(1188, 329);
            listBox_Appointments.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new System.Drawing.Point(1039, 579);
            btnBack.Margin = new System.Windows.Forms.Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(224, 70);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(449, 45);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(346, 41);
            label2.TabIndex = 6;
            label2.Text = "Display appointments";
            // 
            // lblPatientFound
            // 
            lblPatientFound.AutoSize = true;
            lblPatientFound.Location = new System.Drawing.Point(74, 186);
            lblPatientFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientFound.Name = "lblPatientFound";
            lblPatientFound.Size = new System.Drawing.Size(0, 25);
            lblPatientFound.TabIndex = 7;
            // 
            // DisplayAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(1341, 700);
            Controls.Add(lblPatientFound);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(listBox_Appointments);
            Controls.Add(btnSearch);
            Controls.Add(txtPersonalNumber);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
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