using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _10_Regular_Expression_Matching
    {

        //public bool IsMatch(string s, string p)
        //{
        //    int IS = 0;
        //    int IP = 0;
        //    Dictionary<Tuple<int, int>, bool> Pair_Success = new Dictionary<Tuple<int, int>, bool>();


        //    while (IS != s.Length && IP != p.Length)
        //    {
        //        if (s[IS] == p[IP] || p[IP] == '.') //普通对应
        //        {
        //            IS++;
        //            IP++;
        //        }
        //        else if (p[IP] == '*') //遇到*时  优先尝试匹配下一个  
        //        {
        //            if (IP + 1 < p.Length && p[IP + 1] == s[IS])
        //            {
        //                IS++;
        //                IP += 2;
        //            }
        //            else if (p[IP - 1] == s[IS] || p[IP - 1] == '.') //向下失败 尝试回溯
        //            {
        //                IS++;
        //            }
        //            else
        //            {
        //                IP++;
        //            }
        //        }
        //        else if (IP + 1 < p.Length && p[IP + 1] == '*')
        //        {

        //            IP += 2;
        //        }

        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    if (IP < p.Length && p[IP] == '*')
        //    {
        //        IP++;
        //    }
        //    while (IP + 2 < p.Length && p[IP + 2] == '*')
        //    {
        //        IP += 2;
        //    }
        //    return IS == s.Length && IP == p.Length;
        //}


        public bool isMatch(string s, string p)
        {
            int sLen = s.Length, pLen = p.Length;
            bool[,] memory = new bool[sLen + 1, pLen + 1];
            memory[0, 0] = true;
            for (int i = 0; i <= sLen; i++)
            {
                for (int j = 1; j <= pLen; j++)
                {
                    if (p[j - 1] == '*')
                    {
                        memory[i, j] =
                            memory[i, j - 2]
                            ||
                            (i > 0 && (s[i - 1] == p[j - 2] || p[j - 2] == '.') && memory[i - 1, j]);
                    }
                    else
                    {
                        memory[i, j] =
                            i > 0
                            && (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                            && memory[i - 1, j - 1];
                    }
                }
            }
            return memory[sLen, pLen];
        }



    }
}
