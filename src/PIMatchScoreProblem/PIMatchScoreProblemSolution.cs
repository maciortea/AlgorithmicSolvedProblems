namespace PIMatchScoreProblem
{
    public class PIMatchScoreProblemSolution
    {
        private const int PI = 314;

        public double CalculatePIMatchScore(double number)
        {
            if (number < 100)
            {
                return 0D;
            }

            double score = 0D;
            int lastThreeDigitsNumber = 0;
            int k = 1;
            double n = number;
            int numbersCount = 0;
            while (number > 100)
            {
                int digit = (int)(n % 10);
                lastThreeDigitsNumber += digit * k;
                k *= 10;
                n = n / 10;

                if (lastThreeDigitsNumber > 100)
                {
                    double diff = lastThreeDigitsNumber - PI;
                    score += diff;
                    lastThreeDigitsNumber = 0;
                    number = number / 10;
                    n = number;
                    k = 1;
                    numbersCount++;
                }
            }
            return score / numbersCount;
        }
    }
}
