namespace PatientMSWinForms
{
    partial class RegisterPatientViewForm
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
            lblHeadline = new System.Windows.Forms.Label();
            txtMail = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtSSN = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.BackColor = System.Drawing.Color.Transparent;
            lblHeadline.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHeadline.Location = new System.Drawing.Point(296, 24);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new System.Drawing.Size(230, 25);
            lblHeadline.TabIndex = 1;
            lblHeadline.Text = "New Patient Registration";
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(136, 306);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(276, 31);
            txtMail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(131, 130);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 20);
            label2.TabIndex = 8;
            label2.Text = "Patient Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(451, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(188, 20);
            label3.TabIndex = 9;
            label3.Text = "Patient personal number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(131, 207);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(125, 20);
            label4.TabIndex = 10;
            label4.Text = "Patient Address:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(451, 207);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(167, 20);
            label5.TabIndex = 11;
            label5.Text = "Patient phonenumber:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(131, 283);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(160, 20);
            label6.TabIndex = 12;
            label6.Text = "Patient emailaddress:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.White;
            btnRegister.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegister.Location = new System.Drawing.Point(670, 436);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(128, 33);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.White;
            btnClose.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(37, 436);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(128, 33);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.White;
            btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(354, 436);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(128, 33);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(136, 153);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "First Name and Last Name";
            txtName.Size = new System.Drawing.Size(271, 30);
            txtName.TabIndex = 16;
            // 
            // txtSSN
            // 
            txtSSN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSSN.Location = new System.Drawing.Point(451, 153);
            txtSSN.Name = "txtSSN";
            txtSSN.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtSSN.Size = new System.Drawing.Size(257, 30);
            txtSSN.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(136, 230);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(276, 31);
            txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(451, 230);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(257, 31);
            txtPhone.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            panel1.Controls.Add(lblHeadline);
            panel1.Location = new System.Drawing.Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(837, 69);
            panel1.TabIndex = 20;
            // 
            // RegisterPatientViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(836, 511);
            Controls.Add(panel1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtSSN);
            Controls.Add(txtName);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMail);
            Name = "RegisterPatientViewForm";
            Text = "Registrer new patient";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHeadline;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel1;
    }
}