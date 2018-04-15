using System.Collections.Generic;

namespace Brackets
{
    // Determine whether a given string of parentheses is properly nested.
    // A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:
    // - S is empty;
    // - S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
    // - S has the form "VW" where V and W are properly nested strings.
    // For example, the string "{[()()]}" is properly nested but "([)()]" is not.
    // 
    // Write a function that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.
    // 
    // For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]",
    // the function should return 0, as explained above.
    // 
    // Assume that:
    // - N is an integer within the range [0..200,000]
    // - string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")"
    // 
    // Complexity:
    // - expected worst-case time complexity is O(N)
    // - expected worst-case space complexity is O(N) (not counting the storage required for input arguments)
    public class BracketsSolution
    {
        public int HasValidBrackets(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return 1;
            }

            if (s.Length % 2 != 0)
            {
                return 0;
            }

            var stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (IsLeftParantheses(c))
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    char currentLeft = stack.Pop();
                    if (!IsValidPair(currentLeft, c))
                    {
                        return 0;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return 0;
            }

            return 1;
        }

        private bool IsLeftParantheses(char c)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                return true;
            }
            return false;
        }

        private bool IsValidPair(char left, char c)
        {
            if (left == '(' && c == ')')
            {
                return true;
            }
            else if (left == '[' && c == ']')
            {
                return true;
            }
            else if (left == '{' && c == '}')
            {
                return true;
            }
            return false;
        }
    }
}
