using System;

//link: https://edabit.com/challenge/99oN5igrbXddAjHEL
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ReverseCase("he who has a WHY to live can bear almost any HOW"));
    }

    public static string ReverseCase(string str)
    {
        var newStr = string.Empty;
        foreach (var letter in str)
        {
            char reverseCaseletter;
            if (char.IsLower(letter))
            {
                reverseCaseletter = char.ToUpper(letter);
            }
            else reverseCaseletter = char.ToLower(letter);

            newStr += reverseCaseletter;
        }

        return newStr;
    }
}