using System;

namespace Intro.LandOfLogic {
    /// <summary>
    /// Construct a square matrix with a size N × N containing integers from 
    /// 1 to N * N in a spiral order, starting from top-left and in clockwise direction.
    /// 
    /// Example
    /// For n = 3, the output should be
    /// solution(n) = [[1, 2, 3],
    ///                [8, 9, 4],
    ///                [7, 6, 5]]
    ///                
    ///                [1, 4, 7]
    ///                [2, 5, 8]
    ///                [3, 6, 9]
    /// </summary>
    public class SpiralNumbers {
        public static void Main(string[] args) {
            int n = 3;
            int[][] result = solution(n);
        }

        public static int[][] solution(int n) {
            // tbh, I really don't like this solution, but it is what it is
            int[][] matrix = new int[n][];
            int value = 1;
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

            for (int i = 0; i < n; i++) {
                matrix[i] = new int[n];
            }

            while (value <= n * n) {
                // Traverse top row
                for (int i = left; i <= right; i++)
                    matrix[top][i] = value++;

                top++;

                // Traverse right column
                for (int i = top; i <= bottom; i++)
                    matrix[i][right] = value++;

                right--;

                // Traverse bottom row
                for (int i = right; i >= left; i--)
                    matrix[bottom][i] = value++;

                bottom--;

                // Traverse left column
                for (int i = bottom; i >= top; i--)
                    matrix[i][left] = value++;

                left++;
            }

            return matrix;
        }
    }
}
