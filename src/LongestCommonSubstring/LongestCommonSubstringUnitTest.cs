using System;
using Xunit;

namespace LongestCommonSubstring
{
    public class LongestCommonSubstringUnitTest
    {
        [Fact]
        public void Test1()
        {
            string first = "bd";
            string second = "abcd";

            var solution = new LongestCommonSubstringSolution();
            int result = solution.GetLongestCommonSubstring(first, second);

            Assert.Equal(2, result);
        }
    }
}
