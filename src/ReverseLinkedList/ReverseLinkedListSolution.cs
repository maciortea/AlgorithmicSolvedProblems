using ListCore;

namespace ReverseLinkedList
{
    public class ReverseLinkedListSolution
    {
        public void ReverseList<T>(LinkedList<T> list)
        {
            if (list.Head == null)
            {
                return;
            }

            Node<T> currentNode = list.Head;
            Node<T> nextNode = null;
            Node<T> prevNode = null;

            while (currentNode != null)
            {
                nextNode = currentNode.Next;
                currentNode.Next = prevNode;
                prevNode = currentNode;
                currentNode = nextNode;
            }

            list.Head = prevNode;
        }
    }
}
