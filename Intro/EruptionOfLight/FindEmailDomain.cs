using System;
using System.Text.RegularExpressions;

namespace Intro.EruptionOfLight {

    /// <summary>
    /// An email address such as "John.Smith@example.com" is made up of a local part 
    /// ("John.Smith"), an "@" symbol, then a domain part ("example.com").
    /// The domain name part of an email address may only consist of letters, digits, 
    /// hyphens and dots.The local part, however, also allows a lot of different special 
    /// characters.Here you can look at several examples of correct and incorrect email addresses.
    /// 
    /// Given a valid email address, find its domain part.
    /// 
    /// Example
    /// For address = "prettyandsimple@example.com", the output should be
    /// solution(address) = "example.com";
    /// For address = "fully-qualified-domain@codesignal.com", the output should be
    /// solution(address) = "codesignal.com".
    /// </summary>
    public class FindEmailDomain {
        public static void Main(string[] args) {
            string address = "prettyandsimple@example.com";
            Console.WriteLine(solution(address));
        }

        public static string solution(string address) {
            // This pattern is for a real email address validation with a TLD domain, but I'll use the other one.
            // string pattern = @"([a-zA-Z0-9#!%$'&+*\/=?^_`.{|}~-]{0,61}[a-zA-Z0-9#!%$'&+*\/=?^_`.{|}~])(@)([a-zA-Z0-9-]+\.[a-zA-Z]{2,})";
            string pattern = @"([^)]*)(@)([a-zA-Z0-9-]+\.[a-zA-Z]{2,})";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);

            return regex.Match(address).Groups[3].Value;
        }
    }
}
