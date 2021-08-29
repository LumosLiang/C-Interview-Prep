using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Leetcode_1431_Kids_With_the_Greatest_Number_of_Candies

    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {

            var max = candies.Max();
            return candies.Select(c => c + extraCandies >= max).ToList();

        }
    }
}