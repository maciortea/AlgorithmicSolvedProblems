using System;
using System.Collections.Generic;

namespace StringComposition
{
    public class StringCompositionSolution
    {
        private const string Nothing = "NOTHING";
        private const string Impossible = "IMPOSSIBLE";
        private const string Swap = "SWAP";
        private const string Insert = "INSERT";
        private const string Delete = "DELETE";

        public string GetStringChange(string s, string t)
        {
            if (s == t)
            {
                return Nothing;
            }

            if (Math.Abs(s.Length - t.Length) > 1)
            {
                return Impossible;
            }

            var modifiedList = new List<char>(s);
            var possibleResult = string.Empty;
            int compare = s.Length.CompareTo(t.Length);

            if (compare == 0)
            {
                // Check swap

                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] != t[i])
                    {
                        possibleResult = $"{Swap} {modifiedList[i]} {modifiedList[i + 1]}";
                        char temp = modifiedList[i + 1];
                        modifiedList[i + 1] = modifiedList[i];
                        modifiedList[i] = temp;
                        break;
                    }
                }
            }
            else if (compare < 0)
            {
                // Check insert

                for (int i = 0; i < t.Length; i++)
                {
                    if (i == s.Length || s[i] != t[i])
                    {
                        possibleResult = $"{Insert} {t[i]}";
                        modifiedList.Insert(i, t[i]);
                        break;
                    }
                }
            }
            else if (compare > 0)
            {
                // Check delete

                for (int i = 0; i < s.Length; i++)
                {
                    if (i == t.Length || s[i] != t[i])
                    {
                        possibleResult = $"{Delete} {s[i]}";
                        modifiedList.RemoveAt(i);
                        break;
                    }
                }
            }

            if (new string(modifiedList.ToArray()) == t)
            {
                return possibleResult;
            }

            return Impossible;
        }
    }
}
