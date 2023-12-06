using System;

namespace Intro.LandOfLogic {
    /// <summary>
    /// Sudoku is a number-placement puzzle. The objective is to fill a 9 × 9 grid 
    /// with digits so that each column, each row, and each of the nine 3 × 3 sub-grids 
    /// that compose the grid contains all of the digits from 1 to 9.
    /// 
    /// This algorithm should check if the given grid of numbers represents a correct solution to Sudoku.
    /// 
    /// Example
    /// For grid = [[1, 3, 2, | 5, 4, 6, | 9, 8, 7],
    ///             [4, 6, 5, | 8, 7, 9, | 3, 2, 1],
    ///             [7, 9, 8, | 2, 1, 3, | 6, 5, 4],
    ///             ----------+----------+---------
    ///             [9, 2, 1, | 4, 3, 5, | 8, 7, 6],
    ///             [3, 5, 4, | 7, 6, 8, | 2, 1, 9],
    ///             [6, 8, 7, | 1, 9, 2, | 5, 4, 3],
    ///             ----------+----------+---------            
    ///             [5, 7, 6, | 9, 8, 1, | 4, 3, 2],
    ///             [2, 4, 3, | 6, 5, 7, | 1, 9, 8],
    ///             [8, 1, 9, | 3, 2, 4, | 7, 6, 5]]
    /// the output should be
    /// solution(grid) = true;
    /// 
    /// For grid = [[8, 3, 6, | 5, 3, 6, | 7, 2, 9],
    ///             [4, 2, 5, | 8, 7, 9, | 3, 8, 1],
    ///             [7, 9, 1, | 2, 1, 4, | 6, 5, 4],
    ///             ----------+----------+---------
    ///             [9, 2, 1, | 4, 3, 5, | 8, 7, 6],
    ///             [3, 5, 4, | 7, 6, 8, | 2, 1, 9],
    ///             [6, 8, 7, | 1, 9, 2, | 5, 4, 3],
    ///             ----------+----------+---------
    ///             [5, 7, 6, | 9, 8, 1, | 4, 3, 2],
    ///             [2, 4, 3, | 6, 5, 7, | 1, 9, 8],
    ///             [8, 1, 9, | 3, 2, 4, | 7, 6, 5]]
    /// the output should be
    /// solution(grid) = false.
    /// 
    /// The output should be false: each of the nine 3 × 3 
    /// sub-grids should contain all of the digits from 1 to 9.
    /// These examples are represented on the image below.
    /// </summary>
    public class Sudoku {
        public static void Main(string[] args) {
            int[][] grid = {
                 new int[] { 1, 3, 2, 5, 4, 6, 9, 8, 7 },
                 new int[] { 4, 6, 5, 8, 7, 9, 3, 2, 1 },
                 new int[] { 7, 9, 8, 2, 1, 3, 6, 5, 4 },
                 new int[] { 9, 2, 1, 4, 3, 5, 8, 7, 6 },
                 new int[] { 3, 5, 4, 7, 6, 8, 2, 1, 9 },
                 new int[] { 6, 8, 7, 1, 9, 2, 5, 4, 3 },
                 new int[] { 5, 7, 6, 9, 8, 1, 4, 3, 2 },
                 new int[] { 2, 4, 3, 6, 5, 7, 1, 9, 8 },
                 new int[] { 8, 1, 9, 3, 2, 4, 7, 6, 5 }
            };
            Console.WriteLine(solution(grid));
        }

        public static bool solution(int[][] grid) {
            int[][] reversedGrid = new int[grid.Length][];
            bool areAllRowsCorrect = true;
            bool areAllColumnsCorrect = true;
            bool areAll3x3GridCorrect = true;

            // check if all rows contain 1-9 
            for (int i = 0; i < grid.Length; i++) {
                areAllRowsCorrect = grid[i].OrderBy(x => x).SequenceEqual(Enumerable.Range(1, 9));
                if (!areAllRowsCorrect) {
                    return false;
                }
            }

            // reverse the array to check if the all columns are correct
            for (int i = 0; i < grid.Length; i++) {
                reversedGrid[i] = new int[grid[i].Length];
                for (int j = 0; j < reversedGrid[i].Length; j++) {
                    reversedGrid[i][j] = grid[j][i];
                }
            }

            // check if all columns contain 1-9
            for (int i = 0; i < reversedGrid.Length; i++) {
                areAllColumnsCorrect = reversedGrid[i].OrderBy(x => x).SequenceEqual(Enumerable.Range(1, 9));
                if (!areAllColumnsCorrect) {
                    return false;
                }
            }

            // check if all 3x3 grid contain 1-9
            for (int boxRow = 0; boxRow < 3; boxRow++) {
                for (int boxCol = 0; boxCol < 3; boxCol++) {
                    int[] subGrid = Enumerable.Range(0, 9)
                                        .Select(index => grid[3 * boxRow + index / 3][3 * boxCol + index % 3])
                                        .ToArray();

                    areAll3x3GridCorrect = subGrid.OrderBy(x => x).SequenceEqual(Enumerable.Range(1, 9));

                    if (!areAll3x3GridCorrect) {
                        return false;
                    }
                }
            }

            return areAllRowsCorrect && areAllColumnsCorrect && areAll3x3GridCorrect;
        }
    }
}