namespace CodeTracker
{
    public static class CodeTracker
    {
        private static DatabaseManager? _databaseManager;

        static void Main()
        {
            InitializeCodeTrackerComponents();

            var session1 = new CodingSession(DateTime.Now, DateTime.Now.AddDays(3));

            _databaseManager.CreateNewCodingSession(session1);
            _databaseManager.CreateNewCodingSession(session1);

            var sessions = _databaseManager.GetAllCodingSessions();
            DisplayFullListOfCodingSessions(sessions);
            Console.WriteLine("-----");


            var session2 = new CodingSession(DateTime.Now.AddDays(7), DateTime.Now.AddDays(14));
            _databaseManager.UpdateExistingCodingSession(1, session2);

            sessions = _databaseManager.GetAllCodingSessions();
            DisplayFullListOfCodingSessions(sessions);
            Console.WriteLine("-----");

            _databaseManager.DeleteExistingCodingSession(1);

            sessions = _databaseManager.GetAllCodingSessions();
            DisplayFullListOfCodingSessions(sessions);
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