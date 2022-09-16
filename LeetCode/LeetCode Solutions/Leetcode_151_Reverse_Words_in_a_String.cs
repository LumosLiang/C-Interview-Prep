using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_151_Reverse_Words_in_a_String
    {
        public string ReverseWords(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int l = 0, r = sb.Length - 1;

            // remove outter 0
            while (l < r && sb[l] == ' ') l++;
            while (l < r && sb[r] == ' ') r--;

            int start = l, end = r;

            //Console.WriteLine(sb.ToString(start, end - start + 1));

            // remove inner 0
            int p1 = start, p2 = start;
            while (p2 <= end)
            {
                if (sb[p2] == ' ')
                {
                    sb[p1] = sb[p2];
                    p1++;
                    while (p2 <= end && sb[p2] == ' ')
                        p2++;
                }
                else
                {
                    sb[p1] = sb[p2];
                    p1++;
                    p2++;
                }
            }

            end = p1 - 1;

            //Console.WriteLine(sb.ToString(start, end - start + 1));


            // reverse
            Reverse(sb, start, end);

            //Console.WriteLine(sb.ToString(start, end - start + 1));

            // process
            p1 = start;
            p2 = start;
            while (p2 <= end)
            {
                if (sb[p2] == ' ')
                {
                    Reverse(sb, p1, p2 - 1);
                    p1 = p2 + 1;
                }
                else if (p2 == end)
                    Reverse(sb, p1, p2);
                p2++;
            }

            //Console.WriteLine(sb.ToString(start, end - start + 1));

            return sb.ToString(start, end - start + 1);

        }

        public void Reverse(StringBuilder s, int left, int right)
        {
            while (left < right)
            {
                var temp = s[right];
                s[right] = s[left];
                s[left] = temp;
                left++;
                right--;
            }
        }
    }
}
