using System;

namespace MergingTwoPackages
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 4, 6, 10, 15, 16 };
            var solution = new MergingTwoPackagesSolution();
            var output = solution.GetIndicesOfItemWeights(input, 21);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
