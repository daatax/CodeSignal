using System;

namespace Intro.SmoothSailing {
    /// <summary>
    /// Given an array of strings, return another array containing all of its longest strings.
    /// Example
    /// For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
    /// solution(inputArray) = ["aba", "vcd", "aba"]
    /// </summary>
    public class AllLongestStrings {
        public static void Main(string[] args) {
            string[] inputArray = { "abc", "eeee", "abcd", "dcd" };

            solution(inputArray);
        }

        public static string[] solution(string[] inputArray) {
            int maxLenght = inputArray[0].Length;
            List<string> result = new List<string>();

            foreach (string elem in inputArray) {
                if (elem.Length >= maxLenght) {
                    maxLenght = elem.Length;
                }
            }

            foreach (string elem in inputArray) {
                if (elem.Length == maxLenght) {
                    result.Add(elem);
                }
            }
            return result.ToArray();
        }

        public static string[] solution2(string[] inputArray) {
            int maxLenght = inputArray.Max(x => x.Length);
            return inputArray.Where(s => s.Length == maxLenght).ToArray();
        }
    }
}