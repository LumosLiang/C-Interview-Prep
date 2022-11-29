using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    public class Leetcode_692_Top_K_Frequent_Words
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {

            var hash = new Dictionary<string, int>();
            var res = new string[k];

            foreach (var word in words)
            {
                if (!hash.ContainsKey(word))
                    hash.Add(word, 0);
                hash[word]++;
            }

            var pq = new PriorityQueue<string, (string word, int freq)>(new PriorityComparer());

            foreach (var item in hash)
            {
                if (pq.Count < k)
                    pq.Enqueue(item.Key, (item.Key, item.Value));
                else
                    pq.EnqueueDequeue(item.Key, (item.Key, item.Value));
            }

            int idx = k - 1;
            while (pq.Count > 0)
            {
                res[idx] = pq.Dequeue();
                idx--;
            }

            return new List<string>(res);
        }


        public class PriorityComparer : IComparer<(string word, int freq)>
        {
            public int Compare((string word, int freq) x, (string word, int freq) y)
            {
                if (x.freq == y.freq)
                    return y.word.CompareTo(x.word);
                return x.freq.CompareTo(y.freq);
            }
        }
    }
}
