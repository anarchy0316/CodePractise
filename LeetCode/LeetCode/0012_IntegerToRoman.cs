using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0012_IntegerToRoman
    {


        public string IntToRoman(int num)
        {
            Dictionary<int, string> Lookup = new Dictionary<int, string>
            {
                 { 1000,"M"},
                { 900,"CM"},
                { 500,"D"},
                { 400,"CD"},
                { 100,"C"},
                { 90,"XC"},
                { 50,"L"},
                { 40,"XL"},
                { 10,"X"},
                { 9,"IX"},
                { 5,"V"},
                { 4,"IV"},
                { 1,"I"},
            };
            Lookup.Reverse();
            StringBuilder result = new StringBuilder();
            while (num != 0)
            {
                foreach (var kvp in Lookup)
                {
                    if (kvp.Key <= num)
                    {
                        num -= kvp.Key;
                        result.Append(kvp.Value);
                        break;
                    }
                }
            }
            return result.ToString();
        }
    }
}
