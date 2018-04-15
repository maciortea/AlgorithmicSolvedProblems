using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StackMachine
{
    public class StackMachineSolution
    {
        private const string digits = "0123456789";

        public int Calculate(string s)
        {
            if (s == null)
            {
                return -1;
            }

            s = Regex.Replace(s, @"\s", string.Empty);

            if (s.Length == 0)
            {
                return -1;
            }

            var stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (IsDigit(c))
                {
                    int digit = c - '0';
                    stack.Push(digit);
                }
                else if (c == '+')
                {
                    if (stack.Count <= 1)
                    {
                        return -1;
                    }

                    var result = 0;
                    try
                    {
                        result = stack.Pop() + stack.Pop();
                    }
                    catch (OverflowException)
                    {
                        return -1;
                    }

                    stack.Push(result);

                }
                else if (c == '*')
                {
                    int result = 0;
                    try
                    {
                        result = stack.Pop() * stack.Pop();
                    }
                    catch (OverflowException)
                    {
                        return -1;
                    }

                    stack.Push(result);
                }
                else
                {
                    return -1;
                }
            }

            if (stack.Count == 1)
            {
                return stack.Pop();
            }
            else
            {
                return -1;
            }
        }

        private bool IsDigit(char c)
        {
            if (digits.Any(x => x == c))
            {
                return true;
            }
            return false;
        }
    }
}
