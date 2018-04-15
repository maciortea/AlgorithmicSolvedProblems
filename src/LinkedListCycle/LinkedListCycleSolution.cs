using ListCore;
using System.Collections.Generic;

namespace LinkedListCycle
{
    // Given a linked list, return the node where the cycle begins.
    // If there is no cycle return null. Do not modify the linked list.
    public class LinkedListCycleSolution
    {
        public Node<T> DetectCycle<T>(ListCore.LinkedList<T> list)
        {
            if (list.Head == null)
            {
                return null;
            }

            Node<T> fast = list.Head;
            Node<T> slow = list.Head;

            while (fast != null)
            {
                fast = fast.Next;
                if (fast == null)
                {
                    return null;
                }

                fast = fast.Next;
                if (fast == null)
                {
                    return null;
                }

                slow = slow.Next;

                if (fast == slow)
                {
                    Node<T> node1 = list.Head;
                    Node<T> node2 = fast;

                    while (node1 != node2)
                    {
                        node1 = node1.Next;
                        node2 = node2.Next;
                    }

                    return node2;
                }
            }

            return null;
        }

        public Node<T> DetectCycle2<T>(ListCore.LinkedList<T> list)
        {
            var visited = new HashSet<Node<T>>();

            Node<T> node = list.Head;
            while (node != null)
            {
                if (!visited.Add(node))
                {
                    node = node.Next;
                }
                else
                {
                    return node;
                }
            }

            return null;
        }
    }
}
