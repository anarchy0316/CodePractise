using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0024_Swap_Nodes_in_Pairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            var zero = new ListNode(0);
            zero.next = head;
            var currentTail = zero;

            while (currentTail.next != null && currentTail.next.next != null)
            {
                var Current_1 = currentTail.next;
                var Current_2 = Current_1.next;
                currentTail.next = Current_2;
                Current_1.next = Current_2.next;
                Current_2.next = Current_1;
                currentTail = Current_1;
            }
            return zero.next;

        }
    }
}
