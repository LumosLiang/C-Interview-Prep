using System.Collections.Generic;
using System.Text;
namespace LeetCode
{
    public class Leetcode_567_Permutation_in_String
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int l = 0;
            Dictionary<int, int> window = new Dictionary<int, int>(), criteria = new Dictionary<int, int>();

            for (int i = 0; i < s1.Length; i++)
            {
                if (criteria.ContainsKey(s1[i])) criteria[s1[i]]++;
                else criteria.Add(s1[i], 1);
            }

            for (int r = 0; r < s2.Length; r++)
            {
                if (window.ContainsKey(s2[r])) window[s2[r]]++;
                else window.Add(s2[r], 1);

                if (r - l + 1 == s1.Length)
                {
                    int temp = 0;
                    foreach (var item in window)
                    {
                        if (criteria.ContainsKey(item.Key) && criteria[item.Key] == item.Value) temp++;
                    }
                    if (temp == criteria.Count) return true;
                    else
                    {
                        window[s2[l]]--;
                        if (window[s2[l]] == 0) window.Remove(s2[l]);
                        l++;
                    }
                }
            }
            return false;
        }
    }
}
