using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ArrayBFSSolutions
    {
        //542. 01 Matrix

        public int[][] UpdateMatrix(int[][] mat)
        {
            int m = mat.Length, n = mat[0].Length;
            int[] DIR = new int[] { 0, 1, 0, -1, 0 };

            Queue<int[]> q = new Queue<int[]>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i][j] == 0) q.Enqueue(new int[] { i, j });
                    else mat[i][j] = -1;
                }
            }

            while (q.Count != 0)
            {
                var item = q.Dequeue();
                int r = item[0], c = item[1];
                for (int k = 0; k < 4; k++)
                {
                    int nr = r + DIR[k], nc = c + DIR[k + 1];
                    if (nr < 0 || nr >= m || nc < 0 || nc >= n || mat[nr][nc] != -1) continue;
                    mat[nr][nc] = mat[r][c] + 1;
                    q.Enqueue(new int[] { nr, nc });
                }
            }
            
            return mat; 
        }

        //994. Rotting Oranges
        public int OrangesRotting(int[][] grid)
        {

            // first loop, to generate a q and count how many oranges totally.

            int m = grid.Length, n = grid[0].Length, res = 0, countone = 0;
            int[] DIR = new int[] { 0, 1, 0, -1, 0 };
            Queue<int[]> q = new Queue<int[]>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (grid[i][j] != 0)
                    {
                        if (grid[i][j] == 2)
                        {
                            grid[i][j] = -1; // mark as processed
                            q.Enqueue(new int[] { i, j });
                        }
                        else countone += 1;
                       
                    }
                }
            }

            if (q.Count == 0 && countone > 0) return 0;

            // second, BFS, start from rotten one, make all fresh organge rotten.
            while (q.Count != 0)
            {
                Queue<int[]> temp = new Queue<int[]>();
                while (q.Count != 0)
                {
                    var item = q.Dequeue();
                    int r = item[0], c = item[1];
                    for (int k = 0; k < 4; k++)
                    {
                        int nr = r + DIR[k], nc = c + DIR[k + 1];
                        if (nr < 0 || nr >= m || nc < 0 || nc >= n || grid[nr][nc] == 0 || grid[nr][nc] == -1) continue;
                        grid[nr][nc] = -1;
                        countone -= 1;
                        temp.Enqueue(new int[] { nr, nc });
                    }
                }
                q = temp;
                res += 1;
            }

            if (countone == 0) return res;
            else return -1;
        }

    }
}
