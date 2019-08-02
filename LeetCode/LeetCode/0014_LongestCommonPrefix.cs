using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0014_LongestCommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }
            StringBuilder result = new StringBuilder();
            int i = 0;
            while (true)
            {
                char? ThisRound = null;
                foreach (var str in strs)
                {
                    if (i >= str.Length)
                    {
                        return result.ToString();
                    }
                    if (ThisRound == null)
                    {
                        ThisRound = str[i];
                    }
                    else
                    {
                        if (ThisRound != str[i])
                        {
                            return result.ToString();
                        }
                    }

                }
                result.Append(ThisRound);
                i++;
            }
        }
    }
}
