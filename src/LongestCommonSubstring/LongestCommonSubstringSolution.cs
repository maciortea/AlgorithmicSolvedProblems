using System;

namespace LongestCommonSubstring
{
    public class LongestCommonSubstringSolution
    {
        public int GetLongestCommonSubstring(string first, string second)
        {
            return GetLongestCommonSubstring(first, second, 0, 0);
        }

        private int GetLongestCommonSubstring(string first, string second, int firstIndex, int secondIndex)
        {
            if (firstIndex == first.Length || secondIndex == second.Length)
            {
                return 0;
            }

            if (first[firstIndex] == second[secondIndex])
            {
                return 1 + GetLongestCommonSubstring(first, second, firstIndex + 1, secondIndex + 1);
            }
            else
            {
                return Math.Max(
                    GetLongestCommonSubstring(first, second, firstIndex, secondIndex + 1),
                    GetLongestCommonSubstring(first, second, firstIndex + 1, secondIndex));
            }
        }
    }
}
