using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DBLab4
{
    class DBStudents
    {
        private static string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;
Initial Catalog=EducationalDepartment;Integrated Security=True";

        private static DBStudents dBStudents;

        private DBStudents() { }

        public static DBStudents GetInstance()
        {
            if (dBStudents == null)
            {
                dBStudents = new DBStudents();
            }

            return dBStudents;
        }

        public IEnumerable<StudentGroupRecord> GetAllStudents()
        {
            IList<StudentGroupRecord> records = new List<StudentGroupRecord>();
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT * FROM GroupList", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                StudentGroupRecord record = new StudentGroupRecord();
                record.FullName = reader.GetValue(1).ToString();
                record.Group = reader.GetValue(0).ToString();
                records.Add(record);
            }
            connection.Close();
            return records;
        }

        public int GetCount()
        {
            int count = 0;
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Students", connection);
            connection.Open();
            count = (int)command.ExecuteScalar();
            connection.Close();
            return count;
        }
    }
}
