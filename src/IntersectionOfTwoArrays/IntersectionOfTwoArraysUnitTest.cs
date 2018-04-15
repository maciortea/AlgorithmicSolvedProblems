using Xunit;

namespace IntersectionOfTwoArrays
{
    // Given two sorted arrays arr1 and arr2 of passport numbers, implement a method FindIntersection(arr1, arr2)
    // that returns an array of all passport numbers that are both in arr1 and arr2.
    // Note that the output array should be sorted in an ascending order.
    // Let N and M be the lengths of arr1 and arr2, respectively.
    // Solve for two cases and analyze the time & space complexities of your solutions:
    // 1. M ~ N - the array lengths are approximately the same
    // 2. M > N - arr2 is much bigger than arr1
    public class IntersectionOfTwoArraysUnitTest
    {
        [Fact]
        public void SolutionWithHashSetTest()
        {
            int[] arr1 = new int[] { 5, 6, 10 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var solutionWithHashSet = new SolutionWithHashSet();
            int[] result = solutionWithHashSet.FindIntersection(arr1, arr2);

            Assert.Equal(new int[] { 5, 6 }, result);
        }

        [Fact]
        public void SolutionWithNoExtraSpaceTest()
        {
            int[] arr1 = new int[] { 5, 6, 10 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var solutionWithNoExtraSpace = new SolutionWithNoExtraSpace();
            int[] result = solutionWithNoExtraSpace.FindIntersection(arr1, arr2);

            Assert.Equal(new int[] { 5, 6 }, result);
        }

        [Fact]
        public void SolutionWithBinarySearchTest()
        {
            int[] arr1 = new int[] { 5, 6, 10 };
            int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var solutionWithBinarySearch = new SolutionWithBinarySearch();
            int[] result = solutionWithBinarySearch.FindIntersection(arr1, arr2);

            Assert.Equal(new int[] { 5, 6 }, result);
        }
    }
}
