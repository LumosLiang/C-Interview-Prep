

namespace LeetCode
{
    public class Leetcode_344_Reverse_String

    {
        public void ReverseString(char[] s)
        {
            int l = 0, r = s.Length - 1;
            while (l < r)
            {
                char temp = s[l];
                s[l] = s[r];
                s[r] = temp;
                l++;
                r--;
            }

        }
    }
}
