using Xunit;

namespace EquiLeader
{
    public class EquiLeaderUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            int[] arr = { 4, 3, 4, 4, 4, 2 };

            var solution = new EquiLeaderSolution();
            int equiLeaderCount = solution.GetEquiLeadersCount(arr);

            Assert.Equal(2, equiLeaderCount);
        }

        [Fact]
        public void SingleElementTest()
        {
            int[] arr = { 1 };
            var solution = new EquiLeaderSolution();
            int equiLeaderCount = solution.GetEquiLeadersCount(arr);

            Assert.Equal(0, equiLeaderCount);
        }

        [Fact]
        public void TwoElements_NoLeader()
        {
            int[] arr = { 1, 2 };

            var solution = new EquiLeaderSolution();
            int equiLeaderCount = solution.GetEquiLeadersCount(arr);

            Assert.Equal(0, equiLeaderCount);
        }

        [Fact]
        public void TwoElements_WithLeader()
        {
            int[] arr = { 1, 1 };

            var solution = new EquiLeaderSolution();
            int equiLeaderCount = solution.GetEquiLeadersCount(arr);

            Assert.Equal(1, equiLeaderCount);
        }
    }
}
