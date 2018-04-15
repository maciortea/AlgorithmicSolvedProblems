using System.Linq;

namespace WordScoreProblem
{
    public class WordScoreProblemSolution
    {
        private const string specialLetters = "FJXTAEIO";

        public int GetWordScore(string word)
        {
            if (string.IsNullOrWhiteSpace(word))
            {
                return 0;
            }

            var lettersGroup = word
                .ToUpper()
                .Where(x => specialLetters.Contains(x))
                .GroupBy(x => x)
                .Select(x => new { Letter = x.Key, Count = x.Count() });

            if (lettersGroup.Count() == 0)
            {
                return 0;
            }

            int score = 0;
            foreach (var g in lettersGroup)
            {
                if (g.Letter == 'F')
                {
                    score += 3 * g.Count;
                }
                else if (g.Letter == 'J')
                {
                    score += 6 * g.Count;
                }
                else if (g.Letter == 'X')
                {
                    score += 12 * g.Count;
                }
                else if (g.Letter == 'T')
                {
                    score += 5 * g.Count;
                }
                else
                {
                    score += 2 * g.Count;
                }
            }
            return score;
        }
    }
}
