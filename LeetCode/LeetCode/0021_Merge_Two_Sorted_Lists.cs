using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    //https://leetcode-cn.com/problems/merge-two-sorted-lists/



    public class _0021_Merge_Two_Sorted_Lists
    {

        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            var current = result;
            while (l1 != null || l2 != null)
            {
                if (l2 == null || (l1 != null && l1.val < l2.val))
                {
                    AddL1(ref l1, ref current);
                }
                else
                {
                    AddL2(ref l2, ref current);
                }
            }
            return result.next;
        }

        private static void AddL1(ref ListNode l1, ref ListNode current)
        {
            current.next = l1;
            l1 = l1.next;
            current = current.next;
        }

        private void AddL2(ref ListNode l2, ref ListNode current)
        {
            current.next = l2;
            l2 = l2.next;
            current = current.next;
        }
    }
}
