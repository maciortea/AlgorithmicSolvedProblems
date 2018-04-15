using Xunit;

namespace CountDiv
{
    
    public class CountDivUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            var solution = new CountDivSolution();
            int divCount = solution.GetDivCount(6, 11, 2);

            Assert.Equal(3, divCount);
        }
    }
}
