using System.Linq;

namespace LeetCode
{
    public class Leetcode_875_Koko_Eating_Bananas
    {
        public int MinEatingSpeed(int[] piles, int h)
        {

            var lo = 1;
            var hi = piles.Max();

            while (lo < hi)
            {
                var mid = lo + (hi - lo) / 2;
                var t = 0;

                foreach (var p in piles)
                {
                    if (p % mid == 0) t += p / mid;
                    else t += p / mid + 1;
                }

                if (t > h) lo = mid + 1;
                else hi = mid;
            }
            return hi;
        }
    }
}