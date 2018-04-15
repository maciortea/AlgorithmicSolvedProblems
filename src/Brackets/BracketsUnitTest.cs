using Xunit;

namespace Brackets
{
     
    public class BracketsUnitTest
    {
        [Fact]
        public void ValidBrackets()
        {
            var s = "{[]()[{}]}";
            var solution = new BracketsSolution();

            Assert.True(solution.HasValidBrackets(s) == 1);
        }

        [Fact]
        public void EmptyString()
        {
            var s = "";
            var solution = new BracketsSolution();

            Assert.True(solution.HasValidBrackets(s) == 1);
        }

        [Fact]
        public void WhitespacesString()
        {
            var s = "    ";
            var solution = new BracketsSolution();

            Assert.True(solution.HasValidBrackets(s) == 1);
        }

        [Fact]
        public void OddLengthString()
        {
            var s = "(()";
            var solution = new BracketsSolution();

            Assert.True(solution.HasValidBrackets(s) == 0);
        }

        [Fact]
        public void InvalidString()
        {
            var s = "(())[[()]]{{";
            var solution = new BracketsSolution();

            Assert.True(solution.HasValidBrackets(s) == 0);
        }
    }
}
