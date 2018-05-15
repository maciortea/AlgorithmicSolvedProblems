using Xunit;

namespace PairsWithSpecificDifference
{
    public class PairsWithSpecificDifferenceUnitTest
    {
        [Fact]
        public void PairsWithSpecificDifferenceSolutionTest1()
        {
            var arr = new int[] { 0, -1, -2, 2, 1 };
            int k = 1;

            var solution = new PairsWithSpecificDifferenceSolution();
            var output = solution.FindPairsWithGivenDifference(arr, k);

            Assert.Equal(new int[,] { { -1, -2 }, { 0, -1 }, { 1, 0 }, { 2, 1 } }, output);
        }

        [Fact]
        public void PairsWithSpecificDifferenceSolutionTest2()
        {
            var arr = new int[] { 1, 7, 5, 3, 32, 17, 12 };
            int k = 17;

            var solution = new PairsWithSpecificDifferenceSolution();
            var output = solution.FindPairsWithGivenDifference(arr, k);

            Assert.Equal(new int[,] { }, output);
        }
    }
}
