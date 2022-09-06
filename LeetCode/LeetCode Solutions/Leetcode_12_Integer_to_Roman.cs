
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
                { 1000,"M"},
                { 900,"CM"},
                { 500,"D"},
                { 400,"CD"},
                { 100,"C"},
                { 90,"XC"},
                { 50,"L"},
                { 40,"XL"},
                { 10,"X"},
                { 9,"IX"},
                { 5,"V"},
                { 4,"IV"},
                { 1,"I"},
            };

            var res = "";

            foreach (int key in table.Keys)
            {
                while (num >= key)
                {
                    res += table[key];
                    num -= key;
                }
            }

            return res;
        }
    }
}

