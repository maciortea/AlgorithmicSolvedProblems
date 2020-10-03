using System.Collections.Generic;
using Xunit;

namespace SortAlgorithms
{
    public class UnitTest
    {
        private readonly List<ISort> sortAlgorithms = new List<ISort> { new BubbleSort(), new QuickSort(), new SelectionSort() };

        [Fact]
        public void UnsortedArray()
        {
            foreach (ISort sortAlgorithm in sortAlgorithms)
            {
                int[] arr = { 4, 9, 8, 3, 5, 1, 2 };

                sortAlgorithm.Sort(arr);

                int[] expected = { 1, 2, 3, 4, 5, 8, 9 };
                Assert.Equal(arr, expected);
            }
        }

        [Fact]
        public void UnsortedArrayWithDuplicates()
        {
            foreach (ISort sortAlgorithm in sortAlgorithms)
            {
                int[] arr = { 7, 6, 6, 1, 2, 4, 5, 1, 7, 3, 1 };

                sortAlgorithm.Sort(arr);

                int[] expected = { 1, 1, 1, 2, 3, 4, 5, 6, 6, 7, 7 };
                Assert.Equal(arr, expected);
            }
        }

        [Fact]
        public void EmptyArray()
        {
            foreach (ISort sortAlgorithm in sortAlgorithms)
            {
                int[] arr = new int[0];

                sortAlgorithm.Sort(arr);

                int[] expected = new int[0];
                Assert.Equal(arr, expected);
            }
        }

        [Fact]
        public void OneItemArray()
        {
            foreach (ISort sortAlgorithm in sortAlgorithms)
            {
                int[] arr = { 1 };

                sortAlgorithm.Sort(arr);

                int[] expected = { 1 };
                Assert.Equal(arr, expected);
            }
        }

        [Fact]
        public void AlreadySortedArray()
        {
            foreach (ISort sortAlgorithm in sortAlgorithms)
            {
                int[] arr = { 1, 2, 3, 4 };

                sortAlgorithm.Sort(arr);

                int[] expected = { 1, 2, 3, 4 };
                Assert.Equal(arr, expected);
            }
        }
    }
}
