using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0029_Divide_Two_Integers
    {
        public int Divide(int dividend, int divisor)
        {
            bool dividendNega = true;
            bool divisorNega = true;
            if (dividend > 0)
            {
                dividend = -dividend;
                dividendNega = false;
            }
            if (divisor > 0)
            {
                divisor = -divisor;
                divisorNega = false;
            }
            var result = 0;
            while (dividend <= divisor)
            {
                var currentDivisot = divisor;
                var num = 1;
                while (dividend <= currentDivisot)
                {
                    dividend -= currentDivisot;
                    result += num;
                    if (currentDivisot > int.MinValue >> 1) // 除数*2 时要判定是否溢出
                    {
                        currentDivisot *= 2;
                        num *= 2;
                    }
                }
            }
            if (result == int.MinValue && dividendNega == divisorNega)
            {
                return int.MaxValue;
            }
            if (dividendNega == divisorNega)
            {
                return result;
            }
            else
            {
                return -result;
            }

        }
    }
}
