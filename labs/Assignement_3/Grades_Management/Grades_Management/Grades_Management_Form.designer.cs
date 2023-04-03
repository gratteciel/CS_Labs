namespace Presentation_Layer
{
    partial class Grades_Management_Form
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
            this.groupBox_Text = new System.Windows.Forms.GroupBox();
            this.grade_Text = new System.Windows.Forms.TextBox();
            this.name_family_Text = new System.Windows.Forms.TextBox();
            this.grade_Label = new System.Windows.Forms.Label();
            this.course_Label = new System.Windows.Forms.Label();
            this.name_family_Label = new System.Windows.Forms.Label();
            this.id_Label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_Button = new System.Windows.Forms.GroupBox();
            this.exit_Button = new System.Windows.Forms.Button();
            this.preview_Button = new System.Windows.Forms.Button();
            this.modifyGrade_Button = new System.Windows.Forms.Button();
            this.addGrade_Button = new System.Windows.Forms.Button();
            this.new_Button = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.id_ComboBox = new System.Windows.Forms.ComboBox();
            this.course_ComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_Text.SuspendLayout();
            this.groupBox_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_Text
            // 
            this.groupBox_Text.Controls.Add(this.course_ComboBox);
            this.groupBox_Text.Controls.Add(this.id_ComboBox);
            this.groupBox_Text.Controls.Add(this.grade_Text);
            this.groupBox_Text.Controls.Add(this.name_family_Text);
            this.groupBox_Text.Controls.Add(this.grade_Label);
            this.groupBox_Text.Controls.Add(this.course_Label);
            this.groupBox_Text.Controls.Add(this.name_family_Label);
            this.groupBox_Text.Controls.Add(this.id_Label);
            this.groupBox_Text.Location = new System.Drawing.Point(82, 32);
            this.groupBox_Text.Name = "groupBox_Text";
            this.groupBox_Text.Size = new System.Drawing.Size(443, 199);
            this.groupBox_Text.TabIndex = 0;
            this.groupBox_Text.TabStop = false;
            this.groupBox_Text.Enter += new System.EventHandler(this.groupBox_Text_Enter);
            // 
            // grade_Text
            // 
            this.grade_Text.Location = new System.Drawing.Point(221, 126);
            this.grade_Text.Name = "grade_Text";
            this.grade_Text.Size = new System.Drawing.Size(172, 20);
            this.grade_Text.TabIndex = 5;
            this.grade_Text.TextChanged += new System.EventHandler(this.grade_Text_TextChanged);
            // 
            // name_family_Text
            // 
            this.name_family_Text.Location = new System.Drawing.Point(221, 55);
            this.name_family_Text.Name = "name_family_Text";
            this.name_family_Text.Size = new System.Drawing.Size(172, 20);
            this.name_family_Text.TabIndex = 4;
            this.name_family_Text.TextChanged += new System.EventHandler(this.name_family_Text_TextChanged);
            // 
            // grade_Label
            // 
            this.grade_Label.AutoSize = true;
            this.grade_Label.Location = new System.Drawing.Point(26, 129);
            this.grade_Label.Name = "grade_Label";
            this.grade_Label.Size = new System.Drawing.Size(36, 13);
            this.grade_Label.TabIndex = 3;
            this.grade_Label.Text = "Grade";
            this.grade_Label.Click += new System.EventHandler(this.grade_Label_Click);
            // 
            // course_Label
            // 
            this.course_Label.AutoSize = true;
            this.course_Label.Location = new System.Drawing.Point(26, 93);
            this.course_Label.Name = "course_Label";
            this.course_Label.Size = new System.Drawing.Size(40, 13);
            this.course_Label.TabIndex = 2;
            this.course_Label.Text = "Course";
            this.course_Label.Click += new System.EventHandler(this.course_Label_Click);
            // 
            // name_family_Label
            // 
            this.name_family_Label.AutoSize = true;
            this.name_family_Label.Location = new System.Drawing.Point(26, 58);
            this.name_family_Label.Name = "name_family_Label";
            this.name_family_Label.Size = new System.Drawing.Size(88, 13);
            this.name_family_Label.TabIndex = 1;
            this.name_family_Label.Text = "Name and Family";
            this.name_family_Label.Click += new System.EventHandler(this.name_family_Label_Click);
            // 
            // id_Label
            // 
            this.id_Label.AutoSize = true;
            this.id_Label.Location = new System.Drawing.Point(26, 28);
            this.id_Label.Name = "id_Label";
            this.id_Label.Size = new System.Drawing.Size(18, 13);
            this.id_Label.TabIndex = 0;
            this.id_Label.Text = "ID";
            this.id_Label.Click += new System.EventHandler(this.id_Label_Click);
            // 
            // groupBox_Button
            // 
            this.groupBox_Button.Controls.Add(this.exit_Button);
            this.groupBox_Button.Controls.Add(this.preview_Button);
            this.groupBox_Button.Controls.Add(this.modifyGrade_Button);
            this.groupBox_Button.Controls.Add(this.addGrade_Button);
            this.groupBox_Button.Controls.Add(this.new_Button);
            this.groupBox_Button.Location = new System.Drawing.Point(554, 32);
            this.groupBox_Button.Name = "groupBox_Button";
            this.groupBox_Button.Size = new System.Drawing.Size(216, 199);
            this.groupBox_Button.TabIndex = 1;
            this.groupBox_Button.TabStop = false;
            this.groupBox_Button.Enter += new System.EventHandler(this.groupBox_Button_Enter);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(29, 162);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(167, 30);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // preview_Button
            // 
            this.preview_Button.Location = new System.Drawing.Point(29, 126);
            this.preview_Button.Name = "preview_Button";
            this.preview_Button.Size = new System.Drawing.Size(167, 30);
            this.preview_Button.TabIndex = 3;
            this.preview_Button.Text = "Preview";
            this.preview_Button.UseVisualStyleBackColor = true;
            this.preview_Button.Click += new System.EventHandler(this.preview_Button_Click);
            // 
            // modifyGrade_Button
            // 
            this.modifyGrade_Button.Location = new System.Drawing.Point(29, 91);
            this.modifyGrade_Button.Name = "modifyGrade_Button";
            this.modifyGrade_Button.Size = new System.Drawing.Size(167, 30);
            this.modifyGrade_Button.TabIndex = 2;
            this.modifyGrade_Button.Text = "Modify Grade";
            this.modifyGrade_Button.UseVisualStyleBackColor = true;
            this.modifyGrade_Button.Click += new System.EventHandler(this.modifyGrade_Button_Click);
            // 
            // addGrade_Button
            // 
            this.addGrade_Button.Location = new System.Drawing.Point(29, 55);
            this.addGrade_Button.Name = "addGrade_Button";
            this.addGrade_Button.Size = new System.Drawing.Size(167, 30);
            this.addGrade_Button.TabIndex = 1;
            this.addGrade_Button.Text = "Add Grade";
            this.addGrade_Button.UseVisualStyleBackColor = true;
            this.addGrade_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // new_Button
            // 
            this.new_Button.Location = new System.Drawing.Point(29, 19);
            this.new_Button.Name = "new_Button";
            this.new_Button.Size = new System.Drawing.Size(167, 30);
            this.new_Button.TabIndex = 0;
            this.new_Button.Text = "New";
            this.new_Button.UseVisualStyleBackColor = true;
            this.new_Button.Click += new System.EventHandler(this.new_Button_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(82, 254);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(688, 150);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // id_ComboBox
            // 
            this.id_ComboBox.FormattingEnabled = true;
            this.id_ComboBox.Location = new System.Drawing.Point(222, 25);
            this.id_ComboBox.Name = "id_ComboBox";
            this.id_ComboBox.Size = new System.Drawing.Size(171, 21);
            this.id_ComboBox.TabIndex = 6;
            this.id_ComboBox.SelectedIndexChanged += new System.EventHandler(this.id_ComboBox_SelectedIndexChanged);
            // 
            // course_ComboBox
            // 
            this.course_ComboBox.FormattingEnabled = true;
            this.course_ComboBox.Location = new System.Drawing.Point(222, 90);
            this.course_ComboBox.Name = "course_ComboBox";
            this.course_ComboBox.Size = new System.Drawing.Size(171, 21);
            this.course_ComboBox.TabIndex = 7;
            this.course_ComboBox.SelectedIndexChanged += new System.EventHandler(this.course_ComboBox_SelectedIndexChanged);
            // 
            // Grades_Management_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox_Button);
            this.Controls.Add(this.groupBox_Text);
            this.Name = "Grades_Management_Form";
            this.Text = "Grades_Management_Form";
            this.Load += new System.EventHandler(this.Grades_Management_Form_Load);
            this.groupBox_Text.ResumeLayout(false);
            this.groupBox_Text.PerformLayout();
            this.groupBox_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Text;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox_Button;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox grade_Text;
        private System.Windows.Forms.TextBox name_family_Text;
        private System.Windows.Forms.Label grade_Label;
        private System.Windows.Forms.Label course_Label;
        private System.Windows.Forms.Label name_family_Label;
        private System.Windows.Forms.Label id_Label;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button preview_Button;
        private System.Windows.Forms.Button modifyGrade_Button;
        private System.Windows.Forms.Button addGrade_Button;
        private System.Windows.Forms.Button new_Button;
        private System.Windows.Forms.ComboBox course_ComboBox;
        private System.Windows.Forms.ComboBox id_ComboBox;
    }
}