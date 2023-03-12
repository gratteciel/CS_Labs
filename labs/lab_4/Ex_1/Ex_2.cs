using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ex_1
{
    public partial class Ex_2 : Form
    {
        SqlConnection connection;
        DataTable dataTable;
        SqlDataAdapter adapter;
        private int currentCin;
        private int currentRow;
        private int totalRows;
        public Ex_2()
        {
            InitializeComponent();
            //you can change to customers there on the initial catalog 
            connection = new SqlConnection(@"Data Source=DESKTOP-26HSG19\SQLEXPRESS;Initial Catalog=lab_4;Integrated Security=True");

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM customer", connection);
            connection.Open();
            totalRows = (int)command.ExecuteScalar();
            connection.Close();
            command = new SqlCommand("SELECT TOP 1 * FROM customer ORDER BY CIN ASC", connection);
            adapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            if (dataTable.Rows.Count > 0 && int.TryParse(dataTable.Rows[0]["CIN"].ToString(), out int cin))
            {
                currentCin = cin;
            }
            currentRow = 1;
            UpdateLabel();
            

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentRow > 1)
            {
                SqlCommand command = new SqlCommand("Select * from customer where CIN = (SELECT MAX(CIN) FROM customer WHERE CIN < @currentCin)", connection);
                command.Parameters.AddWithValue("@currentCin", currentCin);
                adapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                if (dataTable.Rows.Count > 0 && int.TryParse(dataTable.Rows[0]["CIN"].ToString(), out int cin))
                {
                    currentCin = cin;
                }
                currentRow--;
                UpdateLabel();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from customer where CIN > @currentCin ORDER BY CIN ASC", connection);
            command.Parameters.AddWithValue("@currentCin", currentCin);
            adapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            if (dataTable.Rows.Count > 0 && int.TryParse(dataTable.Rows[0]["CIN"].ToString(), out int cin))
            {
                currentCin = cin;
                currentRow++;
                UpdateLabel();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM customer ORDER BY CIN DESC", connection);
            adapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            if (dataTable.Rows.Count > 0 && int.TryParse(dataTable.Rows[0]["CIN"].ToString(), out int cin))
            {
                currentCin = cin;
            }
            currentRow = totalRows;
            UpdateLabel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }
        private void UpdateLabel()
        {
            label6.Text = currentRow + "/" + dataTable.Rows.Count;
        }
    }
}