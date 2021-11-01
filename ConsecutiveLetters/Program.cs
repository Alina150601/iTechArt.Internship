//TODO
//link: https://www.codewars.com/kata/5ce6728c939bf80029988b57

using System;
using System.Linq;

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
            var a = (char) (s[i] - 1);
            if (a != s[i]) return false;
        }
        return true;
    }
}
