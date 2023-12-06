using System;

namespace Intro.RainbowOfClarity {
    /// <summary>
    /// Determine if the given character is a digit or not.
    /// 
    /// Example
    /// For symbol = '0', the output should be
    /// solution(symbol) = true;
    /// For symbol = '-', the output should be
    /// solution(symbol) = false.
    /// </summary>
    public class IsDigit {
        public static void Main(string[] args) {
            char symbol = '0';
            Console.WriteLine(solution(symbol));
        }

        public static bool solution(char symbol) {
            return char.IsDigit(symbol);
        }
    }
}
