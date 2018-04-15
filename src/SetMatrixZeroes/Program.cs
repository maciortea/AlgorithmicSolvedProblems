using System;

namespace SetMatrixZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];
            matrix[0] = new int[] { 1, 1, 1, 1, 1 };
            matrix[1] = new int[] { 1, 0, 1, 1, 1 };
            matrix[2] = new int[] { 1, 1, 1, 1, 1 };
            matrix[3] = new int[] { 1, 1, 1, 0, 1 };
            matrix[4] = new int[] { 1, 1, 1, 1, 1 };

            var solution = new SetMatrixZeroesSolution();
            solution.SetZeroes(matrix);
            solution.DisplayMatrix(matrix);
            
            Console.ReadLine();
        }
    }
}
