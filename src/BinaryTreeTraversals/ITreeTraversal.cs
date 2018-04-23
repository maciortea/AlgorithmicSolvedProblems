using BinaryTree;
using System;
using System.Collections.Generic;

namespace BinaryTreeTraversals
{
    public interface ITreeTraversal
    {
        void Traverse(BinaryTreeNode root, Action<int> processNode);
        void TraverseNonRecursive(BinaryTreeNode root, Action<int> processNode);
    }
}
