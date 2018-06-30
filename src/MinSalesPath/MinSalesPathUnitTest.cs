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
            int minCost = solution.GetCheapestCostRecursive(root);

            Assert.Equal(4, minCost);
        }

        [Fact]
        public void GetCheapestCostIterativelyTest()
        {
            var root = CreateSampleTree();

            var solution = new MinSalesPathSolution();
            int minCost = solution.GetCheapestCostIterative(root);

            Assert.Equal(4, minCost);
        }

        [Fact]
        public void GetCheapestCostForRootOnlyTreeTest()
        {
            var root = new SalesNode(2);

            var solution = new MinSalesPathSolution();
            int minCost = solution.GetCheapestCostRecursive(root);

            Assert.Equal(2, minCost);
        }

        [Fact]
        public void GetCheapestCostIterativelyForRootOnlyTreeTest()
        {
            var root = new SalesNode(2);

            var solution = new MinSalesPathSolution();
            int minCost = solution.GetCheapestCostIterative(root);

            Assert.Equal(2, minCost);
        }

        private SalesNode CreateSampleTree()
        {
            var root = new SalesNode(0);

            var child1 = new SalesNode(5);
            child1.Children.Add(new SalesNode(2));
            child1.Children.Add(new SalesNode(1));

            var child2 = new SalesNode(3);
            child2.Children.Add(new SalesNode(2));
            child2.Children.Add(new SalesNode(1));

            var child3 = new SalesNode(6);
            child3.Children.Add(new SalesNode(1));
            child3.Children.Add(new SalesNode(5));

            root.Children.Add(child1);
            root.Children.Add(child2);
            root.Children.Add(child3);

            return root;
        }
    }
}
