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
            conn.ConnectionString = @"Data Source=DESKTOP-26HSG19;Initial Catalog=GradeManagement;Integrated Security=True";
            conn.Open();
        }

        public void unLink() //Close the connection
        {
            conn.Close();
        }

        public DataTable SelectData(string strsql)
        {
            cmd.CommandText = strsql;
            dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
