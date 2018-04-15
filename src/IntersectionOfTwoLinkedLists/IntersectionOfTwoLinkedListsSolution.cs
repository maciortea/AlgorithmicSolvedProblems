using ListCore;

namespace IntersectionOfTwoLinkedLists
{
    public class IntersectionOfTwoLinkedListsSolution
    {
        public Node<T> GetIntersectionNode<T>(LinkedList<T> list1, LinkedList<T> list2)
        {
            if (list1 == null || list2 == null)
            {
                return null;
            }

            int len1 = 0;
            int len2 = 0;

            Node<T> node1 = list1.Head;
            Node<T> node2 = list2.Head;
            while (node1 != null)
            {
                node1 = node1.Next;
                len1++;
            }

            while (node2 != null)
            {
                node2 = node2.Next;
                len2++;
            }

            Node<T> head1 = list1.Head;
            Node<T> head2 = list2.Head;
            while (len1 > len2)
            {
                head1 = head1.Next;
                len1--;
            }

            while (len2 > len1)
            {
                head2 = head2.Next;
                len2--;
            }

            while (head1 != head2)
            {
                head1 = head1.Next;
                head2 = head2.Next;
            }

            return head1;
        }
    }
}
