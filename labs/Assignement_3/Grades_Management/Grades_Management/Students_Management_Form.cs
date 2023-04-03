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
    public partial class Students_Management_Form : Form
    {
        public Students_Management_Form()
        {
            InitializeComponent();
        }

        private void groupBox_Info_Enter(object sender, EventArgs e)
        {

        }

        private void id_Label_Click(object sender, EventArgs e)
        {

        }

        private void id_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_Label_Click(object sender, EventArgs e)
        {

        }

        private void name_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void family_Label_Click(object sender, EventArgs e)
        {

        }

        private void family_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthDate_Label_Click(object sender, EventArgs e)
        {

        }

        private void birthDate_Date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Buttons_Enter(object sender, EventArgs e)
        {

        }

        private void new_Button_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void ClearFields()
        {
            id_Text.Clear();
            name_Text.Clear();
            family_Text.Clear();
            birthDate_Date.Format = DateTimePickerFormat.Custom;
        }

        private void search_Button_Click(object sender, EventArgs e)
        {
            if(id_Text.Text != "")
            {
                SearchById();
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }
        }
        private void SearchById()
        { 
            if(int.TryParse(id_Text.Text, out int id))
            {
                BusinessStudent business = new BusinessStudent();
                DataTable result = business.SelectFromId(id);
                foreach (DataRow row in result.Rows)
                {
                    id_Text.Text = row["StudentID"].ToString();
                    name_Text.Text = row["Name"].ToString();
                    family_Text.Text = row["Family"].ToString();
                    birthDate_Date.Text = row["BirthDate"].ToString();

                }

            }

            else
            {
                //The input is not a valid integer
                MessageBox.Show("Please enter a valid integer value.");

            }
        }

        private void add_Button_Click(object sender, EventArgs e)
        {
            if (id_Text.Text != "" && name_Text.Text !="" && family_Text.Text != "" && birthDate_Date.Value < DateTime.Now)
            {
                AddStudent();
            }
            else
            {
                MessageBox.Show("You should fill correctly inputs");

            }

        }
        private void AddStudent()
        {
            BusinessStudent business = new BusinessStudent();
            if (business.AddStudent(int.Parse(id_Text.Text), name_Text.Text, family_Text.Text, birthDate_Date.Value) == true)
            {
                MessageBox.Show("Student Added !");

            }
            else
            {
                MessageBox.Show("We can't add the new Student the id should already exists,we change the id value for being able to be insert in the table ");

            }
            ClearFields();
        }

        private void modify_Button_Click(object sender, EventArgs e)
        {
            if (id_Text.Text != "" && name_Text.Text != "" && family_Text.Text != "" && birthDate_Date.Value < DateTime.Now)
            {
                ModifyStudent();
            }
            else
            {
                MessageBox.Show("You should fill correctly inputs");

            }


        }
        private void ModifyStudent()
        {
            BusinessStudent business = new BusinessStudent();
            if (business.ModifyStudent(int.Parse(id_Text.Text), name_Text.Text, family_Text.Text, birthDate_Date.Value) == true)
            {
                MessageBox.Show("Student Modified with the id = "+ id_Text.Text +"!");

            }
            else
            {
                MessageBox.Show("We can't modify the student with the following id : "+ id_Text.Text + " create a new student or find the good id ");

            }
            ClearFields();


        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            if(id_Text.Text != "")
            {
                DeleteStudent();

            }
            else
            {
                MessageBox.Show("You should fill an id please");
            }

        }
        private void DeleteStudent()
        {
            BusinessStudent business = new BusinessStudent();
            if (business.DeleteStudent(int.Parse(id_Text.Text)) == true)
            {
                MessageBox.Show("Student deleted with the id = " + id_Text.Text + "!");

            }
            else
            {
                MessageBox.Show("We can't delete the student with the following id : " + id_Text.Text + " find the good id ");

            }
            ClearFields();

        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close the form", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                BusinessStudent business = new BusinessStudent();
                business.unLink();
                this.Close();
            }
        }

        private void firstRow_Button_Click(object sender, EventArgs e)
        {
            if (id_Text.Text != "")
            {
                FirstID();
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }

        }
        private void FirstID()
        {
            if (int.TryParse(id_Text.Text, out int id))
            {
                BusinessStudent business = new BusinessStudent();
                DataTable result = business.FirstID(id);
                foreach (DataRow row in result.Rows)
                {
                    id_Text.Text = row["StudentID"].ToString();
                    name_Text.Text = row["Name"].ToString();
                    family_Text.Text = row["Family"].ToString();
                    birthDate_Date.Text = row["BirthDate"].ToString();

                }

            }

            else
            {
                //The input is not a valid integer
                MessageBox.Show("Please enter a valid integer value.");

            }
        }

        private void groupBox_arrows_Enter(object sender, EventArgs e)
        {

        }

        private void previous_Button_Click(object sender, EventArgs e)
        {
            if (id_Text.Text != "")
            {
                PreviousID();
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }

        }
        private void PreviousID()
        {
            if (int.TryParse(id_Text.Text, out int id))
            {
                BusinessStudent business = new BusinessStudent();
                DataTable result = business.PreviousID(id);
                foreach (DataRow row in result.Rows)
                {
                    id_Text.Text = row["StudentID"].ToString();
                    name_Text.Text = row["Name"].ToString();
                    family_Text.Text = row["Family"].ToString();
                    birthDate_Date.Text = row["BirthDate"].ToString();

                }

            }

            else
            {
                //The input is not a valid integer
                MessageBox.Show("Please enter a valid integer value.");

            }

        }

        private void next_Button_Click(object sender, EventArgs e)
        {
            if (id_Text.Text != "")
            {
                NextID();
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }

        }
        private void NextID()
        {
            if (int.TryParse(id_Text.Text, out int id))
            {
                BusinessStudent business = new BusinessStudent();
                DataTable result = business.NextID(id);
                foreach (DataRow row in result.Rows)
                {
                    id_Text.Text = row["StudentID"].ToString();
                    name_Text.Text = row["Name"].ToString();
                    family_Text.Text = row["Family"].ToString();
                    birthDate_Date.Text = row["BirthDate"].ToString();

                }

            }

            else
            {
                //The input is not a valid integer
                MessageBox.Show("Please enter a valid integer value.");

            }

        }

        private void lastRow_Button_Click(object sender, EventArgs e)
        {
            if (id_Text.Text != "")
            {
                LastID();
            }
            else
            {
                MessageBox.Show("You should fill the Code please ");
            }

        }
        private void LastID()
        {
            if (int.TryParse(id_Text.Text, out int id))
            {
                BusinessStudent business = new BusinessStudent();
                DataTable result = business.LastID(id);
                foreach (DataRow row in result.Rows)
                {
                    id_Text.Text = row["StudentID"].ToString();
                    name_Text.Text = row["Name"].ToString();
                    family_Text.Text = row["Family"].ToString();
                    birthDate_Date.Text = row["BirthDate"].ToString();

                }

            }

            else
            {
                //The input is not a valid integer
                MessageBox.Show("Please enter a valid integer value.");

            }

        }

        private void Students_Management_Form_Load(object sender, EventArgs e)
        {
            BusinessStudent business = new BusinessStudent();
            business.openConn();

        }
    }
}
