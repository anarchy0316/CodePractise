using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class longest_substring_without_repeating_characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            int HistoryMaxLength = 0;
            List<char> Chars = new List<char>();
            foreach (var _char in s)
            {
                if (!Chars.Contains(_char))
                {
                    Chars.Add(_char);
                    HistoryMaxLength = Math.Max(HistoryMaxLength, Chars.Count);
                }
                else
                {
                    var idx = Chars.IndexOf(_char);
                    Chars.RemoveRange(0, idx + 1);
                    Chars.Add(_char);
                }
            }
            return HistoryMaxLength;
        }
    }
}
