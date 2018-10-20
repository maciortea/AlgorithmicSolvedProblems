using Xunit;

namespace FindDuplicateNumber
{
    
    public class FindDuplicateNumberUnitTest
    {
        [Fact]
        public void JustTheRepeatedNumberTest()
        {
            var numbers = new int[] { 1, 1 };

            var solution = new FindDuplicateNumberSolution();
            int actual = solution.FindDuplicate(numbers);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void ShortArrayTest()
        {
            var numbers = new int[] { 1, 2, 3, 2 };

            var solution = new FindDuplicateNumberSolution();
            int actual = solution.FindDuplicate(numbers);

            Assert.Equal(2, actual);
        }

        [Fact]
        public void MediumArrayTest()
        {
            var numbers = new int[] { 1, 2, 5, 5, 5, 5 };

            var solution = new FindDuplicateNumberSolution();
            int actual = solution.FindDuplicate(numbers);

            Assert.Equal(5, actual);
        }

        [Fact]
        public void LongArrayTest()
        {
            var numbers = new int[] { 4, 1, 4, 8, 3, 2, 7, 6, 5 };

            var solution = new FindDuplicateNumberSolution();
            int actual = solution.FindDuplicate(numbers);

            Assert.Equal(4, actual);
        }
    }
}
