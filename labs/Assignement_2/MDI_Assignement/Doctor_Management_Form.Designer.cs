namespace MDI_Assignement
{
    partial class Doctor_Management_Form
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
            this.Code_Label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Tel_Label = new System.Windows.Forms.Label();
            this.Hiring_date_label = new System.Windows.Forms.Label();
            this.Speciality_Label = new System.Windows.Forms.Label();
            this.New_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Code_Text = new System.Windows.Forms.TextBox();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.HiringDate_Date = new System.Windows.Forms.DateTimePicker();
            this.Tel_TextMasked = new System.Windows.Forms.MaskedTextBox();
            this.Speciality_ListBox = new System.Windows.Forms.ComboBox();
            this.GroupBox_All = new System.Windows.Forms.GroupBox();
            this.GroupBox_All.SuspendLayout();
            this.SuspendLayout();
            // 
            // Code_Label
            // 
            this.Code_Label.AutoSize = true;
            this.Code_Label.Location = new System.Drawing.Point(28, 41);
            this.Code_Label.Name = "Code_Label";
            this.Code_Label.Size = new System.Drawing.Size(32, 13);
            this.Code_Label.TabIndex = 1;
            this.Code_Label.Text = "Code";
            this.Code_Label.Click += new System.EventHandler(this.Code_Label_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(28, 80);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 2;
            this.Name_Label.Text = "Name";
            this.Name_Label.Click += new System.EventHandler(this.Name_Label_Click);
            // 
            // Tel_Label
            // 
            this.Tel_Label.AutoSize = true;
            this.Tel_Label.Location = new System.Drawing.Point(28, 125);
            this.Tel_Label.Name = "Tel_Label";
            this.Tel_Label.Size = new System.Drawing.Size(58, 13);
            this.Tel_Label.TabIndex = 3;
            this.Tel_Label.Text = "Telephone";
            this.Tel_Label.Click += new System.EventHandler(this.Tel_Label_Click);
            // 
            // Hiring_date_label
            // 
            this.Hiring_date_label.AutoSize = true;
            this.Hiring_date_label.Location = new System.Drawing.Point(28, 170);
            this.Hiring_date_label.Name = "Hiring_date_label";
            this.Hiring_date_label.Size = new System.Drawing.Size(60, 13);
            this.Hiring_date_label.TabIndex = 4;
            this.Hiring_date_label.Text = "Hiring Date";
            this.Hiring_date_label.Click += new System.EventHandler(this.Hiring_date_label_Click);
            // 
            // Speciality_Label
            // 
            this.Speciality_Label.AutoSize = true;
            this.Speciality_Label.Location = new System.Drawing.Point(28, 217);
            this.Speciality_Label.Name = "Speciality_Label";
            this.Speciality_Label.Size = new System.Drawing.Size(52, 13);
            this.Speciality_Label.TabIndex = 5;
            this.Speciality_Label.Text = "Speciality";
            this.Speciality_Label.Click += new System.EventHandler(this.Speciality_Label_Click);
            // 
            // New_Button
            // 
            this.New_Button.Location = new System.Drawing.Point(462, 56);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(160, 19);
            this.New_Button.TabIndex = 6;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(462, 81);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(160, 19);
            this.Search_Button.TabIndex = 7;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(462, 106);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(160, 19);
            this.Add_Button.TabIndex = 8;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(462, 131);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(160, 19);
            this.Edit_Button.TabIndex = 9;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(462, 156);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(160, 19);
            this.Delete_Button.TabIndex = 10;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(462, 181);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(160, 19);
            this.Exit_Button.TabIndex = 11;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Code_Text
            // 
            this.Code_Text.Location = new System.Drawing.Point(105, 38);
            this.Code_Text.Name = "Code_Text";
            this.Code_Text.Size = new System.Drawing.Size(180, 20);
            this.Code_Text.TabIndex = 12;
            this.Code_Text.TextChanged += new System.EventHandler(this.Code_Text_TextChanged);
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(105, 80);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(180, 20);
            this.Name_Text.TabIndex = 13;
            this.Name_Text.TextChanged += new System.EventHandler(this.Name_Text_TextChanged);
            // 
            // HiringDate_Date
            // 
            this.HiringDate_Date.Location = new System.Drawing.Point(105, 170);
            this.HiringDate_Date.Name = "HiringDate_Date";
            this.HiringDate_Date.Size = new System.Drawing.Size(180, 20);
            this.HiringDate_Date.TabIndex = 15;
            this.HiringDate_Date.ValueChanged += new System.EventHandler(this.HiringDate_Date_ValueChanged);
            // 
            // Tel_TextMasked
            // 
            this.Tel_TextMasked.Location = new System.Drawing.Point(105, 122);
            this.Tel_TextMasked.Name = "Tel_TextMasked";
            this.Tel_TextMasked.Size = new System.Drawing.Size(180, 20);
            this.Tel_TextMasked.TabIndex = 16;
            this.Tel_TextMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Tel_TextMasked_MaskInputRejected);
            // 
            // Speciality_ListBox
            // 
            this.Speciality_ListBox.FormattingEnabled = true;
            this.Speciality_ListBox.Items.AddRange(new object[] {
            "Anesthesiology",
            "Cardiology",
            "Dermatology",
            "Emergency Medicine",
            "Family Medicine",
            "Gastroenterology",
            "Hematology",
            "Internal Medicine",
            "Neurology",
            "Obstetrics and Gynecology",
            "Oncology",
            "Ophthalmology",
            "Orthopedics",
            "Otolaryngology (Ear, Nose, and Throat)",
            "Pediatrics",
            "Psychiatry",
            "Radiology",
            "Surgery"});
            this.Speciality_ListBox.Location = new System.Drawing.Point(105, 214);
            this.Speciality_ListBox.Name = "Speciality_ListBox";
            this.Speciality_ListBox.Size = new System.Drawing.Size(180, 21);
            this.Speciality_ListBox.TabIndex = 18;
            this.Speciality_ListBox.SelectedIndexChanged += new System.EventHandler(this.Speciality_ListBox_SelectedIndexChanged);
            // 
            // GroupBox_All
            // 
            this.GroupBox_All.Controls.Add(this.Speciality_ListBox);
            this.GroupBox_All.Controls.Add(this.Tel_TextMasked);
            this.GroupBox_All.Controls.Add(this.HiringDate_Date);
            this.GroupBox_All.Controls.Add(this.Name_Text);
            this.GroupBox_All.Controls.Add(this.Code_Text);
            this.GroupBox_All.Controls.Add(this.Exit_Button);
            this.GroupBox_All.Controls.Add(this.Delete_Button);
            this.GroupBox_All.Controls.Add(this.Edit_Button);
            this.GroupBox_All.Controls.Add(this.Add_Button);
            this.GroupBox_All.Controls.Add(this.Search_Button);
            this.GroupBox_All.Controls.Add(this.New_Button);
            this.GroupBox_All.Controls.Add(this.Speciality_Label);
            this.GroupBox_All.Controls.Add(this.Hiring_date_label);
            this.GroupBox_All.Controls.Add(this.Tel_Label);
            this.GroupBox_All.Controls.Add(this.Name_Label);
            this.GroupBox_All.Controls.Add(this.Code_Label);
            this.GroupBox_All.Location = new System.Drawing.Point(69, 38);
            this.GroupBox_All.Name = "GroupBox_All";
            this.GroupBox_All.Size = new System.Drawing.Size(641, 260);
            this.GroupBox_All.TabIndex = 19;
            this.GroupBox_All.TabStop = false;
            this.GroupBox_All.Text = "Doctor Management";
            this.GroupBox_All.Enter += new System.EventHandler(this.GroupBox_All_Enter);
            // 
            // Doctor_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 342);
            this.Controls.Add(this.GroupBox_All);
            this.Name = "Doctor_Management_Form";
            this.Text = "Doctor_Management";
            this.GroupBox_All.ResumeLayout(false);
            this.GroupBox_All.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Code_Label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Tel_Label;
        private System.Windows.Forms.Label Hiring_date_label;
        private System.Windows.Forms.Label Speciality_Label;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.TextBox Code_Text;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.DateTimePicker HiringDate_Date;
        private System.Windows.Forms.MaskedTextBox Tel_TextMasked;
        private System.Windows.Forms.ComboBox Speciality_ListBox;
        private System.Windows.Forms.GroupBox GroupBox_All;
    }
}