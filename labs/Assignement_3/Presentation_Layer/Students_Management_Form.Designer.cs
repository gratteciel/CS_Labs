﻿namespace Presentation_Layer
{
    partial class Students_Management_Form
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
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.birthDate_Date = new System.Windows.Forms.DateTimePicker();
            this.family_Text = new System.Windows.Forms.TextBox();
            this.name_Text = new System.Windows.Forms.TextBox();
            this.id_Text = new System.Windows.Forms.TextBox();
            this.birthDate_Label = new System.Windows.Forms.Label();
            this.family_Label = new System.Windows.Forms.Label();
            this.name_Label = new System.Windows.Forms.Label();
            this.id_Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_arrows = new System.Windows.Forms.GroupBox();
            this.firstRow_Button = new System.Windows.Forms.Button();
            this.previous_Button = new System.Windows.Forms.Button();
            this.next_Button = new System.Windows.Forms.Button();
            this.lastRow_Button = new System.Windows.Forms.Button();
            this.groupBox_Buttons = new System.Windows.Forms.GroupBox();
            this.exit_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.modify_Button = new System.Windows.Forms.Button();
            this.add_Button = new System.Windows.Forms.Button();
            this.search_Button = new System.Windows.Forms.Button();
            this.new_Button = new System.Windows.Forms.Button();
            this.groupBox_Info.SuspendLayout();
            this.groupBox_arrows.SuspendLayout();
            this.groupBox_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.Controls.Add(this.birthDate_Date);
            this.groupBox_Info.Controls.Add(this.family_Text);
            this.groupBox_Info.Controls.Add(this.name_Text);
            this.groupBox_Info.Controls.Add(this.id_Text);
            this.groupBox_Info.Controls.Add(this.birthDate_Label);
            this.groupBox_Info.Controls.Add(this.family_Label);
            this.groupBox_Info.Controls.Add(this.name_Label);
            this.groupBox_Info.Controls.Add(this.id_Label);
            this.groupBox_Info.Location = new System.Drawing.Point(165, 65);
            this.groupBox_Info.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Info.Size = new System.Drawing.Size(622, 398);
            this.groupBox_Info.TabIndex = 0;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Info";
            this.groupBox_Info.Enter += new System.EventHandler(this.groupBox_Info_Enter);
            // 
            // birthDate_Date
            // 
            this.birthDate_Date.Location = new System.Drawing.Point(222, 323);
            this.birthDate_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthDate_Date.Name = "birthDate_Date";
            this.birthDate_Date.Size = new System.Drawing.Size(276, 26);
            this.birthDate_Date.TabIndex = 7;
            this.birthDate_Date.ValueChanged += new System.EventHandler(this.birthDate_Date_ValueChanged);
            // 
            // family_Text
            // 
            this.family_Text.Location = new System.Drawing.Point(222, 234);
            this.family_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.family_Text.Name = "family_Text";
            this.family_Text.Size = new System.Drawing.Size(276, 26);
            this.family_Text.TabIndex = 6;
            this.family_Text.TextChanged += new System.EventHandler(this.family_Text_TextChanged);
            // 
            // name_Text
            // 
            this.name_Text.Location = new System.Drawing.Point(222, 142);
            this.name_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name_Text.Name = "name_Text";
            this.name_Text.Size = new System.Drawing.Size(276, 26);
            this.name_Text.TabIndex = 5;
            this.name_Text.TextChanged += new System.EventHandler(this.name_Text_TextChanged);
            // 
            // id_Text
            // 
            this.id_Text.Location = new System.Drawing.Point(222, 63);
            this.id_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_Text.Name = "id_Text";
            this.id_Text.Size = new System.Drawing.Size(276, 26);
            this.id_Text.TabIndex = 4;
            this.id_Text.TextChanged += new System.EventHandler(this.id_Text_TextChanged);
            // 
            // birthDate_Label
            // 
            this.birthDate_Label.AutoSize = true;
            this.birthDate_Label.Location = new System.Drawing.Point(58, 323);
            this.birthDate_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.birthDate_Label.Name = "birthDate_Label";
            this.birthDate_Label.Size = new System.Drawing.Size(81, 20);
            this.birthDate_Label.TabIndex = 3;
            this.birthDate_Label.Text = "Birth Date";
            this.birthDate_Label.Click += new System.EventHandler(this.birthDate_Label_Click);
            // 
            // family_Label
            // 
            this.family_Label.AutoSize = true;
            this.family_Label.Location = new System.Drawing.Point(58, 238);
            this.family_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.family_Label.Name = "family_Label";
            this.family_Label.Size = new System.Drawing.Size(54, 20);
            this.family_Label.TabIndex = 2;
            this.family_Label.Text = "Family";
            this.family_Label.Click += new System.EventHandler(this.family_Label_Click);
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(58, 146);
            this.name_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(51, 20);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "Name";
            this.name_Label.Click += new System.EventHandler(this.name_Label_Click);
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Location = new System.Drawing.Point(58, 63);
            this.id_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(26, 20);
            this.id_Label.TabIndex = 0;
            this.id_Label.Text = "ID";
            this.id_Label.Click += new System.EventHandler(this.id_Label_Click);
            // 
            // groupBox_arrows
            // 
            this.groupBox_arrows.Controls.Add(this.firstRow_Button);
            this.groupBox_arrows.Controls.Add(this.previous_Button);
            this.groupBox_arrows.Controls.Add(this.next_Button);
            this.groupBox_arrows.Controls.Add(this.lastRow_Button);
            this.groupBox_arrows.Location = new System.Drawing.Point(165, 495);
            this.groupBox_arrows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_arrows.Name = "groupBox_arrows";
            this.groupBox_arrows.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_arrows.Size = new System.Drawing.Size(993, 102);
            this.groupBox_arrows.TabIndex = 1;
            this.groupBox_arrows.TabStop = false;
            this.groupBox_arrows.Enter += new System.EventHandler(this.groupBox_arrows_Enter);
            // 
            // firstRow_Button
            // 
            this.firstRow_Button.Location = new System.Drawing.Point(9, 29);
            this.firstRow_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstRow_Button.Name = "firstRow_Button";
            this.firstRow_Button.Size = new System.Drawing.Size(216, 46);
            this.firstRow_Button.TabIndex = 6;
            this.firstRow_Button.Text = "<<";
            this.firstRow_Button.UseVisualStyleBackColor = true;
            this.firstRow_Button.Click += new System.EventHandler(this.firstRow_Button_Click);
            // 
            // previous_Button
            // 
            this.previous_Button.Location = new System.Drawing.Point(261, 29);
            this.previous_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previous_Button.Name = "previous_Button";
            this.previous_Button.Size = new System.Drawing.Size(216, 46);
            this.previous_Button.TabIndex = 7;
            this.previous_Button.Text = "<";
            this.previous_Button.UseVisualStyleBackColor = true;
            this.previous_Button.Click += new System.EventHandler(this.previous_Button_Click);
            // 
            // next_Button
            // 
            this.next_Button.Location = new System.Drawing.Point(520, 29);
            this.next_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.next_Button.Name = "next_Button";
            this.next_Button.Size = new System.Drawing.Size(216, 46);
            this.next_Button.TabIndex = 8;
            this.next_Button.Text = ">";
            this.next_Button.UseVisualStyleBackColor = true;
            this.next_Button.Click += new System.EventHandler(this.next_Button_Click);
            // 
            // lastRow_Button
            // 
            this.lastRow_Button.Location = new System.Drawing.Point(765, 29);
            this.lastRow_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastRow_Button.Name = "lastRow_Button";
            this.lastRow_Button.Size = new System.Drawing.Size(219, 46);
            this.lastRow_Button.TabIndex = 9;
            this.lastRow_Button.Text = ">>";
            this.lastRow_Button.UseVisualStyleBackColor = true;
            this.lastRow_Button.Click += new System.EventHandler(this.lastRow_Button_Click);
            // 
            // groupBox_Buttons
            // 
            this.groupBox_Buttons.Controls.Add(this.exit_Button);
            this.groupBox_Buttons.Controls.Add(this.delete_Button);
            this.groupBox_Buttons.Controls.Add(this.modify_Button);
            this.groupBox_Buttons.Controls.Add(this.add_Button);
            this.groupBox_Buttons.Controls.Add(this.search_Button);
            this.groupBox_Buttons.Controls.Add(this.new_Button);
            this.groupBox_Buttons.Location = new System.Drawing.Point(864, 65);
            this.groupBox_Buttons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Buttons.Name = "groupBox_Buttons";
            this.groupBox_Buttons.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox_Buttons.Size = new System.Drawing.Size(294, 398);
            this.groupBox_Buttons.TabIndex = 2;
            this.groupBox_Buttons.TabStop = false;
            this.groupBox_Buttons.Enter += new System.EventHandler(this.groupBox_Buttons_Enter);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(21, 312);
            this.exit_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(264, 46);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.Location = new System.Drawing.Point(21, 257);
            this.delete_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(264, 46);
            this.delete_Button.TabIndex = 4;
            this.delete_Button.Text = "Delete";
            this.delete_Button.UseVisualStyleBackColor = true;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // modify_Button
            // 
            this.modify_Button.Location = new System.Drawing.Point(21, 202);
            this.modify_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.modify_Button.Name = "modify_Button";
            this.modify_Button.Size = new System.Drawing.Size(264, 46);
            this.modify_Button.TabIndex = 3;
            this.modify_Button.Text = "Modify";
            this.modify_Button.UseVisualStyleBackColor = true;
            this.modify_Button.Click += new System.EventHandler(this.modify_Button_Click);
            // 
            // add_Button
            // 
            this.add_Button.Location = new System.Drawing.Point(21, 146);
            this.add_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add_Button.Name = "add_Button";
            this.add_Button.Size = new System.Drawing.Size(264, 46);
            this.add_Button.TabIndex = 2;
            this.add_Button.Text = "Add";
            this.add_Button.UseVisualStyleBackColor = true;
            this.add_Button.Click += new System.EventHandler(this.add_Button_Click);
            // 
            // search_Button
            // 
            this.search_Button.Location = new System.Drawing.Point(21, 91);
            this.search_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(264, 46);
            this.search_Button.TabIndex = 1;
            this.search_Button.Text = "Search";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // new_Button
            // 
            this.new_Button.Location = new System.Drawing.Point(21, 35);
            this.new_Button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.new_Button.Name = "new_Button";
            this.new_Button.Size = new System.Drawing.Size(264, 46);
            this.new_Button.TabIndex = 0;
            this.new_Button.Text = "New";
            this.new_Button.UseVisualStyleBackColor = true;
            this.new_Button.Click += new System.EventHandler(this.new_Button_Click);
            // 
            // Students_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBox_Buttons);
            this.Controls.Add(this.groupBox_arrows);
            this.Controls.Add(this.groupBox_Info);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Students_Management_Form";
            this.Text = "Students_Management_Form";
            this.Load += new System.EventHandler(this.Students_Management_Form_Load);
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.groupBox_arrows.ResumeLayout(false);
            this.groupBox_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Info;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox_arrows;
        private System.Windows.Forms.Label birthDate_Label;
        private System.Windows.Forms.Label family_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label id_Label;
        private System.Windows.Forms.Button firstRow_Button;
        private System.Windows.Forms.Button previous_Button;
        private System.Windows.Forms.Button next_Button;
        private System.Windows.Forms.Button lastRow_Button;
        private System.Windows.Forms.GroupBox groupBox_Buttons;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.Button modify_Button;
        private System.Windows.Forms.Button add_Button;
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.Button new_Button;
        private System.Windows.Forms.DateTimePicker birthDate_Date;
        private System.Windows.Forms.TextBox family_Text;
        private System.Windows.Forms.TextBox name_Text;
        private System.Windows.Forms.TextBox id_Text;
    }
}