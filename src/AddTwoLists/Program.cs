using System;

namespace AddTwoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = new ListNode(2);
            l1.Next = new ListNode(4);
            l1.Next.Next = new ListNode(3);
            l1.Next.Next.Next = new ListNode(1);

            var l2 = new ListNode(7);
            l2.Next = new ListNode(0);
            l2.Next.Next = new ListNode(8);

            ListNode resultHead = AddTwoNumbers(l1, l2);

            while (resultHead != null)
            {
                if (resultHead.Next != null)
                {
                    Console.Write($"{resultHead.Value} -> ");
                }
                else
                {
                    Console.Write($"{resultHead.Value}");
                }
                
                resultHead = resultHead.Next;
            }

            Console.ReadLine();
        }

        // You are given two non-empty linked lists representing two non-negative integers.
        // The digits are stored in reverse order and each of their nodes contain a single digit.
        // Add the two numbers and return it as a linked list.
        // You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        // Example:
        // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        // Output: 7 -> 0 -> 8
        // Explanation: 342 + 465 = 807
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resultHead = null;
            ListNode currentNode = null;
            int reminder = 0;

            while (l1 != null && l2 != null)
            {
                int n = l1.Value + l2.Value + reminder;

                var node = new ListNode(n % 10);
                if (resultHead == null)
                {
                    resultHead = node;
                    currentNode = node;
                }
                else
                {
                    currentNode.Next = node;
                    currentNode = currentNode.Next;
                }

                l1 = l1.Next;
                l2 = l2.Next;

                if (n > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
            }

            while (l1 != null)
            {
                int n = l1.Value + reminder;
                currentNode.Next = new ListNode(n % 10);
                currentNode = currentNode.Next;
                l1 = l1.Next;

                if (n > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
            }

            while (l2 != null)
            {
                int n = l2.Value + reminder;
                currentNode.Next = new ListNode(n % 10);
                currentNode = currentNode.Next;
                l2 = l2.Next;

                if (n > 9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
            }

            if (reminder == 1)
            {
                currentNode.Next = new ListNode(1);
            }

            return resultHead;
        }
    }
}
