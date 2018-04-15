using System;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new PermutationsSolution();
            var res = solution.Permute(new int[] { 1, 2, 3 });

            foreach (var item in res)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write("{0} ", item[i]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
