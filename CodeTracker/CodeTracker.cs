namespace CodeTracker
{
    public static class CodeTracker
    {
        private static DatabaseManager _databaseManager;

        static void Main()
        {
            InitializeCodeTrackerComponents();
        }

        private static void InitializeCodeTrackerComponents()
        {
            _databaseManager = new();
        }
    }
}