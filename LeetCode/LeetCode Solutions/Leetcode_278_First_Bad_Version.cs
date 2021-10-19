
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_278_First_Bad_Version
    {
        public int FirstBadVersion(int n)
        {
            int left = 0, right = n;

            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (!IsBadVersion(mid)) left = mid + 1;
                else right = mid;
            }

            return left;
        }

        //public int FirstBadVersion2(int n)
        //{
        //    return Helper(1, n);
        //}

        //private int Helper(int start, int end)
        //{
        //    if (start > end) return -1;

        //    int mid = start + (end - start) / 2;
        //    if (!IsBadVersion(mid)) return Helper(mid + 1, end);
        //    else return Helper(start, mid);
        //}

        private bool IsBadVersion(int mid)
        {
            throw new NotImplementedException();
        }
    }
}

