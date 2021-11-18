using System;

//TODO
//don't know how to solve the problem
//link: https://www.codewars.com/kata/5ce6728c939bf80029988b57
namespace ConsecutiveLetters
{
    public class ConsecutiveLetters
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Solve("abcd"));
        }

        public static bool Solve(string s)
        {
            for (var i = 1; i < s.Length; i++)
            {
                var a = (char)(s[i] - 1);
                if (a != s[i]) return false;
            }

            return true;
        }
    }
}
