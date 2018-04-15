using Xunit;

namespace CheckContainsDuplicates
{
    public class CheckContainsDuplicatesUnitTest
    {
        [Fact]
        public void EmptyArray_ShouldReturnFalse()
        {
            int[] arr = null;

            var solution = new CheckContainsDuplicatesSolution();
            bool hasDuplicate = solution.HasDuplicate(arr);

            Assert.False(hasDuplicate);
        }

        [Fact]
        public void ArrayWithNoDuplicates_ShouldReturnFalse()
        {
            int[] arr = { 1, 2, 3, 4 };

            var solution = new CheckContainsDuplicatesSolution();
            bool hasDuplicate = solution.HasDuplicate(arr);

            Assert.False(hasDuplicate);
        }

        [Fact]
        public void ArrayWithOneDuplicate_ShouldReturnTrue()
        {
            int[] arr = { 3, 2, 5, 3, 1 };

            var solution = new CheckContainsDuplicatesSolution();
            bool hasDuplicate = solution.HasDuplicate(arr);

            Assert.True(hasDuplicate);
        }

        [Fact]
        public void ArrayWithManyDuplicates_ShouldReturnTrue()
        {
            int[] arr = { 1, 2, 3, 4, 5, 1, 7, 2, 3 };

            var solution = new CheckContainsDuplicatesSolution();
            bool hasDuplicate = solution.HasDuplicate(arr);

            Assert.True(hasDuplicate);
        }
    }
}
