using System.Collections.Generic;

namespace FindAllPalindromes
{
    public class FindAllPalindromesSolution
    {
        public List<string> GetAllPaliondromes(string s)
        {
            var result = new List<string>();

            if (string.IsNullOrWhiteSpace(s))
            {
                return result;
            }

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int j = i + 1; j <= s.Length; j++)
                {
                    if (j - i > 1 && s[j - 1] == s[i])
                    {
                        string currentSubset = s.Substring(i, j - i);
                        if (IsPalindrome(currentSubset))
                        {
                            result.Add(currentSubset);
                        }
                    }
                }
            }

            return result;
        }

        private bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return false;
            }

            int mid = s.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
