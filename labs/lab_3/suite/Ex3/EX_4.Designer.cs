using System.ComponentModel;

namespace Ex3
{
    partial class EX_4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.resgisterDate_label = new System.Windows.Forms.Label();
            this.address_label = new System.Windows.Forms.Label();
            this.address_text = new System.Windows.Forms.TextBox();
            this.tel_label = new System.Windows.Forms.Label();
            this.telText = new System.Windows.Forms.TextBox();
            this.cancel_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(560, 64);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(513, 20);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(146, 100);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(260, 20);
            this.dateTime.TabIndex = 1;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(146, 59);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(242, 20);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.Location = new System.Drawing.Point(34, 62);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(96, 22);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name and Family";
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // resgisterDate_label
            // 
            this.resgisterDate_label.Location = new System.Drawing.Point(34, 98);
            this.resgisterDate_label.Name = "resgisterDate_label";
            this.resgisterDate_label.Size = new System.Drawing.Size(86, 22);
            this.resgisterDate_label.TabIndex = 4;
            this.resgisterDate_label.Text = "registering Date";
            this.resgisterDate_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // address_label
            // 
            this.address_label.Location = new System.Drawing.Point(34, 198);
            this.address_label.Name = "address_label";
            this.address_label.Size = new System.Drawing.Size(86, 22);
            this.address_label.TabIndex = 6;
            this.address_label.Text = "Address";
            this.address_label.Click += new System.EventHandler(this.address_label_Click);
            // 
            // address_text
            // 
            this.address_text.Location = new System.Drawing.Point(146, 195);
            this.address_text.Name = "address_text";
            this.address_text.Size = new System.Drawing.Size(242, 20);
            this.address_text.TabIndex = 5;
            this.address_text.TextChanged += new System.EventHandler(this.address_text_TextChanged);
            // 
            // tel_label
            // 
            this.tel_label.Location = new System.Drawing.Point(34, 248);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(86, 22);
            this.tel_label.TabIndex = 8;
            this.tel_label.Text = "Tel:";
            this.tel_label.Click += new System.EventHandler(this.tel_label_Click);
            // 
            // telText
            // 
            this.telText.Location = new System.Drawing.Point(146, 245);
            this.telText.Name = "telText";
            this.telText.Size = new System.Drawing.Size(242, 20);
            this.telText.TabIndex = 7;
            this.telText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(506, 163);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(79, 35);
            this.cancel_button.TabIndex = 9;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(591, 163);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(79, 35);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(676, 163);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(79, 35);
            this.clear_button.TabIndex = 11;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(449, 66);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(97, 20);
            this.maskedTextBox2.TabIndex = 12;
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // EX_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.tel_label);
            this.Controls.Add(this.telText);
            this.Controls.Add(this.address_label);
            this.Controls.Add(this.address_text);
            this.Controls.Add(this.resgisterDate_label);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "EX_4";
            this.Text = "EX_4";
            this.Load += new System.EventHandler(this.EX_4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MaskedTextBox maskedTextBox2;

        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button clear_button;

        private System.Windows.Forms.Label address_label;
        private System.Windows.Forms.TextBox address_text;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.TextBox telText;

        private System.Windows.Forms.Label resgisterDate_label;

        private System.Windows.Forms.Label label_Name;

        private System.Windows.Forms.TextBox textBox_name;

        private System.Windows.Forms.DateTimePicker dateTime;

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        #endregion
    }
}