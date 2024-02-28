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
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogIn = new System.Windows.Forms.Button();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            lblPatientms = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            pictureLoading = new System.Windows.Forms.PictureBox();
            btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureLoading).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(464, 186);
            txtUsername.Margin = new System.Windows.Forms.Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(238, 31);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(464, 279);
            txtPassword.Margin = new System.Windows.Forms.Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(238, 31);
            txtPassword.TabIndex = 1;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = System.Drawing.Color.MistyRose;
            btnLogIn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLogIn.Location = new System.Drawing.Point(552, 399);
            btnLogIn.Margin = new System.Windows.Forms.Padding(4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new System.Drawing.Size(164, 49);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUsername.Location = new System.Drawing.Point(285, 199);
            lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(86, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(285, 286);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(83, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblPatientms
            // 
            lblPatientms.AutoSize = true;
            lblPatientms.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPatientms.Location = new System.Drawing.Point(285, 78);
            lblPatientms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientms.Name = "lblPatientms";
            lblPatientms.Size = new System.Drawing.Size(378, 41);
            lblPatientms.TabIndex = 5;
            lblPatientms.Text = "Patient Managing System";
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.MistyRose;
            btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(285, 399);
            btnClear.Margin = new System.Windows.Forms.Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(154, 49);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // pictureLoading
            // 
            pictureLoading.BackColor = System.Drawing.Color.MistyRose;
            pictureLoading.Image = (System.Drawing.Image)resources.GetObject("pictureLoading.Image");
            pictureLoading.Location = new System.Drawing.Point(786, 524);
            pictureLoading.Margin = new System.Windows.Forms.Padding(2);
            pictureLoading.Name = "pictureLoading";
            pictureLoading.Size = new System.Drawing.Size(172, 148);
            pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureLoading.TabIndex = 7;
            pictureLoading.TabStop = false;
            pictureLoading.Visible = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = System.Drawing.Color.MistyRose;
            btnExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExit.Location = new System.Drawing.Point(43, 609);
            btnExit.Margin = new System.Windows.Forms.Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(154, 49);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(988, 704);
            Controls.Add(btnExit);
            Controls.Add(pictureLoading);
            Controls.Add(btnClear);
            Controls.Add(lblPatientms);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Margin = new System.Windows.Forms.Padding(4);
            Name = "LogInForm";
            Text = "Log in";
            ((System.ComponentModel.ISupportInitialize)pictureLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPatientms;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureLoading;
        private System.Windows.Forms.Button btnExit;
    }
}
