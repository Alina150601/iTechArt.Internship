using System;
using System.Text.RegularExpressions;

//link: https://edabit.com/challenge/JYEufqRvkusjr5R58
namespace Bomb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Bomb("Hey, did you find the BoMb?"));
        }

        public static string Bomb(string txt)
        {
            Regex regex = new Regex(@"bomb", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(txt);
            return matches.Count > 0 ? "Duck!!!" : "There is no bomb, relax.";
        }
    }
}
