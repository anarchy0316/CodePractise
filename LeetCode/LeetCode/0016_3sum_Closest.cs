using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    //https://leetcode-cn.com/problems/3sum-closest/
    public class _0016_3sum_Closest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var list = nums.OrderBy(x => x).ToList();

            int MinDiffAbs = int.MaxValue;
            var result = int.MaxValue;
            for (int i = 0; i <= (list.Count - 3); i++)
            {
                if (i - 1 >= 0 && list[i] == list[i - 1])
                {
                    continue;
                }
                var left = i + 1;
                var right = list.Count - 1;
                var requestSum = target - list[i];
                while (left < right)
                {
                    var twoSum = list[left] + list[right];
                    if (twoSum < requestSum)
                    {

                        left = MoveLeft(list, left, right);
                    }
                    else if (twoSum > requestSum)
                    {
                        right = MoveRight(list, left, right);
                    }
                    else
                    {
                        return target;
                    }
                    if (MinDiffAbs > Math.Abs(requestSum - twoSum))
                    {
                        MinDiffAbs = Math.Abs(requestSum - twoSum);

                        result = twoSum + list[i];
                    }

                }
            }
            return result;
        }
        private int MoveRight(List<int> list, int left, int right)
        {
            right--;
            while (list[right + 1] == list[right] && left < right)
            {
                right--;
            }

            return right;
        }

        private int MoveLeft(List<int> list, int left, int right)
        {
            left++;
            while (list[left - 1] == list[left] && left < right)
            {
                left++;
            }
            return left;
        }
    }
}
