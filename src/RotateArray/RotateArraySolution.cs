using System;

namespace RotateArray
{
    public class RotateArraySolution
    {
        public int[] RotateArray(int[] arr, int k)
        {
            // If k = 0, array is empty or contains one element or k is equal to length of the array
            // we don't need to rotate the array and we simply return it.
            if (k == 0 || arr.Length <= 1 || k == arr.Length)
            {
                return arr;
            }

            // If k is higher than length of the array then we calculate the actual number
            // of positions to rotate the array.
            // e.g: if array length is 4 and k = 5 then we basically need to rotate the array one time.
            if (k > arr.Length)
            {
                k = k % arr.Length;
            }

            int length = arr.Length - k;

            var arr1 = new int[length];
            Array.Copy(arr, arr1, length);
            Array.Reverse(arr1);

            var arr2 = new int[k];
            Array.Copy(arr, length, arr2, 0, k);
            Array.Reverse(arr2);

            var resultedAr = new int[arr.Length];
            Array.Copy(arr1, resultedAr, arr1.Length);
            Array.Copy(arr2, 0, resultedAr, arr1.Length, arr2.Length);
            Array.Reverse(resultedAr);

            return resultedAr;
        }
    }
}
