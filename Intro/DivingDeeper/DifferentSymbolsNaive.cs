using System;

namespace Intro.DivingDeeper {
    /// <summary>
    /// Given a string, find the number of different characters in it.
    /// 
    /// Example
    /// For s = "cabca", the output should be
    /// solution(s) = 3.
    /// There are 3 different characters a, b and c.
    /// </summary>
    public class DifferentSymbolsNaive {
        public static void Main(string[] args) {
            string inputString = "cabca";
            Console.WriteLine(solution(inputString));
        }

        public static int solution(string inputString) {
            var a = inputString.GroupBy(c => c).ToList();
            var b = a.Count();

            return inputString.GroupBy(c => c).Count();
        }
    }
}
