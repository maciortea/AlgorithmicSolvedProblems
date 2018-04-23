using System;
using System.Collections.Generic;
using BinaryTree;

namespace BinaryTreeTraversals
{
    public class InOrderTreeTraversal : ITreeTraversal
    {
        public void Traverse(BinaryTreeNode root, Action<int> processNode)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.Left, processNode);
            processNode(root.Data);
            Traverse(root.Right, processNode);
        }

        public void TraverseNonRecursive(BinaryTreeNode root, Action<int> processNode)
        {
            var stack = new Stack<BinaryTreeNode>();
            BinaryTreeNode current = root;

            while (current != null || stack.Count > 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.Left;
                }

                BinaryTreeNode node = stack.Pop();
                processNode(node.Data);
                current = node.Right;
            }
        }
    }
}
