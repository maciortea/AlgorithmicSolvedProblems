using System.Collections.Generic;

namespace CheckContainsDuplicates
{
    public class CheckContainsDuplicatesSolution
    {
        public bool HasDuplicate(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return false;
            }

            var set = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!set.Add(arr[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
