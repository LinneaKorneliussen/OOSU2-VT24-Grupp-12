namespace PatientMSWinForms
{
    partial class LogInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            txtStaffID = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogIn = new System.Windows.Forms.Button();
            lblStaffID = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblPatientms = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            pictureLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLoading).BeginInit();
            SuspendLayout();
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(371, 149);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(191, 27);
            txtStaffID.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(371, 223);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(191, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = System.Drawing.Color.MistyRose;
            btnLogIn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogIn.Location = new System.Drawing.Point(442, 319);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new System.Drawing.Size(131, 39);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblStaffID.Location = new System.Drawing.Point(228, 159);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new System.Drawing.Size(56, 17);
            lblStaffID.TabIndex = 3;
            lblStaffID.Text = "StaffID:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(228, 229);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(69, 17);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblPatientms
            // 
            lblPatientms.AutoSize = true;
            lblPatientms.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPatientms.Location = new System.Drawing.Point(228, 62);
            lblPatientms.Name = "lblPatientms";
            lblPatientms.Size = new System.Drawing.Size(316, 34);
            lblPatientms.TabIndex = 5;
            lblPatientms.Text = "Patient Managing System";
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.MistyRose;
            btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(209, 319);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(123, 39);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureLoading
            // 
            pictureLoading.BackColor = System.Drawing.Color.MistyRose;
            pictureLoading.Image = (System.Drawing.Image)resources.GetObject("pictureLoading.Image");
            pictureLoading.Location = new System.Drawing.Point(629, 419);
            pictureLoading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            pictureLoading.Name = "pictureLoading";
            pictureLoading.Size = new System.Drawing.Size(138, 118);
            pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureLoading.TabIndex = 7;
            pictureLoading.TabStop = false;
            pictureLoading.Visible = false;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(790, 563);
            Controls.Add(pictureLoading);
            Controls.Add(btnClear);
            Controls.Add(lblPatientms);
            Controls.Add(lblPassword);
            Controls.Add(lblStaffID);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtStaffID);
            Name = "LogInForm";
            Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)pictureLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPatientms;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureLoading;
    }
}
