
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_47_Permutations_II
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            Helper(new List<int>(nums), new List<int>(), res);
            return res;
        }

        public void Helper(List<int> choices, List<int> path, IList<IList<int>> res)
        {
            if (choices.Count == 0)
            {
                res.Add(path);
                return;
            }
            for (int i = 0; i < choices.Count; i++)
            {
                if (i > 0 && choices[i] == choices[i - 1])
                {
                    continue;
                }
                var tempPath = new List<int>(path);
                tempPath.Add(choices[i]);
                var tempChoices = new List<int>(choices);
                tempChoices.RemoveAt(i);
                Helper(tempChoices, tempPath, res);

            }
        }

        public void Helper2(List<int> choices, List<int> path, IList<IList<int>> res)
        {
            if (choices.Count == 0)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < choices.Count; i++)
            {
                if (i > 0 && choices[i] == choices[i - 1]) continue;

                path.Add(choices[i]);
                var temp = choices[i];
                choices.RemoveAt(i);

                Helper2(choices, path, res);

                choices.Insert(i, temp);
                path.RemoveAt(path.Count - 1);

            }
        }
    }
}