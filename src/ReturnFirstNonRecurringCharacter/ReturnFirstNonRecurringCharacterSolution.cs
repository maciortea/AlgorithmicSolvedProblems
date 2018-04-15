using System.Collections.Generic;

namespace ReturnFirstNonRecurringCharacter
{
    public class ReturnFirstNonRecurringCharacterSolution
    {
        public char? GetFirstNonRecurringCharacter(string s)
        {
            var dict = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                {
                    dict[s[i]] = 1;
                }
                else
                {
                    dict[s[i]] += 1;
                }
            }

            foreach (var c in dict.Keys)
            {
                if (dict[c] == 1)
                {
                    return c;
                }
            }

            return null;
        }
    }
}
