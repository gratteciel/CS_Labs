namespace MDI_Assignement
{
    partial class Show_All_Form
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
            this.DataGridView_Data = new System.Windows.Forms.DataGridView();
            this.Choice_label = new System.Windows.Forms.Label();
            this.Radio_Doctors = new System.Windows.Forms.RadioButton();
            this.Radio_Patient = new System.Windows.Forms.RadioButton();
            this.Radio_Appointments = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Data)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView_Data
            // 
            this.DataGridView_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Data.Location = new System.Drawing.Point(31, 300);
            this.DataGridView_Data.Name = "DataGridView_Data";
            this.DataGridView_Data.Size = new System.Drawing.Size(794, 185);
            this.DataGridView_Data.TabIndex = 0;
            this.DataGridView_Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Data_CellContentClick);
            // 
            // Choice_label
            // 
            this.Choice_label.AutoSize = true;
            this.Choice_label.Location = new System.Drawing.Point(125, 84);
            this.Choice_label.Name = "Choice_label";
            this.Choice_label.Size = new System.Drawing.Size(40, 13);
            this.Choice_label.TabIndex = 1;
            this.Choice_label.Text = "Choice";
            this.Choice_label.Click += new System.EventHandler(this.Choice_label_Click);
            // 
            // Radio_Doctors
            // 
            this.Radio_Doctors.AutoSize = true;
            this.Radio_Doctors.Location = new System.Drawing.Point(129, 116);
            this.Radio_Doctors.Name = "Radio_Doctors";
            this.Radio_Doctors.Size = new System.Drawing.Size(95, 17);
            this.Radio_Doctors.TabIndex = 2;
            this.Radio_Doctors.TabStop = true;
            this.Radio_Doctors.Text = "All the doctors ";
            this.Radio_Doctors.UseVisualStyleBackColor = true;
            this.Radio_Doctors.CheckedChanged += new System.EventHandler(this.Radio_Doctors_CheckedChanged);
            // 
            // Radio_Patient
            // 
            this.Radio_Patient.AutoSize = true;
            this.Radio_Patient.Location = new System.Drawing.Point(353, 116);
            this.Radio_Patient.Name = "Radio_Patient";
            this.Radio_Patient.Size = new System.Drawing.Size(94, 17);
            this.Radio_Patient.TabIndex = 3;
            this.Radio_Patient.TabStop = true;
            this.Radio_Patient.Text = "All the patients";
            this.Radio_Patient.UseVisualStyleBackColor = true;
            this.Radio_Patient.CheckedChanged += new System.EventHandler(this.Radio_Patient_CheckedChanged);
            // 
            // Radio_Appointments
            // 
            this.Radio_Appointments.AutoSize = true;
            this.Radio_Appointments.Location = new System.Drawing.Point(569, 116);
            this.Radio_Appointments.Name = "Radio_Appointments";
            this.Radio_Appointments.Size = new System.Drawing.Size(120, 17);
            this.Radio_Appointments.TabIndex = 4;
            this.Radio_Appointments.TabStop = true;
            this.Radio_Appointments.Text = "All the appointments";
            this.Radio_Appointments.UseVisualStyleBackColor = true;
            this.Radio_Appointments.CheckedChanged += new System.EventHandler(this.Radio_Appointments_CheckedChanged);
            // 
            // Show_All_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 544);
            this.Controls.Add(this.Radio_Appointments);
            this.Controls.Add(this.Radio_Patient);
            this.Controls.Add(this.Radio_Doctors);
            this.Controls.Add(this.Choice_label);
            this.Controls.Add(this.DataGridView_Data);
            this.Name = "Show_All_Form";
            this.Text = "Show_All";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView_Data;
        private System.Windows.Forms.Label Choice_label;
        private System.Windows.Forms.RadioButton Radio_Doctors;
        private System.Windows.Forms.RadioButton Radio_Patient;
        private System.Windows.Forms.RadioButton Radio_Appointments;
    }
}