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
    public class BusinessCons : Data_Access
    {
        public void openConn()
        {
            base.Link();
        }
        public void closeConn()
        {
            base.unLink();
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
        public DataTable GetCourseData(string courseName)
        {
            openConn();
            string query = "SELECT Student.StudentID, Student.Name, Student.Family, Grade.Grade " +
                           "FROM Grade " +
                           "INNER JOIN Student ON Grade.StudentID = Student.StudentID " +
                           "INNER JOIN Course ON Grade.CourseID = Course.CourseID " +
                           "WHERE Course.CourseName = @CourseName";
            SqlCommand cmd = new SqlCommand(query, base.getConn());
            cmd.Parameters.AddWithValue("@CourseName", courseName);
            DataTable output = base.SelectData(cmd);
            closeConn();
            return output;
        }
        public double GetClassAverage(string courseName)
        {
            openConn();
            string query = "SELECT AVG(Grade) AS CourseAverage " +
                           "FROM Grade " +
                           "INNER JOIN Course ON Grade.CourseID = Course.CourseID " +
                           "WHERE Course.CourseName = @CourseName";
            SqlCommand cmd = new SqlCommand(query, base.getConn());
            cmd.Parameters.AddWithValue("@CourseName", courseName);
            object result = cmd.ExecuteScalar();
            closeConn();
            if (result != DBNull.Value) //check if not null
            {
                double average = Convert.ToDouble(result);
                return average;
            }
            else
            {
                return 0.0;
            }
            
            
        }

    }
}

