using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    /*
    给定一个字符串 s，找到 s 中最长的回文子串。你可以假设 s 的最大长度为 1000。
    示例 1：
    输入: "babad"
    输出: "bab"
    注意: "aba" 也是一个有效答案。

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/longest-palindromic-substring
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
    public class _5_Longest_Palindromic_Substring
    {
        //public string LongestPalindrome(string s)
        //{
        //    string result = string.Empty;
        //    for (int i = 0; i < s.Length * 2 - 1; i++)
        //    {
        //        if (i % 2 == 0)// 划分在数上
        //        {
        //            var Center = i / 2;
        //            int halfLength = 0;

        //            while (IsInRange(s, Center, halfLength) && s[Center - halfLength] == s[Center + halfLength])
        //            {
        //                halfLength++;
        //            }
        //            halfLength--;
        //            if (2 * halfLength + 1 > result.Length)
        //            {
        //                result = s.Substring(Center - halfLength, 2 * halfLength + 1);
        //            }
        //        }
        //        else // 划分在数间上
        //        {
        //            var Center = i / 2;
        //            int LefthalfLength = 0;
        //            int RightHalf = 1;
        //            while (Center - LefthalfLength >= 0 && Center + RightHalf < s.Length && s[Center - LefthalfLength] == s[Center + RightHalf])
        //            {
        //                LefthalfLength++;
        //                RightHalf++;
        //            }
        //            LefthalfLength--;
        //            RightHalf--;
        //            if (LefthalfLength + RightHalf + 1 > result.Length)
        //            {
        //                result = s.Substring(Center - LefthalfLength, RightHalf + LefthalfLength + 1);
        //            }
        //        }
        //    }
        //    return result;
        //}
        //public bool IsInRange(string s, int center, int halfLength)
        //{
        //    return center + halfLength < s.Length && center - halfLength >= 0;
        //}

        public string LongestPalindrome(string s)
        {
            if (s == null || s.Length < 1) return "";
            int start = 0, end = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int len1 = expandAroundCenter(s, i, i);
                int len2 = expandAroundCenter(s, i, i + 1);
                int len = Math.Max(len1, len2);
                if (len > end - start)
                {

                    start = i - (len - 1) / 2;
                    end = i + len / 2;

                }
            }
            return s.Substring(start, end - start + 1);
        }

        private int expandAroundCenter(String s, int left, int right)
        {
            int L = left, R = right;
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--;
                R++;
            }
            return R - L - 1;
        }
    }
}
