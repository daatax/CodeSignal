using System;

namespace Intro.RainsOfReason {

    /// <summary>
    /// Given two cells on the standard chess board, determine whether they have the same color or not.
    /// 
    /// Example
    /// For cell1 = "A1" and cell2 = "C3", the output should be
    /// solution(cell1, cell2) = true.
    /// For cell1 = "A1" and cell2 = "H3", the output should be
    /// solution(cell1, cell2) = false.
    /// </summary>
    public class ChessBoardCellColor {
        public static void Main(string[] args) {
            string cell1 = "A2";
            string cell2 = "B3";

            Console.WriteLine(solution(cell1, cell2));
        }

        public static bool solution(string cell1, string cell2) {

            return ((Convert.ToInt32(cell1[0]) + Convert.ToInt32(cell1[1])) % 2 == 0
                && (Convert.ToInt32(cell2[0]) + Convert.ToInt32(cell2[1])) % 2 == 0)
                || ((Convert.ToInt32(cell1[0]) + Convert.ToInt32(cell1[1])) % 2 != 0 &&
                   (Convert.ToInt32(cell2[0]) + Convert.ToInt32(cell2[1])) % 2 != 0);
        }
    }
}
