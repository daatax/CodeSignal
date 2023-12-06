using System;

namespace Intro.IslandOfKnowledge {
    /// <summary>
    /// Call two arms equally strong if the heaviest weights they each are able to lift are equal.
    /// Call two people equally strong if their strongest arms are equally strong(the strongest 
    /// arm can be both the right and the left), and so are their weakest arms.
    /// Given your and your friend's arms' lifting capabilities find out if you two are equally strong.
    /// Example
    /// For yourLeft = 10, yourRight = 15, friendsLeft = 15, and friendsRight = 10, the output should be
    /// solution(yourLeft, yourRight, friendsLeft, friendsRight) = true;
    /// For yourLeft = 15, yourRight = 10, friendsLeft = 15, and friendsRight = 10, the output should be
    /// solution(yourLeft, yourRight, friendsLeft, friendsRight) = true;
    /// For yourLeft = 15, yourRight = 10, friendsLeft = 15, and friendsRight = 9, the output should be
    /// solution(yourLeft, yourRight, friendsLeft, friendsRight) = false.
    /// /// </summary>
    public class AreEquallyStrong {
        public static void Main(string[] args) {
            int yourLeft = 10;
            int yourRight = 15;
            int friendsLeft = 15;
            int friendsRight = 10;
            Console.WriteLine(solution(yourLeft, yourRight, friendsLeft, friendsRight));
        }

        public static bool solution(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
            return (yourLeft + yourRight) == (friendsLeft + friendsRight) &&
                    ((yourLeft == friendsLeft && yourRight == friendsRight) 
                    || (yourLeft == friendsRight && yourRight == friendsLeft));
        }
    }

}