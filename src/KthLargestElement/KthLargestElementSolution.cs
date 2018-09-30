namespace KthLargestElement
{
    public class KthLargestElementSolution
    {
        public int FindKthLargestElement(int[] arr, int k)
        {
            return QuickSelect(arr, k, 0, arr.Length - 1);
        }

        private int QuickSelect(int[] arr, int k, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex)
            {
                return arr[leftIndex];
            }

            int partitionIndex = Partition(arr, leftIndex, rightIndex);
            if (partitionIndex == k - 1)
            {
                return arr[partitionIndex];
            }

            if (partitionIndex < k - 1)
            {
                return QuickSelect(arr, k, partitionIndex + 1, rightIndex);
            }
            return QuickSelect(arr, k, leftIndex, partitionIndex - 1);
        }

        private int Partition(int[] arr, int leftIndex, int rightIndex)
        {
            int pivot = leftIndex++;

            while (leftIndex <= rightIndex)
            {
                while (leftIndex <= rightIndex && arr[leftIndex] > arr[pivot])
                {
                    leftIndex++;
                }

                while (leftIndex <= rightIndex && arr[rightIndex] <= arr[pivot])
                {
                    rightIndex--;
                }

                if (leftIndex > rightIndex)
                {
                    break;
                }

                Swap(arr, leftIndex, rightIndex);
            }

            Swap(arr, rightIndex, pivot);

            return rightIndex;
        }

        private void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}
