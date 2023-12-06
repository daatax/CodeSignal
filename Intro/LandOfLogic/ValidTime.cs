using System;

namespace Intro.LandOfLogic {
    /// <summary>
    /// Check if the given string is a correct time representation of the 24-hour clock.
    /// 
    /// Example
    /// For time = "13:58", the output should be
    /// solution(time) = true;
    /// For time = "25:51", the output should be
    /// solution(time) = false;
    /// For time = "02:76", the output should be
    /// solution(time) = false.
    /// </summary>
    public class ValidTime {
        public static void Main(string[] args) {
            string time = "13:58";
            Console.WriteLine(solution(time));
        }

        public static bool solution(string time) {
            return Convert.ToInt32(time.Substring(0, 2)) <= 23 && Convert.ToInt32(time.Substring(3)) <= 59;
        }
    }
}