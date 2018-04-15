using Xunit;

namespace PeakElementInArray
{
    public class PeakElementInArrayUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            int[] arr = { 1, 3, 4, 2 };

            var solution = new PeakElementInArraySolution();
            int peakElement = solution.FindPeakElement(arr);

            Assert.Equal(4, peakElement);
        }

        [Fact]
        public void TestMethod2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var solution = new PeakElementInArraySolution();
            int peakElement = solution.FindPeakElement(arr);

            Assert.Equal(5, peakElement);
        }

        [Fact]
        public void NullArrayTestMethod()
        {
            int[] arr = null;

            var solution = new PeakElementInArraySolution();
            int peakElement = solution.FindPeakElement(arr);

            Assert.Equal(0, peakElement);
        }

        [Fact]
        public void OneElementTestMethod()
        {
            int[] arr = { 2 };

            var solution = new PeakElementInArraySolution();
            int peakElement = solution.FindPeakElement(arr);

            Assert.Equal(2, peakElement);
        }
    }
}
