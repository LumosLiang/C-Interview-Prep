namespace LeetCode
{
    public class Leetcode_74_Search_A_2D_Matrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            var w = matrix.Length;
            var l = matrix[0].Length;

            var lo = 0;
            var hi = w * l - 1;

            while (lo <= hi)
            {
                var mid = lo + (hi - lo) / 2;
                if (matrix[mid / l][mid % l] == target) return true;
                else if (matrix[mid / l][mid % l] > target) hi = mid - 1;
                else lo = mid + 1;
            }
            return false;
        }
    }
}