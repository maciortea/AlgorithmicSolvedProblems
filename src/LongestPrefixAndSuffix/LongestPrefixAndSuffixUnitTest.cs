using Xunit;

namespace LongestPrefixAndSuffix
{
    public class LongestPrefixAndSuffixUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            var solution = new LongestPrefixAndSuffixSolution();
            int count = solution.LongestCommonPrefixAndSuffix("abbabba");

            Assert.Equal(4, count);
        }

        [Fact]
        public void TestMethod2()
        {
            var solution = new LongestPrefixAndSuffixSolution();
            int count = solution.LongestCommonPrefixAndSuffix("abbxrtabb");

            Assert.Equal(3, count);
        }

        [Fact]
        public void TestMethod3()
        {
            var solution = new LongestPrefixAndSuffixSolution();
            int count = solution.LongestCommonPrefixAndSuffix("akhgkjfjghgfkhgkjgkjgjkhgkyjga");

            Assert.Equal(1, count);
        }

        [Fact]
        public void TestMethod4()
        {
            var solution = new LongestPrefixAndSuffixSolution();
            int count = solution.LongestCommonPrefixAndSuffix("codility");

            Assert.Equal(0, count);
        }

        [Fact]
        public void TestMethod5()
        {
            var solution = new LongestPrefixAndSuffixSolution();
            int count = solution.LongestCommonPrefixAndSuffix("rabbabbt");

            Assert.Equal(0, count);
        }

        [Fact]
        public void TestMethod6()
        {
            var solution = new LongestPrefixAndSuffixSolution();
            int count = solution.LongestCommonPrefixAndSuffix("aaaaa");

            Assert.Equal(4, count);
        }

        [Fact]
        public void TestMethod7()
        {
            var solution = new LongestPrefixAndSuffixSolution();
            int count = solution.LongestCommonPrefixAndSuffix("aabbaabb");

            Assert.Equal(4, count);
        }
    }
}
