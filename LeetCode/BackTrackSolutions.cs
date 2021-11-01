using System;
using System.Collections.Generic;


namespace LeetCode
{
    public class BackTrackSolutions
    {
        // 77. Combinations

        public IList<IList<int>> Combine(int n, int k)
        {
            IList<IList<int>> res = new List<IList<int>>();

            BackTrackCombine(n, new List<int>(), res, k, 1);
            return res;
        }

        private void BackTrackCombine(int choices, List<int> path, IList<IList<int>> result, int length, int start)
        {
            if (path.Count == length)
            {
                result.Add(path);
                return;
            }

            for (int i = start; i <= choices; i++)
            {
                List<int> newpath = new List<int>(path);
                newpath.Add(i);
                BackTrackCombine(choices, newpath, result, length, i + 1);

                // faster
                //path.Add(i);
                //BackTrackCombine(choices, path, result, length, i + 1);
                //path.RemoveAt(path.Count - 1);
            }
        }

        // 46. Permutations

        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>();
            BackTrackPermute(new List<int>(nums), new List<int>(), res);
            return res;
        }

        private void BackTrackPermute(List<int> choices, List<int> path, IList<IList<int>> result)
        {
            if (choices.Count == 0)
            {
                result.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < choices.Count; i++)
            {
                path.Add(choices[i]);
                var tchoices = choices.GetRange(0, i);
                tchoices.AddRange(choices.GetRange(i + 1, choices.Count - i - 1));
                BackTrackPermute(tchoices, path, result);
                path.RemoveAt(path.Count - 1);
            }
        }

        //// 784. Letter Case Permutation

        public IList<string> LetterCasePermutation(string s)
        {
            IList<string> res = new List<string>();
            BackTrackLCP(0, s, "", res);
            return res;
        }

        private void BackTrackLCP(int idx, string s, string path, IList<string> res)
        {

            if (idx == s.Length)
            {
                res.Add(path);
                return;
            }

            var c = s[idx];
            if (char.IsLetter(c))
            {
                BackTrackLCP(idx++, s, path + char.ToUpper(c).ToString(), res);
                BackTrackLCP(idx++, s, path + char.ToLower(c).ToString(), res);
            }
            else
            {
                BackTrackLCP(idx++, s, path + c.ToString(), res);
            }
        }
    }
}
