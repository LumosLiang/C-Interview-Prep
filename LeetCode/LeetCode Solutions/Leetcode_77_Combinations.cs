
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_77_Combinations
    {
        IList<IList<int>> res = new List<IList<int>>();

        public IList<IList<int>> Combine(int n, int k)
        {
            Helper(0, new List<int>(), n, k);
            return res;
        }

        public void Helper(int index, List<int> path, int n, int k)
        {
            if (path.Count == k)
            {
                res.Add(new List<int>(path));
                return;
            }

            for (int i = index; i < n + 1; i++)
            {
                path.Add(i);
                Helper(i + 1, path, n, k);
                path.RemoveAt(path.Count - 1);
            }

        }

    }

}
