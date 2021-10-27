
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Leetcode_36_Valid_Sudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            return IsValidCol(board) && IsValidRow(board) && IsValidCube(board);
        }

        private bool IsValidRow(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!IsValidUnit(new List<char>(board[i]))) return false;
            }
            return true;
        }

        private bool IsValidCol(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                List<char> tempcol = new List<char>();
                for (int j = 0; j < 9; j++)
                {
                    tempcol.Add(board[j][i]);
                }
                if (!IsValidUnit(tempcol)) return false;

            }
            return true;
        }

        private bool IsValidCube(char[][] board)
        {
            //extract each cube's start point
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 9; j += 3)
                {
                    List<char> tempcol = new List<char>();
                    // generate cube
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int m = j; m < j + 3; m++)
                        {
                            tempcol.Add(board[k][m]);
                        }
                    }
                    if (!IsValidUnit(tempcol)) return false;
                }
            }
            return true;
        }

        private bool IsValidUnit(List<char> array)
        {
            List<char> withoutempty = new List<char>();

            foreach (char c in array)
            {
                if (c != '.') withoutempty.Add(c);
            }

            HashSet<char> s = new HashSet<char>(withoutempty);

            return withoutempty.Count == s.Count;
        }
    }
}

