using BinaryTree;
using System;
using System.Collections.Generic;

namespace BinaryTreeTraversals
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

            var traversals = new Dictionary<string, ITreeTraversal>
            {
                { "Pre-order traversal", new PreOrderTreeTraversal() },
                { "In-order traversal", new InOrderTreeTraversal() }
            };

            foreach (var traversal in traversals)
            {
                Console.WriteLine($"{traversal.Key} recursive");
                traversal.Value.Traverse(bt.Root);

                Console.WriteLine($"{traversal.Key} non-recursive");
                foreach (var elem in traversal.Value.TraverseNonRecursive(bt.Root))
                {
                    Console.WriteLine(elem);
                }
            }

            Console.ReadLine();
        }
    }
}
