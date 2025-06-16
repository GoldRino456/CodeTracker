namespace CodeTracker
{
    public static class CodeTracker
    {
        private static DatabaseManager? _databaseManager;

        static void Main()
        {
            var session1 = new CodingSession(DateTime.Now, DateTime.Now.AddDays(5));
            var session2 = new CodingSession(DateTime.Now.AddDays(7), DateTime.Now.AddDays(10));
            var session3 = new CodingSession(DateTime.Now.AddDays(15), DateTime.Now.AddDays(19));
            var session4 = new CodingSession(DateTime.Now.AddDays(23), DateTime.Now.AddDays(24));
            var session5 = new CodingSession(DateTime.Now.AddDays(25), DateTime.Now.AddDays(35));

            InitializeCodeTrackerComponents();
            _databaseManager.CreateNewCodingSession(session1);
            _databaseManager.CreateNewCodingSession(session2);
            _databaseManager.CreateNewCodingSession(session3);
            _databaseManager.CreateNewCodingSession(session4);
            _databaseManager.CreateNewCodingSession(session5);

            DisplayEngine.DisplayCodingSessions(_databaseManager.GetAllCodingSessions());
        }

        private static void InitializeCodeTrackerComponents()
        {
            _databaseManager = new();
        }

        private static void DisplayFullListOfCodingSessions(List<CodingSession> codingSessions)
        {
            foreach (var session in codingSessions)
            {
                Console.WriteLine(session + "\n");
            }
        }
    }
}