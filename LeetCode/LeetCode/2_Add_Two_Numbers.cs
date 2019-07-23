using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LeetCode.LeetCode
{
    /*
    给出两个 非空 的链表用来表示两个非负的整数。其中，它们各自的位数是按照 逆序 的方式存储的，并且它们的每个节点只能存储 一位 数字。
    如果，我们将这两个数相加起来，则会返回一个新的链表来表示它们的和。
    您可以假设除了数字 0 之外，这两个数都不会以 0 开头。
    示例：
    
    输入：(2 -> 4 -> 3) + (5 -> 6 -> 4)
    输出：7 -> 0 -> 8
    原因：342 + 465 = 807

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/add-two-numbers
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool HasCarryBit = false;
            ListNode result = null;
            ListNode Father = null;

            while (l1 != null || l2 != null || HasCarryBit)
            {
                int num = 0;
                if (l1 != null)
                {
                    num += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    num += l2.val;
                    l2 = l2.next;
                }
                if (HasCarryBit)
                {
                    num++;
                    HasCarryBit = false;
                }
                if (num > 9)
                {
                    num -= 10;
                    HasCarryBit = true;
                }
                if (Father == null)
                {

                    Father = new ListNode(num);
                    result = Father;
                }
                else
                {
                    Father.next = new ListNode(num);
                    Father = Father.next;
                }
                Console.WriteLine(num);
            }
            return result;
        }
    }
}
