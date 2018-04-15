using ListCore;
using System;

namespace IntersectionOfTwoLinkedLists
{
    // Find the node at which the intersection of two linked lists begins.
    class Program
    {
        static void Main(string[] args)
        {
            var common = new LinkedList<string>();
            common.Add("c1");
            common.Add("c2");
            common.Add("c3");
            var list1 = new LinkedList<string>();
            list1.Add("a1");
            list1.Add("a2");
            list1.Tail.Next = common.Head;
            var list2 = new LinkedList<string>();
            list2.Add("b1");
            list2.Add("b2");
            list2.Add("b3");
            list2.Tail.Next = common.Head;

            var intersection = new LinkedList<string>();
            var solution = new IntersectionOfTwoLinkedListsSolution();
            intersection.Head = solution.GetIntersectionNode<string>(list1, list2);

            intersection.Display();

            Console.ReadLine();
        }
    }
}
