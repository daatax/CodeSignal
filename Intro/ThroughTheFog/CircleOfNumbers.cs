using System;

namespace Intro.ThroughTheFog {
    /// <summary>
    /// Consider integer numbers from 0 to n - 1 written down along the circle 
    /// in such a way that the distance between any two neighboring numbers is 
    /// equal (note that 0 and n - 1 are neighboring, too).
    /// Given n and firstNumber, find the number which is written in the radially 
    /// opposite position to firstNumber.
    /// 
    /// Example 
    /// For n = 10 and firstNumber = 2, the output should be
    /// solution(n, firstNumber) = 7.
    /// </summary>
    public class CircleOfNumbers {
        public static void Main(string[] args) {
            int n = 10;
            int firstNumber = 2;

            Console.WriteLine(solution(n, firstNumber));
        }

        public static int solution(int n, int firstNumber) {
            return firstNumber < n / 2 ? firstNumber + (n / 2) : firstNumber - (n / 2);
        }
    }
}
