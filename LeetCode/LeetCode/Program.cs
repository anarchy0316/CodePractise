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
            var readin = Console.ReadLine();
            var strs = readin.Split('-');
            var result = new StringBuilder();
            foreach (var str in strs)
            {
                result.Append("_");
                var tp = str.Substring(0, 1).ToUpper() + str.Substring(1);
                result.Append(tp);
            }
            Console.WriteLine(result.ToString().Substring(1));
            Console.ReadKey();
        }
    }
}
