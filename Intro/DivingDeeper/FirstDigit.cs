using System;

namespace Intro.DivingDeeper {

    /// <summary>
    /// Find the leftmost digit that occurs in a given string.
    /// 
    /// Example
    /// For inputString = "var_1__Int", the output should be
    /// solution(inputString) = '1';
    /// For inputString = "q2q-q", the output should be
    /// solution(inputString) = '2';
    /// For inputString = "0ss", the output should be
    /// solution(inputString) = '0'.
    /// </summary>
    public class FirstDigit {
        public static void Main(string[] args) {
            string inputString = "var_1__Int";
            Console.WriteLine(solution(inputString));
        }

        public static char solution(string inputString) {
            return inputString.Where(x => Convert.ToInt32(x) >= 48 && Convert.ToInt32(x) <= 57).First();
        }
    }
}
