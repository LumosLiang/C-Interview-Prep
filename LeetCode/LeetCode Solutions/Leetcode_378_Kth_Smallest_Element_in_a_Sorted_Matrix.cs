using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.LeetCode_Solutions
{
    class Leetcode_378_Kth_Smallest_Element_in_a_Sorted_Matrix
    {
        public int KthSmallest(int[][] matrix, int k)
        {

            int length = matrix.Length;
            var pq = new PriorityQueue<(int row, int col), int>();
            pq.Enqueue((0, 0), matrix[0][0]);
            
           
            var visited = new HashSet<(int row, int col)>
            {
                (0, 0)
            };

            for (int i = 0; i < k - 1; i++)
            {
                (int x, int y) = pq.Dequeue();

                var choice1 = (x + 1, y);
                var choice2 = (x, y + 1);

                if (x + 1 < length && !visited.Contains(choice1))
                {
                    pq.Enqueue(choice1, matrix[x + 1][y]);
                    visited.Add(choice1);
                }
                if (y + 1 < length && !visited.Contains(choice2))
                {
                    pq.Enqueue(choice2, matrix[x][y + 1]);
                    visited.Add(choice2);
                }

            }

            (int l1, int l2) = pq.Peek();
            return matrix[l1][l2];



        }
    }
}
