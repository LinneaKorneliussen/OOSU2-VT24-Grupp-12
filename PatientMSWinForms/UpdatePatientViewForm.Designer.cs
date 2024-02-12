namespace PatientMSWinForms
{
    partial class UpdatePatientViewForm
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
            btnBack = new System.Windows.Forms.Button();
            btnSearch = new System.Windows.Forms.Button();
            textPersonalnumber = new System.Windows.Forms.TextBox();
            Personalnumber = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            lblPatientInfo = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            listbox_Patient = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(155, 401);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(110, 37);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(486, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(97, 27);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSelect_Click;
            // 
            // textPersonalnumber
            // 
            textPersonalnumber.Location = new System.Drawing.Point(311, 96);
            textPersonalnumber.Name = "textPersonalnumber";
            textPersonalnumber.Size = new System.Drawing.Size(169, 27);
            textPersonalnumber.TabIndex = 3;
            // 
            // Personalnumber
            // 
            Personalnumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Personalnumber.Location = new System.Drawing.Point(187, 99);
            Personalnumber.Name = "Personalnumber";
            Personalnumber.Size = new System.Drawing.Size(114, 23);
            Personalnumber.TabIndex = 0;
            Personalnumber.Text = "Personalnumber:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(176, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(384, 26);
            label1.TabIndex = 4;
            label1.Text = "Select personalnumber to update patient";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(467, 401);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(189, 37);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Select option to update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Location = new System.Drawing.Point(265, 152);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new System.Drawing.Size(0, 20);
            lblPatientInfo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(216, 152);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 20);
            label3.TabIndex = 7;
            // 
            // listbox_Patient
            // 
            listbox_Patient.FormattingEnabled = true;
            listbox_Patient.ItemHeight = 20;
            listbox_Patient.Location = new System.Drawing.Point(156, 236);
            listbox_Patient.Name = "listbox_Patient";
            listbox_Patient.Size = new System.Drawing.Size(500, 144);
            listbox_Patient.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(156, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(205, 20);
            label2.TabIndex = 9;
            label2.Text = "Current patient information";
            // 
            // UpdatePatientViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listbox_Patient);
            Controls.Add(label3);
            Controls.Add(lblPatientInfo);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(Personalnumber);
            Controls.Add(textPersonalnumber);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Name = "UpdatePatientViewForm";
            Text = "UpdatePatientViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textPersonalnumber;
        private System.Windows.Forms.Label Personalnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox_Patient;
        private System.Windows.Forms.Label label2;
    }
}