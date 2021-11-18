using System;
using System.Text.RegularExpressions;

//link: https://edabit.com/challenge/u6HAot7ojYFTSm9aZ
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Potatoes("potatopotato"));
    }

    public static int Potatoes(string potato)
    {
        Regex regex = new Regex(@"potato", RegexOptions.IgnoreCase);
        MatchCollection matches = regex.Matches(potato);
        return matches.Count;
    }
}