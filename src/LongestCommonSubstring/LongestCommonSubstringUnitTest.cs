using Xunit;

namespace LongestCommonSubstring
{
    public class LongestCommonSubstringUnitTest
    {
        [Fact]
        public void Test1()
        {
            string str1 = "bd";
            string str2 = "abcd";

            var solution = new LongestCommonSubstringSolution();
            int result1 = solution.GetLongestCommonSubstring(str1, str2);
            int result2 = solution.GetLongestCommonSubstringBottomUp(str1, str2);

            Assert.Equal(2, result1);
            Assert.Equal(2, result2);
        }

        [Fact]
        public void Test2()
        {
            string str1 = "stone";
            string str2 = "longest";

            var solution = new LongestCommonSubstringSolution();
            int result1 = solution.GetLongestCommonSubstring(str1, str2);
            int result2 = solution.GetLongestCommonSubstringBottomUp(str1, str2);

            Assert.Equal(3, result1);
            Assert.Equal(3, result2);
        }

        [Fact]
        public void Test3()
        {
            string str1 = "abcdefghij";
            string str2 = "cdgi";

            var solution = new LongestCommonSubstringSolution();
            int result1 = solution.GetLongestCommonSubstring(str1, str2);
            int result2 = solution.GetLongestCommonSubstringBottomUp(str1, str2);

            Assert.Equal(4, result1);
            Assert.Equal(4, result2);
        }

        [Fact]
        public void Test4()
        {
            string str1 = "abc";
            string str2 = "abc";

            var solution = new LongestCommonSubstringSolution();
            int result1 = solution.GetLongestCommonSubstring(str1, str2);
            int result2 = solution.GetLongestCommonSubstringBottomUp(str1, str2);

            Assert.Equal(3, result1);
            Assert.Equal(3, result2);
        }

        [Fact]
        public void Test5()
        {
            string str1 = "abc";
            string str2 = "deg";

            var solution = new LongestCommonSubstringSolution();
            int result1 = solution.GetLongestCommonSubstring(str1, str2);
            int result2 = solution.GetLongestCommonSubstringBottomUp(str1, str2);

            Assert.Equal(0, result1);
            Assert.Equal(0, result2);
        }
    }
}
