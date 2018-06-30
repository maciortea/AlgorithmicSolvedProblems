namespace Quicksort
{
    public class Quicksort
    {
        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private void Sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int midIndex = (left + right) / 2;
            int pivot = arr[midIndex];
            int index = Partition(arr, left, right, pivot);
            Sort(arr, left, index - 1);
            Sort(arr, index, right);
        }

        private int Partition(int[] arr, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    Swap(arr, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }

        private void Swap(int[] arr, int left, int right)
        {
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;
        }
    }
}
