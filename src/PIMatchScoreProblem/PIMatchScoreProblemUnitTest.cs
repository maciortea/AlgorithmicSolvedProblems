using Xunit;

namespace PIMatchScoreProblem
{
    public class PIMatchScoreProblemUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            double number = 3149;

            var solution = new PIMatchScoreProblemSolution();
            double score = solution.CalculatePIMatchScore(number);

            Assert.Equal(-82.5, score);
        }

        [Fact]
        public void TestMethod2()
        {
            double number = 357878;

            var solution = new PIMatchScoreProblemSolution();
            double score = solution.CalculatePIMatchScore(number);

            Assert.Equal(336.0, score);
        }

        [Fact]
        public void TestMethod3()
        {
            double number = 123456789345;

            var solution = new PIMatchScoreProblemSolution();
            double score = solution.CalculatePIMatchScore(number);

            Assert.Equal(222.4, score);
        }

        [Fact]
        public void TestMethod4()
        {
            double number = 12;

            var solution = new PIMatchScoreProblemSolution();
            double score = solution.CalculatePIMatchScore(number);

            Assert.Equal(0D, score);
        }

        [Fact]
        public void TestMethod5()
        {
            double number = 0D;

            var solution = new PIMatchScoreProblemSolution();
            double score = solution.CalculatePIMatchScore(number);

            Assert.Equal(0D, score);
        }
    }
}
