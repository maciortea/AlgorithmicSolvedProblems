using Xunit;

namespace StackMachine
{
    public class StackMachineUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            var solution = new StackMachineSolution();
            var result = solution.Calculate("13+62*7+*");

            Assert.Equal(76, result);
        }

        [Fact]
        public void EmptyString()
        {
            var solution = new StackMachineSolution();
            var result = solution.Calculate(string.Empty);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void StringWithWhitespaces()
        {
            var solution = new StackMachineSolution();
            var result = solution.Calculate("    ");

            Assert.Equal(-1, result);
        }

        [Fact]
        public void InvalidString()
        {
            var solution = new StackMachineSolution();
            var result = solution.Calculate("11++");

            Assert.Equal(-1, result);
        }

        [Fact]
        public void ValidStringWithWhitespaces()
        {
            var solution = new StackMachineSolution();
            var result = solution.Calculate("  34 + 2* ");

            Assert.Equal(14, result);
        }

        [Fact]
        public void Overflow()
        {
            var s = string.Format("{0}{1}+", int.MaxValue, int.MaxValue);

            var solution = new StackMachineSolution();
            var result = solution.Calculate(s);

            Assert.Equal(-1, result);
        }
    }
}
