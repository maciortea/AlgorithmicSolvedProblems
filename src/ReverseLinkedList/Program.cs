using ListCore;
using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<string>();
            list.Add("apple");
            list.Add("orange");
            list.Add("lime");

            var solution = new ReverseLinkedListSolution();
            solution.ReverseList(list);

            list.Display();

            Console.ReadLine();
        }
    }
}
