using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_733_Flood_Fill
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            int m = image.Length, n = image[0].Length, originColor = image[sr][sc];
            bool[][] visited = new bool[m][];
            for (int i = 0; i < visited.Length; i++) visited[i] = new bool[n];
 
            Queue<int[]> q = new Queue<int[]>();
            q.Enqueue(new int[] { sr, sc});

            while (q.Count != 0)
            {
                var temp = q.Dequeue();
                int i = temp[0], j = temp[1];
                image[i][j] = newColor;
                visited[i][j] = true;

                List<int[]> neighbors = new List<int[]>
                {
                    new int[]{i + 1, j},
                    new int[]{i - 1, j},
                    new int[]{i, j + 1},
                    new int[]{i, j - 1},
                };

                foreach (var item in neighbors)
                {
                    int k = item[0], l = item[1];
                    if (k < m && k >= 0 && l < n && l >= 0 && visited[k][l] != true && image[k][l] == originColor)
                    {
                        image[k][l] = newColor;
                        q.Enqueue(item);
                    }
                }
            }
            return image;
        }
    }
}
