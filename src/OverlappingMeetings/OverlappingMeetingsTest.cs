using Xunit;

namespace OverlappingMeetings
{
    public class OverlappingMeetingsTest
    {
        [Fact]
        public void NoOverlappingMeetingsTest()
        {
            Meeting[] meetings =
            {
                new Meeting("a", 1, 3),
                new Meeting("b", 3, 4),
                new Meeting("c", 5, 6)
            };

            var solution = new OverlappingMeetingsSolution();
            string[] result = solution.GetOverlappingMeetings(meetings);

            Assert.True(result.Length == 0);
        }

        [Fact]
        public void TwoOverlappingMeetingsTest()
        {
            Meeting[] meetings =
            {
                new Meeting("a", 1, 3),
                new Meeting("b", 2, 4),
                new Meeting("c", 5, 6)
            };

            var solution = new OverlappingMeetingsSolution();
            string[] result = solution.GetOverlappingMeetings(meetings);

            Assert.Equal(new string[] { "a", "b" }, result);
        }

        [Fact]
        public void ConsecutiveOverlappingMeetingsTest()
        {
            Meeting[] meetings =
            {
                new Meeting("a", 1, 3),
                new Meeting("b", 2, 4),
                new Meeting("c", 3, 6),
                new Meeting("d", 4, 6)
            };

            var solution = new OverlappingMeetingsSolution();
            string[] result = solution.GetOverlappingMeetings(meetings);

            Assert.Equal(new string[] { "a", "b", "c", "d" }, result);
        }

        [Fact]
        public void InclusiveOverlappingMeetingsTest()
        {
            Meeting[] meetings =
            {
                new Meeting("a", 1, 3),
                new Meeting("b", 3, 7),
                new Meeting("c", 4, 5),
                new Meeting("d", 8, 9)
            };

            var solution = new OverlappingMeetingsSolution();
            string[] result = solution.GetOverlappingMeetings(meetings);

            Assert.Equal(new string[] { "b", "c" }, result);
        }

        [Fact]
        public void InclusiveAndConsecutiveOverlappingMeetingsTest()
        {
            Meeting[] meetings =
            {
                new Meeting("a", 1, 3),
                new Meeting("b", 3, 7),
                new Meeting("c", 4, 5),
                new Meeting("d", 6, 9)
            };

            var solution = new OverlappingMeetingsSolution();
            string[] result = solution.GetOverlappingMeetings(meetings);

            Assert.Equal(new string[] { "b", "c", "d" }, result);
        }

        [Fact]
        public void NoConsecutiveButOverlappingMeetingsTest()
        {
            Meeting[] meetings =
            {
                new Meeting("a", 1, 3),
                new Meeting("b", 4, 5),
                new Meeting("c", 4, 6),
                new Meeting("d", 7, 9),
                new Meeting("e", 9, 12),
                new Meeting("f", 10, 11)
            };

            var solution = new OverlappingMeetingsSolution();
            string[] result = solution.GetOverlappingMeetings(meetings);

            Assert.Equal(new string[] { "b", "c", "e", "f" }, result);
        }
    }
}
