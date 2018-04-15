using ListCore;
using System;

namespace LinkedListCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<string>();
            list.Add("one");
            list.Add("two");
            list.Add("three");
            list.Add("four");
            list.Add("five");
            list.Add("six");
            list.Add("seven");

            // Make the cycle
            list.Tail.Next = list.Head.Next.Next;

            var solution = new LinkedListCycleSolution();
            var cycleEntry = solution.DetectCycle(list);
            Console.WriteLine(cycleEntry.Data);
            Console.ReadLine();
        }
    }
}
