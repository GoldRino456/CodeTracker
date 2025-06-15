using Dapper;
using System.Configuration;
using System.Data.SQLite;

namespace CodeTracker
{
    internal class DatabaseManager
    {
        private readonly string _connectionString;

        //Reusable SQL Commands
        private readonly string _databaseInitialization = "CREATE TABLE IF NOT EXISTS CodingSessions (id INTEGER PRIMARY KEY AUTOINCREMENT, startTime TEXT, endTime TEXT, duration TEXT)";

        public DatabaseManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SQLiteDB"].ConnectionString;
            InitializeDB();
        }

        private void InitializeDB()
        {
            ExecuteNonQueryCommand(_databaseInitialization);
        }

        public void ExecuteNonQueryCommand(string query)
        {
            int result;

            using (var connection = new SQLiteConnection(_connectionString))
            {
                connection.Open();
                result = connection.Execute(query);
                connection.Close();
            }
        }
    }
}
