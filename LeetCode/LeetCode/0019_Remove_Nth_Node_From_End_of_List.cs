using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{

    public class _0019_Remove_Nth_Node_From_End_of_List
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var current = head;
            var list = new List<ListNode>();
            list.Add(current);
            while (current.next != null)
            {
                list.Add(current.next);
                current = current.next;
            }
            if (n == list.Count)
            {
                if (n == 1)
                {
                    return null;
                }
                else
                {
                    return list[1];
                }
            }
            else if (n == 1)
            {
                list[list.Count - 2].next = null;
            }
            else
            {
                list[list.Count - n - 1].next = list[list.Count - n + 1];
            }
            return head;
        }
    }
}
