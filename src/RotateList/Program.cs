using ListCore;
using System;

namespace RotateList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            var solution = new RotateListSolution();
            solution.RotateRight(list, 2);
            list.Display();

            Console.ReadLine();
        }
    }
}
