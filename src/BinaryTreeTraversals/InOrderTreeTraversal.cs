using System;
using System.Collections.Generic;
using BinaryTree;

namespace BinaryTreeTraversals
{
    public class InOrderTreeTraversal : ITreeTraversal
    {
        public void Traverse(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.Left);
            Console.WriteLine(root.Data);
            Traverse(root.Right);
        }

        public List<int> TraverseNonRecursive(BinaryTreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<BinaryTreeNode>();
            BinaryTreeNode next = root;

            while (next != null || stack.Count > 0)
            {
                while (next != null)
                {
                    stack.Push(next);
                    next = next.Left;
                }

                BinaryTreeNode node = stack.Pop();
                result.Add(node.Data);
                next = node.Right;
            }

            return result;
        }
    }
}
