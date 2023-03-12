namespace MDI_Assignement
{
    partial class Patient_Management_Form
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
            this.BirthDate_Date = new System.Windows.Forms.DateTimePicker();
            this.Name_Text = new System.Windows.Forms.TextBox();
            this.Code_Text = new System.Windows.Forms.TextBox();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.Search_Button = new System.Windows.Forms.Button();
            this.New_Button = new System.Windows.Forms.Button();
            this.Birth_Date_label = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Code_Label = new System.Windows.Forms.Label();
            this.Address_Label = new System.Windows.Forms.Label();
            this.Gender_Label = new System.Windows.Forms.Label();
            this.Gender_GroupBox = new System.Windows.Forms.GroupBox();
            this.M_Radio_Button = new System.Windows.Forms.RadioButton();
            this.F_radio_button = new System.Windows.Forms.RadioButton();
            this.GroupBox_All = new System.Windows.Forms.GroupBox();
            this.Address_box = new System.Windows.Forms.RichTextBox();
            this.Gender_GroupBox.SuspendLayout();
            this.GroupBox_All.SuspendLayout();
            this.SuspendLayout();
            // 
            // BirthDate_Date
            // 
            this.BirthDate_Date.Location = new System.Drawing.Point(86, 125);
            this.BirthDate_Date.Name = "BirthDate_Date";
            this.BirthDate_Date.Size = new System.Drawing.Size(180, 20);
            this.BirthDate_Date.TabIndex = 33;
            this.BirthDate_Date.ValueChanged += new System.EventHandler(this.BirthDate_Date_ValueChanged);
            // 
            // Name_Text
            // 
            this.Name_Text.Location = new System.Drawing.Point(86, 86);
            this.Name_Text.Name = "Name_Text";
            this.Name_Text.Size = new System.Drawing.Size(180, 20);
            this.Name_Text.TabIndex = 32;
            this.Name_Text.TextChanged += new System.EventHandler(this.Name_Text_TextChanged);
            // 
            // Code_Text
            // 
            this.Code_Text.Location = new System.Drawing.Point(86, 44);
            this.Code_Text.Name = "Code_Text";
            this.Code_Text.Size = new System.Drawing.Size(180, 20);
            this.Code_Text.TabIndex = 31;
            this.Code_Text.TextChanged += new System.EventHandler(this.Code_Text_TextChanged);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(443, 187);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(160, 19);
            this.Exit_Button.TabIndex = 30;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(443, 162);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(160, 19);
            this.Delete_Button.TabIndex = 29;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(443, 137);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(160, 19);
            this.Edit_Button.TabIndex = 28;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(443, 112);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(160, 19);
            this.Add_Button.TabIndex = 27;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Search_Button
            // 
            this.Search_Button.Location = new System.Drawing.Point(443, 87);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(160, 19);
            this.Search_Button.TabIndex = 26;
            this.Search_Button.Text = "Search";
            this.Search_Button.UseVisualStyleBackColor = true;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // New_Button
            // 
            this.New_Button.Location = new System.Drawing.Point(443, 62);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(160, 19);
            this.New_Button.TabIndex = 25;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // Birth_Date_label
            // 
            this.Birth_Date_label.AutoSize = true;
            this.Birth_Date_label.Location = new System.Drawing.Point(9, 125);
            this.Birth_Date_label.Name = "Birth_Date_label";
            this.Birth_Date_label.Size = new System.Drawing.Size(54, 13);
            this.Birth_Date_label.TabIndex = 23;
            this.Birth_Date_label.Text = "Birth Date";
            this.Birth_Date_label.Click += new System.EventHandler(this.Birth_Date_label_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(9, 86);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 21;
            this.Name_Label.Text = "Name";
            this.Name_Label.Click += new System.EventHandler(this.Name_Label_Click);
            // 
            // Code_Label
            // 
            this.Code_Label.AutoSize = true;
            this.Code_Label.Location = new System.Drawing.Point(9, 47);
            this.Code_Label.Name = "Code_Label";
            this.Code_Label.Size = new System.Drawing.Size(32, 13);
            this.Code_Label.TabIndex = 20;
            this.Code_Label.Text = "Code";
            this.Code_Label.Click += new System.EventHandler(this.Code_Label_Click);
            // 
            // Address_Label
            // 
            this.Address_Label.AutoSize = true;
            this.Address_Label.Location = new System.Drawing.Point(9, 168);
            this.Address_Label.Name = "Address_Label";
            this.Address_Label.Size = new System.Drawing.Size(45, 13);
            this.Address_Label.TabIndex = 34;
            this.Address_Label.Text = "Address";
            this.Address_Label.Click += new System.EventHandler(this.Address_Label_Click);
            // 
            // Gender_Label
            // 
            this.Gender_Label.AutoSize = true;
            this.Gender_Label.Location = new System.Drawing.Point(9, 236);
            this.Gender_Label.Name = "Gender_Label";
            this.Gender_Label.Size = new System.Drawing.Size(42, 13);
            this.Gender_Label.TabIndex = 35;
            this.Gender_Label.Text = "Gender";
            this.Gender_Label.Click += new System.EventHandler(this.Gender_Label_Click);
            // 
            // Gender_GroupBox
            // 
            this.Gender_GroupBox.Controls.Add(this.M_Radio_Button);
            this.Gender_GroupBox.Controls.Add(this.F_radio_button);
            this.Gender_GroupBox.Location = new System.Drawing.Point(86, 236);
            this.Gender_GroupBox.Name = "Gender_GroupBox";
            this.Gender_GroupBox.Size = new System.Drawing.Size(180, 91);
            this.Gender_GroupBox.TabIndex = 36;
            this.Gender_GroupBox.TabStop = false;
            this.Gender_GroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // M_Radio_Button
            // 
            this.M_Radio_Button.AutoSize = true;
            this.M_Radio_Button.Location = new System.Drawing.Point(17, 62);
            this.M_Radio_Button.Name = "M_Radio_Button";
            this.M_Radio_Button.Size = new System.Drawing.Size(73, 17);
            this.M_Radio_Button.TabIndex = 1;
            this.M_Radio_Button.TabStop = true;
            this.M_Radio_Button.Text = "Masculine";
            this.M_Radio_Button.UseVisualStyleBackColor = true;
            this.M_Radio_Button.CheckedChanged += new System.EventHandler(this.M_Radio_Button_CheckedChanged);
            // 
            // F_radio_button
            // 
            this.F_radio_button.AutoSize = true;
            this.F_radio_button.Location = new System.Drawing.Point(17, 28);
            this.F_radio_button.Name = "F_radio_button";
            this.F_radio_button.Size = new System.Drawing.Size(67, 17);
            this.F_radio_button.TabIndex = 0;
            this.F_radio_button.TabStop = true;
            this.F_radio_button.Text = "Feminine";
            this.F_radio_button.UseVisualStyleBackColor = true;
            this.F_radio_button.CheckedChanged += new System.EventHandler(this.F_radio_button_CheckedChanged);
            // 
            // GroupBox_All
            // 
            this.GroupBox_All.Controls.Add(this.Address_box);
            this.GroupBox_All.Controls.Add(this.Gender_GroupBox);
            this.GroupBox_All.Controls.Add(this.Gender_Label);
            this.GroupBox_All.Controls.Add(this.Address_Label);
            this.GroupBox_All.Controls.Add(this.BirthDate_Date);
            this.GroupBox_All.Controls.Add(this.Name_Text);
            this.GroupBox_All.Controls.Add(this.Code_Text);
            this.GroupBox_All.Controls.Add(this.Exit_Button);
            this.GroupBox_All.Controls.Add(this.Delete_Button);
            this.GroupBox_All.Controls.Add(this.Edit_Button);
            this.GroupBox_All.Controls.Add(this.Add_Button);
            this.GroupBox_All.Controls.Add(this.Search_Button);
            this.GroupBox_All.Controls.Add(this.New_Button);
            this.GroupBox_All.Controls.Add(this.Birth_Date_label);
            this.GroupBox_All.Controls.Add(this.Name_Label);
            this.GroupBox_All.Controls.Add(this.Code_Label);
            this.GroupBox_All.Location = new System.Drawing.Point(83, 44);
            this.GroupBox_All.Name = "GroupBox_All";
            this.GroupBox_All.Size = new System.Drawing.Size(629, 344);
            this.GroupBox_All.TabIndex = 37;
            this.GroupBox_All.TabStop = false;
            this.GroupBox_All.Text = "Patient Management";
            this.GroupBox_All.Enter += new System.EventHandler(this.GroupBox_All_Enter);
            // 
            // Address_box
            // 
            this.Address_box.Location = new System.Drawing.Point(87, 164);
            this.Address_box.Name = "Address_box";
            this.Address_box.Size = new System.Drawing.Size(178, 58);
            this.Address_box.TabIndex = 37;
            this.Address_box.Text = "";
            this.Address_box.TextChanged += new System.EventHandler(this.Address_box_TextChanged);
            // 
            // Patient_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBox_All);
            this.Name = "Patient_Management_Form";
            this.Text = "Patient_Management";
            this.Gender_GroupBox.ResumeLayout(false);
            this.Gender_GroupBox.PerformLayout();
            this.GroupBox_All.ResumeLayout(false);
            this.GroupBox_All.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthDate_Date;
        private System.Windows.Forms.TextBox Name_Text;
        private System.Windows.Forms.TextBox Code_Text;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Button Search_Button;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Label Birth_Date_label;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Code_Label;
        private System.Windows.Forms.Label Address_Label;
        private System.Windows.Forms.Label Gender_Label;
        private System.Windows.Forms.GroupBox Gender_GroupBox;
        private System.Windows.Forms.RadioButton M_Radio_Button;
        private System.Windows.Forms.RadioButton F_radio_button;
        private System.Windows.Forms.GroupBox GroupBox_All;
        private System.Windows.Forms.RichTextBox Address_box;
    }
}