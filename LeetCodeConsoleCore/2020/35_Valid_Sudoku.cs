using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeConsoleCore
{
    class Valid_Sudoku
    {
        static void Main35(string[] args)
        {
            char[] a0 = new char[9] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            char[] a1 = new char[9] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            char[] a2 = new char[9] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            char[] a3 = new char[9] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            char[] a4 = new char[9] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            char[] a5 = new char[9] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            char[] a6 = new char[9] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            char[] a7 = new char[9] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            char[] a8 = new char[9] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };


            char[][] x = new char[9][] { a0, a1, a2, a3, a4, a5, a6, a7, a8 };

            bool res = IsValidSudoku(x);

        }

        static bool IsValidSudoku(char[][] board)
        {
            int high = 9;
            string row = ""; string colu = "";
            int nhigh = 3;
            string[][] test = new string[3][];

            for (int i = 0; i < nhigh; i++)
            {
                test[i] = new string[] { "", "", "" };
            }

            for (int i = 0; i < high; i++)
            {
                row = colu = "";
                for (int j = 0; j < high; j++)
                {
                    if (board[i][j] != '.')
                    {
                        if (!test[i / 3][j / 3].Contains(board[i][j]))
                        {
                            test[i / 3][j / 3] += board[i][j];
                        }
                        else
                        {
                            return false;
                        }
                        if (!row.Contains(board[i][j]))
                        {
                            row += board[i][j];
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (board[j][i] != '.')
                    {
                        if (!colu.Contains(board[j][i]))
                        {
                            colu += board[j][i];
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }


}
