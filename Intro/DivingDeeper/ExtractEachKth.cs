using System;

namespace Intro.DivingDeeper {
    /// <summary>
    /// Given array of integers, remove each kth element from it.
    /// 
    /// Example
    /// For inputArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] and k = 3, 
    /// the output should be
    /// solution(inputArray, k) = [1, 2, 4, 5, 7, 8, 10].
    /// </summary>
    public class ExtractEachKth {
        public static void Main(string[] args) {
            int[] inputArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int k = 3;
            int[] result = solution(inputArray, k);
        }

        public static int[] solution(int[] inputArray, int k) {
            List<int> list = new List<int>();

            for (int i = 0; i < inputArray.Length; i++) {
                if ((i + 1) % k != 0) {
                    list.Add(inputArray[i]);
                }
            }

            return list.ToArray();
        }
    }
}
