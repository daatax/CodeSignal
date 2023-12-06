using System;

namespace Intro.SmoothSailing {
    /// <summary>
    /// Ticket numbers usually consist of an even number of digits. A ticket number is considered 
    /// lucky if the sum of the first half of the digits is equal to the sum of the second half.
    /// Given a ticket number n, determine if it's lucky or not.
    /// Example
    /// For n = 1230, the output should be
    /// solution(n) = true;
    /// For n = 239017, the output should be
    /// solution(n) = false.
    /// </summary>

    public class IsLucky {
        public static void Main(string[] args) {
            int n = 134008;

            Console.WriteLine(solution(n));
            //Console.WriteLine(n % 100);
        }

        public static bool solution(int n) {
            int firstHalfSum = 0;
            int secondHalfSum = 0;

            for (int i = 0; i <= n.ToString().Length / 2; i++) {
                firstHalfSum += n % 10;
                n /= 10;
            }

            for (int i = 0; i <= n.ToString().Length + 1; i++) {
                secondHalfSum += n % 10;
                n /= 10;
            }

            return firstHalfSum == secondHalfSum;
        }
    }
}