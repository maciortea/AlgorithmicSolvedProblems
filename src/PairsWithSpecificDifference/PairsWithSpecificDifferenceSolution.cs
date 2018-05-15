using System;
using System.Collections.Generic;

namespace PairsWithSpecificDifference
{
    // Given an array arr of distinct integers and a nonnegative integer k,
    // write a function FindPairsWithGivenDifference() that returns an array of all pairs[x, y] in arr, such that x - y = k.
    // If no such pairs exist, return an empty array.
    // In your solution, try to reduce the memory usage while maintaining time efficiency.
    // Prove the correctness of your solution and analyze its time and space complexities.
    //
    // Examples:
    // input:  arr = [0, -1, -2, 2, 1], k = 1
    // output: [[1, 0], [0, -1], [-1, -2], [2, 1]]
    //
    // input:  arr = [1, 7, 5, 3, 32, 17, 12], k = 17
    // output: []
    public class PairsWithSpecificDifferenceSolution
    {
        public int[,] FindPairsWithGivenDifference(int[] arr, int k)
        {
            Array.Sort(arr);

            var result = new List<int[]>();
            int first = 0;
            int last = 1;

            while (first < arr.Length && last < arr.Length)
            {
                int value = arr[last] - arr[first];
                if (first != last && value == k)
                {
                    result.Add(new int[] { arr[last], arr[first] });
                    first++;
                    last++;
                }
                else if (value < k)
                {
                    last++;
                }
                else
                {
                    first++;
                }
            }

            if (result.Count <= 0)
            {
                return new int[,] { };
            }

            var resultArr = new int[result.Count, 2];
            for (int i = 0; i < result.Count; i++)
            {
                resultArr[i, 0] = result[i][0];
                resultArr[i, 1] = result[i][1];
            }
            return resultArr;
        }
    }
}
