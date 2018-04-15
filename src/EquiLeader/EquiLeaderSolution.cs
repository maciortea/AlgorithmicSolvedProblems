using System.Collections.Generic;

namespace EquiLeader
{
    // A non-empty zero-indexed array A consisting of N integers is given.
    // The leader of this array is the value that occurs in more than half of the elements of A.
    // An equi leader is an index S such that 0 ≤ S<N − 1 and two sequences
    // A[0], A[1], ..., A[S] and A[S + 1], A[S + 2], ..., A[N − 1] have leaders of the same value.
    // For example, given array A such that:
    // A[0] = 4
    // A[1] = 3
    // A[2] = 4
    // A[3] = 4
    // A[4] = 4
    // A[5] = 2
    // we can find two equi leaders:
    // 0, because sequences: (4) and (3, 4, 4, 4, 2) have the same leader, whose value is 4.
    // 2, because sequences: (4, 3, 4) and (4, 4, 2) have the same leader, whose value is 4.
    // The goal is to count the number of equi leaders.
    //
    // Assume that:
    // - N is an integer within the range[1..100,000]
    // - each element of array A is an integer within the range[−1,000,000,000..1,000,000,000]
    //
    // Complexity:
    //
    // - expected worst-case time complexity is O(N)
    // - expected worst-case space complexity is O(N), beyond input storage (not counting the storage required
    //   for input arguments)
    // - elements of input arrays can be modified
    public class EquiLeaderSolution
    {
        public int GetEquiLeadersCount(int[] arr)
        {
            var stack = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (stack.Count == 0 || arr[i] == stack.Peek())
                {
                    stack.Push(arr[i]);
                }
                else
                {
                    stack.Pop();
                }
            }

            int leader = -1;
            int leaderCount = 0;

            if (stack.Count > 0)
            {
                int candidate = stack.Peek();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == candidate)
                    {
                        leaderCount++;
                    }
                }

                if (leaderCount > arr.Length / 2)
                {
                    leader = candidate;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

            int equiLeaderCount = 0;
            int leaderCountInRight = 0;
            int leaderCountInLeft = leaderCount;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == leader)
                {
                    leaderCountInRight++;
                    leaderCountInLeft--;
                }

                if (leaderCountInLeft > i / 2 && leaderCountInRight > (arr.Length - i) / 2)
                {
                    equiLeaderCount++;
                }
            }

            return equiLeaderCount;
        }
    }
}
