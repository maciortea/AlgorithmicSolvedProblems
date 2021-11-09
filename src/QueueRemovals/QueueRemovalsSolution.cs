using System;
using System.Collections.Generic;
using System.Linq;

namespace QueueRemovals
{
    // You're given a list of n integers arr, which represent elements in a queue (in order from front to back). You're also given an integer x, and must perform x iterations of the following 3-step process:
    // 1) Pop x elements from the front of queue(or, if it contains fewer than x elements, pop all of them)
    // 2) Of the elements that were popped, find the one with the largest value(if there are multiple such elements, take the one which had been popped the earliest), and remove it
    // 3) For each one of the remaining elements that were popped(in the order they had been popped), decrement its value by 1 if it's positive (otherwise, if its value is 0, then it's left unchanged), and then add it back to the queue
    // Compute a list of x integers output, the ith of which is the 1-based index in the original array of the element which had been removed in step 2 during the ith iteration.
    // Input:
    // x is in the range[1, 316]
    // n is in the range[x, x * x]
    // Each value arr[i] is in the range[1, x]
    // Output:
    // Return a list of x integers output, as described above.
    public class QueueRemovalsSolution
    {
        private Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

        public int[] FindPositions(int[] arr, int x)
        {
            int[] output = new int[x];

            InitializeQueue(arr);

            for (int i = 0; i < x; i++)
            {
                output[i] = Iteration(x);
            }

            return output;
        }

        private void InitializeQueue(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                queue.Enqueue(Tuple.Create(arr[i], i + 1));
            }
        }

        private int Iteration(int x)
        {
            List<Tuple<int, int>> elems = Step1(x);
            var resultFromStep2 = Step2(elems);
            Step3(resultFromStep2.Item2);

            return resultFromStep2.Item1;
        }

        private List<Tuple<int, int>> Step1(int x)
        {
            var output = new List<Tuple<int, int>>();
            int length = Math.Min(x, queue.Count);

            for (int i = 0; i < length; i++)
            {
                var elem = queue.Dequeue();
                output.Add(elem);
            }

            return output;
        }

        private Tuple<int, List<Tuple<int, int>>> Step2(List<Tuple<int, int>> elems)
        {
            var firstItem = elems.First();
            int largestNum = firstItem.Item1;
            int largestInitialIndex = firstItem.Item2;
            int actualIndex = 0;

            for (int i = 0; i < elems.Count; i++)
            {
                var elem = elems[i];
                if (elem.Item1 > largestNum)
                {
                    largestNum = elem.Item1;
                    largestInitialIndex = elem.Item2;
                    actualIndex = i;
                }
            }

            elems.RemoveAt(actualIndex);

            return Tuple.Create(largestInitialIndex, elems);
        }

        private void Step3(List<Tuple<int, int>> elems)
        {
            foreach (var elem in elems)
            {
                int num = elem.Item1 > 0 ? elem.Item1 - 1 : 0;
                queue.Enqueue(Tuple.Create(num, elem.Item2));
            }
        }
    }
}
