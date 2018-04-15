using System;

namespace AllSubsetsOfASet
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new AllSubsetsOfASetSolution();
            solution.AllSubsets(new int[] { 1, 2, 3 });
            Console.ReadLine();
        }
    }
}
