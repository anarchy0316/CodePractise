using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{

    public class _0017_LetterCombinationsOfAPhoneNumber
    {
        public static Dictionary<int, List<char>> LookUp = new Dictionary<int, List<char>>
        {
            {2,new List<char>{ 'a','b','c'} },
            {3,new List<char>{ 'd','e','f'} },
            {4,new List<char>{ 'g','h','i'} },
            {5,new List<char>{ 'j','k','l'} },
            {6,new List<char>{ 'm','n','o'} },
            {7,new List<char>{ 'p','q','r','s'} },
            {8,new List<char>{ 't','u','v'} },
            {9,new List<char>{ 'w','x','y','z'} },

        };
        public IList<string> LetterCombinations(string digits)
        {
            var result = new List<string>();
            var nums = new List<int>();
            foreach (var ch in digits)
            {
                nums.Add(int.Parse(ch.ToString()));
            }
            List<int> Limit = nums.Select(x => LookUp[x].Count).ToList();
            if (nums.Count == 0)
            {
                return new List<string>();
            }
            result = LookUp[nums[0]].ConvertAll(x => x.ToString());
            for (int i = 1; i < nums.Count; i++)
            {
                var ListTtemp = new List<string>();
                foreach (var it in result)
                {
                    foreach (var item in LookUp[nums[i]])
                    {
                        ListTtemp.Add(it + item.ToString());
                    }
                }
                result = ListTtemp;
            }
            return result;

        }

    }
}
