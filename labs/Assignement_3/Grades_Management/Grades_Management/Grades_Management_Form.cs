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
    public partial class Grades_Management_Form : Form
    {
        public Grades_Management_Form()
        {
            InitializeComponent();
           
        }
        private void PopulateComboBox()
        {
            BusinessGrades business = new BusinessGrades();
            DataTable result = business.PopulateID();
            foreach (DataRow row in result.Rows)
            {
                id_ComboBox.Items.Add(row["StudentID"]);

            }
            DataTable resultCourse = business.PopulateCourses();
            foreach (DataRow row in resultCourse.Rows)
            {
                course_ComboBox.Items.Add(row["CourseName"]);

            }
        }

        private void button2_Click(object sender, EventArgs e) // addGrade_Button
        {
            if (id_ComboBox.SelectedIndex != -1 && course_ComboBox.SelectedIndex != -1 && int.TryParse(grade_Text.Text, out int grade))
            {
                BusinessGrades business = new BusinessGrades();
                int studentId = int.Parse(id_ComboBox.SelectedItem.ToString());
                string course = course_ComboBox.SelectedItem.ToString();
                int grade1 = int.Parse(grade_Text.Text);

                if (business.AddGrade(studentId, course, grade1))
                {
                    MessageBox.Show("Grade Added");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Grade already exist");
                }
            }
            else
            {
                MessageBox.Show("Please select a student and a course.");
            }
        }

        private void groupBox_Text_Enter(object sender, EventArgs e)
        {

        }

        private void id_Label_Click(object sender, EventArgs e)
        {

        }

        private void name_family_Label_Click(object sender, EventArgs e)
        {

        }

        private void course_Label_Click(object sender, EventArgs e)
        {

        }

        private void grade_Label_Click(object sender, EventArgs e)
        {

        }

        private void name_family_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void grade_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Button_Enter(object sender, EventArgs e)
        {

        }

        private void new_Button_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        public void ClearFields()
        {
            id_ComboBox.SelectedIndex = -1;
            course_ComboBox.SelectedIndex = -1;
            name_family_Text.Text = "";
            grade_Text.Text = "";
        }

        private void modifyGrade_Button_Click(object sender, EventArgs e)
        {
            if (id_ComboBox.SelectedIndex != -1 && course_ComboBox.SelectedIndex != -1 && int.TryParse(grade_Text.Text, out int grade))
            {
                BusinessGrades business = new BusinessGrades();
                int studentId = int.Parse(id_ComboBox.SelectedItem.ToString());
                string course = course_ComboBox.SelectedItem.ToString();
                int grade1 = int.Parse(grade_Text.Text);

                if (business.ModifyGrade(studentId, course, grade1))
                {
                    MessageBox.Show("Grade Modified");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a student and a course.");
            }

        }

        private void preview_Button_Click(object sender, EventArgs e)
        {
            if (id_ComboBox.SelectedIndex != -1)
            {
                BusinessGrades business = new BusinessGrades();
                int studentId = int.Parse(id_ComboBox.SelectedItem.ToString());
                DataTable grades = business.GetGrades(studentId);
                dataGridView.DataSource = grades;
            }
            else
            {
                MessageBox.Show("Please select a student ");
            }
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the form", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BusinessGrades business = new BusinessGrades();
                business.unLink();
                this.Close();
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grades_Management_Form_Load(object sender, EventArgs e)
        {
            BusinessStudent business = new BusinessStudent();
            PopulateComboBox();
            business.openConn();
        }

        private void id_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void course_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
