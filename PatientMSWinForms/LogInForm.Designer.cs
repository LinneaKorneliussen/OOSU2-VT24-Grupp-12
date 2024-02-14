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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            pictureLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureLoading).BeginInit();
            SuspendLayout();
            // 
            // txtStaffID
            // 
            txtStaffID.Location = new System.Drawing.Point(464, 186);
            txtStaffID.Margin = new System.Windows.Forms.Padding(4);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.Size = new System.Drawing.Size(238, 31);
            txtStaffID.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(285, 199);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "StaffID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(285, 286);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 20);
            label2.TabIndex = 4;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(285, 78);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(378, 41);
            label3.TabIndex = 5;
            label3.Text = "Patient Managing System";
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.MistyRose;
            btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(261, 399);
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
            pictureLoading.Name = "pictureLoading";
            pictureLoading.Size = new System.Drawing.Size(173, 148);
            pictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureLoading.TabIndex = 7;
            pictureLoading.TabStop = false;
            pictureLoading.Visible = false;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(988, 704);
            Controls.Add(pictureLoading);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(txtStaffID);
            Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureLoading;
    }
}
