using System;

namespace Intro.DarkWilderness {
    /// <summary>
    /// Let's define digit degree of some positive integer as the number of times 
    /// we need to replace this number with the sum of its digits until we get 
    /// to a one digit number.
    /// Given an integer, find its digit degree.
    /// 
    /// Example  
    /// For n = 5, the output should be
    /// solution(n) = 0;
    /// For n = 100, the output should be
    /// solution(n) = 1.
    /// 1 + 0 + 0 = 1.
    /// For n = 91, the output should be
    /// solution(n) = 2.
    /// 9 + 1 = 10 -> 1 + 0 = 1.
    /// </summary>
    public class DigitDegree {
        public static void Main(string[] args) {
            int n = 91;
            Console.WriteLine(solution(n));
        }

        public static int solution(int n) {
            int count = 0;
            string sumOfDigits = n.ToString();

            for (int i = 0; sumOfDigits.Length > 1; i++) {
                sumOfDigits = sumOfDigits.Sum(c => int.Parse(c.ToString())).ToString();
                count++;
            }

            return count;
        }
    }
}