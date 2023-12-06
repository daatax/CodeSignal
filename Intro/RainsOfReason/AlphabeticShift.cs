using System;

namespace Intro.RainsOfReason {

    /// <summary>
    /// Given a string, your task is to replace each of its characters by the 
    /// next one in the English alphabet; i.e. replace a with b, replace b with c, 
    /// etc (z would be replaced by a).
    /// 
    /// Example
    /// For inputString = "crazy", 
    /// the output should be solution(inputString) = "dsbaz".
    /// </summary>
    public class AlphabeticShift {
        public static void Main(string[] args) {
            string inputString = "crazy";
            Console.WriteLine(solution(inputString));

        }

        public static string solution(string inputString) {
            string result = "";
            var characters = inputString.ToCharArray();

            for (int i = 0; i < characters.Length; i++) {
                if (characters[i] == 'z') {
                    result += 'a';
                }
                else {
                    result += (char) (characters[i] + 1);
                }
            }

            return result;
        }
    }
}
