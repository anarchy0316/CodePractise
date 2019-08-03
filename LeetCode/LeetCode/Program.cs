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
            _0019_Remove_Nth_Node_From_End_of_List a = new _0019_Remove_Nth_Node_From_End_of_List();
            var head = new _0019_Remove_Nth_Node_From_End_of_List.ListNode(1);
            head.next = new _0019_Remove_Nth_Node_From_End_of_List.ListNode(2);
            head.next.next = new _0019_Remove_Nth_Node_From_End_of_List.ListNode(3);
            head.next.next.next = new _0019_Remove_Nth_Node_From_End_of_List.ListNode(4);
            head.next.next.next.next = new _0019_Remove_Nth_Node_From_End_of_List.ListNode(5);
            a.RemoveNthFromEnd(head, 2);
        }
    }
}
