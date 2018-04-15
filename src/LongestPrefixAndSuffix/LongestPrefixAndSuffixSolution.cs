using System.Text;

namespace LongestPrefixAndSuffix
{
    public class LongestPrefixAndSuffixSolution
    {
        public int LongestCommonPrefixAndSuffix(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            {
                return 0;
            }

            if (s.Length == 2 && s[0] == s[1])
            {
                return 1;
            }

            int maxLength = 0;
            var prefix = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++)
            {
                prefix.Append(s[i]);
                if (IsProperSuffix(s, prefix.ToString().ToCharArray()))
                {
                    if (i + 1 > maxLength)
                    {
                        maxLength = i + 1;
                    }
                }
            }

            return maxLength;
        }

        private bool IsProperSuffix(string s, char[] arr)
        {
            if (arr.Length < s.Length)
            {
                int k = s.Length - arr.Length;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != s[k])
                    {
                        return false;
                    }
                    k++;
                }

                return true;
            }

            return false;
        }
    }
}
