using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_46_Permutations
    {

        IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> Permute(int[] nums)
        {

            helper(new List<int>(nums), new List<int>());
            return res;
        }

        public void helper(List<int> choices, List<int> path)
        {
            if (choices.Count == 0)
            {
                res.Add(path);
                return;

            }

            for (int i = 0; i < choices.Count; i++)
            {
                var tpath = new List<int>(path);
                tpath.Add(choices[i]);
                var tchoices = new List<int>(choices);
                tchoices.RemoveAt(i);
                helper(tchoices, tpath);
            }

        }
    }


}
