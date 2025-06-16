using Dapper;
using System.Configuration;

namespace CodeTracker
{
    internal class DatabaseManager
    {
        private readonly string _connectionString;

        //Reusable SQL Commands
        private readonly string _databaseInitialization = "CREATE TABLE IF NOT EXISTS CodingSessions (id INTEGER PRIMARY KEY AUTOINCREMENT, startTime TEXT, endTime TEXT, duration TEXT)";
        private readonly string _readAllEntries = "SELECT * FROM CodingSessions";
        private readonly string _createEntry = "INSERT INTO CodingSessions (startTime, endTime, duration) VALUES (@StartTime, @EndTime, @Duration)";
        private readonly string _updateEntry = "UPDATE CodingSessions SET startTime = @StartTime, endTime = @EndTime, duration = @Duration WHERE id = @Id";
        private readonly string _deleteEntry = "DELETE FROM CodingSessions WHERE id = @Id";


        public DatabaseManager()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["SQLiteDB"].ConnectionString;
            InitializeDB();
        }

        private void InitializeDB()
        {
            DatabaseUtilities.ExecuteNonQueryCommand(_connectionString, _databaseInitialization);
        }

        public List<CodingSession> GetAllCodingSessions()
        {
            return DatabaseUtilities.ExecuteQueryCommand<CodingSession>(_connectionString, _readAllEntries);
        }

        public void CreateNewCodingSession(CodingSession newCodingSession)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@StartTime", newCodingSession.StartTime);
            parameters.Add("@EndTime", newCodingSession.EndTime);
            parameters.Add("@Duration", newCodingSession.Duration);

            DatabaseUtilities.ExecuteNonQueryCommand(_connectionString, _createEntry, parameters);
        }

        
    }
}
