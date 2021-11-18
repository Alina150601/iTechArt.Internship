using System;
using System.Linq;

//link: https://www.codewars.com/kata/5266876b8f4bf2da9b000362/train/csharp
//TODO: check the string on null
public static class Program
{
    public static void Main(string[] args)
    {
        string[] name = { "ftj", "yuk", "yjdtyj", "yuyuk" };
        Likes(name);
    }

    public static void Likes(string[] name)
    {
        name = name.Where(x => x != string.Empty).ToArray();
        var answer = "";
        if (!name.Any())
        {
            answer = "no one likes this";
        }
        else if (name.Length == 1)
        {
            answer = name.First() + " likes this";
        }
        else if (name.Length == 2)
        {
            answer = name.First() + " and " + name[1] + " like this";
        }
        else if (name.Length == 3)
        {
            answer = name[0] + "," + name[1] + " and " + name[2] + " like this";
        }
        else if (name.Length >= 4)
        {
            answer = name[0] + "," + name[1] + " and " + ((name.Length) - 2) + " like this";
        }

        Console.WriteLine(answer);
    }
}
