using System;

namespace Intro.IslandOfKnowledge {

    /// <summary>
    /// Given an array of integers, find the maximal absolute difference between any two of its adjacent elements.
    /// Example
    /// For inputArray = [2, 4, 1, 0], the output should be
    /// solution(inputArray) = 3.
    /// </summary>
    public class ArrayMaximalAdjacentDifference {
        public static void Main(string[] args) {
            int[] inputArray = { 2, 4, 1, 0 };
            Console.WriteLine(solution(inputArray));
        }

        public static int solution(int[] inputArray) {
            int diff = Math.Abs(inputArray[0] - inputArray[1]);

            for (int i = 1; i < inputArray.Length - 1; i++) {
                if (Math.Abs(inputArray[i] - inputArray[i + 1]) >= diff) {
                    diff = Math.Abs(inputArray[i] - inputArray[i + 1]);
                }
            }

            return diff;
        }

    }
}