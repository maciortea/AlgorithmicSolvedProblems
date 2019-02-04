using Xunit;

namespace LargestRectangleInHistogram
{
    public class LargestRectangleInHistogramTest
    {
        [Fact]
        public void AscendingHistogramTest()
        {
            int[] heights = { 1, 2, 4, 5 };

            var solution = new LargestRectangleInHistogramSolution();
            int result = solution.GetLargestRectangleArea(heights);

            Assert.Equal(8, result);
        }

        [Fact]
        public void DescendingHistogramTest()
        {
            int[] heights = { 4, 2, 1 };

            var solution = new LargestRectangleInHistogramSolution();
            int result = solution.GetLargestRectangleArea(heights);

            Assert.Equal(4, result);
        }

        [Fact]
        public void MixedHistogramTest1()
        {
            int[] heights = { 2, 1, 5, 6, 2, 3 };

            var solution = new LargestRectangleInHistogramSolution();
            int result = solution.GetLargestRectangleArea(heights);

            Assert.Equal(10, result);
        }

        [Fact]
        public void MixedHistogramTest2()
        {
            int[] heights = { 2, 1, 2 };

            var solution = new LargestRectangleInHistogramSolution();
            int result = solution.GetLargestRectangleArea(heights);

            Assert.Equal(3, result);
        }

        [Fact]
        public void OneElementHistogramTest()
        {
            int[] heights = { 2 };

            var solution = new LargestRectangleInHistogramSolution();
            int result = solution.GetLargestRectangleArea(heights);

            Assert.Equal(2, result);
        }

        [Fact]
        public void EmptyHistogramTest()
        {
            int[] heights = new int[0];

            var solution = new LargestRectangleInHistogramSolution();
            int result = solution.GetLargestRectangleArea(heights);

            Assert.Equal(0, result);
        }

        [Fact]
        public void NullHistogramTest()
        {
            var solution = new LargestRectangleInHistogramSolution();
            int result = solution.GetLargestRectangleArea(null);

            Assert.Equal(0, result);
        }
    }
}
