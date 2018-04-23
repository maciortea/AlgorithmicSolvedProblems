using Xunit;

namespace TimePlanner
{
    public class TimePlannerUnitTest
    {
        [Fact]
        public void TimePlannerSolutionTest1()
        {
            int[,] slotsA = new int[,] { { 10, 50 }, { 60, 120 }, { 140, 210 } };
            int[,] slotsB = new int[,] { { 0, 15 }, { 60, 70 } };
            int dur = 8;

            var solution = new TimePlannerSolution();
            int[] result = solution.MeetingPlanner(slotsA, slotsB, dur);

            Assert.Equal(new int[] { 60, 68 }, result);
        }

        [Fact]
        public void TimePlannerSolutionTest2()
        {
            int[,] slotsA = new int[,] { { 10, 50 }, { 60, 120 }, { 140, 210 } };
            int[,] slotsB = new int[,] { { 0, 15 }, { 60, 70 } };
            int dur = 12;

            var solution = new TimePlannerSolution();
            int[] result = solution.MeetingPlanner(slotsA, slotsB, dur);

            Assert.Null(result);
        }
    }
}
