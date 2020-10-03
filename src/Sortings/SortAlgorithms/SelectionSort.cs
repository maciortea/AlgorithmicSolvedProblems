using Helpers;

namespace SortAlgorithms
{
    public class SelectionSort : ISort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = arr[i];
                int minPos = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minPos = j;
                    }
                }

                if (i != minPos)
                {
                    ArrayUtils.Swap(arr, i, minPos);
                }
            }
        }
    }
}
