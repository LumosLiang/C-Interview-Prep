//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode.LeetCode_Solutions
//{
//    class Leetcode_264_Ugly_Number_II
//    {
//        public int NthUglyNumber(int n)
//        {

//            return Solution2(n);
//        }

//        public int Solution1(int n)
//        {
//            if (n == 1) return 1;

//            int cnt = 0;
//            var visited = new HashSet<Int64> { 2, 3, 5 };

//            var pq = new PriorityQueue<Int64, Int64>();

//            pq.Enqueue(2, 2);
//            pq.Enqueue(3, 3);
//            pq.Enqueue(5, 5);

//            while (cnt < n - 2)
//            {
//                var curr = pq.Dequeue();
//                cnt++;
//                if (!visited.Contains(curr * 2))
//                {
//                    pq.Enqueue(curr * 2, curr * 2);
//                    visited.Add(curr * 2);
//                }
//                if (!visited.Contains(curr * 3))
//                {
//                    pq.Enqueue(curr * 3, curr * 3);
//                    visited.Add(curr * 3);
//                }
//                if (!visited.Contains(curr * 5))
//                {
//                    pq.Enqueue(curr * 5, curr * 5);
//                    visited.Add(curr * 5);
//                }
//            }

//            return (int)pq.Peek();
//        }

//        public int Solution2(int n)
//        {

//            if (n == 1) return 1;

//            int cnt = 0;

//            var pq = new PriorityQueue<(long val, int factor), long>();

//            pq.Enqueue((2, 2), 2);
//            pq.Enqueue((3, 3), 3);
//            pq.Enqueue((5, 5), 5);

//            while (cnt < n - 2)
//            {
//                (var currVal, var currFactor) = pq.Dequeue();
//                pq.Enqueue((currVal * 5, 5), currVal * 5);
//                if (currFactor < 5)
//                    pq.Enqueue((currVal * 3, 3), currVal * 3);
//                if (currFactor < 3)
//                    pq.Enqueue((currVal * 2, 2), currVal * 2);
//                cnt++;
//            }

//            return (int)pq.Peek().Item1;

//        }
//    }
//}
