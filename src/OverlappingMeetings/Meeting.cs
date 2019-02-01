namespace OverlappingMeetings
{
    public class Meeting
    {
        public string Name { get; }
        public int StartTime { get; }
        public int EndTime { get; }

        public Meeting(string name, int startTime, int endTime)
        {
            Name = name;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
