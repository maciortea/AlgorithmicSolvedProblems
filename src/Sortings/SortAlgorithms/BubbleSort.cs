using Helpers;

namespace SortAlgorithms
{
    public class BubbleSort : ISort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        ArrayUtils.Swap(arr, j, j - 1);
                    }
                }
            }
        }
    }
}
