using System;

namespace Intro.ExploringTheWaters {
    /// <summary>
    /// Given a string, find out if its characters can be rearranged to form a palindrome.
    /// Example
    /// For inputString = "aabb", the output should be
    /// solution(inputString) = true.
    /// We can rearrange "aabb" to make "abba", which is a palindrome.
    /// </summary>
    public class PalindromeRearranging {
        public static void Main(string[] args) {
            string inputString = "abab";
            Console.WriteLine(solution(inputString));
        }

        public static bool solution(string inputString) {
            var groupedChars = inputString.GroupBy(c => c);
            var filterByCout = groupedChars.Where(g => g.Count() % 2 == 1);
            
            return filterByCout.Count() <= 1;
        }
    }
}