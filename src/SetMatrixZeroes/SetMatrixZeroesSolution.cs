using System;

namespace SetMatrixZeroes
{
    // Given a M x N matrix, if an element is 0, set its entire row and column to 0.
    // Do it in place.
    // You should use constant space.
    public class SetMatrixZeroesSolution
    {
        public void SetZeroes(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            bool hasFirstRowZero = false;
            bool hasFirstColumnZero = false;

            // Check if the first row contains any zero
            for (int i = 0; i < cols; i++)
            {
                if (matrix[0][i] == 0)
                {
                    hasFirstRowZero = true;
                    break;
                }
            }

            // Check if the first column contains any zero
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i][0] == 0)
                {
                    hasFirstColumnZero = true;
                    break;
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        // We will use first row and column to keep track of zeroes
                        matrix[0][j] = 0;
                        matrix[i][0] = 0;
                    }
                }
            }

            // Make zero every element that is on a zero row or zero column
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[0][i] == 0 || matrix[j][0] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }

            if (hasFirstRowZero)
            {
                // Make all the first row zero
                for (int i = 0; i < cols; i++)
                {
                    matrix[0][i] = 0;
                }
            }

            if (hasFirstColumnZero)
            {
                // Make all the first column to zero
                for (int i = 0; i < rows; i++)
                {
                    matrix[i][0] = 0;
                }
            }
        }

        public void DisplayMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
