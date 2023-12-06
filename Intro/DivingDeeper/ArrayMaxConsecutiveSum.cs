using System;

namespace Intro.DivingDeeper {

    /// <summary>
    /// Given array of integers, find the maximal possible sum of some of its k consecutive elements.
    /// 
    /// Example
    /// For inputArray = [2, 3, 5, 1, 6] and k = 2, the output should be
    /// solution(inputArray, k) = 8.
    /// All possible sums of 2 consecutive elements are:
    ///                                     2 + 3 = 5;
    ///                                     3 + 5 = 8;
    ///                                     5 + 1 = 6;
    ///                                     1 + 6 = 7.
    /// Thus, the answer is 8.
    /// </summary>
    public class ArrayMaxConsecutiveSum {
        public static void Main(string[] args) {
            int[] inputArray = [1, 7, 2, 4];
            int k = 3;
            Console.WriteLine(solution(inputArray, k));
        }

        public static int solution(int[] inputArray, int k) {
            int currentSum = inputArray.Take(k).Sum();
            int maxSum = currentSum;

            for (int i = k; i < inputArray.Length; i++) {
                currentSum = currentSum - inputArray[i - k] + inputArray[i];
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}