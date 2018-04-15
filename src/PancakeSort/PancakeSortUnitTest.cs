using Xunit;

namespace PancakeSort
{
    public class PancakeSortUnitTest
    {
        [Fact]
        public void PancakeSort_OddNoOfElementsArray()
        {
            var arr = new int[] { 1, 5, 4, 3, 2 };

            var solution = new PancakeSortSolution();
            solution.PancakeSort(arr);

            Assert.Equal(new int[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Fact]
        public void PancakeSort_EvenNoOfElementsArray()
        {
            var arr = new int[] { 6, 2, 1, 3 };

            var solution = new PancakeSortSolution();
            solution.PancakeSort(arr);

            Assert.Equal(new int[] { 1, 2, 3, 6 }, arr);
        }
    }
}
