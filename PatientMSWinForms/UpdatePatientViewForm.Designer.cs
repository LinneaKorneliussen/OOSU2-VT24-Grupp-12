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
            txtPersonalnumber = new System.Windows.Forms.TextBox();
            lblPersonalnumber = new System.Windows.Forms.Label();
            lblSelect = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            lblPatientInfo = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            listbox_Patient = new System.Windows.Forms.ListBox();
            lblCurrentinfo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.BackColor = System.Drawing.Color.White;
            btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(155, 401);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(110, 37);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.White;
            btnSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSearch.Location = new System.Drawing.Point(486, 96);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(97, 27);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSelect_Click;
            // 
            // txtPersonalnumber
            // 
            txtPersonalnumber.Location = new System.Drawing.Point(311, 96);
            txtPersonalnumber.Name = "txtPersonalnumber";
            txtPersonalnumber.Size = new System.Drawing.Size(169, 27);
            txtPersonalnumber.TabIndex = 3;
            // 
            // lblPersonalnumber
            // 
            lblPersonalnumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPersonalnumber.Location = new System.Drawing.Point(187, 99);
            lblPersonalnumber.Name = "lblPersonalnumber";
            lblPersonalnumber.Size = new System.Drawing.Size(114, 23);
            lblPersonalnumber.TabIndex = 0;
            lblPersonalnumber.Text = "Personalnumber:";
            // 
            // lblSelect
            // 
            lblSelect.AutoSize = true;
            lblSelect.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSelect.ForeColor = System.Drawing.Color.Black;
            lblSelect.Location = new System.Drawing.Point(176, 50);
            lblSelect.Name = "lblSelect";
            lblSelect.Size = new System.Drawing.Size(384, 26);
            lblSelect.TabIndex = 4;
            lblSelect.Text = "Select personalnumber to update patient";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = System.Drawing.Color.White;
            btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdate.Location = new System.Drawing.Point(467, 401);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(189, 37);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Select option to update";
            btnUpdate.UseVisualStyleBackColor = false;
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
            // lblCurrentinfo
            // 
            lblCurrentinfo.AutoSize = true;
            lblCurrentinfo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCurrentinfo.Location = new System.Drawing.Point(156, 200);
            lblCurrentinfo.Name = "lblCurrentinfo";
            lblCurrentinfo.Size = new System.Drawing.Size(205, 20);
            lblCurrentinfo.TabIndex = 9;
            lblCurrentinfo.Text = "Current patient information";
            // 
            // UpdatePatientViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Ivory;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lblCurrentinfo);
            Controls.Add(listbox_Patient);
            Controls.Add(label3);
            Controls.Add(lblPatientInfo);
            Controls.Add(btnUpdate);
            Controls.Add(lblSelect);
            Controls.Add(lblPersonalnumber);
            Controls.Add(txtPersonalnumber);
            Controls.Add(btnSearch);
            Controls.Add(btnBack);
            Name = "UpdatePatientViewForm";
            Text = "Update patient information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPersonalnumber;
        private System.Windows.Forms.Label lblPersonalnumber;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblPatientInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listbox_Patient;
        private System.Windows.Forms.Label lblCurrentinfo;
    }
}