using Xunit;

namespace LongestCommonPrefix
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void NullInput_ShouldReturnEmptyString()
        {
            var solution = new LongestCommonPrefixSolution();
            string result = solution.GetLongestCommonPrefix(null);

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void EmptyInput_ShouldReturnEmptyString()
        {
            var solution = new LongestCommonPrefixSolution();
            string result = solution.GetLongestCommonPrefix(new string[0]);

            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void SingleInput_ShouldReturnInput()
        {
            string[] words = { "cat" };

            var solution = new LongestCommonPrefixSolution();
            string result = solution.GetLongestCommonPrefix(words);

            Assert.Equal("cat", result);
        }

        [Fact]
        public void SimpleInputTest()
        {
            string[] words = { "calculator", "car", "candy" };

            var solution = new LongestCommonPrefixSolution();
            string result = solution.GetLongestCommonPrefix(words);

            Assert.Equal("ca", result);
        }

        [Fact]
        public void MixedInputTest()
        {
            string[] words = { "hamburger", "hamster", "hamburg" };

            var solution = new LongestCommonPrefixSolution();
            string result = solution.GetLongestCommonPrefix(words);

            Assert.Equal("ham", result);
        }

        [Fact]
        public void NoCommonPrefixInputTest()
        {
            string[] words = { "apple", "lemon", "strawberries" };

            var solution = new LongestCommonPrefixSolution();
            string result = solution.GetLongestCommonPrefix(words);

            Assert.Equal(string.Empty, result);
        }
    }
}
