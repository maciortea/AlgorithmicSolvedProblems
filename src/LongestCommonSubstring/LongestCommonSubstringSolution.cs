using System;

namespace LongestCommonSubstring
{
    public class LongestCommonSubstringSolution
    {
        public int GetLongestCommonSubstringBottomUp(string str1, string str2)
        {
            int length1 = str1.Length + 1;
            int length2 = str2.Length + 1;
            int[,] matrix = new int[length1, length2];
            for (int i = 1; i < length1; i++)
            {
                for (int j = 1; j < length2; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                    {
                        matrix[i, j] = 1 + matrix[i - 1, j - 1];
                    }
                    else
                    {
                        matrix[i, j] = Math.Max(matrix[i - 1, j], matrix[i, j - 1]);
                    }
                }
            }

            return matrix[length1 - 1, length2 - 1];
        }

        public int GetLongestCommonSubstring(string str1, string str2)
        {
            return GetLongestCommonSubstring(str1, str2, 0, 0);
        }

        private int GetLongestCommonSubstring(string str1, string str2, int i, int j)
        {
            if (i == str1.Length || j == str2.Length)
            {
                return 0;
            }

            if (str1[i] == str2[j])
            {
                return 1 + GetLongestCommonSubstring(str1, str2, i + 1, j + 1);
            }
            else
            {
                return Math.Max(GetLongestCommonSubstring(str1, str2, i, j + 1), GetLongestCommonSubstring(str1, str2, i + 1, j));
            }
        }
    }
}
