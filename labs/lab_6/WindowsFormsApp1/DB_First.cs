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

namespace WindowsFormsApp1
{
    public partial class DB_First : Form
    {
        

        public DB_First()
        {
            var db = new DB_First();
            InitializeComponent();
            
        }

        private void DB_First_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@ "Data Source=LAPTOP-2F8CO37S;Initial Catalog=school;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new DB_First())
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            string connectionString =
            "Data Source=(local);Initial Catalog=Entity;"
            + "Integrated Security=true";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT * from dbo.sales ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
