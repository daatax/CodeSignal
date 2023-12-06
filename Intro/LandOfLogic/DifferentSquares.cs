using System;

namespace Intro.LandOfLogic {
    /// <summary>
    /// Given a rectangular matrix containing only digits, 
    /// calculate the number of different 2 × 2 squares in it.
    /// 
    /// Example
    /// For matrix = [[1, 2, 1],
    ///               [2, 2, 2],
    ///               [2, 2, 2],
    ///               [1, 2, 3],
    ///               [2, 2, 1]]
    /// the output should be
    /// solution(matrix) = 6.
    /// 
    /// Here are all 6 different 2 × 2 squares:
    /// 1 2
    /// 2 2
    /// ---
    /// 2 1
    /// 2 2
    /// ---
    /// 2 2
    /// 2 2
    /// ---
    /// 2 2
    /// 1 2
    /// ---
    /// 2 2
    /// 2 3
    /// ---
    /// 2 3
    /// 2 1
    /// </summary>
    public class DifferentSquares {
        public static void Main(string[] args) {
            int[][] matrix = {
                    new int[] {1, 2, 1},
                    new int[] {2, 2, 2},
                    new int[] {2, 2, 2},
                    new int[] {1, 2, 3},
                    new int[] {2, 2, 1}
            };
            Console.WriteLine(solution(matrix));
        }

        public static int solution(int[][] matrix) {
            HashSet<string> result = new HashSet<string>();

            for (int i = 0; i < matrix.Length - 1; i++) {
                for (int j = 0; j < matrix[i].Length - 1; j++) {
                    result.Add(matrix[i][j].ToString() + matrix[i + 1][j].ToString()
                        + matrix[i][j + 1].ToString() + matrix[i + 1][j + 1].ToString());
                }
            }

            return result.Distinct().Count();
        }
    }
}
