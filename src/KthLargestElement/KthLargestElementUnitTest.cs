using Xunit;

namespace KthLargestElement
{
    public class KthLargestElementUnitTest
    {
        [Fact]
        public void FindKthLargestElement_Test()
        {
            var solution = new KthLargestElementSolution();
            int[] arr = { 4, 5, 1, 3, 2 };
            int k = 3;
            int actual = solution.FindKthLargestElement(arr, k);
            int expected = 3;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindKthLargestElement_LongArrayTest()
        {
            var solution = new KthLargestElementSolution();
            int[] arr = { 50, 34, 12, 100, 5, 1, 55, 99, 87, 90, 95, 44, 50, 6, 7 };
            int k = 9;
            int actual = solution.FindKthLargestElement(arr, k);
            int expected = 44;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindKthLargestElement_EvenLengthArrayTest()
        {
            var solution = new KthLargestElementSolution();
            int[] arr = { 5, 2, 1, 4, 3, 6 };
            int k = 2;
            int actual = solution.FindKthLargestElement(arr, k);
            int expected = 5;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindKthLargestElement_OddLengthArrayTest()
        {
            var solution = new KthLargestElementSolution();
            int[] arr = { 5, 7, 2, 1, 4, 3, 6 };
            int k = 2;
            int actual = solution.FindKthLargestElement(arr, k);
            int expected = 6;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindKthLargestElement_SortedArrayTest()
        {
            var solution = new KthLargestElementSolution();
            int[] arr = { 6, 7, 8, 9 };
            int k = 3;
            int actual = solution.FindKthLargestElement(arr, k);
            int expected = 7;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindKthLargestElement_OneItemArrayTest()
        {
            var solution = new KthLargestElementSolution();
            int[] arr = { 5 };
            int k = 1;
            int actual = solution.FindKthLargestElement(arr, k);
            int expected = 5;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindKthLargestElement_TwoItemArrayTest()
        {
            var solution = new KthLargestElementSolution();
            int[] arr = { 5, 4 };
            int k = 2;
            int actual = solution.FindKthLargestElement(arr, k);
            int expected = 4;
            Assert.Equal(expected, actual);
        }
    }
}
