using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _4_Median_of_Two_Sorted_Arrays
    {
        /*
        给定两个大小为 m 和 n 的有序数组 nums1 和 nums2。
        请你找出这两个有序数组的中位数，并且要求算法的时间复杂度为 O(log(m + n))。
        你可以假设 nums1 和 nums2 不会同时为空。

        示例 1:
        nums1 = [1, 3]
        nums2 = [2]
        则中位数是 2.0
        来源：力扣（LeetCode）
        链接：https://leetcode-cn.com/problems/median-of-two-sorted-arrays   
        著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
        */
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var DoubleCut1 = nums1.Length;
            var DoubleCut2 = nums2.Length;
            Tuple<int, int> L_R_1;
            Tuple<int, int> L_R_2;
            L_R_1 = GetLMax_Rmin(nums1, DoubleCut1);
            L_R_2 = GetLMax_Rmin(nums2, DoubleCut2);
            var Limit_L_1 = 0;
            var Limit_R_1 = 2 * nums1.Length - 2;
            var Limit_L_2 = 0;
            var Limit_R_2 = 2 * nums2.Length - 2;

            while (L_R_1.Item1 > L_R_2.Item2 || L_R_2.Item1 > L_R_1.Item2)
            {
                if (L_R_1.Item1 > L_R_2.Item2) //说明 cut1 太右
                {
                    //两种做法 1.  cut1 左移（二分 1左） 2. cut2 右移动 （二分 2右）
                    //当然是取较为小的一边进行二分

                    Limit_R_1 = DoubleCut1;//更新 cut1 右边界
                    Limit_L_2 = DoubleCut2;//更新 cut2 左边界

                    if (DoubleCut1 - Limit_L_1 < Limit_R_2 - DoubleCut2)//cut1 左移
                    {
                        DoubleCut1 = (DoubleCut1 + Limit_L_1) / 2;
                        DoubleCut2 = DoubleCut2 + (Limit_R_1 - DoubleCut1);// L1 cut 左移动多少 l2 cut就右移多少
                    }
                    else                                                //cut2 右移
                    {
                        DoubleCut2 = (DoubleCut2 + Limit_R_2) / 2;
                        DoubleCut1 = DoubleCut1 + (Limit_L_2 - DoubleCut2);
                    }

                }
                else                    //说明 cut1 太左
                {
                    Limit_L_1 = DoubleCut1;//更新 cut1 左边界
                    Limit_R_2 = DoubleCut2;//更新 cut2 右边界

                    if (DoubleCut2 - Limit_L_2 < Limit_R_1 - DoubleCut1) //cut2 左移
                    {
                        DoubleCut2 = (DoubleCut2 + Limit_L_2) / 2;
                        DoubleCut1 = DoubleCut1 + (Limit_R_2 - DoubleCut2);// L2 cut 左移动多少 l1 cut就右移多少
                    }
                    else                                                 //cut1 右移
                    {
                        DoubleCut1 = (DoubleCut1 + Limit_R_1) / 2;
                        DoubleCut2 = DoubleCut2 + (Limit_L_1 - DoubleCut1);
                    }

                }
                L_R_1 = GetLMax_Rmin(nums1, DoubleCut1);
                L_R_2 = GetLMax_Rmin(nums2, DoubleCut2);
            }











            bool Cut1_Is_Even = DoubleCut1 % 2 == 0;
            bool Cut2_Is_Even = DoubleCut2 % 2 == 0;

            if (Cut1_Is_Even && Cut2_Is_Even)
            {
                return (L_R_1.Item1 + L_R_2.Item1) / 2.0f;
            }
            if (Cut1_Is_Even && !Cut2_Is_Even)
            {
                List<int> temp = new List<int> { L_R_1.Item1, L_R_2.Item1, L_R_2.Item2 };
                temp.Sort();
                return temp[1];
            }
            if (Cut2_Is_Even && !Cut1_Is_Even)
            {
                List<int> temp = new List<int> { L_R_2.Item1, L_R_1.Item1, L_R_1.Item2 };
                temp.Sort();
                return temp[1];
            }
            if (!Cut2_Is_Even && !Cut1_Is_Even)
            {
                List<int> temp = new List<int> { L_R_2.Item1, L_R_2.Item2, L_R_1.Item1, L_R_1.Item2 };
                temp.Sort();
                return (temp[1] + temp[2]) / 2.0f;
            }
        }


        public Tuple<int, int> GetLMax_Rmin(int[] num, int DoubleCut)
        {
            if (DoubleCut % 2 == 0)
            {
                return new Tuple<int, int>(num[DoubleCut / 2], num[DoubleCut / 2]);
            }
            else
            {
                return new Tuple<int, int>(num[DoubleCut / 2], num[DoubleCut / 2 + 1]);
            }
        }
    }
}
