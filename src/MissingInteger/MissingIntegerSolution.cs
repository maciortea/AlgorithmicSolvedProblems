using System.Collections.Generic;

namespace MissingInteger
{
    // Given an array arr of unique nonnegative integers, implement a function GetMissingInteger() that finds the
    // smallest nonnegative integer that is NOT in the array.
    // Even if your programming language of choice doesn't have that restriction (like Python),
    // assume that the maximum value an integer can have is MAX_INT = 2 ^ 31 - 1.
    // So, for instance, the operation MAX_INT + 1 would be undefined in our case.
    // Your algorithm should be efficient, both from a time and a space complexity perspectives.
    // Solve first for the case when you’re NOT allowed to modify the input arr.
    // If successful and still have time, see if you can come up with an algorithm with an improved space complexity
    // when modifying arr is allowed.Do so without trading off the time complexity.
    // Analyze the time and space complexities of your algorithm.
    // 
    // Example:
    // input: arr = [0, 1, 2, 3]
    // output: 4
    public class MissingIntegerSolution
    {
        public int GetMissingInteger(int[] arr)
        {
            var n = arr.Length;
            var set = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                set.Add(arr[i]);
            }

            for (int i = 0; i < n; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }

            return n;
        }
    }
}
