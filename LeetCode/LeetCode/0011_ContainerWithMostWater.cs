﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0011_ContainerWithMostWater
    {
        /*
         给定 n 个非负整数 a1，a2，...，an，每个数代表坐标中的一个点 (i, ai) 。在坐标内画 n 条垂直线，垂直线 i 的两个端点分别为 (i, ai) 和 (i, 0)。找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。

        说明：你不能倾斜容器，且 n 的值至少为 2


        示例:
        输入: [1,8,6,2,5,4,8,3,7]
        输出: 49

        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/container-with-most-water
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
         */
        //a.MaxArea(new int[] { 2, 3, 4, 5, 18, 17, 6 });
        public int MaxArea(int[] height)
        {
            int right = height.Length - 1;
            int left = 0;
            int max = 0;
            while (right != left)
            {
                var bottom = right - left;
                var thisHeight = Math.Min(height[right], height[left]);
                max = Math.Max(max, bottom * thisHeight);
                if (height[right] > height[left])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return max;
        }
    }
}
