using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0042_Trapping_Rain_Water
    {
        public int Trap(int[] height)
        {
            int sum = 0;
            Stack<int> stack = new Stack<int>();
            int current = 0;
            while (current < height.Length)
            {
                //如果栈不空并且当前指向的高度大于栈顶高度就一直循环
                while (stack.Count != 0 && height[current] > height[stack.Peek()])
                {
                    int h = height[stack.Peek()]; //取出要出栈的元素
                    stack.Pop(); //出栈
                    if (stack.Count == 0)
                    { // 栈空就出去
                        break;
                    }
                    int distance = current - stack.Peek() - 1; //两堵墙之前的距离。

                    int min = Math.Min(height[stack.Peek()], height[current]);
                    Console.WriteLine(string.Format(stack.Peek() + " " + height[stack.Peek()] + "     " + current + " " + height[current] + " 之间高" + (min - h)));
                    sum = sum + distance * (min - h);
                }
                stack.Push(current); //当前指向的墙入栈
                current++; //指针后移
            }
            return sum;
        }

    }
}
