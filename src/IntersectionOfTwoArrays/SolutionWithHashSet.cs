using System.Collections.Generic;

namespace IntersectionOfTwoArrays
{
    public class SolutionWithHashSet
    {
        // N = arr1.Length
        // M = arr2.Length
        // Time complexity: O(N + M)
        // Space complexity: O(2*N), if N ~ M
        public int[] FindIntersection(int[] arr1, int[] arr2)
        {
            var intersection = new List<int>();
            var set = new HashSet<int>();
            
            for (int i = 0; i < arr1.Length; i++)
            {
                set.Add(arr1[i]);
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (set.Contains(arr2[i]))
                {
                    intersection.Add(arr2[i]);
                }
            }

            return intersection.ToArray();
        }
    }
}
