using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace Business_Layer
{
    public class BusinessStudent: Data_Access
    {
       public DataTable SelectFromId(int id)
        {
            openConn();
            string Query = "Select * from Student where StudentID = @id";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            cmd.Parameters.AddWithValue("@id", id);
            DataTable output = base.SelectData(cmd);
            return output;
            closeConn();
        }
        public void openConn()
        {
            base.Link();
        }
        public void closeConn()
        {
            base.unLink();
        }
        public int getLastId()
        {
            
            closeConn();
            openConn();
            string Query = "Select TOP 1 StudentID from Student ORDER BY StudentID DESC";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            DataTable output = base.SelectData(cmd);
            // Extract the integer value of the last student ID
            int lastId = Convert.ToInt32(output.Rows[0]["StudentID"]);
            return lastId;
            closeConn();
        }
        public bool AddStudent(int id, string name, string family, DateTime birthDate)
        {
            openConn();
            try
            {
                // Insert the new student record into the database
                string Query = "Insert INTO Student Values(@id,@name,@family,@birthDate)";
                SqlCommand cmd = new SqlCommand(Query, base.getConn());
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@family", family);
                cmd.Parameters.AddWithValue("@birthDate", birthDate);
                base.InsertData(cmd); // need to handle PK violation

                return true; // Insertion was successful
            }
            catch (SqlException ex)
            {
                
                    string Query = "Insert INTO Student Values(@id,@name,@family,@birthDate)";
                    SqlCommand cmd = new SqlCommand(Query, base.getConn());
                    cmd.Parameters.AddWithValue("@id", getLastId());
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@family", family);
                    cmd.Parameters.AddWithValue("@birthDate", birthDate);
                    base.InsertData(cmd);

                    return false; // Insertion failed due to duplicate ID
               
            }
                closeConn();

        }
    }
}
