using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_43_Multiply_Strings
    {
        public string Multiply(string num1, string num2)
        {
            int l1 = num1.Length, l2 = num2.Length;

            int[] res = new int[l1 + l2];

            for (int i = l1 - 1; i >= 0; i--)
            {
                for (int j = l2 - 1; j >= 0; j--)
                {
                    int v1 = num1[i] - '0', v2 = num2[j] - '0';
                    int mul = v1 * v2;
                    int s = res[i + j + 1] + mul;

                    res[i + j + 1] = s % 10;
                    res[i + j] += s / 10;
                }
            }

            string ans = "";
            foreach (int item in res) ans += item.ToString();

            ans = ans.TrimStart('0');

            if (ans != "") return ans;
            return "0";
        }



    }
}
