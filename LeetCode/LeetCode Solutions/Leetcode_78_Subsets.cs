
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_78_Subsets
    {
        IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> Subsets(int[] nums)
        {

            helper(new List<int>(nums), new List<int>());
            return res;
        }

        public void helper(List<int> choices, List<int> path)
        {

            res.Add(path);
            for (int i = 0; i < choices.Count; i++)
            {
                var tpath = new List<int>(path);
                tpath.Add(choices[i]);
                var tchoices = choices.GetRange(i + 1, choices.Count - i - 1);
                helper(tchoices, tpath);
            }
        }

    }

}
