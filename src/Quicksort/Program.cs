using System;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 3, 6, 7, 1, 4, 2 };

            var quicksort = new Quicksort();
            quicksort.Sort(arr);

            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }
    }
}
