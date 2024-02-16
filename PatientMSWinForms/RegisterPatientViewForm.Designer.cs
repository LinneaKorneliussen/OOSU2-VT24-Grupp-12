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
            lblName = new System.Windows.Forms.Label();
            lblPersonalNumber = new System.Windows.Forms.Label();
            lblAdress = new System.Windows.Forms.Label();
            lblPhonenumber = new System.Windows.Forms.Label();
            lblEmailadress = new System.Windows.Forms.Label();
            btnRegister = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            txtSSN = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtPhone = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            lblMandatoryfield = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeadline
            // 
            lblHeadline.AutoSize = true;
            lblHeadline.BackColor = System.Drawing.Color.Transparent;
            lblHeadline.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblHeadline.Location = new System.Drawing.Point(237, 19);
            lblHeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblHeadline.Name = "lblHeadline";
            lblHeadline.Size = new System.Drawing.Size(193, 21);
            lblHeadline.TabIndex = 1;
            lblHeadline.Text = "New Patient Registration";
            // 
            // txtMail
            // 
            txtMail.Location = new System.Drawing.Point(109, 245);
            txtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtMail.Name = "txtMail";
            txtMail.Size = new System.Drawing.Size(222, 27);
            txtMail.TabIndex = 7;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblName.Location = new System.Drawing.Point(105, 104);
            lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(99, 17);
            lblName.TabIndex = 8;
            lblName.Text = "Patient Name:*";
            // 
            // lblPersonalNumber
            // 
            lblPersonalNumber.AutoSize = true;
            lblPersonalNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPersonalNumber.Location = new System.Drawing.Point(361, 104);
            lblPersonalNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPersonalNumber.Name = "lblPersonalNumber";
            lblPersonalNumber.Size = new System.Drawing.Size(160, 17);
            lblPersonalNumber.TabIndex = 9;
            lblPersonalNumber.Text = "Patient personal number:*";
            // 
            // lblAdress
            // 
            lblAdress.AutoSize = true;
            lblAdress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAdress.Location = new System.Drawing.Point(105, 166);
            lblAdress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblAdress.Name = "lblAdress";
            lblAdress.Size = new System.Drawing.Size(111, 17);
            lblAdress.TabIndex = 10;
            lblAdress.Text = "Patient Address:*";
            // 
            // lblPhonenumber
            // 
            lblPhonenumber.AutoSize = true;
            lblPhonenumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPhonenumber.Location = new System.Drawing.Point(361, 166);
            lblPhonenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblPhonenumber.Name = "lblPhonenumber";
            lblPhonenumber.Size = new System.Drawing.Size(142, 17);
            lblPhonenumber.TabIndex = 11;
            lblPhonenumber.Text = "Patient phonenumber:*";
            // 
            // lblEmailadress
            // 
            lblEmailadress.AutoSize = true;
            lblEmailadress.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmailadress.Location = new System.Drawing.Point(105, 226);
            lblEmailadress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEmailadress.Name = "lblEmailadress";
            lblEmailadress.Size = new System.Drawing.Size(139, 17);
            lblEmailadress.TabIndex = 12;
            lblEmailadress.Text = "Patient emailaddress:*";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = System.Drawing.Color.White;
            btnRegister.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegister.Location = new System.Drawing.Point(536, 349);
            btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(102, 26);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.White;
            btnClose.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(30, 349);
            btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(102, 26);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.White;
            btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(283, 349);
            btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(102, 26);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // txtName
            // 
            txtName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtName.Location = new System.Drawing.Point(109, 122);
            txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "First Name and Last Name";
            txtName.Size = new System.Drawing.Size(218, 27);
            txtName.TabIndex = 16;
            // 
            // txtSSN
            // 
            txtSSN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSSN.Location = new System.Drawing.Point(361, 122);
            txtSSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtSSN.Name = "txtSSN";
            txtSSN.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtSSN.Size = new System.Drawing.Size(206, 27);
            txtSSN.TabIndex = 17;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(109, 184);
            txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(222, 27);
            txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new System.Drawing.Point(361, 184);
            txtPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new System.Drawing.Size(206, 27);
            txtPhone.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            panel1.Controls.Add(lblHeadline);
            panel1.Location = new System.Drawing.Point(-1, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(670, 55);
            panel1.TabIndex = 20;
            // 
            // lblMandatoryfield
            // 
            lblMandatoryfield.AutoSize = true;
            lblMandatoryfield.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMandatoryfield.Location = new System.Drawing.Point(109, 294);
            lblMandatoryfield.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblMandatoryfield.Name = "lblMandatoryfield";
            lblMandatoryfield.Size = new System.Drawing.Size(107, 16);
            lblMandatoryfield.TabIndex = 21;
            lblMandatoryfield.Text = "* Mandatory field";
            // 
            // RegisterPatientViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(669, 409);
            Controls.Add(lblMandatoryfield);
            Controls.Add(panel1);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtSSN);
            Controls.Add(txtName);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(lblEmailadress);
            Controls.Add(lblPhonenumber);
            Controls.Add(lblAdress);
            Controls.Add(lblPersonalNumber);
            Controls.Add(lblName);
            Controls.Add(txtMail);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPersonalNumber;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblEmailadress;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMandatoryfield;
    }
}