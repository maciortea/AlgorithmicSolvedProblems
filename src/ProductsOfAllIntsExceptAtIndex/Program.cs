using System;

namespace ProductsOfAllIntsExceptAtIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 8 };
            var solution = new ProductsOfAllIntsExceptAtIndexSolution();
            int[] resultedArray = solution.GetProductsOfAllIntsExceptAtIndex(intArray);

            foreach (var item in resultedArray)
            {
                Console.Write("{0} ", item);
            }

            Console.ReadLine();
        }
    }
}
