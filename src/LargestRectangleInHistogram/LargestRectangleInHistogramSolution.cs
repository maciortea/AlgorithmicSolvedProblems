using System;
using System.Collections.Generic;

namespace LargestRectangleInHistogram
{
    // Given n non-negative integers representing the histogram's bar height where the width of each bar is 1,
    // find the area of largest rectangle in the histogram.
    public class LargestRectangleInHistogramSolution
    {
        public int GetLargestRectangleArea(int[] heights)
        {
            if (heights == null || heights.Length == 0)
            {
                return 0;
            }

            int largestArea = 0;
            var heightsStack = new Stack<int>();
            var positionsStack = new Stack<int>();

            heightsStack.Push(heights[0]);
            positionsStack.Push(0);

            for (int position = 1; position < heights.Length; position++)
            {
                int currentHeight = heights[position];
                int currentPosition = position;

                while (heightsStack.Count > 0 && currentHeight < heightsStack.Peek())
                {
                    currentPosition = positionsStack.Peek();
                    int area = PopArea(heightsStack, positionsStack, position);
                    largestArea = Math.Max(largestArea, area);
                }

                heightsStack.Push(currentHeight);
                positionsStack.Push(currentPosition);
            }

            while (heightsStack.Count > 0)
            {
                int area = PopArea(heightsStack, positionsStack, heights.Length);
                largestArea = Math.Max(largestArea, area);
            }

            return largestArea;
        }

        private int PopArea(Stack<int> heightsStack, Stack<int> posStack, int currentPosition)
        {
            int height = heightsStack.Pop();
            int position = posStack.Pop();
            return height * (currentPosition - position);
        }
    }
}
