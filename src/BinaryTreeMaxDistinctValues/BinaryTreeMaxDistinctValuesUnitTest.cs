using BinaryTree;
using Xunit;

namespace BinaryTreeMaxDistinctValues
{
    public class BinaryTreeMaxDistinctValuesUnitTest
    {
        [Fact]
        public void FindMaxDistinctValuesOnNullTreeTest()
        {
            var solution = new BinaryTreeMaxDistinctValuesSolution();
            int maxDistinctValues = solution.FindMaxDistinctValues(null);

            Assert.Equal(0, maxDistinctValues);
        }

        [Fact]
        public void FindMaxDistinctValuesOnRootOnlyTest()
        {
            var bt = new BinaryTree.BinaryTree
            {
                Root = new BinaryTreeNode(3)
            };

            var solution = new BinaryTreeMaxDistinctValuesSolution();
            int maxDistinctValues = solution.FindMaxDistinctValues(bt);

            Assert.Equal(1, maxDistinctValues);
        }

        [Fact]
        public void FindMaxDistinctValuesTest()
        {
            var bt = new BinaryTree.BinaryTree
            {
                Root = new BinaryTreeNode(4)
                {
                    Left = new BinaryTreeNode(6)
                    {
                        Left = new BinaryTreeNode(6)
                        {
                            Left = new BinaryTreeNode(4),
                            Right = new BinaryTreeNode(3)
                        }
                    },
                    Right = new BinaryTreeNode(2)
                    {
                        Left = new BinaryTreeNode(2)
                        {
                            Right = new BinaryTreeNode(5)
                            {
                                Left = new BinaryTreeNode(1)
                            }
                        },
                        Right = new BinaryTreeNode(1)
                    }
                }
            };

            var solution = new BinaryTreeMaxDistinctValuesSolution();
            int maxDistinctValues = solution.FindMaxDistinctValues(bt);

            Assert.Equal(4, maxDistinctValues);
        }
    }
}
