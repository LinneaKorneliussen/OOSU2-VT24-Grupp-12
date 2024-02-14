namespace PatientMSWinForms
{
    partial class RegisterPrescriptionViewForm
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
            lblPatientFound = new System.Windows.Forms.Label();
            lblEnterDose = new System.Windows.Forms.Label();
            lblEnterMedicine = new System.Windows.Forms.Label();
            lblEnterPrescriptionDate = new System.Windows.Forms.Label();
            txtPersonalNumber = new System.Windows.Forms.TextBox();
            txtMedicineName = new System.Windows.Forms.TextBox();
            txtDose = new System.Windows.Forms.TextBox();
            txtPrescriptionDate = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnAddPrescription = new System.Windows.Forms.Button();
            lblRegisterprescription = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblPersonalNumber
            // 
            lblPersonalNumber.AutoSize = true;
            lblPersonalNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPersonalNumber.Location = new System.Drawing.Point(153, 118);
            lblPersonalNumber.Name = "lblPersonalNumber";
            lblPersonalNumber.Size = new System.Drawing.Size(144, 17);
            lblPersonalNumber.TabIndex = 0;
            lblPersonalNumber.Text = "Enter personal number:";
            lblPersonalNumber.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblPatientFound
            // 
            lblPatientFound.AutoSize = true;
            lblPatientFound.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPatientFound.Location = new System.Drawing.Point(153, 161);
            lblPatientFound.Name = "lblPatientFound";
            lblPatientFound.Size = new System.Drawing.Size(89, 17);
            lblPatientFound.TabIndex = 1;
            lblPatientFound.Text = "Patient found:";
            // 
            // lblEnterDose
            // 
            lblEnterDose.AutoSize = true;
            lblEnterDose.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEnterDose.Location = new System.Drawing.Point(223, 278);
            lblEnterDose.Name = "lblEnterDose";
            lblEnterDose.Size = new System.Drawing.Size(74, 17);
            lblEnterDose.TabIndex = 2;
            lblEnterDose.Text = "Enter dose:";
            // 
            // lblEnterMedicine
            // 
            lblEnterMedicine.AutoSize = true;
            lblEnterMedicine.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEnterMedicine.Location = new System.Drawing.Point(162, 239);
            lblEnterMedicine.Name = "lblEnterMedicine";
            lblEnterMedicine.Size = new System.Drawing.Size(135, 17);
            lblEnterMedicine.TabIndex = 3;
            lblEnterMedicine.Text = "Enter medicine name:";
            // 
            // lblEnterPrescriptionDate
            // 
            lblEnterPrescriptionDate.AutoSize = true;
            lblEnterPrescriptionDate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEnterPrescriptionDate.Location = new System.Drawing.Point(153, 320);
            lblEnterPrescriptionDate.Name = "lblEnterPrescriptionDate";
            lblEnterPrescriptionDate.Size = new System.Drawing.Size(144, 17);
            lblEnterPrescriptionDate.TabIndex = 4;
            lblEnterPrescriptionDate.Text = "Enter prescription date:";
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Location = new System.Drawing.Point(313, 112);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtPersonalNumber.Size = new System.Drawing.Size(293, 27);
            txtPersonalNumber.TabIndex = 5;
            // 
            // txtMedicineName
            // 
            txtMedicineName.Location = new System.Drawing.Point(303, 233);
            txtMedicineName.Name = "txtMedicineName";
            txtMedicineName.Size = new System.Drawing.Size(293, 27);
            txtMedicineName.TabIndex = 6;
            // 
            // txtDose
            // 
            txtDose.Location = new System.Drawing.Point(303, 272);
            txtDose.Name = "txtDose";
            txtDose.Size = new System.Drawing.Size(293, 27);
            txtDose.TabIndex = 7;
            // 
            // txtPrescriptionDate
            // 
            txtPrescriptionDate.Location = new System.Drawing.Point(303, 314);
            txtPrescriptionDate.Name = "txtPrescriptionDate";
            txtPrescriptionDate.PlaceholderText = "yyyy-mm-dd hh:mm";
            txtPrescriptionDate.Size = new System.Drawing.Size(293, 27);
            txtPrescriptionDate.TabIndex = 8;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(638, 112);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnFind_Click;
            // 
            // btnAddPrescription
            // 
            btnAddPrescription.BackColor = System.Drawing.Color.RosyBrown;
            btnAddPrescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddPrescription.Location = new System.Drawing.Point(638, 363);
            btnAddPrescription.Name = "btnAddPrescription";
            btnAddPrescription.Size = new System.Drawing.Size(111, 49);
            btnAddPrescription.TabIndex = 10;
            btnAddPrescription.Text = "Add new prescription";
            btnAddPrescription.UseVisualStyleBackColor = false;
            btnAddPrescription.Click += btnAddPrescription_Click;
            // 
            // lblRegisterprescription
            // 
            lblRegisterprescription.AutoSize = true;
            lblRegisterprescription.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRegisterprescription.Location = new System.Drawing.Point(223, 47);
            lblRegisterprescription.Name = "lblRegisterprescription";
            lblRegisterprescription.Size = new System.Drawing.Size(317, 32);
            lblRegisterprescription.TabIndex = 11;
            lblRegisterprescription.Text = "Register new prescription";
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.RosyBrown;
            btnClose.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Location = new System.Drawing.Point(26, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.RosyBrown;
            btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClear.Location = new System.Drawing.Point(344, 409);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // RegisterPrescriptionViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnClose);
            Controls.Add(lblRegisterprescription);
            Controls.Add(btnAddPrescription);
            Controls.Add(btnSearch);
            Controls.Add(txtPrescriptionDate);
            Controls.Add(txtDose);
            Controls.Add(txtMedicineName);
            Controls.Add(txtPersonalNumber);
            Controls.Add(lblEnterPrescriptionDate);
            Controls.Add(lblEnterMedicine);
            Controls.Add(lblEnterDose);
            Controls.Add(lblPatientFound);
            Controls.Add(lblPersonalNumber);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "RegisterPrescriptionViewForm";
            Text = "RegisterPrescriptionViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPersonalNumber;
        private System.Windows.Forms.Label lblPatientFound;
        private System.Windows.Forms.Label lblEnterDose;
        private System.Windows.Forms.Label lblEnterMedicine;
        private System.Windows.Forms.Label lblEnterPrescriptionDate;
        private System.Windows.Forms.TextBox txtPersonalNumber;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtDose;
        private System.Windows.Forms.TextBox txtPrescriptionDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.Label lblRegisterprescription;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
    }
}