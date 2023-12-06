using System;

namespace Intro.ExploringTheWaters {

    /// <summary>
    /// You are given an array of integers. On each move you are allowed 
    /// to increase exactly one of its element by one. Find the minimal 
    /// number of moves required to obtain a strictly increasing sequence from the input.
    /// Example
    /// For inputArray = [1, 1, 1], the output should be
    /// solution(inputArray) = 3.
    /// </summary>
    public class ArrayChange {
        public static void Main(string[] args) {
            int[] inputArray = { 2, 1, 10, 1 };
            Console.WriteLine(solution(inputArray));
        }

        public static int solution(int[] inputArray) {
            int count = 0;

            for (int i = 0; i < inputArray.Length - 1; i++) {
                if (inputArray[i] >= inputArray[i + 1]) {
                    count += (inputArray[i] - inputArray[i + 1]) + 1;
                    inputArray[i + 1] += (inputArray[i] - inputArray[i + 1]) + 1;
                }
            }

            return count;
        }
    }
}