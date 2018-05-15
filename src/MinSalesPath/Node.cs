using System.Collections.Generic;

namespace MinSalesPath
{
    public class Node
    {
        private List<Node> _children;

        public int Cost { get; }
        public IReadOnlyList<Node> Children { get { return _children; } }
        public Node Parent { get; }

        public Node(int cost)
        {
            Cost = cost;
            _children = new List<Node>();
        }

        public Node(int cost, Node parent) : this(cost)
        {
            Parent = parent;
        }

        public void AddChildren(List<Node> children)
        {
            _children = children;
        }
    }
}
