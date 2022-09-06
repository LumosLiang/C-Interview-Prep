
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
                List<char> tempCol = new List<char>();
                for (int j = 0; j < 9; j++)
                {
                    tempCol.Add(board[j][i]);
                }
                if (!IsValidUnit(tempCol)) return false;

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
                    List<char> tempCol = new List<char>();
                    // generate cube
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int m = j; m < j + 3; m++)
                        {
                            tempCol.Add(board[k][m]);
                        }
                    }
                    if (!IsValidUnit(tempCol)) return false;
                }
            }
            return true;
        }

        private bool IsValidUnit(List<char> array)
        {
            List<char> withOutEmpty = new List<char>();

            foreach (char c in array)
            {
                if (c != '.') withOutEmpty.Add(c);
            }

            HashSet<char> s = new HashSet<char>(withOutEmpty);

            return withOutEmpty.Count == s.Count;
        }
    }
}

