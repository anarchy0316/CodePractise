using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    /*
     https://leetcode-cn.com/problems/roman-to-integer/
         */
    public class _0013_RomanToInt
    {


        public Dictionary<string, int> Lookup = new Dictionary<string, int>
            {
                 { "M",1000},
                { "CM",900},
                { "D",500},
                { "CD",400},
                { "C",100},
                { "XC",90},
                { "L",50},
                { "XL",40},
                { "X",10},
                { "IX",9},
                { "V",5},
                { "IV",4},
                { "I",1},
            };
        public int RomanToInt(string s)
        {
            int result = 0;
            int current = 0;
            while (current != s.Length)
            {
                if (s.Length - current > 1 && Lookup.ContainsKey(s.Substring(current, 2)))
                {
                    result += Lookup[s.Substring(current, 2)];
                    current += 2;
                }
                else
                {
                    result += Lookup[s.Substring(current, 1)];
                    current++;
                }
            }
            return result;
        }
    }
}
