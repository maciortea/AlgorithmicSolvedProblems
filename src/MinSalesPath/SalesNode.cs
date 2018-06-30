using System.Collections.Generic;

namespace MinSalesPath
{
    public class SalesNode
    {
        public int Cost { get; set; }
        public List<SalesNode> Children { get; set; }

        public SalesNode(int cost)
        {
            Cost = cost;
            Children = new List<SalesNode>();
        }
    }
}
