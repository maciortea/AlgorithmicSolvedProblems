using System.Collections.Generic;

namespace Permutations
{
    // Given a collection of numbers, return all possible permutations.
    // For example, [1,2,3] have the following permutations:
    // [1,2,3], [1,3,2], [2,1,3], [2,3,1], [3,1,2], [3,2,1]
    public class PermutationsSolution
    {
        public List<List<int>> Permute(int[] nums)
        {
            var res = new List<List<int>>();

            if (nums == null || nums.Length == 0)
            {
                return res;
            }

            var record = new List<int>();
            var visited = new HashSet<int>();

            RecPermute(nums, res, record, visited);

            return res;
        }

        private void RecPermute(int[] nums, List<List<int>> res, List<int> record, HashSet<int> visited)
        {
            if (record.Count == nums.Length)
            {
                var temp = new List<int>();
                temp.AddRange(record);
                res.Add(temp);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited.Contains(nums[i]))
                {
                    continue;
                }

                record.Add(nums[i]);
                visited.Add(nums[i]);

                RecPermute(nums, res, record, visited);

                visited.Remove(record[record.Count - 1]);
                record.Remove(record.Count - 1);
            }
        }
    }
}
