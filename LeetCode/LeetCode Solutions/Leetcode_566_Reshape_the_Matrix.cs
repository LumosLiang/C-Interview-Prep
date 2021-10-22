using System.Collections.Generic;
using System.Text;
namespace LeetCode
{
    public class Leetcode_566_Reshape_the_Matrix
    {

        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length, n = mat[0].Length;

            if (r * c != m * n) return mat;

            int[][] res = new int[r][];

            for (int k = 0; k < r; k++)
            {
                res[k] = new int[c];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int newi = (i * n + j) / c;
                    int newj = (i * n + j) % c;
                    res[newi][newj] = mat[i][j];
                }
            }
            

            return res;
        }
    }
}
