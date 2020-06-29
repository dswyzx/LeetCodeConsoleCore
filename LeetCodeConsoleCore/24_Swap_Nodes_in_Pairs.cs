using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Swap_Nodes_in_Pairs
    {
        static void Main24(string[] args)
        {
            ListNode f = new ListNode(6); f.next = null;
            ListNode e = new ListNode(5); e.next = f;
            ListNode d = new ListNode(4); d.next = e;
            ListNode c = new ListNode(3); c.next = d;
            ListNode b = new ListNode(2); b.next = c;
            ListNode a = new ListNode(1); a.next = b;

            SwapPairs(a);
        }

        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode old = head.next;

            ListNode first = head;
            ListNode sec = head.next;
            head.next = sec.next;
            sec.next = head;

            while (head != null && head.next != null && head.next.next != null)
            {
                first = head.next;
                sec = first.next;
                first.next = sec.next;
                sec.next = first;
                head.next = sec;
                head = head.next.next;
            }
            return old;

        }
    }


}
