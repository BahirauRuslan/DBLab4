using System.Collections.Generic;
using System.Data.SqlClient;

namespace DBLab4
{
    class DBGroups
    {
        private static string CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;
Initial Catalog=EducationalDepartment;Integrated Security=True";

        private static DBGroups dBGroups;

        private DBGroups() { }

        public static DBGroups GetInstance()
        {
            if (dBGroups == null)
            {
                dBGroups = new DBGroups();
            }

            return dBGroups;
        }

        public IEnumerable<Group> GetAllGroups()
        {
            IList<Group> records = new List<Group>();
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            SqlCommand command = new SqlCommand("SELECT Id, Number FROM Groups", connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Group record = new Group();
                record.Id = (int)reader.GetValue(0);
                record.Number = (int)reader.GetValue(1);
                records.Add(record);
            }
            connection.Close();
            return records;
        }
    }
}
