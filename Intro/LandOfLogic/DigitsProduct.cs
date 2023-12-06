using System;

namespace Intro.LandOfLogic {
    /// <summary>
    /// Given an integer product, find the smallest positive (i.e. greater than 0) 
    /// integer the product of whose digits is equal to product. 
    /// If there is no such integer, return -1 instead.
    /// 
    /// Example
    /// For product = 12, the output should be
    /// solution(product) = 26;
    /// 
    /// For product = 19, the output should be
    /// solution(product) = -1.
    /// </summary>
    public class DigitsProduct {
        public static void Main(string[] args) {
            int product = 450; // 2559
            Console.WriteLine(solution(product));
        }

        public static int solution(int product) {
            if (product == 0) {
                return 10;
            }

            if (product < 10) {
                return product;
            }

            int result = 0;
            int pos = 1;
            int divisor = 9;

            while (divisor > 1) {
                if (product % divisor == 0) {
                    result += divisor * pos;
                    pos *= 10;
                    product /= divisor;
                }
                else {
                    divisor--;
                }
            }

            if (product > 1) {
                return -1;
            }

            return result;
        }
    }
}