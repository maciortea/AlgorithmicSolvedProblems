using BinaryTree;
using System.Collections.Generic;

namespace BinarySearchTreeIterator
{
    // Implement an iterator over binary search tree. Your iterator will be initialized with the root node of BST.
    // Calling Next() will return next smallest number in BST.
    public class BSTIterator
    {
        private Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

        public BSTIterator(BinaryTreeNode root)
        {
            PushAllLeft(root);
        }

        public bool HasNext()
        {
            return stack.Count > 0;
        }

        public int GetNext()
        {
            BinaryTreeNode nextSmallest = stack.Pop();
            PushAllLeft(nextSmallest.Right);

            return nextSmallest.Data;
        }

        private void PushAllLeft(BinaryTreeNode node)
        {
            while (node != null)
            {
                stack.Push(node);
                node = node.Left;
            }
        }
    }
}
