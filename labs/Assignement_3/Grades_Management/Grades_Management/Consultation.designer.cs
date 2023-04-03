namespace Presentation_Layer
{
    partial class Consultation
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
            this.course_Label = new System.Windows.Forms.Label();
            this.average_Label = new System.Windows.Forms.Label();
            this.average_Text = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.course_comboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // course_Label
            // 
            this.course_Label.AutoSize = true;
            this.course_Label.Location = new System.Drawing.Point(374, 28);
            this.course_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.course_Label.Name = "course_Label";
            this.course_Label.Size = new System.Drawing.Size(60, 20);
            this.course_Label.TabIndex = 0;
            this.course_Label.Text = "Course";
            this.course_Label.Click += new System.EventHandler(this.course_Label_Click);
            // 
            // average_Label
            // 
            this.average_Label.AutoSize = true;
            this.average_Label.Location = new System.Drawing.Point(852, 642);
            this.average_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.average_Label.Name = "average_Label";
            this.average_Label.Size = new System.Drawing.Size(153, 20);
            this.average_Label.TabIndex = 1;
            this.average_Label.Text = "Average of the class";
            this.average_Label.Click += new System.EventHandler(this.average_Label_Click);
            // 
            // average_Text
            // 
            this.average_Text.Location = new System.Drawing.Point(1023, 637);
            this.average_Text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.average_Text.Name = "average_Text";
            this.average_Text.Size = new System.Drawing.Size(157, 26);
            this.average_Text.TabIndex = 2;
            this.average_Text.TextChanged += new System.EventHandler(this.average_Text_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(144, 118);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.Size = new System.Drawing.Size(1016, 460);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // course_comboBox
            // 
            this.course_comboBox.FormattingEnabled = true;
            this.course_comboBox.Location = new System.Drawing.Point(490, 23);
            this.course_comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.course_comboBox.Name = "course_comboBox";
            this.course_comboBox.Size = new System.Drawing.Size(241, 28);
            this.course_comboBox.TabIndex = 4;
            this.course_comboBox.SelectedIndexChanged += new System.EventHandler(this.course_comboBox_SelectedIndexChanged);
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 692);
            this.Controls.Add(this.course_comboBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.average_Text);
            this.Controls.Add(this.average_Label);
            this.Controls.Add(this.course_Label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Consultation";
            this.Text = "Consultation";
            this.Load += new System.EventHandler(this.Consultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label course_Label;
        private System.Windows.Forms.Label average_Label;
        private System.Windows.Forms.TextBox average_Text;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox course_comboBox;
    }
}