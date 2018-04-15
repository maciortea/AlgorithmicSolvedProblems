using System;
using System.Linq;
using Xunit;

namespace PermArray
{
    public class PermArrayUnitTest
    {
        [Fact]
        public void SimpleArray_IsPermutation()
        {
            int[] arr = { 4, 1, 3, 2 };

            var solution = new PermArraySolution();
            int isPermutation = solution.IsPermutation(arr);

            Assert.True(isPermutation == 1);
        }

        [Fact]
        public void SimpleArray_IsNotPermutation()
        {
            int[] arr = { 4, 1, 3 };

            var solution = new PermArraySolution();
            int isPermutation = solution.IsPermutation(arr);

            Assert.True(isPermutation == 0);
        }

        [Fact]
        public void SingleElement_IsPermutation()
        {
            int[] arr = { 1 };

            var solution = new PermArraySolution();
            int isPermutation = solution.IsPermutation(arr);

            Assert.True(isPermutation == 1);
        }

        [Fact]
        public void SingleElement_IsNotPermutation()
        {
            int[] arr = { 2 };

            var solution = new PermArraySolution();
            int isPermutation = solution.IsPermutation(arr);

            Assert.True(isPermutation == 0);
        }

        [Fact]
        public void DuplicateElements_IsNotPermutation()
        {
            int[] arr = { 1, 2, 2 };

            var solution = new PermArraySolution();
            int isPermutation = solution.IsPermutation(arr);

            Assert.True(isPermutation == 0);
        }

        [Fact]
        public void BigArray_IsPermutation()
        {
            int[] arr = Enumerable.Range(1, 100000).ToArray();

            var solution = new PermArraySolution();
            int isPermutation = solution.IsPermutation(arr);

            Assert.True(isPermutation == 1);
        }

        [Fact]
        public void BigArray_IsNotPermutation()
        {
            int[] arr = new int[100001];
            Array.Copy(Enumerable.Range(1, 100000).ToArray(), arr, 100000);
            arr[100000] = 1;

            var solution = new PermArraySolution();
            int isPermutation = solution.IsPermutation(arr);

            Assert.True(isPermutation == 0);
        }
    }
}
