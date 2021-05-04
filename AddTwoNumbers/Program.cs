using System;

namespace AddTwoNumbers
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        static void Main()
        {
            ListNode list1node3 = new ListNode(3, null);
            ListNode list1node2 = new ListNode(4, list1node3);
            ListNode list1node1 = new ListNode(0, list1node2);
            ListNode list2node3 = new ListNode(4, null);
            ListNode list2node2 = new ListNode(6, list2node3);
            ListNode list2node1 = new ListNode(0, list2node2);
            
            
            Program program = new Program();
            program.AddTwoNumbers(list1node1, list2node1);
        }


        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode FinalListHead = addTwoBackwardsSingleLinkedList(l1, l2);

            return FinalListHead;
        }

        private ListNode addTwoBackwardsSingleLinkedList(ListNode head1, ListNode head2)
        {
            ListNode newHead = new ListNode(head1.val + head2.val, null);
            ListNode currentNodeInNewList = newHead;
            int carryOver = 0;
            while(head1 != null || head2 != null)
            {
                int head1ValueExtracted = 0;
                int head2ValueExtracted = 0;
                if (head1 != null)
                {
                    head1ValueExtracted = head1.val;
                }
                if(head2 != null)
                {
                    head2ValueExtracted = head2.val;
                }

                currentNodeInNewList.val = head1ValueExtracted + head2ValueExtracted;
                currentNodeInNewList.val = currentNodeInNewList.val + carryOver;
                carryOver = 0;

                if(currentNodeInNewList.val > 9)
                {
                    carryOver = currentNodeInNewList.val / 10;
                    currentNodeInNewList.val = (currentNodeInNewList.val % 10);
                }
                if (head1 != null)
                {
                    head1 = head1.next;
                }
                if(head2 != null)
                {
                    head2 = head2.next;
                }

                if(head1 != null || head2 != null)
                {
                    currentNodeInNewList.next = new ListNode();
                }
                else if(carryOver != 0)
                {
                    currentNodeInNewList.next = new ListNode(carryOver, null);
                    currentNodeInNewList = currentNodeInNewList.next;
                }

              
                currentNodeInNewList = currentNodeInNewList.next;
            }

            return newHead;
        }


    }
}

