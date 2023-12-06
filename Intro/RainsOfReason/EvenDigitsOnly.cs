using System;

namespace Intro.RainsOfReason {

    /// <summary>
    /// Check if all digits of the given integer are even.
    /// 
    /// Example
    /// For n = 248622, the output should be
    /// solution(n) = true;
    /// For n = 642386, the output should be
    /// solution(n) = false.
    /// </summary>
    public class EvenDigitsOnly {
        public static void Main(string[] args) {
            int n = 642386;
            Console.WriteLine(solution(n));
        }

        public static bool solution(int n) {
            List<char> list = n.ToString().ToList();
            List<int> intList = list.ConvertAll(x => Convert.ToInt32(x)).ToList();
            List<int> evenDigits = intList.Where(x => x % 2 == 0).ToList();

            return evenDigits.Count == n.ToString().Length;
        }
    }
}