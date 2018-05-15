using System.Collections.Generic;
using Xunit;

namespace MinSalesPath
{
    public class MinSalesPathUnitTest
    {
        [Fact]
        public void GetCheapestCostTest()
        {
            var root = CreateSampleTree();

            var solution = new MinSalesPathSolution();
            int minCost = solution.GetCheapestCost(root);

            Assert.Equal(4, minCost);
        }

        [Fact]
        public void GetCheapestCostIterativelyTest()
        {
            var root = CreateSampleTree();

            var solution = new MinSalesPathSolution();
            int minCost = solution.GetCheapestCostIteratively(root);

            Assert.Equal(4, minCost);
        }

        [Fact]
        public void GetCheapestCostForRootOnlyTreeTest()
        {
            var root = new Node(2);

            var solution = new MinSalesPathSolution();
            int minCost = solution.GetCheapestCost(root);

            Assert.Equal(2, minCost);
        }

        [Fact]
        public void GetCheapestCostIterativelyForRootOnlyTreeTest()
        {
            var root = new Node(2);

            var solution = new MinSalesPathSolution();
            int minCost = solution.GetCheapestCostIteratively(root);

            Assert.Equal(2, minCost);
        }

        private Node CreateSampleTree()
        {
            var root = new Node(0);

            var child1 = new Node(5, root);
            var childrenOfChild1 = new List<Node> { new Node(2, child1), new Node(1, child1) };
            child1.AddChildren(childrenOfChild1);

            var child2 = new Node(3, root);
            var childrenOfChild2 = new List<Node> { new Node(2, child2), new Node(1, child2) };
            child2.AddChildren(childrenOfChild2);

            var child3 = new Node(6, root);
            var childrenOfChild3 = new List<Node> { new Node(1, child3), new Node(5, child3) };
            child3.AddChildren(childrenOfChild3);

            root.AddChildren(new List<Node> { child1, child2, child3 });

            return root;
        }
    }
}
