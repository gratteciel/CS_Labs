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
    public class BusinessGrades : Data_Access
    {


        public void openConn()
        {
            base.Link();
        }
        public void closeConn()
        {
            base.unLink();
        }

        public DataTable PopulateID()
        {
            openConn();
            string Query = "Select StudentID FROM Student";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
        }
        public DataTable PopulateCourses()
        {
            openConn();
            string Query = "Select CourseName FROM Course";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
        }
        public int getIDCourse(string CourseName)
        {
            closeConn();
            openConn();
            string Query = "Select CourseID from COURSE Where CourseName=@CourseName";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            cmd.Parameters.AddWithValue("@CourseName", CourseName);
            DataTable output = base.SelectData(cmd);
            // Extract the integer value of the last student ID
            int IDCourse = Convert.ToInt32(output.Rows[0]["CourseID"]);
            closeConn();
            return IDCourse;
            
        }
        public bool ModifyGrade(int StudentId, string course, int Grade)
        {
            openConn();
            int CourseID = getIDCourse(course); //get the id of the course

            string Query = "UPDATE Grade SET Grade = @Grade where StudentID = @StudentId AND CourseID= @CourseID";
            SqlCommand cmd = new SqlCommand(Query, base.getConn());
            cmd.Parameters.AddWithValue("@Grade", Grade);
            cmd.Parameters.AddWithValue("@StudentId", StudentId);
            cmd.Parameters.AddWithValue("@CourseID", CourseID);
            closeConn();
            openConn();
            base.InsertData(cmd);
            closeConn();
            return true;

        }
        public DataTable GetGrades(int StudentID)
        {
            openConn();
            string query = "SELECT Course.CourseName, Grade.Grade FROM Grade INNER JOIN Course ON Grade.CourseID = Course.CourseID WHERE Grade.StudentID = @StudentID";
            SqlCommand cmd = new SqlCommand(query, base.getConn());
            cmd.Parameters.AddWithValue("@StudentID", StudentID);
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
        }

        public bool AddGrade(int StudentId, string course, int Grade)
        {
            openConn();
            int CourseID = getIDCourse(course); //get the id of the course

            // Check if the grade already exists for the given student and course
            string query = "SELECT COUNT(*) FROM Grade WHERE StudentID = @StudentID AND CourseID = @CourseID";
            SqlCommand cmd = new SqlCommand(query, base.getConn());
            cmd.Parameters.AddWithValue("@StudentID", StudentId);
            cmd.Parameters.AddWithValue("@CourseID", CourseID);
            int count = (int)cmd.ExecuteScalar();

            if (count > 0) // If the grade already exists, return false
            {
                closeConn();
                return false;
            }

            // If the grade does not exist, insert it into the database
            query = "INSERT INTO Grade VALUES (@StudentID, @CourseID, @Grade)";
            cmd = new SqlCommand(query, base.getConn());
            cmd.Parameters.AddWithValue("@StudentID", StudentId);
            cmd.Parameters.AddWithValue("@CourseID", CourseID);
            cmd.Parameters.AddWithValue("@Grade", Grade);
            base.InsertData(cmd);

            closeConn();
            return true;
        }

    }
}
