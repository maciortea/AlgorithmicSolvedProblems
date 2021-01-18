using System;

namespace MaxSumInArray
{
    // Given an array of integers, calculate maximum sum of k consecutive elements from array.
    // Time complexity: O(n)
    // Space complexity: O(1)
    public class MaxSumInArraySolution
    {
        public int GetMaxSum(int[] arr, int k)
        {
            if (arr.Length < k)
            {
                return 0;
            }

            int maxSum = 0;

            for (int i = 0; i < k; i++)
            {
                maxSum += arr[i];
            }

            int sum = maxSum;
            for (int i = k; i < arr.Length; i++)
            {
                sum += arr[i] - arr[i - k];
                maxSum = Math.Max(sum, maxSum);
            }

            return maxSum;
        }
    }
}
