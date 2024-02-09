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
            label1 = new System.Windows.Forms.Label();
            txtSSN = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnFind = new System.Windows.Forms.Button();
            lbl_DisplayPInfo = new System.Windows.Forms.Label();
            txtDescription = new System.Windows.Forms.TextBox();
            txtTreatmentplan = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnAddDiagnosis = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(307, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 25);
            label1.TabIndex = 0;
            label1.Text = "New diagnosis registration";
            // 
            // txtSSN
            // 
            txtSSN.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSSN.Location = new System.Drawing.Point(302, 116);
            txtSSN.Name = "txtSSN";
            txtSSN.PlaceholderText = "yyyy-mm-dd-xxxx";
            txtSSN.Size = new System.Drawing.Size(324, 30);
            txtSSN.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(136, 123);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(160, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter patientnumber:";
            // 
            // btnFind
            // 
            btnFind.BackColor = System.Drawing.Color.White;
            btnFind.Location = new System.Drawing.Point(648, 115);
            btnFind.Name = "btnFind";
            btnFind.Size = new System.Drawing.Size(109, 32);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // lbl_DisplayPInfo
            // 
            lbl_DisplayPInfo.AutoSize = true;
            lbl_DisplayPInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_DisplayPInfo.Location = new System.Drawing.Point(136, 191);
            lbl_DisplayPInfo.Name = "lbl_DisplayPInfo";
            lbl_DisplayPInfo.Size = new System.Drawing.Size(0, 20);
            lbl_DisplayPInfo.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(306, 284);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(321, 31);
            txtDescription.TabIndex = 5;
            // 
            // txtTreatmentplan
            // 
            txtTreatmentplan.Location = new System.Drawing.Point(306, 366);
            txtTreatmentplan.Name = "txtTreatmentplan";
            txtTreatmentplan.Size = new System.Drawing.Size(321, 31);
            txtTreatmentplan.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(91, 291);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(205, 20);
            label3.TabIndex = 7;
            label3.Text = "Enter diagnosis description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(136, 373);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(155, 20);
            label4.TabIndex = 8;
            label4.Text = "Enter treatmentplan:";
            // 
            // btnAddDiagnosis
            // 
            btnAddDiagnosis.BackColor = System.Drawing.Color.White;
            btnAddDiagnosis.Location = new System.Drawing.Point(669, 436);
            btnAddDiagnosis.Name = "btnAddDiagnosis";
            btnAddDiagnosis.Size = new System.Drawing.Size(167, 61);
            btnAddDiagnosis.TabIndex = 9;
            btnAddDiagnosis.Text = "Add new diagnosis";
            btnAddDiagnosis.UseVisualStyleBackColor = false;
            btnAddDiagnosis.Click += btnAddDiagnosis_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = System.Drawing.Color.White;
            btnClose.Location = new System.Drawing.Point(32, 461);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(118, 36);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(893, 60);
            panel1.TabIndex = 11;
            // 
            // RegisterDiagnosisViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(892, 530);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnAddDiagnosis);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTreatmentplan);
            Controls.Add(txtDescription);
            Controls.Add(lbl_DisplayPInfo);
            Controls.Add(btnFind);
            Controls.Add(label2);
            Controls.Add(txtSSN);
            Name = "RegisterDiagnosisViewForm";
            Text = "Register new diagnosis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbl_DisplayPInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtTreatmentplan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
    }
}