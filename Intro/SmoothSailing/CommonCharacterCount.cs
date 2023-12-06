using System;

namespace Intro.SmoothSailing {
    /// <summary>
    /// Given two strings, find the number of common characters between them.
    /// Example
    /// For s1 = "aabcc" and s2 = "adcaa", the output should be
    /// solution(s1, s2) = 3.
    /// Strings have 3 common characters - 2 "a"s and 1 "c".
    /// </summary>
    public class CommonCharacterCount {

        public static void Main(string[] args) {
            string s1 = "aabcc";
            string s2 = "adcaa";

            Console.WriteLine(solution(s1, s2));
        }

        public static int solution(string s1, string s2) {
            int count = 0;
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            foreach (char c in s1) {
                if (s2.Contains(c)) {
                    count++;
                    if (s2.IndexOf(c) == 0) {
                        s2 = s2.Substring(s2.IndexOf(c) + 1);
                    }
                    else {
                        s2 = s2.Substring(0, s2.IndexOf(c)) + s2.Substring(s2.IndexOf(c) + 1);
                    }
                }
            }
            return count;
        }
    }
}