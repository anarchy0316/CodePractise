using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0027_Remove_Element
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int CurrentPos = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (val != nums[i])
                {
                    nums[CurrentPos] = nums[i];
                    CurrentPos++;
                }
            }
            return CurrentPos;
        }
    }
}
