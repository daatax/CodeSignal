using System;

namespace Intro.RainbowOfClarity {
    /// <summary>
    /// Given some integer, find the maximal number you can obtain 
    /// by deleting exactly one digit of the given number.
    /// 
    /// Example
    /// For n = 152, the output should be
    /// solution(n) = 52;
    /// 
    /// For n = 1001, the output should be
    /// solution(n) = 101.
    /// </summary>
    public class DeleteDigit {
        public static void Main(string[] args) {
            int number = 152;
            Console.WriteLine(solution(number));
        }

        public static int solution(int number) {
            List<int> list = new List<int>();
            string inputNumber = number.ToString();

            for (int i = 0; i < inputNumber.Length; i++) {
                list.Add(Convert.ToInt32(inputNumber.Substring(0, i) + inputNumber.Substring(i + 1)));
            }

            return list.Max();
        }
    }
}
