using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    /// <summary>
    /// https://leetcode-cn.com/problems/reverse-nodes-in-k-group/
    /// </summary>
    public class _0025_Reverse_Nodes_In_K_Group
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var zero = new ListNode(0);
            zero.next = head;
            var currentTail = zero;

            while (currentTail.next != null)
            {
                List<ListNode> Temp = new List<ListNode>();
                var cn = currentTail.next;
                for (int i = 0; i < k; i++)
                {
                    Temp.Add(cn);
                    cn = cn.next;
                    if (cn == null && i < k - 1)
                    {
                        return zero.next;
                    }
                }
                Temp.Reverse();
                var currentHead = currentTail;
                foreach (var item in Temp)
                {
                    currentHead.next = item;
                    currentHead = item;
                }
                currentHead.next = cn;
                currentTail = currentHead;
            }
            return zero.next;

        }
        public ListNode ReverseKGroup2(ListNode head, int k)
        {
            var zero = new ListNode(0);
            zero.next = head;
            var currentTail = zero;
            Stack<ListNode> stk = new Stack<ListNode>();
            while (currentTail.next != null)
            {
                var cn = currentTail.next;
                for (int i = 0; i < k; i++)
                {
                    stk.Push(cn);
                    cn = cn.next;
                    if (cn == null && i < k - 1)
                    {
                        return zero.next;
                    }
                }
                var currentHead = currentTail;
                while (stk.Count > 0)
                {
                    currentHead.next = stk.Pop();
                    currentHead = currentHead.next;
                }
                currentHead.next = cn;
                currentTail = currentHead;
            }
            return zero.next;
        }
    }
}
