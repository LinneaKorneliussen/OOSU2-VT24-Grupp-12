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
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(194, 501);
            btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(138, 46);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.White;
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(608, 120);
            btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(121, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSelect_Click;
            // 
            // textPersonalnumber
            // 
            textPersonalnumber.Location = new System.Drawing.Point(389, 120);
            textPersonalnumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textPersonalnumber.Name = "textPersonalnumber";
            textPersonalnumber.Size = new System.Drawing.Size(210, 31);
            textPersonalnumber.TabIndex = 3;
            // 
            // Personalnumber
            // 
            Personalnumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Personalnumber.Location = new System.Drawing.Point(234, 124);
            Personalnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Personalnumber.Name = "Personalnumber";
            Personalnumber.Size = new System.Drawing.Size(142, 29);
            Personalnumber.TabIndex = 0;
            Personalnumber.Text = "Personalnumber:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(220, 62);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(460, 33);
            label1.TabIndex = 4;
            label1.Text = "Select personalnumber to update patient";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.White;
            btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(584, 501);
            btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(236, 46);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Select option to update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblPatientInfo
            // 
            lblPatientInfo.AutoSize = true;
            lblPatientInfo.Location = new System.Drawing.Point(331, 190);
            lblPatientInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPatientInfo.Name = "lblPatientInfo";
            lblPatientInfo.Size = new System.Drawing.Size(0, 25);
            lblPatientInfo.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(270, 190);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 25);
            label3.TabIndex = 7;
            // 
            // listbox_Patient
            // 
            listbox_Patient.FormattingEnabled = true;
            listbox_Patient.ItemHeight = 25;
            listbox_Patient.Location = new System.Drawing.Point(195, 295);
            listbox_Patient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            listbox_Patient.Name = "listbox_Patient";
            listbox_Patient.Size = new System.Drawing.Size(624, 179);
            listbox_Patient.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(195, 250);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(249, 25);
            label2.TabIndex = 9;
            label2.Text = "Current patient information";
            // 
            // UpdatePatientViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(1000, 562);
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
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "UpdatePatientViewForm";
            Text = "Update patient information";
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