using System;
using System.Collections.Generic;

namespace MinSalesPath
{
    public class MinSalesPathSolution
    {
        public int GetCheapestCostRecursive(SalesNode root)
        {
            if (root.Children.Count <= 0)
            {
                return root.Cost;
            }

            int minCost = int.MaxValue;
            foreach (var child in root.Children)
            {
                int tempCost = GetCheapestCostRecursive(child);
                if (tempCost < minCost)
                {
                    minCost = tempCost;
                }
            }

            return root.Cost + minCost;
        }

        public int GetCheapestCostIterative(SalesNode root)
        {
            if (root.Children.Count <= 0)
            {
                return root.Cost;
            }

            // We are going to save the node and the cost so far
            var stack = new Stack<KeyValuePair<SalesNode, int>>();
            stack.Push(KeyValuePair.Create(root, root.Cost));

            int cheapestCost = int.MaxValue;
            while (stack.Count > 0)
            {
                KeyValuePair<SalesNode, int> nodeParentCostPair = stack.Pop();
                int costToParent = nodeParentCostPair.Value;
                int currentNodeCost = nodeParentCostPair.Key.Cost;
                int currentCost = costToParent + currentNodeCost;

                if (nodeParentCostPair.Key.Children.Count <= 0)
                {
                    cheapestCost = Math.Min(cheapestCost, currentCost);
                }
                else
                {
                    foreach (SalesNode child in nodeParentCostPair.Key.Children)
                    {
                        // Push to stack current children and the cost so far
                        stack.Push(KeyValuePair.Create(child, currentCost));
                    }
                }
            }

            return cheapestCost;
        }
    }
}
