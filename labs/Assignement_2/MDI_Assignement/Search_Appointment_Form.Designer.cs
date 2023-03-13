namespace MDI_Assignement
{
    partial class Search_Appointment_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeUser = new System.Windows.Forms.DateTimePicker();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.doctorSpeciality = new System.Windows.Forms.TextBox();
            this.doctorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.patientBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.patientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeUser);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Location = new System.Drawing.Point(51, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose the date";
            // 
            // dateTimeUser
            // 
            this.dateTimeUser.Location = new System.Drawing.Point(80, 39);
            this.dateTimeUser.Name = "dateTimeUser";
            this.dateTimeUser.Size = new System.Drawing.Size(200, 20);
            this.dateTimeUser.TabIndex = 2;
            this.dateTimeUser.ValueChanged += new System.EventHandler(this.dateTimeUser_ValueChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(591, 52);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 27);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(591, 19);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(93, 27);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.doctorSpeciality);
            this.groupBox2.Controls.Add(this.doctorName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(51, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doctor";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // doctorSpeciality
            // 
            this.doctorSpeciality.Location = new System.Drawing.Point(80, 61);
            this.doctorSpeciality.Name = "doctorSpeciality";
            this.doctorSpeciality.Size = new System.Drawing.Size(149, 20);
            this.doctorSpeciality.TabIndex = 3;
            this.doctorSpeciality.TextChanged += new System.EventHandler(this.doctorSpeciality_TextChanged);
            // 
            // doctorName
            // 
            this.doctorName.Location = new System.Drawing.Point(80, 26);
            this.doctorName.Name = "doctorName";
            this.doctorName.Size = new System.Drawing.Size(149, 20);
            this.doctorName.TabIndex = 2;
            this.doctorName.TextChanged += new System.EventHandler(this.doctorName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speciality";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.patientBirthDate);
            this.groupBox3.Controls.Add(this.patientName);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(449, 315);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Patient";
            // 
            // patientBirthDate
            // 
            this.patientBirthDate.Location = new System.Drawing.Point(82, 58);
            this.patientBirthDate.Mask = "00/00/0000";
            this.patientBirthDate.Name = "patientBirthDate";
            this.patientBirthDate.Size = new System.Drawing.Size(72, 20);
            this.patientBirthDate.TabIndex = 3;
            this.patientBirthDate.ValidatingType = typeof(System.DateTime);
            this.patientBirthDate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.patientBirthDate_MaskInputRejected);
            // 
            // patientName
            // 
            this.patientName.Location = new System.Drawing.Point(82, 26);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(172, 20);
            this.patientName.TabIndex = 2;
            this.patientName.TextChanged += new System.EventHandler(this.patientName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birth Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(690, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Search_Appointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Search_Appointment_Form";
            this.Text = "Search_Appointment";
            this.Load += new System.EventHandler(this.Search_Appointment_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeUser;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox doctorSpeciality;
        private System.Windows.Forms.TextBox doctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox patientBirthDate;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}