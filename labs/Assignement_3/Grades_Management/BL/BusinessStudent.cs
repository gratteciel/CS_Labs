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
            closeConn();
            return output;
            
        }
        public DataTable FirstID(int id)
        {
            openConn();
            string Query = "Select TOP 1 * from Student ORDER BY StudentID ASC";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            cmd.Parameters.AddWithValue("@id", id);
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
            
        }
        public DataTable PreviousID(int id)
        {
            openConn();
            string Query = "SELECT TOP 1 * FROM Student WHERE StudentID < @id ORDER BY StudentID DESC";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            cmd.Parameters.AddWithValue("@id", id);
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
            
        }
        public DataTable NextID(int id)
        {
            openConn();
            string Query = "SELECT TOP 1 * FROM Student WHERE StudentID > @id ORDER BY StudentID ASC";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            cmd.Parameters.AddWithValue("@id", id);
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
            
        }
        public DataTable LastID(int id)
        {
            openConn();
            string Query = "Select TOP 1 * from Student ORDER BY StudentID DESC";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            cmd.Parameters.AddWithValue("@id", id);
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
            
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
        public bool ModifyStudent(int id, string name, string family, DateTime birthDate)
        {
            openConn();// Check if the student with the given ID exists
            string checkQuery = "SELECT COUNT(*) FROM Student WHERE StudentID = @id";
            SqlCommand checkCmd = new SqlCommand(checkQuery, base.getConn());
            checkCmd.Parameters.AddWithValue("@id", id);
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                // The student with the given ID doesn't exist
                closeConn();
                return false;
            }

            string modifyQuery = "UPDATE Student SET name = @name, family = @family, birthDate = @birthDate WHERE StudentID = @id";
            SqlCommand modifyCmd = new SqlCommand(modifyQuery, base.getConn());
            modifyCmd.Parameters.AddWithValue("@id", id);
            modifyCmd.Parameters.AddWithValue("@name", name);
            modifyCmd.Parameters.AddWithValue("@family", family);
            modifyCmd.Parameters.AddWithValue("@birthDate", birthDate);
            base.InsertData(modifyCmd);
            closeConn();
            return true;
            

        }
        public bool DeleteStudent(int id)
        {
            openConn();
            string checkQuery = "SELECT COUNT(*) FROM Student WHERE StudentID = @id";
            SqlCommand checkCmd = new SqlCommand(checkQuery, base.getConn());
            checkCmd.Parameters.AddWithValue("@id", id);
            int count = (int)checkCmd.ExecuteScalar();

            if (count == 0)
            {
                // The student with the given ID doesn't exist
                closeConn();
                return false;
            }
            string deleteQuery = "Delete Student where StudentID = @id";
            SqlCommand deleteCmd = new SqlCommand(deleteQuery, base.getConn());
            deleteCmd.Parameters.AddWithValue("@id", id);
            base.InsertData(deleteCmd);
            closeConn();
            return true;


        }
       
        public bool AddStudent(int id, string name, string family, DateTime birthDate)
        {
            openConn();
            int i = 0; // know if the id already exists 
          
            // Insert the new student record into the database
            string Query = "Insert INTO Student Values(@id,@name,@family,@birthDate)";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            if (id <= getLastId())
            {
                cmd.Parameters.AddWithValue("@id", getLastId() + 1);
                i = 1;
            }
            else
            {
                cmd.Parameters.AddWithValue("@id", id);

            }
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@family", family);
            cmd.Parameters.AddWithValue("@birthDate", birthDate);
            
            base.InsertData(cmd); // need to handle PK violation
            if (i == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            closeConn();

        }
    }
}
