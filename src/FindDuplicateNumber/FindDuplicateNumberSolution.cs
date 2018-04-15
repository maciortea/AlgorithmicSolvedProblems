namespace FindDuplicateNumber
{
    // Given an array containing n + 1 integers where each integer is between 1 and n, prove that at least
    // one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate one.
    // Note:
    // 1. You must not modify the array
    // 2. You must use O(1) extra space
    // 3. Your runtime complexity should be less than O(2n)
    // 4. There is only one duplicate number in the array, but it could be repeated more than once
    public class FindDuplicateNumberSolution
    {
        public int FindDuplicate(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            int low = 1;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                int count = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] <= mid)
                    {
                        count++;
                    }
                }

                if (count <= mid)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return low;
        }
    }
}
