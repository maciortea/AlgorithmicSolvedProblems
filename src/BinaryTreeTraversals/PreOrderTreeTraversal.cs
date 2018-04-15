using BinaryTree;
using System;
using System.Collections.Generic;

namespace BinaryTreeTraversals
{
    public class PreOrderTreeTraversal : ITreeTraversal
    {
        public void Traverse(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.Data);
            Traverse(root.Left);
            Traverse(root.Right);
        }

        public List<int> TraverseNonRecursive(BinaryTreeNode root)
        {
            var result = new List<int>();

            if (root == null)
            {
                return result;
            }

            var stack = new Stack<BinaryTreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                BinaryTreeNode node = stack.Pop();
                result.Add(node.Data);

                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }

            return result;
        }
    }
}
