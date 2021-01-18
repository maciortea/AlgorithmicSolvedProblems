using Xunit;

namespace MaxSumInArray
{
    public class MaxSumInArrayUnitTest
    {
        [Fact]
        public void SampleArray1Test()
        {
            var solution = new MaxSumInArraySolution();
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 2;

            int actual = solution.GetMaxSum(arr, k);
            int expected = 9;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SampleArray2Test()
        {
            var solution = new MaxSumInArraySolution();
            int[] arr = { 1, 4, 2, 10, 23, 3, 1, 0, 20 };
            int k = 4;

            int actual = solution.GetMaxSum(arr, k);
            int expected = 39;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SampleArray3Test()
        {
            var solution = new MaxSumInArraySolution();
            int[] arr = { 4, 5, 6 };
            int k = 3;

            int actual = solution.GetMaxSum(arr, k);
            int expected = 15;

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SampleArray4Test()
        {
            var solution = new MaxSumInArraySolution();
            int[] arr = { 4, 5, 6 };
            int k = 4;

            int actual = solution.GetMaxSum(arr, k);
            int expected = 0;

            Assert.Equal(expected, actual);
        }
    }
}
