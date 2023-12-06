using System;

namespace Intro.TheJourneyBegin {
    /// <summary>
    /// Write a function that returns the sum of two numbers.
    ///
    /// Example
    /// For param1 = 1 and param2 = 2, the output should be
    /// solution(param1, param2) = 3. 
    /// </summary>
    public class AddNumbers {
        public static void Main(string[] args) {
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine(solution(num1, num2));
        }
        static int solution(int param1, int param2) {
            return param1 + param2;
        }
    }
}
