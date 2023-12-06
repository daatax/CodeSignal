using System;

namespace Intro.ExploringTheWaters {
    /// <summary>
    /// Two arrays are called similar if one can be obtained from another by 
    /// swapping at most one pair of elements in one of the arrays.
    /// Given two arrays a and b, check whether they are similar.
    /// Example 
    /// For a = [1, 2, 3] and b = [1, 2, 3], the output should be
    /// solution(a, b) = true.   
    /// The arrays are equal, no need to swap any elements.
    /// For a = [1, 2, 3] and b = [2, 1, 3], the output should be
    /// solution(a, b) = true.     
    /// We can obtain b from a by swapping 2 and 1 in b.
    /// For a = [1, 2, 2] and b = [2, 1, 1], the output should be
    /// solution(a, b) = false.  
    /// Any swap of any two elements either in a or in b won't make a and b equal.
    /// </summary>
    public class AreSimilar {
        public static void Main(string[] args) {
            int[] a = { 1, 2, 1, 2 };
            int[] b = { 2, 2, 1, 1 };
            Console.WriteLine(solution(a, b));
        }

        public static bool solution(int[] a, int[] b) {
            int tempVal = 0;
            int[] clone = new int[a.Length];
            if (a.SequenceEqual(b)) return true;

            for (int i = 0; i < a.Length - 1; i++) {
                for (int j = 1; j <= a.Length - 1; j++) {
                    a.CopyTo(clone, 0);
                    tempVal = clone[i];
                    clone[i] = clone[j];
                    clone[j] = tempVal;
                    if (clone.SequenceEqual(b)) {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}