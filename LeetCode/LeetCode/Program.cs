using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Add_Two_Numbers a = new Add_Two_Numbers();
            var n1 = new ListNode(2);
            var n2 = new ListNode(4);
            var n3 = new ListNode(3);
            n1.next = n2;
            n2.next = n3;


            var c = a.AddTwoNumbers(n1, n1);
            while (c != null)
            {

                c = c.next;
            }
        }
    }
}
