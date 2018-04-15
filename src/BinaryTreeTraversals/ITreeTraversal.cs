using BinaryTree;
using System.Collections.Generic;

namespace BinaryTreeTraversals
{
    public interface ITreeTraversal
    {
        void Traverse(BinaryTreeNode root);
        List<int> TraverseNonRecursive(BinaryTreeNode root);
    }
}
