using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    //https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/
    public class _0026_Remove_Duplicates_From_Sorted_Array
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            int CurrentPos = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[CurrentPos] != nums[i])
                {
                    nums[CurrentPos + 1] = nums[i];
                    CurrentPos++;
                }
            }
            return CurrentPos + 1;
        }
    }
}
