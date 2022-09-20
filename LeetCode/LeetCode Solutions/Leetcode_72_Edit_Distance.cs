using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_72_Edit_Distance
    {
        Dictionary<(int i, int j), int> memo = new Dictionary<(int i, int j), int>();

        public int MinDistance(string word1, string word2)
        {

            int l1 = word1.Length, l2 = word2.Length;

            for (int j = 0; j <= word2.Length; j++)
                memo.Add((l1, j), l2 - j);

            for (int i = 0; i < word1.Length; i++)
                memo.Add((i, l2), l1 - i);

            // Console.WriteLine(memo);
            return Helper(word1, word2, 0, 0);

        }


        public int Helper(string word1, string word2, int i, int j)
        {
            if (!memo.ContainsKey((i, j)))
            {
                memo[(i, j)] = 0;

                if (word1[i] == word2[j])
                    memo[(i, j)] = Helper(word1, word2, i + 1, j + 1);

                else
                {
                    memo[(i, j)] = 1 + Math.Min(Helper(word1, word2, i + 1, j + 1),
                                    Math.Min(Helper(word1, word2, i + 1, j),
                                    Helper(word1, word2, i, j + 1)));
                }
            }
            return memo[(i, j)];
        }
    }
}
