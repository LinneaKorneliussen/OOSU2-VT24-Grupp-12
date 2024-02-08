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
            btnUpdate = new System.Windows.Forms.Button();
            btnRemoveAppointment = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btnBack = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lbxAppointments = new System.Windows.Forms.ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPersonalNumber
            // 
            lblPersonalNumber.AutoSize = true;
            lblPersonalNumber.Location = new System.Drawing.Point(86, 145);
            lblPersonalNumber.Name = "lblPersonalNumber";
            lblPersonalNumber.Size = new System.Drawing.Size(122, 20);
            lblPersonalNumber.TabIndex = 0;
            lblPersonalNumber.Text = "Personal number:";
            // 
            // btnShowAppointments
            // 
            btnShowAppointments.BackColor = System.Drawing.Color.RosyBrown;
            btnShowAppointments.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnShowAppointments.Location = new System.Drawing.Point(559, 138);
            btnShowAppointments.Name = "btnShowAppointments";
            btnShowAppointments.Size = new System.Drawing.Size(153, 27);
            btnShowAppointments.TabIndex = 1;
            btnShowAppointments.Text = "Show appointments";
            btnShowAppointments.UseVisualStyleBackColor = false;
            btnShowAppointments.Click += btnShowAppointments_Click;
            // 
            // txtGetPersonalNumber
            // 
            txtGetPersonalNumber.Location = new System.Drawing.Point(242, 138);
            txtGetPersonalNumber.Name = "txtGetPersonalNumber";
            txtGetPersonalNumber.Size = new System.Drawing.Size(269, 27);
            txtGetPersonalNumber.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.RosyBrown;
            btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(524, 389);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(176, 45);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update appointment";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnRemoveAppointment
            // 
            btnRemoveAppointment.BackColor = System.Drawing.Color.RosyBrown;
            btnRemoveAppointment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRemoveAppointment.Location = new System.Drawing.Point(193, 389);
            btnRemoveAppointment.Name = "btnRemoveAppointment";
            btnRemoveAppointment.Size = new System.Drawing.Size(176, 49);
            btnRemoveAppointment.TabIndex = 5;
            btnRemoveAppointment.Text = "Remove appointment";
            btnRemoveAppointment.UseVisualStyleBackColor = false;
            btnRemoveAppointment.Click += btnRemoveAppointment_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGray;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 62);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(193, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(405, 32);
            label1.TabIndex = 0;
            label1.Text = "Managing existing appointments";
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.RosyBrown;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(23, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
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
            // lbxAppointments
            // 
            lbxAppointments.FormattingEnabled = true;
            lbxAppointments.ItemHeight = 20;
            lbxAppointments.Location = new System.Drawing.Point(86, 181);
            lbxAppointments.Name = "lbxAppointments";
            lbxAppointments.Size = new System.Drawing.Size(638, 184);
            lbxAppointments.TabIndex = 10;
            // 
            // ManageAppointmentViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lbxAppointments);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemoveAppointment);
            Controls.Add(panel1);
            Controls.Add(txtGetPersonalNumber);
            Controls.Add(btnShowAppointments);
            Controls.Add(lblPersonalNumber);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "ManageAppointmentViewForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "ManageAppointmentViewForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPersonalNumber;
        private System.Windows.Forms.Button btnShowAppointments;
        private System.Windows.Forms.TextBox txtGetPersonalNumber;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxAppointments;
    }
}