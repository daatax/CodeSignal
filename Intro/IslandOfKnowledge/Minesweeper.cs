using System;

namespace Intro.IslandOfKnowledge {

    /// <summary>
    /// In the popular Minesweeper game you have a board with some mines and those cells 
    /// that don't contain a mine have a number in it that indicates the total number of 
    /// mines in the neighboring cells. Starting off with some arrangement of mines we 
    /// want to create a Minesweeper game setup.
    /// 
    /// Example
    /// For matrix = [[true, false, false],
    ///               [false, true, false],
    ///               [false, false, false]]
    /// the output should be
    /// solution(matrix) = [[1, 2, 1],
    ///                     [2, 1, 1],
    ///                     [1, 1, 1]]
    /// </summary>
    public class Minesweeper {
        public static void Main(string[] args) {
            bool[][] matrix = {
                    new bool[]{ true, false, false },
                    new bool[] { false, true, false },
                    new bool[] { false, false, false }
            };

            int[][] result = solution(matrix);
        }

        public static int[][] solution(bool[][] matrix) {
            int[][] result = new int[matrix.Length][];
            int count;

            for (int i = 0; i < matrix.Length; i++) {
                result[i] = new int[matrix[0].Length];
                for (int j = 0; j < matrix[0].Length; j++) {
                    count = 0;

                    for (int k = i - 1; k < i + 2; k++) {
                        if (k < 0 || k >= matrix.Length) {
                            continue;
                        }
                        for (int l = j - 1; l < j + 2; l++) {
                            if (l < 0 || l >= matrix[0].Length || (i == k && j == l)) {
                                continue;
                            }
                            if (matrix[k][l] == true) {
                                count++;
                            }
                        }
                    }
                    result[i][j] = count;
                }
            }

            return result;
        }

    }
}
