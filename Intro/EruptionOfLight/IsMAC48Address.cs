﻿using System;
using System.Text.RegularExpressions;

namespace Intro.EruptionOfLight {
    /// <summary>
    /// A media access control address (MAC address) is a unique identifier assigned 
    /// to network interfaces for communications on the physical network segment.
    /// The standard(IEEE 802) format for printing MAC-48 addresses in human-friendly 
    /// form is six groups of two hexadecimal digits(0 to 9 or A to F), separated by 
    /// hyphens(e.g. 01-23-45-67-89-AB).
    /// Your task is to check by given string inputString whether it corresponds to 
    /// MAC-48 address or not.
    /// 
    /// Example
    /// For inputString = "00-1B-63-84-45-E6", the output should be
    /// solution(inputString) = true;
    /// 
    /// For inputString = "Z1-1B-63-84-45-E6", the output should be
    /// solution(inputString) = false;
    /// 
    /// For inputString = "not a MAC-48 address", the output should be
    /// solution(inputString) = false.
    /// </summary>
    public class IsMAC48Address {
        public static void Main(string[] args) {
            string inputString = "00-1B-63-84-45-E6";
            Console.WriteLine(solution(inputString));
        }

        public static bool solution(string inputString) {
            string pattern = @"^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.IsMatch(inputString);
        }
    }
}
