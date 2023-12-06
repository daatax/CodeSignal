using System;

namespace Intro.DarkWilderness {

    /// <summary>
    /// Given the positions of a white bishop and a black pawn on the 
    /// standard chess board determine whether the bishop can capture 
    /// the pawn in one move.
    /// 
    /// The bishop has no restrictions in distance for each move, but 
    /// is limited to diagonal movement.Check out the example below to 
    /// see how it can move:
    /// 
    /// Example
    /// For bishop = "a1" and pawn = "c3", the output should be
    /// solution(bishop, pawn) = true.
    /// 
    /// For bishop = "h1" and pawn = "h3", the output should be
    /// solution(bishop, pawn) = false.
    /// </summary>
    public class BishopAndPawn {
        public static void Main(string[] args) {
            string bishop = "a1";
            string pawn = "c3";
            Console.WriteLine(solution(bishop, pawn));
        }

        public static bool solution(string bishop, string pawn) {
            bool areOnSameColor = ((Convert.ToInt32(bishop[0]) + Convert.ToInt32(bishop[1])) % 2 == 0 &&
                                    (Convert.ToInt32(pawn[0]) + Convert.ToInt32(pawn[1])) % 2 == 0)
                                || ((Convert.ToInt32(bishop[0]) + Convert.ToInt32(bishop[1])) % 2 != 0 &&
                                    (Convert.ToInt32(pawn[0]) + Convert.ToInt32(pawn[1])) % 2 != 0);

            bool areOnSameDiagonal = Math.Abs(Convert.ToInt32(bishop[0]) - Convert.ToInt32(pawn[0]))
                                == Math.Abs(Convert.ToInt32(bishop[1]) - Convert.ToInt32(pawn[1]));

            return areOnSameColor && areOnSameDiagonal;
        }
    }
}
