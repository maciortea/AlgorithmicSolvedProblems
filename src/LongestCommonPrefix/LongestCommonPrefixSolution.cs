using System;

namespace LongestCommonPrefix
{
    public class LongestCommonPrefixSolution
    {
        public string GetLongestCommonPrefix(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            int minLength = GetMinLength(words);
            int start = 1;
            int end = minLength;
            int middle = 0;

            while (start <= end)
            {
                middle = (start + end) / 2;
                if (IsCommonPrefix(words, middle))
                {
                    start = middle + 1;
                }
                else
                {
                    end = middle - 1;
                }
            }

            middle = (start + end) / 2;
            return words[0].Substring(0, middle);
        }

        private int GetMinLength(string[] words)
        {
            int minLength = int.MaxValue;
            foreach (string word in words)
            {
                minLength = Math.Min(minLength, word.Length);
            }
            return minLength;
        }

        private bool IsCommonPrefix(string[] words, int length)
        {
            string firstWord = words[0].Substring(0, length);
            for (int i = 1; i < words.Length; i++)
            {
                if (!words[i].StartsWith(firstWord))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
