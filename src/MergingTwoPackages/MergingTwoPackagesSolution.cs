using System.Collections.Generic;

namespace MergingTwoPackages
{
    // Given a package with a weight limit and an array arr of item weights,
    // implement a function getIndicesOfItemWeights that finds two items whose sum of
    // weights equals the weight limit limit.
    // Your function should return a pair[i, j] of the indices of the item weights, ordered such that i > j.
    // If such a pair doesn't exist, return an empty array.
    // Analyze the time and space complexities of your solution.
    // input:  arr = [4, 6, 10, 15, 16],  lim = 21
    // output: [3, 1] # since these are the indices of the
    // # weights 6 and 15 whose sum equals to 21
    public class MergingTwoPackagesSolution
    {
        public int[] GetIndicesOfItemWeights(int[] arr, int limit)
        {
            var hashSet = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var weight = arr[i];
                if (hashSet.ContainsKey(limit - weight))
                {
                    var complementIndex = hashSet[limit - weight];
                    return new int[] { i, complementIndex };
                }
                hashSet[weight] = i;
            }

            return new int[0];
        }
    }
}
