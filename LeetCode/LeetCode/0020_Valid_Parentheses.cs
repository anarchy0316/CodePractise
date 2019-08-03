using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0020_Valid_Parentheses
    {
        public bool IsValid(string s)
        {
            Dictionary<char, char> dic = new Dictionary<char, char>
            {
                { ')','('},
                { ']','['},
                { '}','{'},
            };
            Stack<char> stk = new Stack<char>();
            foreach (var c in s)
            {
                if (stk.Count > 0 && (dic.ContainsKey(c) && stk.Peek() == dic[c]))
                {
                    stk.Pop();
                }
                else
                {
                    stk.Push(c);
                }
            }
            return stk.Count == 0;
        }
        /// <summary>
        /// ASCII Hack
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsValid2(string s)
        {

            Stack<char> stk = new Stack<char>();
            foreach (var c in s)
            {
                if (stk.Count > 0 && (c - stk.Peek() == 1 || c - stk.Peek() == 2))
                {
                    stk.Pop();
                }
                else
                {
                    stk.Push(c);
                }
            }
            return stk.Count == 0;
        }
    }
}
