using BinaryTree;
using System;

namespace BinarySearchTreeIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var bt = new BinaryTree.BinaryTree
            {
                Root = new BinaryTreeNode(4)
            };
            bt.Root.Left = new BinaryTreeNode(2)
            {
                Left = new BinaryTreeNode(1),
                Right = new BinaryTreeNode(3)
            };
            bt.Root.Right = new BinaryTreeNode(6)
            {
                Left = new BinaryTreeNode(5),
                Right = new BinaryTreeNode(7)
            };

            var bstIterator = new BSTIterator(bt.Root);
            while (bstIterator.HasNext())
            {
                int data = bstIterator.GetNext();
                Console.WriteLine(data);
            }

            Console.ReadLine();
        }
    }
}
