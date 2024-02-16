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
            lblProvideInfo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // txtNewvalue
            // 
            txtNewvalue.Location = new System.Drawing.Point(344, 102);
            txtNewvalue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            txtNewvalue.Name = "txtNewvalue";
            txtNewvalue.Size = new System.Drawing.Size(323, 31);
            txtNewvalue.TabIndex = 0;
            // 
            // lblNewvalue
            // 
            lblNewvalue.AutoSize = true;
            lblNewvalue.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNewvalue.Location = new System.Drawing.Point(231, 108);
            lblNewvalue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNewvalue.Name = "lblNewvalue";
            lblNewvalue.Size = new System.Drawing.Size(105, 23);
            lblNewvalue.TabIndex = 4;
            lblNewvalue.Text = "New value:";
            // 
            // btnUpdatePatient
            // 
            btnUpdatePatient.BackColor = System.Drawing.Color.White;
            btnUpdatePatient.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdatePatient.Location = new System.Drawing.Point(632, 439);
            btnUpdatePatient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnUpdatePatient.Name = "btnUpdatePatient";
            btnUpdatePatient.Size = new System.Drawing.Size(196, 62);
            btnUpdatePatient.TabIndex = 8;
            btnUpdatePatient.Text = "Update patient";
            btnUpdatePatient.UseVisualStyleBackColor = false;
            btnUpdatePatient.Click += btnUpdatePatient_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(195, 439);
            btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(196, 62);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblProvideInfo
            // 
            lblProvideInfo.AutoSize = true;
            lblProvideInfo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblProvideInfo.Location = new System.Drawing.Point(344, 40);
            lblProvideInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProvideInfo.Name = "lblProvideInfo";
            lblProvideInfo.Size = new System.Drawing.Size(289, 33);
            lblProvideInfo.TabIndex = 10;
            lblProvideInfo.Text = "Provide new information";
            // 
            // UpdateViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(1000, 562);
            Controls.Add(lblProvideInfo);
            Controls.Add(btnBack);
            Controls.Add(btnUpdatePatient);
            Controls.Add(lblNewvalue);
            Controls.Add(txtNewvalue);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label lblProvideInfo;
    }
}