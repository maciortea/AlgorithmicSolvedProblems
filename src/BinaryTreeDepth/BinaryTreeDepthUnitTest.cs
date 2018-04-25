using BinaryTree;
using Xunit;

namespace BinaryTreeDepth
{
    public class BinaryTreeDepthUnitTest
    {
        [Fact]
        public void FindMaxDepthTest1()
        {
            var solution = new BinaryTreeDepthSolution();
            int maxDepth = solution.FindMaxDepth(null);

            Assert.Equal(0, maxDepth);
        }

        [Fact]
        public void FindMaxDepthTest2()
        {
            var bt = new BinaryTree.BinaryTree
            {
                Root = new BinaryTreeNode(4)
            };

            var solution = new BinaryTreeDepthSolution();
            int maxDepth = solution.FindMaxDepth(bt.Root);

            Assert.Equal(1, maxDepth);
        }

        [Fact]
        public void FindMaxDepthTest3()
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
            bt.Root.Right = new BinaryTreeNode(6);

            var solution = new BinaryTreeDepthSolution();
            int maxDepth = solution.FindMaxDepth(bt.Root);

            Assert.Equal(3, maxDepth);
        }

        [Fact]
        public void FindMinDepthTest1()
        {
            var solution = new BinaryTreeDepthSolution();
            int minDepth = solution.FindMinDepth(null);

            Assert.Equal(0, minDepth);
        }

        [Fact]
        public void FindMinDepthTest2()
        {
            var bt = new BinaryTree.BinaryTree
            {
                Root = new BinaryTreeNode(4)
            };

            var solution = new BinaryTreeDepthSolution();
            int minDepth = solution.FindMinDepth(bt.Root);

            Assert.Equal(1, minDepth);
        }

        [Fact]
        public void FindMinDepthTest3()
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
            bt.Root.Right = new BinaryTreeNode(6);

            var solution = new BinaryTreeDepthSolution();
            int minDepth = solution.FindMinDepth(bt.Root);

            Assert.Equal(2, minDepth);
        }
    }
}
