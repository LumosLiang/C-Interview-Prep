
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Leetcode_12_Integer_to_Roman
    {
        public string IntToRoman(int num)
        {
            Dictionary<int, string> table = new Dictionary<int, string>
            {
                { 1,"I"},
                { 4,"IV"},
                { 5,"V"},
                { 9,"IX"},
                { 10,"X"},
                { 40,"XL"},
                { 50,"L"},
                { 90,"XC"},
                { 100,"C"},
                { 400,"CD"},
                { 500,"D"},
                { 900,"CM"},
                { 1000,"M"},
                
            };

            var res = "";

            foreach (int key in table.Keys)
            {
                var resid = num / key;
                if (resid != 0)
                {
                    res += new StringBuilder().Insert(0, table[key], resid).ToString();
                    num %= key;
                }

            }
            
            return res;
        }
    }
}

