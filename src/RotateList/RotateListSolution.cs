using ListCore;

namespace RotateList
{
    // Given a linked list, rotate the list to the right by k places, where k is non-negative.
    public class RotateListSolution
    {
        public Node<T> RotateRight<T>(LinkedList<T> list, int k)
        {
            if (list == null || list.Head == null)
            {
                return null;
            }

            var listLength = list.GetLength();
            k = k % listLength;

            Node<T> fast = list.Head;
            for (int i = 0; i < k; i++)
            {
                fast = fast.Next;
            }

            Node<T> slow = list.Head;
            while (fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            fast.Next = list.Head;
            list.Head = slow.Next;
            slow.Next = null;

            return list.Head;
        }
    }
}
