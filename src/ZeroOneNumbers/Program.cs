using System;

namespace ZeroOneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] binaryNumbers = new int[] { 1, 0 };

            var solution = new ZeroOneNumbersSolution();
            var result = solution.Combine(binaryNumbers, 2);

            foreach (var list in result)
            {
                foreach (var item in list)
                {
                    Console.Write("{0} ", item);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
