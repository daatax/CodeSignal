using System;

namespace Intro.IslandOfKnowledge {
    /// <summary>
    /// An IP address is a numerical label assigned to each device (e.g., computer, printer) 
    /// participating in a computer network that uses the Internet Protocol for communication. 
    /// There are two versions of the Internet protocol, and thus two versions of addresses. 
    /// One of them is the IPv4 address.
    /// Given a string, find out if it satisfies the IPv4 address naming rules.
    /// 
    /// Example
    /// For inputString = "172.16.254.1", the output should be
    /// solution(inputString) = true;
    /// For inputString = "172.316.254.1", the output should be
    /// solution(inputString) = false.
    /// 316 is not in range[0, 255].
    /// For inputString = ".254.255.0", the output should be
    /// solution(inputString) = false.
    /// There is no first number.
    /// </summary>
    public class IsIPv4Address {
        public static void Main(string[] args) {
            string inputString = "172.16.254.1";
            Console.WriteLine(solution(inputString));
        }

        public static bool solution(string inputString) {
            string[] parsedIP = inputString.Split('.');

            return !(parsedIP.Length != 4
                    || parsedIP.Any(x => string.IsNullOrEmpty(x))
                    || parsedIP.Any(x => x.StartsWith('0') && x.Length > 1)
                    || parsedIP.Any(x => int.TryParse(x, out int a) == true && a > 255)
                    || parsedIP.Any(x => int.TryParse(x, out int a) == false));
        }
    }
}