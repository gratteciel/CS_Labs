namespace Ex3
{
    partial class Form1
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
            this.listBox_language = new System.Windows.Forms.ListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_UP = new System.Windows.Forms.Button();
            this.button_LL = new System.Windows.Forms.Button();
            this.button_SS = new System.Windows.Forms.Button();
            this.button_L = new System.Windows.Forms.Button();
            this.button_R = new System.Windows.Forms.Button();
            this.button_ZAR = new System.Windows.Forms.Button();
            this.button_AZR = new System.Windows.Forms.Button();
            this.button_UPR = new System.Windows.Forms.Button();
            this.button_DOWNR = new System.Windows.Forms.Button();
            this.button_ZA = new System.Windows.Forms.Button();
            this.button_AZ = new System.Windows.Forms.Button();
            this.button_DOWN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_language
            // 
            this.listBox_language.FormattingEnabled = true;
            this.listBox_language.Items.AddRange(new object[] { "Langage C", "Langage Java", "Langage C#", "HTML", "CSS", "JavaScript", "Python" });
            this.listBox_language.Location = new System.Drawing.Point(87, 46);
            this.listBox_language.Name = "listBox_language";
            this.listBox_language.Size = new System.Drawing.Size(190, 225);
            this.listBox_language.TabIndex = 0;
            this.listBox_language.SelectedIndexChanged += new System.EventHandler(this.listBox_language_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(490, 46);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(190, 225);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // button_UP
            // 
            this.button_UP.Location = new System.Drawing.Point(101, 313);
            this.button_UP.Name = "button_UP";
            this.button_UP.Size = new System.Drawing.Size(56, 22);
            this.button_UP.TabIndex = 2;
            this.button_UP.Text = "UP";
            this.button_UP.UseVisualStyleBackColor = true;
            this.button_UP.Click += new System.EventHandler(this.button_UP_Click);
            // 
            // button_LL
            // 
            this.button_LL.Location = new System.Drawing.Point(355, 201);
            this.button_LL.Name = "button_LL";
            this.button_LL.Size = new System.Drawing.Size(56, 22);
            this.button_LL.TabIndex = 3;
            this.button_LL.Text = "<<";
            this.button_LL.UseVisualStyleBackColor = true;
            this.button_LL.Click += new System.EventHandler(this.button_LL_Click);
            // 
            // button_SS
            // 
            this.button_SS.Location = new System.Drawing.Point(355, 143);
            this.button_SS.Name = "button_SS";
            this.button_SS.Size = new System.Drawing.Size(56, 22);
            this.button_SS.TabIndex = 4;
            this.button_SS.Text = ">>";
            this.button_SS.UseVisualStyleBackColor = true;
            this.button_SS.Click += new System.EventHandler(this.button_SS_Click);
            // 
            // button_L
            // 
            this.button_L.Location = new System.Drawing.Point(355, 92);
            this.button_L.Name = "button_L";
            this.button_L.Size = new System.Drawing.Size(56, 22);
            this.button_L.TabIndex = 5;
            this.button_L.Text = "<";
            this.button_L.UseVisualStyleBackColor = true;
            this.button_L.Click += new System.EventHandler(this.button_L_Click);
            // 
            // button_R
            // 
            this.button_R.Location = new System.Drawing.Point(355, 46);
            this.button_R.Name = "button_R";
            this.button_R.Size = new System.Drawing.Size(56, 22);
            this.button_R.TabIndex = 6;
            this.button_R.Text = ">";
            this.button_R.UseVisualStyleBackColor = true;
            this.button_R.Click += new System.EventHandler(this.button_R_Click);
            // 
            // button_ZAR
            // 
            this.button_ZAR.Location = new System.Drawing.Point(624, 351);
            this.button_ZAR.Name = "button_ZAR";
            this.button_ZAR.Size = new System.Drawing.Size(56, 22);
            this.button_ZAR.TabIndex = 7;
            this.button_ZAR.Text = "Z-A";
            this.button_ZAR.UseVisualStyleBackColor = true;
            this.button_ZAR.Click += new System.EventHandler(this.button_ZAR_Click);
            // 
            // button_AZR
            // 
            this.button_AZR.Location = new System.Drawing.Point(538, 351);
            this.button_AZR.Name = "button_AZR";
            this.button_AZR.Size = new System.Drawing.Size(56, 22);
            this.button_AZR.TabIndex = 8;
            this.button_AZR.Text = "A-Z";
            this.button_AZR.UseVisualStyleBackColor = true;
            this.button_AZR.Click += new System.EventHandler(this.button_AZR_Click);
            // 
            // button_UPR
            // 
            this.button_UPR.Location = new System.Drawing.Point(538, 313);
            this.button_UPR.Name = "button_UPR";
            this.button_UPR.Size = new System.Drawing.Size(56, 22);
            this.button_UPR.TabIndex = 9;
            this.button_UPR.Text = "UP";
            this.button_UPR.UseVisualStyleBackColor = true;
            this.button_UPR.Click += new System.EventHandler(this.button_UPR_Click);
            // 
            // button_DOWNR
            // 
            this.button_DOWNR.Location = new System.Drawing.Point(624, 313);
            this.button_DOWNR.Name = "button_DOWNR";
            this.button_DOWNR.Size = new System.Drawing.Size(56, 22);
            this.button_DOWNR.TabIndex = 10;
            this.button_DOWNR.Text = "DOWN";
            this.button_DOWNR.UseVisualStyleBackColor = true;
            this.button_DOWNR.Click += new System.EventHandler(this.button_DOWNR_Click);
            // 
            // button_ZA
            // 
            this.button_ZA.Location = new System.Drawing.Point(208, 351);
            this.button_ZA.Name = "button_ZA";
            this.button_ZA.Size = new System.Drawing.Size(56, 22);
            this.button_ZA.TabIndex = 11;
            this.button_ZA.Text = "Z-A";
            this.button_ZA.UseVisualStyleBackColor = true;
            this.button_ZA.Click += new System.EventHandler(this.button_ZA_Click);
            // 
            // button_AZ
            // 
            this.button_AZ.Location = new System.Drawing.Point(101, 351);
            this.button_AZ.Name = "button_AZ";
            this.button_AZ.Size = new System.Drawing.Size(56, 22);
            this.button_AZ.TabIndex = 12;
            this.button_AZ.Text = "A-Z";
            this.button_AZ.UseVisualStyleBackColor = true;
            this.button_AZ.Click += new System.EventHandler(this.button_AZ_Click);
            // 
            // button_DOWN
            // 
            this.button_DOWN.Location = new System.Drawing.Point(208, 313);
            this.button_DOWN.Name = "button_DOWN";
            this.button_DOWN.Size = new System.Drawing.Size(56, 22);
            this.button_DOWN.TabIndex = 13;
            this.button_DOWN.Text = "DOWN";
            this.button_DOWN.UseVisualStyleBackColor = true;
            this.button_DOWN.Click += new System.EventHandler(this.button_DOWN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_DOWN);
            this.Controls.Add(this.button_AZ);
            this.Controls.Add(this.button_ZA);
            this.Controls.Add(this.button_DOWNR);
            this.Controls.Add(this.button_UPR);
            this.Controls.Add(this.button_AZR);
            this.Controls.Add(this.button_ZAR);
            this.Controls.Add(this.button_R);
            this.Controls.Add(this.button_L);
            this.Controls.Add(this.button_SS);
            this.Controls.Add(this.button_LL);
            this.Controls.Add(this.button_UP);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.listBox_language);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBox;

        private System.Windows.Forms.Button button_SS;
        private System.Windows.Forms.Button button_R;
        private System.Windows.Forms.Button button_L;
        private System.Windows.Forms.Button button_LL;

        private System.Windows.Forms.Button button_ZAR;

        private System.Windows.Forms.Button button_AZR;

        private System.Windows.Forms.Button button_DOWNR;

        private System.Windows.Forms.Button button_UPR;

        private System.Windows.Forms.Button button_ZA;

        private System.Windows.Forms.Button button_AZ;

        private System.Windows.Forms.Button button_UP;
        private System.Windows.Forms.Button button_DOWN;

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox listBox_language;
        private System.Windows.Forms.ListBox listBox_left;

        #endregion
    }
}