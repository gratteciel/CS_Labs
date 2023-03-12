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
    public partial class EX_3 : Form
    {
        SqlConnection connection;
        DataTable dataTable;
        SqlDataAdapter adapter;
        private int currentCin;
        private int currentRow;
        private int totalRows;
        public EX_3()
        {
            InitializeComponent();
            //you can change to customer there on the initial catalog 
            connection = new SqlConnection(@"Data Source=DESKTOP-26HSG19\SQLEXPRESS;Initial Catalog=lab_4;Integrated Security=True");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        { 
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchCustomerByCIN();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCustomer();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClearInputFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void SearchCustomerByCIN()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid CIN");
                return;
            }

            int cin = Convert.ToInt32(textBox1.Text);

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM customer WHERE CIN = @cin", connection);
                cmd.Parameters.AddWithValue("@cin", cin);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox2.Text = reader["NAME"].ToString();
                    textBox3.Text = reader["FAMILY"].ToString();
                    textBox4.Text = reader["CITY"].ToString();
                    textBox5.Text = reader["TEL"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while searching customer: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddCustomer()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Please fill in all the input fields");
                return;
            }
            try
            {
                connection.Open();

                SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO customer (CIN, NAME, FAMILY, CITY, TEL) VALUES (@cin, @name, @family, @city, @tel)",
                        connection);
                cmd.Parameters.AddWithValue("@cin", Convert.ToInt32(textBox1.Text));
                cmd.Parameters.AddWithValue("@name", textBox2.Text);
                cmd.Parameters.AddWithValue("@family", textBox3.Text);
                cmd.Parameters.AddWithValue("@city", textBox4.Text);
                cmd.Parameters.AddWithValue("@tel", textBox5.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer added successfully");
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Error adding customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while adding customer: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void EditCustomer()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid CIN");
                return;
            }

            int cin = Convert.ToInt32(textBox1.Text);
            string name = textBox2.Text;
            string family = textBox3.Text;
            string city = textBox4.Text;
            string tel = textBox5.Text;

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE customer SET Name=@name, Family=@family, City=@city, Tel=@tel WHERE CIN=@cin", connection);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@family", family);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@cin", cin);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Customer updated successfully");
                }
                else
                {
                    MessageBox.Show("Error while updating customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while updating customer: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void DeleteCustomer()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a valid CIN");
                return;
            }

            int cin = Convert.ToInt32(textBox1.Text);

            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE CIN=@cin", connection);
                cmd.Parameters.AddWithValue("@cin", cin);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Customer deleted successfully");
                }
                else
                {
                    MessageBox.Show("Error while deleting customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting customer: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        


    }
}