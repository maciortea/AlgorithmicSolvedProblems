using System.Collections.Generic;

namespace IntersectionOfTwoArrays
{

    public class SolutionWithBinarySearch
    {
        // N = arr1.Length
        // M = arr2.Length
        // Time complexity: O(log(M)), if M is much bigger than N
        // Space complexity: O(N)
        public int[] FindIntersection(int[] arr1, int[] arr2)
        {
            var intersection = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                int valueToSearch = arr1[i];
                if (BinarySearch(arr2, valueToSearch))
                {
                    intersection.Add(valueToSearch);
                }
            }

            return intersection.ToArray();
        }

        private bool BinarySearch(int[] arr, int valueToSearch)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;
                if (valueToSearch == arr[mid])
                {
                    return true;
                }

                if (valueToSearch > arr[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return false;
        }
    }
}
