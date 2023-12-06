using System;
using System.Text;

namespace Intro.RainbowOfClarity {
    /// <summary>
    /// Given a string, return its encoding defined as follows:
    /// First, the string is divided into the least possible number of disjoint 
    /// substrings consisting of identical characters
    /// for example, "aabbbc" is divided into["aa", "bbb", "c"]
    /// 
    /// Next, each substring with length greater than one is replaced with a 
    /// concatenation of its length and the repeating character
    /// for example, substring "bbb" is replaced by "3b"
    /// 
    /// Finally, all the new strings are concatenated together in the same 
    /// order and a new string is returned.
    /// 
    /// Example
    /// For s = "aabbbc", the output should be
    /// solution(s) = "2a3bc".
    /// </summary>
    public class ԼineEncoding {
        public static void Main(string[] args) {
            string inputString = "abbcabb"; // a2bca2b
            Console.WriteLine(solution(inputString));
        }

        public static string solution(string inputString) {
            StringBuilder result = new StringBuilder();
            char currentChar = inputString[0];
            int count = 1;

            for (int i = 1; i < inputString.Length; i++) {
                if (currentChar == inputString[i]) {
                    count++;
                }
                else {
                    result.Append(count > 1 ? count.ToString() + currentChar : currentChar.ToString());
                    count = 1;
                    currentChar = inputString[i];
                }
            }
            result.Append(count > 1 ? count.ToString() + currentChar : currentChar.ToString());

            return result.ToString();
        }
    }
}
