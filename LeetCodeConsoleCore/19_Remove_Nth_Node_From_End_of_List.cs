using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Remove_Nth_Node_From_End_of_List
    {
        static void Main19(string[] args)
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null)
            {
                return null;
            }
            ListNode pre = head; ListNode cur = head;
            for (int i = 0; i < n; i++)
            {
                cur = cur.next;
            }
            if (cur == null)
            {
                return head.next;
            }
            while (cur.next != null)
            {
                cur = cur.next;
                pre = pre.next;
            }
            pre.next = pre.next.next;
            return head;
        }

    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
