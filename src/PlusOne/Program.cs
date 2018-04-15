using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = { 2, 1, 3, 9 };
            var solution = new PlusOneSolution();
            int[] result = solution.PlusOne(digits);
            Console.ReadLine();
        }
    }
}
