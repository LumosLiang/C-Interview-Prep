
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_242_Valid_Anagram
    {
        public bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length) return false;

            Dictionary<int, int> criteria = new Dictionary<int, int>(), temp = new Dictionary<int, int>();
            int cnt = 0;

            foreach (char c in s)
            {
                if (criteria.ContainsKey(c)) criteria[c]++;
                else criteria.Add(c, 1);
            }

            foreach (char c in t)
            {
                if (temp.ContainsKey(c)) temp[c]++;
                else temp.Add(c, 1);
            }

            foreach (var item in temp)
            {
                if (criteria.ContainsKey(item.Key) && criteria[item.Key] == item.Value) cnt++;
            }

            if (cnt == criteria.Count) return true;
            else return false;
        }
    }
}
