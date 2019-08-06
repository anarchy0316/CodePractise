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
            _0022_Generate_Parentheses a = new _0022_Generate_Parentheses();
            foreach (var item in a.GenerateParenthesis(4))
            {
                Console.WriteLine(item);

            }

        }
    }
}
