using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            _0015_3Sum a = new _0015_3Sum();
            foreach (var item in a.ThreeSum(new int[] { 0, -4, -1, -4, -2, -3, 2 }))
            {
                foreach (var s in item)
                {
                    Console.Write(s + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
