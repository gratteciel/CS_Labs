using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab_5
{
    public partial class Ex_1 : Form
    {
        private DataClasses2DataContext db = new DataClasses2DataContext();
        private bool isFiltering = false;
        public Ex_1()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            listBox1.ClearSelected();
            listBox2.ClearSelected();
            checkBox1.Checked = false;
            isFiltering = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox3.Text = row.Cells["ID"].Value.ToString();
                textBox4.Text = row.Cells["Name"].Value.ToString();
                textBox5.Text = row.Cells["Family"].Value.ToString();
                textBox6.Text = row.Cells["Grade"].Value.ToString();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //1st filter text 
        {
            if (isFiltering)
            {
                button1.PerformClick();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) //2nd filter text
        {
            if (isFiltering)
            {
                button1.PerformClick();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //list box 1st filter
        {
            if (isFiltering)
            {
                button1.PerformClick();
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) //list box 2nd filter 
        {
            if (isFiltering && checkBox1.Checked)
            {
                button1.PerformClick();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //double filters
        {
            if (isFiltering)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e) //search button
        {
            var query = from s in db.students select s;

            if (listBox1.SelectedItem != null)
            {
                string field = listBox1.SelectedItem.ToString();
                string value = textBox1.Text.Trim();

                switch (field)
                {
                    case "ID":
                        int id = 0;
                        if (int.TryParse(value, out id))
                        {
                            query = query.Where(s => s.ID == id);
                        }
                        break;
                    case "Name":
                        query = query.Where(s => s.Name.Contains(value));
                        break;
                    case "Family":
                        query = query.Where(s => s.Family.Contains(value));
                        break;
                    case "Grade":
                        double grade = 0;
                        if (double.TryParse(value, out grade))
                        {
                            query = query.Where(s => s.Grade == grade);
                        }
                        break;
                }
            }

            if (listBox2.SelectedItem != null && checkBox1.Checked)
            {
                string field = listBox2.SelectedItem.ToString();
                string value = textBox2.Text.Trim();

                switch (field)
                {
                    case "ID":
                        int id = 0;
                        if (int.TryParse(value, out id))
                        {
                            query = query.Where(s => s.ID == id);
                        }
                        break;
                    case "Name":
                        query = query.Where(s => s.Name.Contains(value));
                        break;
                    case "Family":
                        query = query.Where(s => s.Family.Contains(value));
                        break;
                    case "Grade":
                        double grade = 0;
                        if (double.TryParse(value, out grade))
                        {
                            query = query.Where(s => s.Grade == grade);
                        }
                        break;
                }

                isFiltering = true;
            }

            dataGridView1.DataSource = query.ToList();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) // Id label
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) //grade label
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e) //name label
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e) //Family label
        {

        }

        private void button5_Click(object sender, EventArgs e) //Save button
        {

        }

        private void button6_Click(object sender, EventArgs e) //Cancel button
        {
            ResetForm();
        }

        private void Ex_1_Load(object sender, EventArgs e)
        {
            LoadData();
            

        }
        private void LoadData()
        {
                var data = from s in db.students
                select new { s.ID, s.Name, s.Family, s.Grade };
                dataGridView1.DataSource = data.ToList();
        }

        private void button2_Click(object sender, EventArgs e) //New button
        {
            int id = Convert.ToInt32(textBox3.Text);
            var student = db.students.SingleOrDefault(s => s.ID == id);

            if (student != null)
            {
                student.Name = textBox5.Text;
                student.Family = textBox6.Text;
                student.Grade = (int?)Convert.ToDecimal(textBox4.Text);
                db.SubmitChanges();
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e) //Edit button
        {

        }

        private void button4_Click(object sender, EventArgs e) //delete button
        {
            // Delete selected row
            int id = int.Parse(textBox3.Text);
            var data = from s in db.students
                       where s.ID == id
                       select s;
            foreach (var d in data)
            {
                db.students.DeleteOnSubmit(d);
            }
            db.SubmitChanges();
            LoadData();
        }
    }
}
