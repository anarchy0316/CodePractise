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
            _0042_Trapping_Rain_Water a = new _0042_Trapping_Rain_Water();
            Console.WriteLine(a.Trap(new int[] { 4, 3, 2, 1, 0, 1, 2, 3, 4 }));
        }
    }
}