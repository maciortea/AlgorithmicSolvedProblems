namespace PlusOne
{
    // Given a non-negative number represented as an array of digits, add one to the number.
    // The digits are stored such that the most significant digit is at the head of the array.
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits == null || digits.Length <= 0)
            {
                return new int[0];
            }

            int[] result = null;

            if (AreAllDigitsNine(digits))
            {
                result = new int[digits.Length + 1];
                result[0] = 1;
            }
            else
            {
                result = new int[digits.Length];
            }

            int carry = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int num = digits[i] + carry;
                result[i] = num % 10;

                carry = 0;
                if (num >= 10)
                {
                    carry = 1;
                }
            }

            return result;
        }

        private bool AreAllDigitsNine(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 9)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
