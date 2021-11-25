using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace App.Repository
{
    class MySQLite
    {
        private SQLiteConnection connection = null;
        public void Connect()
        {
            if (connection != null)
                return;

            string databaseFile = Directory.GetCurrentDirectory() + "\\Resources\\local.db";
            string connectionString = $"Data Source={databaseFile}"; // "Data Source=:memory:";

            connection = new SQLiteConnection(connectionString);
            connection.Open();
        }

        public string ExecuteScalar(string query = "SELECT SQLITE_VERSION()")
        {
            using (var cmd = new SQLiteCommand(query, connection))
            {
                string output = cmd.ExecuteScalar().ToString();
                return output;
            }
        }

        public void ExecuteNonQuery(string query, List<SQLiteParameter> paramters = null)
        {
            using (var cmd = new SQLiteCommand(query, connection))
            {
                if (paramters != null)
                    foreach (var parameter in paramters)
                        cmd.Parameters.Add(parameter);
                cmd.ExecuteNonQuery();
            }
        }

        public SQLiteDataReader ExecuteReader(string query = "SELECT count(*) FROM People", List<SQLiteParameter> paramters = null)
        {
            using (var cmd = new SQLiteCommand(query, connection))
            {
                if (paramters != null)
                    foreach (var parameter in paramters)
                        cmd.Parameters.Add(parameter);
                var reader = cmd.ExecuteReader();
                return reader;
            }
        }
    }
}
