using System;
using System.Text.RegularExpressions;

namespace Intro.LandOfLogic {
    /// <summary>
    /// Define a word as a sequence of consecutive English letters. 
    /// Find the longest word from the given string.
    /// 
    /// Example
    /// For text = "Ready, steady, go!", the output should be
    /// solution(text) = "steady".
    /// </summary>
    public class LongestWord {
        public static void Main(string[] args) {
            string text = "You are the best!!!!!!!!!!!! CodeFighter ever!";
            Console.WriteLine(solution(text));
        }

        public static string solution(string text) {
            string pattern = @"[^a-zA-Z]+";
            string[] splitParts = Regex.Split(text, pattern); 

            return splitParts.OrderByDescending(x => x.Length).First().ToString();
        }
    }
}