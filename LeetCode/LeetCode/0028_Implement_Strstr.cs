using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    //https://leetcode-cn.com/problems/implement-strstr/submissions/
    public class _0028_Implement_Strstr
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle == string.Empty) return 0;
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (needle[j] != haystack[i + j])
                    {
                        break;
                    }
                    else
                    {
                        if (j == needle.Length - 1)
                        {
                            return i;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
