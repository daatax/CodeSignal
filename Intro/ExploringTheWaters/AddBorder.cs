using System;

namespace Intro.ExploringTheWaters {

    /// <summary>
    /// Given a rectangular matrix of characters, add a border of asterisks(*) to it.
    /// Example
    /// For
    /// picture = ["abc",
    ///         "ded"]
    /// the output should be
    /// solution(picture) = ["*****",   
    ///                     "*abc*",
    ///                     "*ded*",
    ///                     "*****"]
    /// </summary>
    public class AddBorder {
        public static void Main(string[] args) {
            string[] picture = { "abc", "ded" };
            string[] result = solution(picture);
        }

        public static string[] solution(string[] picture) {
            int index = 0;
            int maxLength = picture.Max(str => str.Length);
            string[] result = new string[picture.Length + 2];
            
            for (int i = 0; i <= result.Length - 1; i++) {
                if (i == 0 || i == result.Length - 1) {
                    result[i] = new string('*', maxLength + 2);
                }
                else {
                    result[i] = "*" + picture[index] + "*";
                    index++;
                }
            }

            return result;
        }
    }
}