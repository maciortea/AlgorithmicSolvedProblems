namespace AddDigits
{
    // Given a non-negative number, repeatedly add all its digits until the result has only one digit.
    public class AddDigitsSolution
    {
        public int AddDigits(int num)
        {
            if (num < 10)
            {
                return num;
            }

            while (true)
            {
                int result = 0;
                while (num != 0)
                {
                    result = result + (num % 10);
                    num = num / 10;
                }

                num = result;

                if (num < 10)
                {
                    break;
                }
            }

            return num;
        }
    }
}
