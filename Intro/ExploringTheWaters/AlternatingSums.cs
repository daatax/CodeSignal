using System;

namespace Intro.ExploringTheWaters {

    /// <summary>
    /// Several people are standing in a row and need to be divided into two teams. 
    /// The first person goes into team 1, the second goes into team 2, the third 
    /// goes into team 1 again, the fourth into team 2, and so on.You are given an 
    /// array of positive integers - the weights of the people. 
    /// Return an array of two integers, where the first element is the total weight of team 1, 
    /// and the second element is the total weight of team 2 after the division is complete.
    /// 
    /// Example
    /// For a = [50, 60, 60, 45, 70], the output should besolution(a) = [180, 105].
    /// </summary>
    public class AlternatingSums {
        public static void Main(string[] args) {
            int[] a = { 50, 60, 60, 45, 70 };
            int[] b = solution(a);
        }

        public static int[] solution(int[] a) {
            int[] result = new int[2];

            for (int i = 0; i < a.Length; i++) {
                if (i % 2 == 0) {
                    result[0] += a[i];
                }
                if (i % 2 != 0) {
                    result[1] += a[i];
                }
            }

            return result;
        }
    }
}