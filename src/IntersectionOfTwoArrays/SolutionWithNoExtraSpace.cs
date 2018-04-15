using System.Collections.Generic;

namespace IntersectionOfTwoArrays
{
    public class SolutionWithNoExtraSpace
    {
        // N = arr1.Length
        // M = arr2.Length
        // Time complexity: O(N + M)
        // Space complexity: O(N), if N ~ M
        public int[] FindIntersection(int[] arr1, int[] arr2)
        {
            var intersection = new List<int>();
            int i = 0;
            int j = 0;

            while (i < arr1.Length && j < arr2.Length)
            {
                if (arr1[i] == arr2[j])
                {
                    intersection.Add(arr1[i]);
                    i++;
                    j++;
                }
                else if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return intersection.ToArray();
        }
    }
}
