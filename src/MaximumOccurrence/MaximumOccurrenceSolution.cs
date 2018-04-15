using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumOccurrence
{
    public class MaximumOccurrenceSolution
    {
        public Tuple<char, int> FindCharacterWithMaxOccurrence(string str)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                int val = 1;
                if (dict.ContainsKey(c))
                {
                    val = dict[c] + 1;
                }
                dict[c] = val;
            }

            int max = 0;
            foreach (var item in dict)
            {
                if (item.Value >= max)
                {
                    max = item.Value;
                }
            }

            int minChar = 'z';
            foreach (var item in dict.Where(x => x.Value == max))
            {
                if (item.Key < minChar)
                {
                    minChar = item.Key;
                }
            }

            return Tuple.Create((char)minChar, max);
        }
    }
}
