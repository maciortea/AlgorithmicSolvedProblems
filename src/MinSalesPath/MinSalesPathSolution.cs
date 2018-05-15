using System.Collections.Generic;
using System.Linq;

namespace MinSalesPath
{
    public class MinSalesPathSolution
    {
        public int GetCheapestCost(Node root)
        {
            if (root.Children.Count <= 0)
            {
                return root.Cost;
            }

            int minCost = int.MaxValue;
            foreach (var child in root.Children)
            {
                int tempCost = GetCheapestCost(child);
                if (tempCost < minCost)
                {
                    minCost = tempCost;
                }
            }

            return root.Cost + minCost;
        }

        public int GetCheapestCostIteratively(Node root)
        {
            var costs = new List<int>();
            var stack = new Stack<Node>();
            stack.Push(root);

            int sum = 0;
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                if (node.Parent == null)
                {
                    sum += node.Cost;
                }
                else
                {
                    sum += node.Cost + node.Parent.Cost;
                }

                if (node.Children.Count <= 0)
                {
                    costs.Add(sum);
                    sum = 0;
                }
                else
                {
                    for (int i = node.Children.Count - 1; i >= 0; i--)
                    {
                        stack.Push(node.Children[i]);
                    }
                }
            }

            return costs.Min();
        }
    }
}
