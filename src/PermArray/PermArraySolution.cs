using System.Collections.Generic;

namespace PermArray
{
    // A non-empty zero-indexed array A consisting of N integers is given.
    // A permutation is a sequence containing each element from 1 to N once, and only once.
    // For example, array A such that:
    // A[0] = 4
    // A[1] = 1
    // A[2] = 3
    // A[3] = 2
    //is a permutation, but array A such that:
    // A[0] = 4
    // A[1] = 1
    // A[2] = 3
    // is not a permutation, because value 2 is missing.
    // The goal is to check whether array A is a permutation.
    //
    // Write a function hat, given a zero-indexed array A, returns 1 if array A is a permutation and 0 if it is not.
    //
    // Assume that:
    // - N is an integer within the range[1..100,000]
    // - each element of array A is an integer within the range[1..1,000,000,000]
    //
    // Complexity:
    // - expected worst-case time complexity is O(N)
    // - expected worst-case space complexity is O(N), beyond input storage
    //   (not counting the storage required for input arguments)
    // - elements of input arrays can be modified
    public class PermArraySolution
    {
        public int IsPermutation(int[] arr)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (set.Contains(arr[i]))
                {
                    return 0;
                }

                set.Add(arr[i]);
            }

            int val = 1;
            for (int i = 0; i < set.Count; i++)
            {
                if (!set.Contains(val))
                {
                    return 0;
                }
                val++;
            }

            return 1;
        }
    }
}
