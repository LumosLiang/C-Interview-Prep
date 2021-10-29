using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_695_Max_Area_of_Island
    {
        public int MaxAreaOfIsland(int[][] grid)
        {
            int m = grid.Length, n = grid[0].Length, res = 0;

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        int temp = 0;
                        grid[i][j] = 0;

                        Queue<int[]> q = new Queue<int[]>();
                        q.Enqueue(new int[] {i,j });

                        while (q.Count != 0)
                        {
                            var coord = q.Dequeue();
                            temp++;
                            int x = coord[0], y = coord[1];

                            List<int[]> neighbors = new List<int[]>
                            {
                                new int[]{x + 1, y},
                                new int[]{x - 1, y},
                                new int[]{x, y + 1},
                                new int[]{x, y - 1},
                            };

                            foreach (var item in neighbors)
                            {
                                int k = item[0], l = item[1];
                                if (k < m && k >= 0 && l < n && l >= 0 && grid[k][l] == 1)
                                {
                                    grid[k][l] = 0;
                                    q.Enqueue(item);
                                }
                            }

                        }
                        res = Math.Max(res, temp);
                        
                    }

                }
            }

            return res;
        }
    }
}