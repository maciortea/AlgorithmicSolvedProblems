using Xunit;

namespace MissingInteger
{
    public class MissingIntegerUnitTest
    {
        [Fact]
        public void GetMissingIntegerTest1()
        {
            int[] arr = { 0, 1, 2, 3 };

            var solution = new MissingIntegerSolution();
            int missingInteger = solution.GetMissingInteger(arr);

            Assert.Equal(4, missingInteger);
        }

        [Fact]
        public void GetMissingIntegerTest2()
        {
            int[] arr = { 1, 2, 3 };

            var solution = new MissingIntegerSolution();
            int missingInteger = solution.GetMissingInteger(arr);

            Assert.Equal(0, missingInteger);
        }

        [Fact]
        public void GetMissingIntegerTest3()
        {
            int[] arr = { 3, 4, 1, 0 };

            var solution = new MissingIntegerSolution();
            int missingInteger = solution.GetMissingInteger(arr);

            Assert.Equal(2, missingInteger);
        }
    }
}
