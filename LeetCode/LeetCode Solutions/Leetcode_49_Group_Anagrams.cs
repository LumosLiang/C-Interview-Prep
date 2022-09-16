using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_49_Group_Anagrams
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

            Dictionary<string, List<string>> hash = new Dictionary<string, List<string>>();

            foreach (var str in strs)
            {
                string k = SortString(str);
                if (!hash.ContainsKey(k))
                {
                    hash[k] = new List<string>() { str };
                }
                else
                    hash[k].Add(str);

            }

            IList<IList<string>> res = new List<IList<string>>();
            foreach (var value in hash.Values)
            {
                res.Add(value);
            }

            return res;

        }

        private string SortString(string s)
        {
            var res = s.ToCharArray();
            Array.Sort(res);
            return String.Join("", res);
        }
    }
}
