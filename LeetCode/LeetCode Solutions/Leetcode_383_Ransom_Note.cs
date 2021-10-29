
using System;
using System.Collections.Generic;

namespace LeetCode
{
    // ransomNote's key are all included in the magazine's, and its value is <= magazine's
    public class Leetcode_383_Ransom_Note
    {
        // 1 dict
        public bool CanConstruct(string ransomNote, string magazine)
        {
            if (ransomNote.Length > magazine.Length) return false;

            Dictionary<int, int> criteria = new Dictionary<int, int>();
            

            foreach (char c in magazine)
            {
                if (criteria.ContainsKey(c)) criteria[c]++;
                else criteria.Add(c, 1);
            }

            foreach (char c in ransomNote)
            {
                if (criteria.ContainsKey(c)) criteria[c]--;
                else return false;
            }

            foreach (var item in criteria)
            {
                if (item.Value < 0) return false;
            }

            return true;
            
        }

        // 2 dict
        public bool CanConstruct2(string ransomNote, string magazine)
        {

            Dictionary<int, int> criteria = new Dictionary<int, int>(), temp = new Dictionary<int, int>();
            int cnt = 0;

            foreach (char c in magazine)
            {
                if (criteria.ContainsKey(c)) criteria[c]++;
                else criteria.Add(c, 1);
            }

            foreach (char c in ransomNote)
            {
                if (temp.ContainsKey(c)) temp[c]++;
                else temp.Add(c, 1);
            }

            foreach (var item in temp)
            {
                if (criteria.ContainsKey(item.Key) && criteria[item.Key] >= item.Value) cnt++;
            }

            if (cnt == temp.Count) return true;
            else return false;
        }
    }
}

