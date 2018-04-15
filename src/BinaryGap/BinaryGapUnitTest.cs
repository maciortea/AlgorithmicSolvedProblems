using Xunit;

namespace BinaryGap
{
    
    public class BinaryGapUnitTest
    {
        [Fact]
        public void FindMaxBinaryGapTest1()
        {
            var solution = new BinaryGapSolution();
            int maxBinaryGap = solution.FindMaxBinaryGap(1041);

            Assert.Equal(5, maxBinaryGap);
        }

        [Fact]
        public void FindMaxBinaryGapTest2()
        {
            var solution = new BinaryGapSolution();
            int maxBinaryGap = solution.FindMaxBinaryGap(15);

            Assert.Equal(0, maxBinaryGap);
        }

        [Fact]
        public void FindMaxBinaryGapTest3()
        {
            var solution = new BinaryGapSolution();
            int maxBinaryGap = solution.FindMaxBinaryGap(16);

            Assert.Equal(0, maxBinaryGap);
        }

        [Fact]
        public void FindMaxBinaryGapTest4()
        {
            var solution = new BinaryGapSolution();
            int maxBinaryGap = solution.FindMaxBinaryGap(6);

            Assert.Equal(0, maxBinaryGap);
        }

        [Fact]
        public void FindMaxBinaryGapTest5()
        {
            var solution = new BinaryGapSolution();
            int maxBinaryGap = solution.FindMaxBinaryGap(328);

            Assert.Equal(2, maxBinaryGap);
        }

        [Fact]
        public void FindMaxBinaryGapTest6()
        {
            var solution = new BinaryGapSolution();
            int maxBinaryGap = solution.FindMaxBinaryGap(51712);

            Assert.Equal(2, maxBinaryGap);
        }
    }
}
