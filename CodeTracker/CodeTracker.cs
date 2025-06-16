namespace CodeTracker
{
    public static class CodeTracker
    {
        private static DatabaseManager? _databaseManager;

        static void Main()
        {
            InitializeCodeTrackerComponents();

            var session1 = new CodingSession(DateTime.Now, DateTime.Now.AddDays(3));
            var session2 = new CodingSession(DateTime.Now.AddDays(7), DateTime.Now.AddDays(14));

            _databaseManager.CreateNewCodingSession(session1);
            _databaseManager.CreateNewCodingSession(session2);

            var sessions = _databaseManager.GetAllCodingSessions();

            foreach(var session in sessions)
            {
                Console.WriteLine(session);
            }
        }

        private static void InitializeCodeTrackerComponents()
        {
            _databaseManager = new();
        }
    }
}