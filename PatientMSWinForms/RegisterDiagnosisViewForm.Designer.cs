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
            textBox1 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnFind = new System.Windows.Forms.Button();
            lbl_DisplayPInfo = new System.Windows.Forms.Label();
            textBox2 = new System.Windows.Forms.TextBox();
            textBox3 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            btnAddDiagnosis = new System.Windows.Forms.Button();
            btnClose = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(302, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 25);
            label1.TabIndex = 0;
            label1.Text = "New diagnosis registration";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(302, 116);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "yyyy-mm-dd-xxxx";
            textBox1.Size = new System.Drawing.Size(324, 31);
            textBox1.TabIndex = 1;
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
            lbl_DisplayPInfo.Location = new System.Drawing.Point(136, 180);
            lbl_DisplayPInfo.Name = "lbl_DisplayPInfo";
            lbl_DisplayPInfo.Size = new System.Drawing.Size(115, 20);
            lbl_DisplayPInfo.TabIndex = 4;
            lbl_DisplayPInfo.Text = "Patient found: ";
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(306, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(321, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(306, 366);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(321, 31);
            textBox3.TabIndex = 6;
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
            // RegisterDiagnosisViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(892, 530);
            Controls.Add(btnClose);
            Controls.Add(btnAddDiagnosis);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lbl_DisplayPInfo);
            Controls.Add(btnFind);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "RegisterDiagnosisViewForm";
            Text = "Register new diagnosis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lbl_DisplayPInfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnClose;
    }
}