using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{


    public class Data_Access
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        public Data_Access()
        {
            //Creating variables for connection
            conn = new SqlConnection();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
        }

        

        public void Link() // link to the db/ Need to change the source 
        {
            if (conn.State == ConnectionState.Open) // check if connection is open
            {
                conn.Close(); // close connection if open
            }
            conn.ConnectionString = @"Data Source=LAPTOP-EM\SQLEXPRESS;Initial Catalog=GradeManagement;Integrated Security=True";
            conn.Open();
        }
        public SqlConnection getConn()
        {
            return conn;
        }
      

        public void unLink() //Close the connection
        {
            conn.Close();
        }

        public DataTable SelectData(SqlCommand cmd)
        {
            dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            return dt;
        }
        public void InsertData(SqlCommand cmd)
        {
            cmd.ExecuteNonQuery();

        }
    }
}
