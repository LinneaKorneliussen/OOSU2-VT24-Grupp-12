namespace PatientMSWinForms
{
    partial class UpdateViewForm
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
            textBox1 = new System.Windows.Forms.TextBox();
            name_label = new System.Windows.Forms.Label();
            btnUpdatePatient = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(275, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(259, 27);
            textBox1.TabIndex = 0;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            name_label.Location = new System.Drawing.Point(185, 86);
            name_label.Name = "name_label";
            name_label.Size = new System.Drawing.Size(84, 19);
            name_label.TabIndex = 4;
            name_label.Text = "New value:";
            // 
            // btnUpdatePatient
            // 
            btnUpdatePatient.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnUpdatePatient.Location = new System.Drawing.Point(506, 351);
            btnUpdatePatient.Name = "btnUpdatePatient";
            btnUpdatePatient.Size = new System.Drawing.Size(157, 50);
            btnUpdatePatient.TabIndex = 8;
            btnUpdatePatient.Text = "Update patient";
            btnUpdatePatient.UseVisualStyleBackColor = true;
            btnUpdatePatient.Click += btnUpdatePatient_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBack.Location = new System.Drawing.Point(156, 351);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(157, 50);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(275, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(246, 26);
            label1.TabIndex = 10;
            label1.Text = "Provide new information";
            // 
            // UpdateViewForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnUpdatePatient);
            Controls.Add(name_label);
            Controls.Add(textBox1);
            Name = "UpdateViewForm";
            Text = "UpdateViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
    }
}