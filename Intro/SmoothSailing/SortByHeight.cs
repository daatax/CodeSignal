using System;

namespace Intro.SmoothSailing {
    /// <summary>
    /// Some people are standing in a row in a park. There are trees between them which cannot be moved. 
    /// Your task is to rearrange the people by their heights in a non-descending order without moving 
    /// the trees. People can be very tall!
    /// Example
    /// For a = [-1, 150, 190, 170, -1, -1, 160, 180], 
    /// the output should be
    /// solution(a) = [-1, 150, 160, 170, -1, -1, 180, 190].
    /// </summary>
    public class SortByHeight {
        public static void Main(string[] args) {
            int[] a = { -1, 150, 190, 170, -1, -1, 160, 180 };
            int[] b = solution(a);
        }

        public static int[] solution(int[] a) {
            int i = 0;
            int[] sortedHeights = a.Where(x => x != -1).OrderBy(x => x).ToArray();

            return a.Select(x => x > 0 ? sortedHeights[i++] : -1).ToArray();
        }
    }
}
