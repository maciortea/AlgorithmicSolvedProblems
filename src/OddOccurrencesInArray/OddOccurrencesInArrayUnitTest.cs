using System;
using System.Linq;
using Xunit;

namespace OddOccurrencesInArray
{
    public class OddOccurrencesInArrayUnitTest
    {
        [Fact]
        public void TestMethod1()
        {
            int[] arr = { 9, 3, 9, 3, 9, 7, 9 };

            var solution = new OddOccurrencesInArraySolution();
            int number = solution.FindSingleNumber(arr);

            Assert.Equal(7, number);
        }

        [Fact]
        public void EmptyArrayTest()
        {
            var solution = new OddOccurrencesInArraySolution();
            int number = solution.FindSingleNumber(new int[0]);

            Assert.Equal(0, number);
        }

        [Fact]
        public void ArrayWithOneElementTest()
        {
            var solution = new OddOccurrencesInArraySolution();
            int number = solution.FindSingleNumber(new int[] { 1 });

            Assert.Equal(1, number);
        }

        [Fact]
        public void BigArrayTest()
        {
            int[] arr = new int[1000001];
            int[] tempArr = Enumerable.Range(1, 500000).ToArray();
            Array.Copy(tempArr, arr, tempArr.Length);
            Array.Copy(tempArr, 0, arr, tempArr.Length, tempArr.Length);
            arr[1000000] = 500001;

            var solution = new OddOccurrencesInArraySolution();
            int number = solution.FindSingleNumber(arr);

            Assert.Equal(500001, number);
        }
    }
}
