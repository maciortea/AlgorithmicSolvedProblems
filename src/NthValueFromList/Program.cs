using ListCore;
using System;

namespace NthValueFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            var solution = new NthValueFromListSolution();
            int n = solution.GetNthNodeFromTail(list.Head, 4);
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
