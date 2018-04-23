using BinaryTree;
using System;
using System.Collections.Generic;

namespace BinaryTreeTraversals
{
    public class PreOrderTreeTraversal : ITreeTraversal
    {
        public void Traverse(BinaryTreeNode root, Action<int> processNode)
        {
            if (root == null)
            {
                return;
            }

            processNode(root.Data);
            Traverse(root.Left, processNode);
            Traverse(root.Right, processNode);
        }

        public void TraverseNonRecursive(BinaryTreeNode root, Action<int> processNode)
        {
            if (root == null)
            {
                return;
            }

            var stack = new Stack<BinaryTreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                BinaryTreeNode node = stack.Pop();
                processNode(node.Data);

                if (node.Right != null)
                {
                    stack.Push(node.Right);
                }

                if (node.Left != null)
                {
                    stack.Push(node.Left);
                }
            }
        }
    }
}
