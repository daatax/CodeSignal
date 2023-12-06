﻿using System;

namespace Intro.IslandOfKnowledge {
    /// <summary>
    /// You are given an array of integers representing coordinates of 
    /// obstacles situated on a straight line.
    /// Assume that you are jumping from the point with coordinate 0 to the right.
    /// You are allowed only to make jumps of the same length represented by some integer.
    /// Find the minimal length of the jump enough to avoid all the obstacles.
    /// 
    /// Example
    /// For inputArray = [5, 3, 6, 7, 9], the output should be
    /// solution(inputArray) = 4.
    /// </summary>
    public class AvoidObstacles {
        public static void Main(string[] args) {
            int[] inputArray = { 5, 3, 6, 7, 9 };
            // { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
            Console.WriteLine(solution(inputArray));
        }

        public static int solution(int[] inputArray) {
            int n = 2;
            while (inputArray.Any(x => x % n < 1)) {
                n++;
            }
            return n;
        }

    }
}
