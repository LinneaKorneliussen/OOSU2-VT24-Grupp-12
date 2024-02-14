namespace PatientMSWinForms
{
    partial class RegisterDiagnosisViewForm
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
            lblNewdiagnosis = new System.Windows.Forms.Label();
            txtSSN = new System.Windows.Forms.TextBox();
            lblEnterPatientnumber = new System.Windows.Forms.Label();
            btnFind = new System.Windows.Forms.Button();
            lbl_DisplayPInfo = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            txtTreatmentplan = new System.Windows.Forms.TextBox();
            lblEnterdescription = new System.Windows.Forms.Label();
            lblEntertreatment = new System.Windows.Forms.Label();
            btnAddDiagnosis = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNewdiagnosis
            // 
            lblNewdiagnosis.AutoSize = true;
            lblNewdiagnosis.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNewdiagnosis.Location = new System.Drawing.Point(246, 18);
            lblNewdiagnosis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblNewdiagnosis.Name = "lblNewdiagnosis";
            lblNewdiagnosis.Size = new System.Drawing.Size(206, 21);
            lblNewdiagnosis.TabIndex = 0;
            lblNewdiagnosis.Text = "New diagnosis registration";
            // 
            // txtSSN
            // 
            txtSSN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSSN.Location = new System.Drawing.Point(242, 93);
            txtSSN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtSSN.Name = "txtSSN";
            txtSSN.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtSSN.Size = new System.Drawing.Size(260, 27);
            txtSSN.TabIndex = 1;
            // 
            // lblEnterPatientnumber
            // 
            lblEnterPatientnumber.AutoSize = true;
            lblEnterPatientnumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEnterPatientnumber.Location = new System.Drawing.Point(109, 98);
            lblEnterPatientnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEnterPatientnumber.Name = "lblEnterPatientnumber";
            lblEnterPatientnumber.Size = new System.Drawing.Size(130, 17);
            lblEnterPatientnumber.TabIndex = 2;
            lblEnterPatientnumber.Text = "Enter patientnumber:";
            // 
            // btnFind
            // 
            btnFind.BackColor = System.Drawing.Color.White;
            btnFind.Location = new System.Drawing.Point(518, 92);
            btnFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(87, 26);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // lbl_DisplayPInfo
            // 
            lbl_DisplayPInfo.AutoSize = true;
            lbl_DisplayPInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_DisplayPInfo.Location = new System.Drawing.Point(109, 153);
            lbl_DisplayPInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lbl_DisplayPInfo.Name = "lbl_DisplayPInfo";
            lbl_DisplayPInfo.Size = new System.Drawing.Size(0, 17);
            lbl_DisplayPInfo.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(245, 227);
            txtDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(258, 27);
            txtDescription.TabIndex = 5;
            // 
            // txtTreatmentplan
            // 
            txtTreatmentplan.Location = new System.Drawing.Point(245, 293);
            txtTreatmentplan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            txtTreatmentplan.Name = "txtTreatmentplan";
            txtTreatmentplan.Size = new System.Drawing.Size(258, 27);
            txtTreatmentplan.TabIndex = 6;
            // 
            // lblEnterdescription
            // 
            lblEnterdescription.AutoSize = true;
            lblEnterdescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEnterdescription.Location = new System.Drawing.Point(73, 233);
            lblEnterdescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEnterdescription.Name = "lblEnterdescription";
            lblEnterdescription.Size = new System.Drawing.Size(167, 17);
            lblEnterdescription.TabIndex = 7;
            lblEnterdescription.Text = "Enter diagnosis description:";
            // 
            // lblEntertreatment
            // 
            lblEntertreatment.AutoSize = true;
            lblEntertreatment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEntertreatment.Location = new System.Drawing.Point(109, 298);
            lblEntertreatment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEntertreatment.Name = "lblEntertreatment";
            lblEntertreatment.Size = new System.Drawing.Size(127, 17);
            lblEntertreatment.TabIndex = 8;
            lblEntertreatment.Text = "Enter treatmentplan:";
            // 
            // btnAddDiagnosis
            // 
            btnAddDiagnosis.BackColor = System.Drawing.Color.White;
            btnAddDiagnosis.Location = new System.Drawing.Point(535, 349);
            btnAddDiagnosis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnAddDiagnosis.Name = "btnAddDiagnosis";
            btnAddDiagnosis.Size = new System.Drawing.Size(134, 49);
            btnAddDiagnosis.TabIndex = 9;
            btnAddDiagnosis.Text = "Add new diagnosis";
            btnAddDiagnosis.UseVisualStyleBackColor = false;
            btnAddDiagnosis.Click += btnAddDiagnosis_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(26, 369);
            btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            panel1.Controls.Add(lblNewdiagnosis);
            panel1.Location = new System.Drawing.Point(-1, 0);
            panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(714, 48);
            panel1.TabIndex = 11;
            // 
            // RegisterDiagnosisViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(714, 424);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnAddDiagnosis);
            Controls.Add(lblEntertreatment);
            Controls.Add(lblEnterdescription);
            Controls.Add(txtTreatmentplan);
            Controls.Add(txtDescription);
            Controls.Add(lbl_DisplayPInfo);
            Controls.Add(btnFind);
            Controls.Add(lblEnterPatientnumber);
            Controls.Add(txtSSN);
            Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            Name = "RegisterDiagnosisViewForm";
            Text = "Register new diagnosis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNewdiagnosis;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblEnterPatientnumber;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbl_DisplayPInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTreatmentplan;
        private System.Windows.Forms.Label lblEnterdescription;
        private System.Windows.Forms.Label lblEntertreatment;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}