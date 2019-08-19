using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode
{
    public class _0071_Simplify_Path
    {
        public string SimplifyPath(string path)
        {
            while (path.Contains("//"))
            {
                path = path.Replace("//", "/");
            }
            while (path.Contains("/./"))
            {
                path = path.Replace("/./", "/");
            }
            Console.WriteLine(path);
            path = path.TrimStart('/');
            path = path.TrimEnd('/');

            var list = path.Split('/');
            Stack<string> st = new Stack<string>();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == "..")
                {
                    if (st.Count > 0)
                    {
                        st.Pop();
                    }
                }
                else
                {
                    st.Push(list[i]);
                }
            }
            var result = string.Empty;
            while (st.Count > 0)
            {
                result = "/" + st.Pop() + result;
            }
            if (result.EndsWith("/."))
            {
                result = result.Substring(0, result.Length - 2);
            }
            if (result == string.Empty)
            {
                return "/";
            }
            return result;
        }
    }
}
