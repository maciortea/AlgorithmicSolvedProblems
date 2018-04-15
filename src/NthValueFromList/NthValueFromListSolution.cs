using ListCore;

namespace NthValueFromList
{
    // You're given the pointer to the head node of a linked list and a specific position.
    // Counting backwards from the tail node of the linked list, get the value of the node at the given position.
    // A position of 0 corresponds to the tail, 1 corresponds to the node before the tail and so on.
    public class NthValueFromListSolution
    {
        public T GetNthNodeFromTail<T>(Node<T> head, int position)
        {
            Node<T> fast = head;
            for (int i = 0; i < position; i++)
            {
                fast = fast.Next;
            }

            Node<T> slow = head;
            while (fast.Next != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            return slow.Data;
        }
    }
}
