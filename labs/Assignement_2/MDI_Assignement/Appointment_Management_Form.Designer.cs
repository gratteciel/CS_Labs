namespace MDI_Assignement
{
    partial class Appointment_Management_Form
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
            this.GroupBox_All = new System.Windows.Forms.GroupBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.New_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Doctor_GroupBox = new System.Windows.Forms.GroupBox();
            this.Doctor_Name_Text = new System.Windows.Forms.TextBox();
            this.Doctor_Speciality_Text = new System.Windows.Forms.TextBox();
            this.Doctor_Code_ListBox = new System.Windows.Forms.ListBox();
            this.Doctor_Code_Label = new System.Windows.Forms.Label();
            this.Doctor_Name_Label = new System.Windows.Forms.Label();
            this.Doctor_Speciality_Label = new System.Windows.Forms.Label();
            this.Appointment_GroupBox = new System.Windows.Forms.GroupBox();
            this.AppointmentTime = new System.Windows.Forms.DateTimePicker();
            this.AppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.Appointment_Time_Label = new System.Windows.Forms.Label();
            this.Appointment_Date_Label = new System.Windows.Forms.Label();
            this.Patient_GroupBox = new System.Windows.Forms.GroupBox();
            this.Patient_Name_Text = new System.Windows.Forms.TextBox();
            this.Patient_Code_ListBox = new System.Windows.Forms.ListBox();
            this.Gender_GroupBox = new System.Windows.Forms.GroupBox();
            this.M_Radio_Button = new System.Windows.Forms.RadioButton();
            this.F_radio_button = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Patient_Name_Label = new System.Windows.Forms.Label();
            this.Patient_Code_Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBox_All.SuspendLayout();
            this.Doctor_GroupBox.SuspendLayout();
            this.Appointment_GroupBox.SuspendLayout();
            this.Patient_GroupBox.SuspendLayout();
            this.Gender_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_All
            // 
            this.GroupBox_All.Controls.Add(this.Exit_Button);
            this.GroupBox_All.Controls.Add(this.New_Button);
            this.GroupBox_All.Controls.Add(this.Add_Button);
            this.GroupBox_All.Controls.Add(this.Doctor_GroupBox);
            this.GroupBox_All.Controls.Add(this.Appointment_GroupBox);
            this.GroupBox_All.Controls.Add(this.Patient_GroupBox);
            this.GroupBox_All.Location = new System.Drawing.Point(66, 43);
            this.GroupBox_All.Name = "GroupBox_All";
            this.GroupBox_All.Size = new System.Drawing.Size(758, 380);
            this.GroupBox_All.TabIndex = 0;
            this.GroupBox_All.TabStop = false;
            this.GroupBox_All.Text = "Appointment Management";
            this.GroupBox_All.Enter += new System.EventHandler(this.GroupBox_All_Enter);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(542, 291);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(184, 23);
            this.Exit_Button.TabIndex = 3;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // New_Button
            // 
            this.New_Button.Location = new System.Drawing.Point(542, 262);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(184, 23);
            this.New_Button.TabIndex = 2;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(542, 233);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(184, 23);
            this.Add_Button.TabIndex = 0;
            this.Add_Button.Text = "Add Appointment";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Doctor_GroupBox
            // 
            this.Doctor_GroupBox.Controls.Add(this.Doctor_Name_Text);
            this.Doctor_GroupBox.Controls.Add(this.Doctor_Speciality_Text);
            this.Doctor_GroupBox.Controls.Add(this.Doctor_Code_ListBox);
            this.Doctor_GroupBox.Controls.Add(this.Doctor_Code_Label);
            this.Doctor_GroupBox.Controls.Add(this.Doctor_Name_Label);
            this.Doctor_GroupBox.Controls.Add(this.Doctor_Speciality_Label);
            this.Doctor_GroupBox.Location = new System.Drawing.Point(448, 49);
            this.Doctor_GroupBox.Name = "Doctor_GroupBox";
            this.Doctor_GroupBox.Size = new System.Drawing.Size(278, 145);
            this.Doctor_GroupBox.TabIndex = 1;
            this.Doctor_GroupBox.TabStop = false;
            this.Doctor_GroupBox.Enter += new System.EventHandler(this.Doctor_GroupBox_Enter);
            // 
            // Doctor_Name_Text
            // 
            this.Doctor_Name_Text.Location = new System.Drawing.Point(111, 54);
            this.Doctor_Name_Text.Name = "Doctor_Name_Text";
            this.Doctor_Name_Text.Size = new System.Drawing.Size(102, 20);
            this.Doctor_Name_Text.TabIndex = 40;
            this.Doctor_Name_Text.TextChanged += new System.EventHandler(this.Doctor_Name_Text_TextChanged);
            // 
            // Doctor_Speciality_Text
            // 
            this.Doctor_Speciality_Text.Location = new System.Drawing.Point(112, 91);
            this.Doctor_Speciality_Text.Name = "Doctor_Speciality_Text";
            this.Doctor_Speciality_Text.Size = new System.Drawing.Size(102, 20);
            this.Doctor_Speciality_Text.TabIndex = 41;
            this.Doctor_Speciality_Text.TextChanged += new System.EventHandler(this.Doctor_Speciality_Text_TextChanged);
            // 
            // Doctor_Code_ListBox
            // 
            this.Doctor_Code_ListBox.FormattingEnabled = true;
            this.Doctor_Code_ListBox.Location = new System.Drawing.Point(111, 16);
            this.Doctor_Code_ListBox.Name = "Doctor_Code_ListBox";
            this.Doctor_Code_ListBox.Size = new System.Drawing.Size(103, 17);
            this.Doctor_Code_ListBox.TabIndex = 39;
            this.Doctor_Code_ListBox.SelectedIndexChanged += new System.EventHandler(this.Doctor_Code_ListBox_SelectedIndexChanged);
            // 
            // Doctor_Code_Label
            // 
            this.Doctor_Code_Label.AutoSize = true;
            this.Doctor_Code_Label.Location = new System.Drawing.Point(17, 20);
            this.Doctor_Code_Label.Name = "Doctor_Code_Label";
            this.Doctor_Code_Label.Size = new System.Drawing.Size(67, 13);
            this.Doctor_Code_Label.TabIndex = 7;
            this.Doctor_Code_Label.Text = "Doctor Code";
            this.Doctor_Code_Label.Click += new System.EventHandler(this.Doctor_Code_Label_Click);
            // 
            // Doctor_Name_Label
            // 
            this.Doctor_Name_Label.AutoSize = true;
            this.Doctor_Name_Label.Location = new System.Drawing.Point(17, 54);
            this.Doctor_Name_Label.Name = "Doctor_Name_Label";
            this.Doctor_Name_Label.Size = new System.Drawing.Size(70, 13);
            this.Doctor_Name_Label.TabIndex = 8;
            this.Doctor_Name_Label.Text = "Doctor Name";
            this.Doctor_Name_Label.Click += new System.EventHandler(this.Doctor_Name_Label_Click);
            // 
            // Doctor_Speciality_Label
            // 
            this.Doctor_Speciality_Label.AutoSize = true;
            this.Doctor_Speciality_Label.Location = new System.Drawing.Point(17, 94);
            this.Doctor_Speciality_Label.Name = "Doctor_Speciality_Label";
            this.Doctor_Speciality_Label.Size = new System.Drawing.Size(87, 13);
            this.Doctor_Speciality_Label.TabIndex = 9;
            this.Doctor_Speciality_Label.Text = "Doctor Speciality";
            this.Doctor_Speciality_Label.Click += new System.EventHandler(this.Doctor_Speciality_Label_Click);
            // 
            // Appointment_GroupBox
            // 
            this.Appointment_GroupBox.Controls.Add(this.AppointmentTime);
            this.Appointment_GroupBox.Controls.Add(this.AppointmentDate);
            this.Appointment_GroupBox.Controls.Add(this.Appointment_Time_Label);
            this.Appointment_GroupBox.Controls.Add(this.Appointment_Date_Label);
            this.Appointment_GroupBox.Location = new System.Drawing.Point(39, 212);
            this.Appointment_GroupBox.Name = "Appointment_GroupBox";
            this.Appointment_GroupBox.Size = new System.Drawing.Size(373, 102);
            this.Appointment_GroupBox.TabIndex = 1;
            this.Appointment_GroupBox.TabStop = false;
            this.Appointment_GroupBox.Enter += new System.EventHandler(this.Appointment_GroupBox_Enter);
            // 
            // AppointmentTime
            // 
            this.AppointmentTime.Location = new System.Drawing.Point(132, 60);
            this.AppointmentTime.Name = "AppointmentTime";
            this.AppointmentTime.Size = new System.Drawing.Size(177, 20);
            this.AppointmentTime.TabIndex = 13;
            this.AppointmentTime.ValueChanged += new System.EventHandler(this.AppointmentTime_ValueChanged);
            // 
            // AppointmentDate
            // 
            this.AppointmentDate.Location = new System.Drawing.Point(132, 31);
            this.AppointmentDate.Name = "AppointmentDate";
            this.AppointmentDate.Size = new System.Drawing.Size(177, 20);
            this.AppointmentDate.TabIndex = 12;
            this.AppointmentDate.ValueChanged += new System.EventHandler(this.AppointmentDate_ValueChanged);
            // 
            // Appointment_Time_Label
            // 
            this.Appointment_Time_Label.AutoSize = true;
            this.Appointment_Time_Label.Location = new System.Drawing.Point(15, 60);
            this.Appointment_Time_Label.Name = "Appointment_Time_Label";
            this.Appointment_Time_Label.Size = new System.Drawing.Size(92, 13);
            this.Appointment_Time_Label.TabIndex = 11;
            this.Appointment_Time_Label.Text = "Appointment Time";
            this.Appointment_Time_Label.Click += new System.EventHandler(this.Appointment_Time_Label_Click);
            // 
            // Appointment_Date_Label
            // 
            this.Appointment_Date_Label.AutoSize = true;
            this.Appointment_Date_Label.Location = new System.Drawing.Point(15, 31);
            this.Appointment_Date_Label.Name = "Appointment_Date_Label";
            this.Appointment_Date_Label.Size = new System.Drawing.Size(92, 13);
            this.Appointment_Date_Label.TabIndex = 10;
            this.Appointment_Date_Label.Text = "Appointment Date";
            this.Appointment_Date_Label.Click += new System.EventHandler(this.Appointment_Date_Label_Click);
            // 
            // Patient_GroupBox
            // 
            this.Patient_GroupBox.Controls.Add(this.Patient_Name_Text);
            this.Patient_GroupBox.Controls.Add(this.Patient_Code_ListBox);
            this.Patient_GroupBox.Controls.Add(this.Gender_GroupBox);
            this.Patient_GroupBox.Controls.Add(this.label3);
            this.Patient_GroupBox.Controls.Add(this.Patient_Name_Label);
            this.Patient_GroupBox.Controls.Add(this.Patient_Code_Label);
            this.Patient_GroupBox.Location = new System.Drawing.Point(39, 49);
            this.Patient_GroupBox.Name = "Patient_GroupBox";
            this.Patient_GroupBox.Size = new System.Drawing.Size(309, 145);
            this.Patient_GroupBox.TabIndex = 0;
            this.Patient_GroupBox.TabStop = false;
            this.Patient_GroupBox.Enter += new System.EventHandler(this.Patient_GroupBox_Enter);
            // 
            // Patient_Name_Text
            // 
            this.Patient_Name_Text.Location = new System.Drawing.Point(99, 52);
            this.Patient_Name_Text.Name = "Patient_Name_Text";
            this.Patient_Name_Text.Size = new System.Drawing.Size(102, 20);
            this.Patient_Name_Text.TabIndex = 39;
            this.Patient_Name_Text.TextChanged += new System.EventHandler(this.Patient_Name_Text_TextChanged);
            // 
            // Patient_Code_ListBox
            // 
            this.Patient_Code_ListBox.FormattingEnabled = true;
            this.Patient_Code_ListBox.Location = new System.Drawing.Point(99, 19);
            this.Patient_Code_ListBox.Name = "Patient_Code_ListBox";
            this.Patient_Code_ListBox.Size = new System.Drawing.Size(103, 17);
            this.Patient_Code_ListBox.TabIndex = 38;
            this.Patient_Code_ListBox.SelectedIndexChanged += new System.EventHandler(this.Patient_Code_ListBox_SelectedIndexChanged);
            // 
            // Gender_GroupBox
            // 
            this.Gender_GroupBox.Controls.Add(this.M_Radio_Button);
            this.Gender_GroupBox.Controls.Add(this.F_radio_button);
            this.Gender_GroupBox.Location = new System.Drawing.Point(99, 71);
            this.Gender_GroupBox.Name = "Gender_GroupBox";
            this.Gender_GroupBox.Size = new System.Drawing.Size(54, 68);
            this.Gender_GroupBox.TabIndex = 37;
            this.Gender_GroupBox.TabStop = false;
            this.Gender_GroupBox.Enter += new System.EventHandler(this.Gender_GroupBox_Enter);
            // 
            // M_Radio_Button
            // 
            this.M_Radio_Button.AutoSize = true;
            this.M_Radio_Button.Location = new System.Drawing.Point(6, 44);
            this.M_Radio_Button.Name = "M_Radio_Button";
            this.M_Radio_Button.Size = new System.Drawing.Size(34, 17);
            this.M_Radio_Button.TabIndex = 1;
            this.M_Radio_Button.TabStop = true;
            this.M_Radio_Button.Text = "M";
            this.M_Radio_Button.UseVisualStyleBackColor = true;
            this.M_Radio_Button.CheckedChanged += new System.EventHandler(this.M_Radio_Button_CheckedChanged);
            // 
            // F_radio_button
            // 
            this.F_radio_button.AutoSize = true;
            this.F_radio_button.Location = new System.Drawing.Point(6, 10);
            this.F_radio_button.Name = "F_radio_button";
            this.F_radio_button.Size = new System.Drawing.Size(31, 17);
            this.F_radio_button.TabIndex = 0;
            this.F_radio_button.TabStop = true;
            this.F_radio_button.Text = "F";
            this.F_radio_button.UseVisualStyleBackColor = true;
            this.F_radio_button.CheckedChanged += new System.EventHandler(this.F_radio_button_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Patient Gender";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Patient_Name_Label
            // 
            this.Patient_Name_Label.AutoSize = true;
            this.Patient_Name_Label.Location = new System.Drawing.Point(15, 54);
            this.Patient_Name_Label.Name = "Patient_Name_Label";
            this.Patient_Name_Label.Size = new System.Drawing.Size(71, 13);
            this.Patient_Name_Label.TabIndex = 5;
            this.Patient_Name_Label.Text = "Patient Name";
            this.Patient_Name_Label.Click += new System.EventHandler(this.Patient_Name_Label_Click);
            // 
            // Patient_Code_Label
            // 
            this.Patient_Code_Label.AutoSize = true;
            this.Patient_Code_Label.Location = new System.Drawing.Point(15, 20);
            this.Patient_Code_Label.Name = "Patient_Code_Label";
            this.Patient_Code_Label.Size = new System.Drawing.Size(68, 13);
            this.Patient_Code_Label.TabIndex = 4;
            this.Patient_Code_Label.Text = "Patient Code";
            this.Patient_Code_Label.Click += new System.EventHandler(this.Patient_Code_Label_Click);
            // 
            // Appointment_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 487);
            this.Controls.Add(this.GroupBox_All);
            this.Name = "Appointment_Management_Form";
            this.Text = "Appointment_Management";
            this.Load += new System.EventHandler(this.Appointment_Management_Form_Load);
            this.GroupBox_All.ResumeLayout(false);
            this.Doctor_GroupBox.ResumeLayout(false);
            this.Doctor_GroupBox.PerformLayout();
            this.Appointment_GroupBox.ResumeLayout(false);
            this.Appointment_GroupBox.PerformLayout();
            this.Patient_GroupBox.ResumeLayout(false);
            this.Patient_GroupBox.PerformLayout();
            this.Gender_GroupBox.ResumeLayout(false);
            this.Gender_GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_All;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.GroupBox Doctor_GroupBox;
        private System.Windows.Forms.GroupBox Appointment_GroupBox;
        private System.Windows.Forms.GroupBox Patient_GroupBox;
        private System.Windows.Forms.Label Appointment_Time_Label;
        private System.Windows.Forms.Label Appointment_Date_Label;
        private System.Windows.Forms.Label Doctor_Speciality_Label;
        private System.Windows.Forms.Label Doctor_Name_Label;
        private System.Windows.Forms.Label Doctor_Code_Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Patient_Name_Label;
        private System.Windows.Forms.Label Patient_Code_Label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Gender_GroupBox;
        private System.Windows.Forms.RadioButton M_Radio_Button;
        private System.Windows.Forms.RadioButton F_radio_button;
        private System.Windows.Forms.TextBox Doctor_Name_Text;
        private System.Windows.Forms.TextBox Doctor_Speciality_Text;
        private System.Windows.Forms.ListBox Doctor_Code_ListBox;
        private System.Windows.Forms.TextBox Patient_Name_Text;
        private System.Windows.Forms.ListBox Patient_Code_ListBox;
        private System.Windows.Forms.DateTimePicker AppointmentTime;
        private System.Windows.Forms.DateTimePicker AppointmentDate;
    }
}