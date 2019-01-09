using System;

namespace RotateArray
{
    public class RotateArraySolution
    {
        public int[] RotateArray(int[] arr, int k)
        {
            int[] rotatedArr = new int[arr.Length];

            k = k % arr.Length;

            int sourceIndex = arr.Length - k;
            Array.Copy(arr, sourceIndex, rotatedArr, 0, k);

            int length = arr.Length - k;
            Array.Copy(arr, 0, rotatedArr, k, length);

            return rotatedArr;
        }
    }
}
