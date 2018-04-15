using Xunit;

namespace WordScoreProblem
{
    public class WordScoreProblemUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            var word = "XRay Machine";

            var solution = new WordScoreProblemSolution();
            int score = solution.GetWordScore(word);

            Assert.Equal(20, score);
        }

        [Fact]
        public void TestMethod2()
        {
            var word = "Jabbt";

            var solution = new WordScoreProblemSolution();
            int score = solution.GetWordScore(word);

            Assert.Equal(13, score);
        }

        [Fact]
        public void TestMethod3()
        {
            var word = "XRay1 Machine23";

            var solution = new WordScoreProblemSolution();
            int score = solution.GetWordScore(word);

            Assert.Equal(20, score);
        }

        [Fact]
        public void TestMethod4()
        {
            var word = "XRay Machine fff";

            var solution = new WordScoreProblemSolution();
            int score = solution.GetWordScore(word);

            Assert.Equal(29, score);
        }

        [Fact]
        public void NoSpecialLettersStringTest()
        {
            var word = "uuuuuu";

            var solution = new WordScoreProblemSolution();
            int score = solution.GetWordScore(word);

            Assert.Equal(0, score);
        }

        [Fact]
        public void OnlySpecialLettersStringTest()
        {
            var word = "afxttjf";

            var solution = new WordScoreProblemSolution();
            int score = solution.GetWordScore(word);

            Assert.Equal(36, score);
        }

        [Fact]
        public void EmptyStringTest()
        {
            var solution = new WordScoreProblemSolution();
            int score = solution.GetWordScore(string.Empty);

            Assert.Equal(0, score);
        }
    }
}
