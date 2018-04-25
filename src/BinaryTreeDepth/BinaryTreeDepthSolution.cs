using BinaryTree;
using System;
using System.Collections.Generic;

namespace BinaryTreeDepth
{
    public class BinaryTreeDepthSolution
    {
        public int FindMaxDepth(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int leftMaxDepth = FindMaxDepth(root.Left);
            int rightMaxDepth = FindMaxDepth(root.Right);

            return Math.Max(leftMaxDepth, rightMaxDepth) + 1;
        }

        public int FindMinDepth(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            int minDepth = 1;
            var queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    BinaryTreeNode current = queue.Dequeue();
                    if (current.Left == null && current.Right == null)
                    {
                        return minDepth;
                    }

                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                    }

                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                    }
                }

                minDepth++;
            }

            return minDepth;
        }
    }
}
