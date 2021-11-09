using System;
using Xunit;

namespace QueueRemovals
{
    public class QueueRemovalsUnitTest
    {
        [Fact]
        public void Test1()
        {
            // Given
            var solution = new QueueRemovalsSolution();
            int[] arr = { 1, 2, 2, 3, 4, 5 };
            int x = 5;

            // When
            int[] output = solution.FindPositions(arr, x);

            // Then
            Assert.Equal<int>(new int[] { 5, 6, 4, 1, 2 }, output);
        }
    }
}
