using System;
using System.Text.RegularExpressions;

namespace Intro.RainbowOfClarity {
    /// <summary>
    /// Given a position of a knight on the standard chessboard, find the number of 
    /// different moves the knight can perform. 
    /// The knight can move to a square that 
    /// is two squares horizontally and one square vertically, or two squares vertically 
    /// and one square horizontally away from it.The complete move therefore looks like 
    /// the letter L.Check out the image below to see all valid moves for a knight piece 
    /// that is placed on one of the central squares.
    /// 
    /// Example
    /// 
    /// For cell = "a1", the output should be
    /// solution(cell) = 2.
    /// 
    /// For cell = "c2", the output should be
    /// solution(cell) = 6.
    /// </summary>
    public class ChessKnight {
        public static void Main(string[] args) {
            string cell = "c2";
            Console.WriteLine(solution(cell));
        }

        public static int solution(string cell) {
            string pattern = @"^[a-h1-8]{2}$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            List<string> list = new List<string>() {
                Convert.ToChar(cell[0] - 1).ToString() + Convert.ToChar(cell[1] - 2).ToString(),
                Convert.ToChar(cell[0] + 1).ToString() + Convert.ToChar(cell[1] - 2).ToString(),
                Convert.ToChar(cell[0] - 1).ToString() + Convert.ToChar(cell[1] + 2).ToString(),
                Convert.ToChar(cell[0] + 1).ToString() + Convert.ToChar(cell[1] + 2).ToString(),
                Convert.ToChar(cell[0] - 2).ToString() + Convert.ToChar(cell[1] - 1).ToString(),
                Convert.ToChar(cell[0] + 2).ToString() + Convert.ToChar(cell[1] - 1).ToString(),
                Convert.ToChar(cell[0] - 2).ToString() + Convert.ToChar(cell[1] + 1).ToString(),
                Convert.ToChar(cell[0] + 2).ToString() + Convert.ToChar(cell[1] + 1).ToString(),
            };

            return list.Count(x => regex.IsMatch(x));
        }
    }
}