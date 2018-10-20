using System.Linq;

namespace FindDuplicateNumber
{
    // Given an array containing n + 1 integers where each integer is between 1 and n, prove that at least
    // one duplicate number must exist. Assume that there is only one duplicate number, find the duplicate index.
    // Note:
    // 1. You must not modify the array
    // 2. You must use O(1) extra space
    // 3. Your runtime complexity should be less than O(n^2)
    // 4. There is only one duplicate number in the array, but it could be repeated more than once
    public class FindDuplicateNumberSolution
    {
        public int FindDuplicate(int[] arr)
        {
            int floor = 1;
            int ceiling = arr.Length - 1;

            while (floor < ceiling)
            {
                int middle = floor + (ceiling - floor) / 2;
                int lowerRangeFloor = floor;
                int lowerRangeCeiling = middle;
                int upperRangeFloor = middle + 1;
                int upperRangeCeiling = ceiling;

                int lowerRangeItemsCount = arr.Count(item => item >= lowerRangeFloor && item <= lowerRangeCeiling);
                int distinctPossibleIntegersInLowerRange = lowerRangeCeiling - lowerRangeFloor + 1;

                if (lowerRangeItemsCount > distinctPossibleIntegersInLowerRange)
                {
                    floor = lowerRangeFloor;
                    ceiling = lowerRangeCeiling;
                }
                else
                {
                    floor = upperRangeFloor;
                    ceiling = upperRangeCeiling;
                }
            }

            return floor;
        }
    }
}
