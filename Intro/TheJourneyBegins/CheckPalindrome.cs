using System;

namespace Intro.TheJourneyBegin {

    /// <summary>
    /// Given the string, check if it is a palindrome.
    /// 
    /// Example
    /// For inputString = "aabaa", the output should be
    /// solution(inputString) = true;
    /// 
    /// For inputString = "abac", the output should be
    /// solution(inputString) = false;
    /// 
    /// For inputString = "a", the output should be
    /// solution(inputString) = true.
    /// </summary>
    public class CheckPalindrome {
        public static void Main(string[] args) {
            string input = "aabaa";
            Console.WriteLine(solution(input));
        }
        static bool solution(string inputString) {

            return inputString.SequenceEqual(inputString.Reverse());

            // leaving this here, just in case!!!

            //for (int i = 0; i < inputString.Length / 2; i++) {
            //    if (inputString[i] != inputString[inputString.Length - i - 1]) {
            //        return false;
            //    }
            //}
            //return true;
        }
    }
}