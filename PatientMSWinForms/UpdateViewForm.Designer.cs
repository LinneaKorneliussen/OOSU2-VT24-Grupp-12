namespace PatientMSWinForms
{
    partial class UpdateViewForm
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
            txtNewvalue = new System.Windows.Forms.TextBox();
            lblNewvalue = new System.Windows.Forms.Label();
            btnUpdatePatient = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtNewvalue
            // 
            txtNewvalue.Location = new System.Drawing.Point(275, 82);
            txtNewvalue.Name = "txtNewvalue";
            txtNewvalue.Size = new System.Drawing.Size(259, 27);
            txtNewvalue.TabIndex = 0;
            // 
            // lblNewvalue
            // 
            lblNewvalue.AutoSize = true;
            lblNewvalue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNewvalue.Location = new System.Drawing.Point(185, 86);
            lblNewvalue.Name = "lblNewvalue";
            lblNewvalue.Size = new System.Drawing.Size(84, 19);
            lblNewvalue.TabIndex = 4;
            lblNewvalue.Text = "New value:";
            // 
            // btnUpdatePatient
            // 
            btnUpdatePatient.BackColor = System.Drawing.Color.White;
            btnUpdatePatient.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdatePatient.Location = new System.Drawing.Point(506, 351);
            btnUpdatePatient.Name = "btnUpdatePatient";
            btnUpdatePatient.Size = new System.Drawing.Size(157, 50);
            btnUpdatePatient.TabIndex = 8;
            btnUpdatePatient.Text = "Update patient";
            btnUpdatePatient.UseVisualStyleBackColor = false;
            btnUpdatePatient.Click += btnUpdatePatient_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(156, 351);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(157, 50);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(275, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(186, 26);
            label1.TabIndex = 10;
            label1.Text = "lblProvidenewinfo";
            // 
            // UpdateViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnUpdatePatient);
            Controls.Add(lblNewvalue);
            Controls.Add(txtNewvalue);
            Name = "UpdateViewForm";
            Text = "Enter new information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtNewvalue;
        private System.Windows.Forms.Label lblNewvalue;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}