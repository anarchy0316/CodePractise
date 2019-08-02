using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    /*
     将一个给定字符串根据给定的行数，以从上往下、从左到右进行 Z 字形排列。
    比如输入字符串为 "LEETCODEISHIRING" 行数为 3 时，排列如下：

    L   C   I   R
    E T O E S I I G
    E   D   H   N
    之后，你的输出需要从左往右逐行读取，产生出一个新的字符串，比如："LCIRETOESIIGEDHN"。

    请你实现这个将字符串进行指定行数变换的函数：

    string convert(string s, int numRows);
    示例 1:

    输入: s = "LEETCODEISHIRING", numRows = 3
    输出: "LCIRETOESIIGEDHN"

    来源：力扣（LeetCode）
    链接：https://leetcode-cn.com/problems/zigzag-conversion
    著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         
         */
    public class _6_zigzag_conversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            int Head = 0;
            int Tail = numRows;
            int Current = 0;
            bool up = true;
            Dictionary<int, List<char>> dic = new Dictionary<int, List<char>>();
            for (int i = 0; i < numRows; i++)
            {
                dic[i] = new List<char>();
            }
            foreach (var c in s)
            {
                dic[Current].Add(c);
                if (up)
                {
                    if (Current == Tail - 1) //触顶
                    {
                        up = false;
                        Current--;
                    }
                    else
                    {
                        Current++;
                    }
                }
                else
                {
                    if (Current == Head) //触底
                    {
                        up = true;
                        Current++;
                    }
                    else
                    {
                        Current--;
                    }
                }
            }
            string result = string.Empty;
            foreach (var kvp in dic)
            {
                result += new string(kvp.Value.ToArray());
            }
            return result;
        }
        public string Convert2(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }
            StringBuilder result = new StringBuilder(string.Empty);

            var temp = 0;
            while (temp < s.Length)
            {
                result.Append(s[temp]);
                temp += numRows * 2 - 2;
            }

            for (int i = 1; i < numRows - 1; i++)
            {
                temp = i;
                while (temp < s.Length)
                {
                    result.Append(s[temp]);

                    int Vdepth = numRows - temp % (numRows * 2 - 2);
                    var right = temp + Vdepth * 2 - 2;
                    if (right < s.Length)
                    {
                        result.Append(s[right]);
                    }
                    temp += numRows * 2 - 2;
                }
            }

            temp = numRows - 1;
            while (temp < s.Length)
            {
                result.Append(s[temp]);
                temp += numRows * 2 - 2;
            }
            return result.ToString();
        }
    }
    //PAHN APLLIGG YIR
}
