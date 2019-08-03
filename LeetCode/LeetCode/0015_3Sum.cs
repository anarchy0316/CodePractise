using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    //https://leetcode-cn.com/problems/3sum/
    public class _0015_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = nums.OrderBy(x => x).ToList();

            var result = new List<IList<int>>();
            for (int i = 0; i <= (list.Count - 3); i++)
            {
                if (i - 1 >= 0 && list[i] == list[i - 1])
                {
                    continue;
                }
                var left = i + 1;
                var right = list.Count - 1;
                var requestSum = -list[i];
                while (left < right)
                {
                    if (list[left] + list[right] < requestSum)
                    {
                        left = MoveLeft(list, left, right);
                    }
                    else if (list[left] + list[right] > requestSum)
                    {
                        right = MoveRight(list, left, right);
                    }
                    else
                    {
                        result.Add(new List<int> { list[i], list[left], list[right] });
                        left = MoveLeft(list, left, right);
                        right = MoveRight(list, left, right);
                    }
                }
            }
            return result.ToList();
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
