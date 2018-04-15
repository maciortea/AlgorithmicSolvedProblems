using Xunit;

namespace StringComposition
{
    public class StringCompositionUnitTest
    {
        [Fact]
        public void InsertCharacterTest()
        {
            var s = "nice";
            var t = "niece";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("INSERT e", result);
        }

        [Fact]
        public void DeleteCharacterTest()
        {
            var s = "niece";
            var t = "nice";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("DELETE e", result);
        }

        [Fact]
        public void SwapCharacterTest()
        {
            var s = "form";
            var t = "from";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("SWAP o r", result);
        }

        [Fact]
        public void ImpossibleTest()
        {
            string s = "form";
            string t = "frto";

            var solution = new StringCompositionSolution();
            string result = solution.GetStringChange(s, t);

            Assert.Equal("IMPOSSIBLE", result);
        }

        [Fact]
        public void SwapLastCharacter()
        {
            var s = "abcde";
            var t = "abced";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("SWAP d e", result);
        }

        [Fact]
        public void BigStringWithInsertCharacterTest()
        {
            var s = "sdfkljhasdfkljhadsfkjhasdkjfhalskdjhfaklsdjhfaklsdhfjkashdfkjahsdf";
            var t = "sdfkljhasdfkljhadsfkjhasdkjfhalskdjhfaklsdjhfakljsdhfjkashdfkjahsdf";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("INSERT j", result);
        }

        [Fact]
        public void BigStringImpossibleTest()
        {
            var s = "sdfkljhasdfkljhadsfkjhasdkjfhalskdahfaklsdjhfakljsdhfjkashdfkjahsdf";
            var t = "sdfkljhasdfkljhadsfkjhasdkjfhalskdghfaklsdjhfakljsdhfjkashdfkjahsdf";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("IMPOSSIBLE", result);
        }

        [Fact]
        public void InsertCharacterAtTheEndTest()
        {
            var s = "marian";
            var t = "marianc";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("INSERT c", result);
        }

        [Fact]
        public void InsertCharacterAtTheBeginningTest()
        {
            var s = "arian";
            var t = "marian";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("INSERT m", result);
        }

        [Fact]
        public void DeleteCharacterFromTheEndTest()
        {
            var s = "marianc";
            var t = "marian";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("DELETE c", result);
        }

        [Fact]
        public void DeleteCharacterFromTheBeginningTest()
        {
            var s = "marian";
            var t = "arian";

            var solution = new StringCompositionSolution();
            var result = solution.GetStringChange(s, t);

            Assert.Equal("DELETE m", result);
        }
    }
}
