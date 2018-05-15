using BinaryTree;
using System.Collections.Generic;
using System;

namespace BinaryTreeMaxDistinctValues
{
    // Find maximum distinct values in a binary tree path.
    public class BinaryTreeMaxDistinctValuesSolution
    {
        public int FindMaxDistinctValues(BinaryTree.BinaryTree tree)
        {
            if (tree == null || tree.Root == null)
            {
                return 0;
            }

            var distinctValues = new Dictionary<int, int>();
            return GetMaxDistinctValuesCount(tree.Root, distinctValues);
        }

        private int GetMaxDistinctValuesCount(BinaryTreeNode root, Dictionary<int, int> distinctValues)
        {
            if (root == null)
            {
                return distinctValues.Count;
            }

            if (!distinctValues.ContainsKey(root.Data))
            {
                distinctValues[root.Data] = 1;
            }
            else
            {
                distinctValues[root.Data]++;
            }

            int max = Math.Max(
                GetMaxDistinctValuesCount(root.Left, distinctValues),
                GetMaxDistinctValuesCount(root.Right, distinctValues));

            distinctValues[root.Data]--;

            if (distinctValues[root.Data] == 0)
            {
                distinctValues.Remove(root.Data);
            }

            return max;
        }
    }
}
