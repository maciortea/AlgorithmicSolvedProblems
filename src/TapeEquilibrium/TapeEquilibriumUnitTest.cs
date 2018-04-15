using Xunit;

namespace TapeEquilibrium
{
    public class TapeEquilibriumUnitTest
    {
        [Fact]
        public void SimpleArrayTest()
        {
            int[] arr = { 3, 1, 2, 4, 3 };

            var solution = new TapeEquilibriumSolution();
            int minSum = solution.GetMinSum(arr);

            Assert.Equal(1, minSum);
        }

        [Fact]
        public void TwoElementsTest()
        {
            int[] arr = { 4, 5 };
            var solution = new TapeEquilibriumSolution();
            int minSum = solution.GetMinSum(arr);

            Assert.Equal(1, minSum);
        }

        [Fact]
        public void NegativeElementsTest()
        {
            int[] arr = { 0, 3, -3, -4, 1 };

            var solution = new TapeEquilibriumSolution();
            int minSum = solution.GetMinSum(arr);

            Assert.Equal(3, minSum);
        }
    }
}
