using System;
using System.Text.RegularExpressions;

namespace Intro.RainsOfReason {
    
    /// <summary>
    /// Correct variable names consist only of English letters, 
    /// digits and underscores and they can't start with a digit.
    /// Check if the given string is a correct variable name.
    /// 
    /// Example
    /// For name = "var_1__Int", the output should be
    /// solution(name) = true;
    /// For name = "qq-q", the output should be
    /// solution(name) = false;
    /// For name = "2w2", the output should be
    /// solution(name) = false.
    /// </summary>
    public class VariableName {
        public static void Main(string[] args) {
            string name = "var_1__Int";
            Console.WriteLine(solution(name));
        }

        public static bool solution(string name) {
            string pattern = @"^[a-zA-Z_][a-zA-Z0-9_]*$";
            return Regex.IsMatch(name, pattern);
        }
    }
}
