using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }

        private void course_Label_Click(object sender, EventArgs e)
        {

        }

        private void course_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            // Add columns
            dataGridView.Columns.Add("StudentID", "Student ID");
            dataGridView.Columns.Add("Name", "Name");
            dataGridView.Columns.Add("Family", "Family");
            dataGridView.Columns.Add("Grade", "Grade");
            BusinessCons business = new BusinessCons();
            string selectedCourse = course_comboBox.SelectedItem.ToString();
            DataTable studentData = business.GetCourseData(selectedCourse);

            
            
            // Add each row of student data to the DataGridView
            foreach (DataRow row in studentData.Rows)
            {
                dataGridView.Rows.Add(row["StudentID"], row["Name"], row["Family"], row["Grade"]);
            }
            //display average
            double classAverage = business.GetClassAverage(selectedCourse);
            average_Text.Text = "Class Average: " + classAverage.ToString("N2");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void average_Label_Click(object sender, EventArgs e)
        {

        }

        private void average_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            BusinessCons business = new BusinessCons();
            PopulateComboBox();
            business.openConn();
        }
        private void PopulateComboBox()
        {
            BusinessCons business = new BusinessCons();
            DataTable resultCourse = business.PopulateCourses();
            foreach (DataRow row in resultCourse.Rows)
            {
                course_comboBox.Items.Add(row["CourseName"]);

            }

        }
    }
}
