using System;
using System.Collections.Generic;

namespace OverlappingMeetings
{
    public class OverlappingMeetingsSolution
    {
        public string[] GetOverlappingMeetings(Meeting[] meetings)
        {
            var overlappingMeetings = new List<string>();
            var tempOverlappingMeetings = new List<string> { meetings[0].Name };

            int prevEndTime = meetings[0].EndTime;
            for (int i = 1; i < meetings.Length; i++)
            {
                Meeting currentMeeting = meetings[i];
                if (currentMeeting.StartTime >= prevEndTime)
                {
                    if (tempOverlappingMeetings.Count > 1)
                    {
                        overlappingMeetings.AddRange(tempOverlappingMeetings);
                    }
                    
                    tempOverlappingMeetings.Clear();
                }

                prevEndTime = Math.Max(prevEndTime, currentMeeting.EndTime);
                tempOverlappingMeetings.Add(currentMeeting.Name);
            }

            if (tempOverlappingMeetings.Count > 1)
            {
                overlappingMeetings.AddRange(tempOverlappingMeetings);
            }

            return overlappingMeetings.ToArray();
        }
    }
}
