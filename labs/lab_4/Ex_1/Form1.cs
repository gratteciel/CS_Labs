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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        DataTable dataTable;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            //you can change to customers there on the initial catalog 
            connection = new SqlConnection(@"Data Source=DESKTOP-26HSG19\SQLEXPRESS;Initial Catalog=lab_4;Integrated Security=True");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToDB();
        }
        private void ConnectToDB()
        {
            
            try
            {
                connection.Open();
                MessageBox.Show("Connection Open !");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting to SQL Server.");
                MessageBox.Show(e.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            SqlCommand command = new SqlCommand("Select * from customer", connection);
            adapter = new SqlDataAdapter(command);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisconnectedFromDB();
        }

        private void DisconnectedFromDB()
        {
            if (connection != null)
            {
                connection.Close();
                MessageBox.Show("Closing the Connection"); 
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}