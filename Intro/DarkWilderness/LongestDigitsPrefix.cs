using System;

namespace Intro.DarkWilderness {

    /// <summary>
    /// Given a string, output its longest prefix which contains only digits.
    /// 
    /// Example
    /// For inputString = "123aa1", the output should be
    /// solution(inputString) = "123".
    /// </summary>
    public class LongestDigitsPrefix {
        public static void Main(string[] args) {
            string inputString = "123aa1";
            Console.WriteLine(solution(inputString));
        }

        public static string solution(string inputString) {
            return new string((char[]?) inputString.TakeWhile(c => c >= 48 && c <= 57).ToArray());
        }
    }
}
