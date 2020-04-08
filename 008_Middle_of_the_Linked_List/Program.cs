using System;

namespace _008_Middle_of_the_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            // [1, 2, 3, 4, 5]
            var testNode = new ListNode(1);
            testNode.next = new ListNode(2);
            testNode.next.next = new ListNode(3);
            testNode.next.next.next = new ListNode(4);
            testNode.next.next.next.next = new ListNode(5);

            Console.WriteLine(MiddleNode(testNode).val == 3);
        }

        public static ListNode MiddleNode(ListNode head)
        {
            var nodeLength = 0;
            var currentNode = head;

            while (currentNode != null)
            {
                nodeLength++;
                currentNode = currentNode.next;
            }

            var forLength = nodeLength / 2;

            for (int i = 0; i < forLength; i++)
            {
                head = head.next;
            }

            return head;
        }

        /**
        * Definition for singly-linked list.
        */
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
