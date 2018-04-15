using System;

namespace AllSubsetsOfASet
{
    public class AllSubsetsOfASetSolution
    {
        public void AllSubsets(int[] arr)
        {
            int?[] subset = new int?[arr.Length];
            Helper(arr, subset, 0);
        }

        private void Helper(int[] arr, int?[] subset, int index)
        {
            if (index == arr.Length)
            {
                PrintSubset(subset);
            }
            else
            {
                subset[index] = null;
                Helper(arr, subset, index + 1);
                subset[index] = arr[index];
                Helper(arr, subset, index + 1);
            }
        }

        private void PrintSubset(int?[] subset)
        {
            foreach (var item in subset)
            {
                if (item != null)
                {
                    Console.Write($"{item}, ");
                }
            }
            Console.WriteLine();
        }
    }
}
