using Xunit;

namespace FindDuplicateNumber
{
    
    public class FindDuplicateNumberUnitTest
    {
        [Fact]
        public void FindDuplicateTest()
        {
            int[] nums = { 3, 6, 2, 1, 5, 4, 3 };

            var solution = new FindDuplicateNumberSolution();
            int duplicate = solution.FindDuplicate(nums);

            Assert.Equal(3, duplicate);
        }
    }
}
