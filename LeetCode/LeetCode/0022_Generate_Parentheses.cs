using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    //https://leetcode-cn.com/problems/generate-parentheses/
    public class _0022_Generate_Parentheses
    {
        Dictionary<int, List<string>> l = new Dictionary<int, List<string>>
            {
                {0,new List<string>{"" } },
                {1, new List<string>{"()" }},
            };
        List<string> GetList(int num)
        {
            if (!l.ContainsKey(num))
            {
                l[num] = new List<string>();
                for (int i = 0; i < num; i++)
                {
                    foreach (var k1 in GetList(i))
                    {
                        foreach (var k2 in GetList(num - 1 - i))
                        {
                            l[num].Add("(" + k1 + ")" + k2);
                        }
                    }

                }
            }
            return l[num];
        }

        public IList<string> GenerateParenthesis(int n)
        {
            return GetList(n);
        }
    }
}
