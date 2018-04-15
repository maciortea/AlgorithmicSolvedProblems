using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };
            var solution = new RotateArraySolution();
            int[] rotatedArr = solution.RotateArray(arr, 5);

            foreach (var item in rotatedArr)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadLine();
        }
    }
}
