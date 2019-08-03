using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0018_4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            if (nums.Length < 4)
            {
                return new List<IList<int>>();
            }
            var Sorted = nums.OrderBy(x => x).ToList();
            var result = new List<IList<int>>();
            int OutLeft;
            int OutRight;

            for (OutLeft = 0; OutLeft <= Sorted.Count - 3; OutLeft++)
            {
                if (OutLeft > 0 && Sorted[OutLeft] == Sorted[OutLeft - 1])
                {
                    continue;//在缩小范围时 如果在左侧去掉一个重复项 对结果没有影响
                }
                for (OutRight = OutLeft + 3; OutRight < Sorted.Count; OutRight++)
                {
                    if (OutRight + 1 < Sorted.Count && Sorted[OutRight] == Sorted[OutRight + 1])
                    {
                        continue; //扩大范围时，如果下一个和这个一样 可以忽略这个
                    }
                    var innerleft = OutLeft + 1;
                    var innerRight = OutRight - 1;
                    var aim = target - (Sorted[OutLeft] + Sorted[OutRight]);
                    while (innerleft < innerRight)
                    {
                        if (Sorted[innerleft] + Sorted[innerRight] == aim)
                        {
                            result.Add(new List<int> { Sorted[OutLeft], Sorted[innerleft], Sorted[innerRight], Sorted[OutRight] });
                            innerleft = MoveLeft(Sorted, innerleft, innerRight);
                            innerRight = MoveRight(Sorted, innerleft, innerRight);
                        }
                        else if (Sorted[innerleft] + Sorted[innerRight] > aim)
                        {
                            innerRight = MoveRight(Sorted, innerleft, innerRight);
                        }
                        else
                        {
                            innerleft = MoveLeft(Sorted, innerleft, innerRight);
                        }
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
