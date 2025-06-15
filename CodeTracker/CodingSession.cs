namespace CodeTracker
{
    internal class CodingSession
    {
        public DateTime StartTime { get; private set; }
        public DateTime EndTime { get; private set; }
        public TimeSpan Duration { get; private set; }

        public CodingSession(DateTime startTime, DateTime endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
            Duration = CalculateDuration(StartTime, EndTime);
        }

        /// <summary>
        /// Method <c>UpdateCodingSession</c> changes the start or end time of a coding session.
        /// </summary>
        /// <param name="newTime">Time object that will replace either start or end time.</param>
        /// <param name="isStartTime">Flag used to determine which time property to replace.</param>
        public void UpdateCodingSession(DateTime newTime, bool isStartTime)
        {
            if(isStartTime)
            {
                StartTime = newTime;
            }
            else
            {
                EndTime = newTime;
            }

            Duration = CalculateDuration(StartTime, EndTime);
        }

        /// <summary>
        /// Method <c>UpdateCodingSession</c> changes both the start and end time of a coding session.
        /// </summary>
        /// <param name="newStartTime"></param>
        /// <param name="newEndTime"></param>
        public void UpdateCodingSession(DateTime newStartTime,  DateTime newEndTime)
        {
            StartTime = newStartTime;
            EndTime = newEndTime;
            Duration = CalculateDuration(StartTime, EndTime);
        }

        private TimeSpan CalculateDuration(DateTime startTime,  DateTime endTime)
        {
            return endTime - startTime;
        }
    }
}
