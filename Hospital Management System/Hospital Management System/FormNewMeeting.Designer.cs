namespace Hospital_Management_System
{
    partial class FormNewMeeting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkViewPatientRecord = new System.Windows.Forms.LinkLabel();
            this.linkViewPatientData = new System.Windows.Forms.LinkLabel();
            this.tbPatientName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtMeeting = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linkViewDoctorData = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSumbit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meeting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Patient Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkViewPatientRecord);
            this.groupBox1.Controls.Add(this.linkViewPatientData);
            this.groupBox1.Controls.Add(this.tbPatientName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(45, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chose Patient";
            // 
            // linkViewPatientRecord
            // 
            this.linkViewPatientRecord.AutoSize = true;
            this.linkViewPatientRecord.Location = new System.Drawing.Point(35, 123);
            this.linkViewPatientRecord.Name = "linkViewPatientRecord";
            this.linkViewPatientRecord.Size = new System.Drawing.Size(153, 20);
            this.linkViewPatientRecord.TabIndex = 4;
            this.linkViewPatientRecord.TabStop = true;
            this.linkViewPatientRecord.Text = "View Patient Record";
            this.linkViewPatientRecord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewPatientRecord_LinkClicked);
            // 
            // linkViewPatientData
            // 
            this.linkViewPatientData.AutoSize = true;
            this.linkViewPatientData.Location = new System.Drawing.Point(35, 83);
            this.linkViewPatientData.Name = "linkViewPatientData";
            this.linkViewPatientData.Size = new System.Drawing.Size(136, 20);
            this.linkViewPatientData.TabIndex = 3;
            this.linkViewPatientData.TabStop = true;
            this.linkViewPatientData.Text = "View Patient Data";
            this.linkViewPatientData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewPatientData_LinkClicked);
            // 
            // tbPatientName
            // 
            this.tbPatientName.Location = new System.Drawing.Point(160, 38);
            this.tbPatientName.Name = "tbPatientName";
            this.tbPatientName.Size = new System.Drawing.Size(217, 26);
            this.tbPatientName.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtMeeting);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(45, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chose Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "lblQuene";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Queue Number";
            // 
            // dtMeeting
            // 
            this.dtMeeting.Location = new System.Drawing.Point(122, 43);
            this.dtMeeting.Name = "dtMeeting";
            this.dtMeeting.Size = new System.Drawing.Size(200, 26);
            this.dtMeeting.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbName);
            this.groupBox4.Controls.Add(this.cbCategory);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.linkViewDoctorData);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(515, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 180);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chose Doctor";
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(163, 83);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(223, 28);
            this.cbName.TabIndex = 7;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(163, 41);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(223, 28);
            this.cbCategory.TabIndex = 6;
            this.cbCategory.SelectedValueChanged += new System.EventHandler(this.cbCategory_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Name";
            // 
            // linkViewDoctorData
            // 
            this.linkViewDoctorData.AutoSize = true;
            this.linkViewDoctorData.Location = new System.Drawing.Point(35, 123);
            this.linkViewDoctorData.Name = "linkViewDoctorData";
            this.linkViewDoctorData.Size = new System.Drawing.Size(134, 20);
            this.linkViewDoctorData.TabIndex = 4;
            this.linkViewDoctorData.TabStop = true;
            this.linkViewDoctorData.Text = "View Doctor Data";
            this.linkViewDoctorData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkViewDoctorData_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Category";
            // 
            // btnSumbit
            // 
            this.btnSumbit.Location = new System.Drawing.Point(554, 380);
            this.btnSumbit.Name = "btnSumbit";
            this.btnSumbit.Size = new System.Drawing.Size(286, 40);
            this.btnSumbit.TabIndex = 7;
            this.btnSumbit.Text = "Sumbit";
            this.btnSumbit.UseVisualStyleBackColor = true;
            this.btnSumbit.Click += new System.EventHandler(this.btnSumbit_Click);
            // 
            // FormNewMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 487);
            this.Controls.Add(this.btnSumbit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormNewMeeting";
            this.Text = "FormNewMeeting";
            this.Load += new System.EventHandler(this.FormNewMeeting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkViewPatientData;
        private System.Windows.Forms.TextBox tbPatientName;
        private System.Windows.Forms.LinkLabel linkViewPatientRecord;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtMeeting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkViewDoctorData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSumbit;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label5;
    }
}