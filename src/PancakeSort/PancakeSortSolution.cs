namespace PancakeSort
{
    // Pancake Sort
    // Given an array of integers arr:
    // 1. Write a function flip(arr, k) that reverses the order of the first k elements in the array arr.
    // 2. Write a function pancakeSort(arr) that sorts and returns the input array.
    // You are allowed to use only the function flip you wrote in the first step in order to make changes in the array.
    // Analyze the time and space complexities of your solution.
    // Note: it’s called pancake sort because it resembles sorting pancakes on a plate with a spatula,
    // where you can only use the spatula to flip some of the top pancakes in the plate.
    public class PancakeSortSolution
    {
        public int[] PancakeSort(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int maxIndex = GetMaxIndex(arr, i);
                Flip(arr, maxIndex + 1);
                Flip(arr, i + 1);
            }
            return arr;
        }

        private void Flip(int[] arr, int k)
        {
            int j = k - 1;
            for (int i = 0; i < k / 2; i++)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j--;
            }
        }

        private int GetMaxIndex(int[] arr, int k)
        {
            int maxIndex = 0;
            for (int i = 0; i <= k; i++)
            {
                if (arr[i] > arr[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
