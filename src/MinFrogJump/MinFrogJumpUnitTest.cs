using Xunit;

namespace MinFrogJump
{
    public class MinFrogJumpUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            var solution = new MinFrogJumpSolution();
            int minJumps = solution.GetMinJumps(10, 85, 30);

            Assert.Equal(3, minJumps);
        }
    }
}
