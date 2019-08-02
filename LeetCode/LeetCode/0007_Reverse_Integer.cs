using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _7_Reverse_Integer
    {
        /*
         * 给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

        示例 1:

        输入: 123
        输出: 321
         示例 2:

        输入: -123
        输出: -321

        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/reverse-integer
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        public int Reverse(int x)
        {
            int ans = 0;
            while (x != 0)
            {
                int pop = x % 10;
                if (ans > int.MaxValue / 10 || (ans == int.MaxValue / 10 && pop > 7))
                    return 0;
                if (ans < int.MinValue / 10 || (ans == int.MinValue / 10 && pop < -8))
                    return 0;
                ans = ans * 10 + pop;
                x /= 10;
            }
            return ans;
        }
    }
}
