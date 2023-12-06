using System;

namespace Intro.RainsOfReason {

    /// <summary>
    /// Given an array of integers, replace all the occurrences of elemToReplace with substitutionElem.
    /// 
    /// Example
    /// For inputArray = [1, 2, 1], elemToReplace = 1, and substitutionElem = 3, 
    /// the output should be
    /// solution(inputArray, elemToReplace, substitutionElem) = [3, 2, 3].
    /// </summary>
    public class ArrayReplace {
        public static void Main(string[] args) {
            int[] inputArray = { 1, 2, 1 };
            int[] result = solution(inputArray, 1, 3);
        }

        public static int[] solution(int[] inputArray, int elemToReplace, int substitutionElem) {
            for (int i = 0; i <= inputArray.Length - 1; i++) {
                if (inputArray[i] == elemToReplace) {
                    inputArray[i] = substitutionElem;
                }
            }

            return inputArray;
        }
    }
}
