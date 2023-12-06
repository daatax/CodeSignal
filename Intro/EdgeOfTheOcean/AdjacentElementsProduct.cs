using System;

namespace Intro.EdgeOfTheOcean {

    /// <summary>
    /// Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.
    /// Example
    /// For inputArray = [3, 6, -2, -5, 7, 3], the output should be
    /// solution(inputArray) = 21.
    /// 7 and 3 produce the largest product.
    /// </summary>
    public class AdjacentElementsProduct {
        public static void Main(String[] args) {
            int[] inputArray = { 3, 6, -2, -5, 7, 3 };
            Console.WriteLine(solution(inputArray));
        }

        static int solution(int[] inputArray) {
            int maxProduct = inputArray[0] * inputArray[1];
            for (int i = 0; i < inputArray.Length - 1; i++) {
                if (inputArray[i] * inputArray[i + 1] > maxProduct) {
                    maxProduct = inputArray[i] * inputArray[i + 1];
                }
            }
            return maxProduct;
        }
    }
}