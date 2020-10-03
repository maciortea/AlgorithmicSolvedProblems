using System.Collections.Generic;
using Xunit;

namespace SortAlgorithms
{
    public class UnitTest
    {
        private readonly List<ISort> sortAlgorithms = new List<ISort> { new BubbleSort(), new QuickSort() };

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
