using System.Collections.Generic;
using System.Text;
namespace LeetCode
{
    public class Leetcode_557_Reverse_Words_in_a_String_III
    {
        public string ReverseWords(string s)
        {
            string res = "";
            var substrs = s.Split(' ');
            
            foreach (string substr in substrs)
            {
                StringBuilder temp = new StringBuilder(substr);
                int l = 0, r = temp.Length - 1;
                while (l < r)
                {
                    var t = temp[l];
                    temp[l] = temp[r];
                    temp[r] = t;
                    l++;
                    r--;
                }
                res += temp + " ";
            }

            return res.TrimEnd();
        }

    }
}
