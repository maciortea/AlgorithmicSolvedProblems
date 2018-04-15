using System;

namespace ListCore
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; set; } = null;

        public Node<T> Tail { get; set; } = null;

        public void Add(T data)
        {
            if (Head == null)
            {
                Head = new Node<T>(data);
                Tail = Head;
            }
            else
            {
                Node<T> node = Head;
                while (node.Next != null)
                {
                    node = node.Next;
                }

                node.Next = new Node<T>(data);
                Tail = node.Next;
            }
        }

        public void Display()
        {
            Node<T> node = Head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public int GetLength()
        {
            int length = 0;
            Node<T> node = Head;
            while (node != null)
            {
                length++;
                node = node.Next;
            }

            return length;
        }
    }
}
