using System;

namespace TimePlanner
{
    // Implement a function MeetingPlanner() that given the availability, slotsA and slotsB,
    // of two people and a meeting duration dur, returns the earliest time slot that works for
    // both of them and is of duration dur.If there is no common time slot that satisfies the duration requirement,
    // return null.
    // Time is given in a Unix format called Epoch, which is a nonnegative integer holding the number of
    // seconds that have elapsed since 00:00:00 UTC, Thursday, 1 January 1970.
    // Each person's availability is represented by an array of pairs.Each pair is an epoch array of size two.
    // The first epoch in a pair represents the start time of a slot.The second epoch is the end time of that slot.
    // The input variable dur is a positive integer that represents the duration of a meeting in seconds.
    // The output is also a pair represented by an epoch array of size two.
    // In your implementation assume that the time slots in a person's availability are disjointed, i.e,
    // time slots in a person's availability don't overlap. Further assume that the slots are sorted by slots start time.
    // Implement an efficient solution and analyze its time and space complexities.
    // Examples:
    // Input:
    // - slotsA = [[10, 50], [60, 120], [140, 210]]
    // - slotsB = [[0, 15], [60, 70]]
    // - dur = 8
    // Output: [60, 68]
    public class TimePlannerSolution
    {
        public int[] MeetingPlanner(int[,] slotsA, int[,] slotsB, int dur)
        {
            int i = 0;
            int j = 0;
            while (i < slotsA.GetLength(0) && j < slotsB.GetLength(0))
            {
                int start = Math.Max(slotsA[i, 0], slotsB[j, 0]);
                int end = Math.Min(slotsA[i, 1], slotsB[j, 1]);
                if (dur <= (end - start))
                {
                    return new int[] { start, start + dur };
                }
                if (slotsA[i, 1] > slotsB[j, 1])
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }
            return null;
        }
    }
}
