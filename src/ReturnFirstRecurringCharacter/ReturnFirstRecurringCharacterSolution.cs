using System.Collections.Generic;

namespace ReturnFirstRecurringCharacter
{
    public class ReturnFirstRecurringCharacterSolution
    {
        public char? GetFirstRecurringCharacter(string s)
        {
            var set = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i]))
                {
                    return s[i];
                }
                set.Add(s[i]);
            }
            return null;
        }
    }
}
