using System;
using System.Collections.Generic;
using BinaryTree;

namespace BinaryTreeTraversals
{
    public class PostOrderTreeTraversal : ITreeTraversal
    {
        public void Traverse(BinaryTreeNode root, Action<int> processNode)
        {
            if (root == null)
            {
                return;
            }

            Traverse(root.Left, processNode);
            Traverse(root.Right, processNode);
            processNode(root.Data);
        }

        public void TraverseNonRecursive(BinaryTreeNode root, Action<int> processNode)
        {
            if (root == null)
            {
                return;
            }

            var leftStack = new Stack<BinaryTreeNode>();
            var rightStack = new Stack<BinaryTreeNode>();
            leftStack.Push(root);

            while (leftStack.Count > 0)
            {
                BinaryTreeNode node = leftStack.Pop();
                rightStack.Push(node);

                if (node.Left != null)
                {
                    leftStack.Push(node.Left);
                }

                if (node.Right != null)
                {
                    leftStack.Push(node.Right);
                }
            }

            while (rightStack.Count > 0)
            {
                BinaryTreeNode node = rightStack.Pop();
                processNode(node.Data);
            }
        }
    }
}
