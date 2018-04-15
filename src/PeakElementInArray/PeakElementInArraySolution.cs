namespace PeakElementInArray
{
    // Find peak element.
    // A peak element is an element that is greater than its neighbors.
    // Given an input array where num[i] != num[i + 1], find peak element and return it.
    // The array may contain multiple peaks, in that case return any of it.
    // For example in array [1, 2, 3, 1], 3 is a peak element.
    public class PeakElementInArraySolution
    {
        public int FindPeakElement(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }

            int peak = 0;
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                if (left == right)
                {
                    peak = arr[left];
                    break;
                }

                int mid = (left + right) / 2;

                if (arr[mid] <= arr[mid + 1])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return peak;
        }
    }
}
