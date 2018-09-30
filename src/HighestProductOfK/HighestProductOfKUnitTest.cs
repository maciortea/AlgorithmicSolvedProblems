using Xunit;

namespace HighestProductOfK
{
    public class HighestProductOfKUnitTest
    {
        [Fact]
        public void HighestProductOf3_ShortArrayTest()
        {
            var solution = new HighestProductOfKSolution();
            int[] arr = { 1, 2, 3, 4 };
            int k = 3;
            var actual = solution.GetHighestProductOfK(arr, k);
            var expected = 24;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HighestProductOf3_LongerArrayTest()
        {
            var solution = new HighestProductOfKSolution();
            int[] arr = { 6, 1, 3, 5, 7, 8, 2 };
            int k = 3;
            var actual = solution.GetHighestProductOfK(arr, k);
            var expected = 336;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HighestProductOf3_ArrayHasOneNegativeTest()
        {
            var solution = new HighestProductOfKSolution();
            int[] arr = { -5, 4, 8, 2, 3 };
            int k = 3;
            var actual = solution.GetHighestProductOfK(arr, k);
            var expected = 96;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HighestProductOf3_ArrayHasTwoNegativesTest()
        {
            var solution = new HighestProductOfKSolution();
            int[] arr = { -10, 1, 3, 2, -10 };
            int k = 3;
            var actual = solution.GetHighestProductOfK(arr, k);
            var expected = 300;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HighestProductOf3_ArrayHasAllNegativesTest()
        {
            var solution = new HighestProductOfKSolution();
            int[] arr = { -5, -1, -3, -2 };
            int k = 3;
            var actual = solution.GetHighestProductOfK(arr, k);
            var expected = -6;
            Assert.Equal(expected, actual);
        }
    }
}
