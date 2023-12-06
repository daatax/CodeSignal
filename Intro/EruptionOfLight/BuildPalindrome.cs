using System;

namespace Intro.EruptionOfLight {
    /// <summary>
    /// Given a string, find the shortest possible string which can be achieved 
    /// by adding characters to the end of initial string to make it a palindrome.
    /// 
    /// Example
    /// For st = "abcdc", the output should be
    /// solution(st) = "abcdcba".
    /// </summary>
    public class BuildPalindrome {
        public static void Main(string[] args) {
            string inputString = "abcdc";
            //Console.WriteLine(inputString.Substring(0, 2));
            Console.WriteLine(solution(inputString));
        }

        public static string solution(string inputString) {
            string palindrome = inputString;

            if (palindrome.SequenceEqual(palindrome.Reverse())) {
                return palindrome;
            }

            for (int i = 0; i < inputString.Length / 2; i++) {
                var addition = inputString.Substring(0, i + 1).ToCharArray();
                Array.Reverse(addition);
                palindrome += new string(addition);
                if (palindrome.SequenceEqual(palindrome.Reverse())) {
                    return palindrome;
                }
                else {
                    palindrome = inputString;
                }
            }

            return palindrome;
        }
    }
}