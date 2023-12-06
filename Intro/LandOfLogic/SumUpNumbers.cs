using System;
using System.Text.RegularExpressions;

namespace Intro.LandOfLogic {
    /// <summary>
    /// CodeMaster has just returned from shopping. He scanned the check of the items 
    /// he bought and gave the resulting string to Ratiorg to figure out the total 
    /// number of purchased items. Since Ratiorg is a bot he is definitely going to 
    /// automate it, so he needs a program that sums up all the numbers which appear 
    /// in the given input.
    /// 
    /// Help Ratiorg by writing a function that returns the sum of numbers that appear 
    /// in the given inputString.
    /// 
    /// Example
    /// For inputString = "2 apples, 12 oranges", the output should be
    /// solution(inputString) = 14.
    /// </summary>
    public class SumUpNumbers {
        public static void Main(string[] args) {
            string inputString = "2 apples, 12 oranges";
            Console.WriteLine(solution(inputString));
        }

        public static int solution(string inputString) {
            string pattern = @"\D+"; 
            
            return Regex.Split(inputString, pattern)
                        .Where(x => int.TryParse(x, out int number) && number > 0)
                        .Sum(a => Convert.ToInt32(a));
        }
    }
}
