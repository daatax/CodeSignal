using System;

namespace Intro.EdgeOfTheOcean {

    /// <summary>
    /// Below we will define an n-interesting polygon. Your task is to find the area of a polygon for a given n.
    /// A 1-interesting polygon is just a square with a side of length 1. An n-interesting polygon is obtained 
    /// by taking the n - 1-interesting polygon and appending 1-interesting polygons to its rim, side by side.
    /// You can see the 1-, 2-, 3- and 4-interesting polygons in the picture below.
    /// 
    /// Example
    /// For n = 2, the output should be
    /// solution(n) = 5;
    /// For n = 3, the output should be
    /// solution(n) = 13.
    /// </summary>
    public class ShapeArea {
        public static void Main(String[] args) {
            Console.WriteLine(solution(5));
        }
        static int solution(int n) {
            int area = 0;

            for (int i = -n + 1; i < n; i++) {
                for (int j = -n + 1; j < n; j++) {
                    int absI = Math.Abs(i);
                    int absJ = Math.Abs(j);
                    if (absI + absJ <= n - 1) {
                        area++;
                    }
                }
            }
            return area;
        }
    }
}