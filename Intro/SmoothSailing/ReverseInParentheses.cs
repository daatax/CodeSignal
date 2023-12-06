using System;

namespace Intro.SmoothSailing {

    /// <summary>
    /// Write a function that reverses characters in (possibly nested) parentheses in the input string.
    /// Input strings will always be well-formed with matching()s.
    /// Example
    /// For inputString = "(bar)", the output should be
    /// solution(inputString) = "rab";
    /// For inputString = "foo(bar)baz", the output should be
    /// solution(inputString) = "foorabbaz";
    /// For inputString = "foo(bar)baz(blim)", the output should be
    /// solution(inputString) = "foorabbazmilb";
    /// For inputString = "foo(bar(baz))blim", the output should be
    /// solution(inputString) = "foobazrabblim".
    /// Because "foo(bar(baz))blim" becomes "foo(barzab)blim" and then "foobazrabblim".
    /// </summary>
    public class ReverseInParentheses {
        public static void Main(string[] args) {
            string inputString = "foo(bar(baz))blim";

            Console.WriteLine(solution(inputString));
        }

        public static string solution(string inputString) {
            string result = "";
            string[] split = inputString.Split('(', ')');

            for (int i = 0; i <= split.Length - 1; i++) {
                var splitPart = split[i];
                if (!inputString.Contains("(" + splitPart)) {
                    result += splitPart;
                }
                if (inputString.Contains("(" + splitPart + "(")) {
                    var tempSplitPart = splitPart.ToCharArray();
                    Array.Reverse(tempSplitPart);
                    result += split[i + 1] + new string(tempSplitPart);
                    i++;
                    continue;
                }
                if (inputString.Contains("(" + splitPart)) {
                    var tempSplitPart = splitPart.ToCharArray();
                    Array.Reverse(tempSplitPart);
                    result += new string(tempSplitPart);
                }
            }

            return result.Trim();
        }
    }
}