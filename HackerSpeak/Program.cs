using System;

//link: https://edabit.com/challenge/7nzfry4P3WrrL7t38
namespace HackerSpeak
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testStr = "javascript is cool";
            Console.WriteLine(HackerSpeak(testStr));
        }

        public static string HackerSpeak(string str)
        {
            var newStr = string.Empty;
            foreach (var letter in str)
            {
                switch (letter)
                {
                    case 'a': newStr += '4'; break;
                    case 'e': newStr += '3'; break;
                    case 'i': newStr += '1'; break;
                    case 'o': newStr += '0'; break;
                    case 's': newStr += '5'; break;
                    default: newStr += letter; break;
                }
            }

            return newStr;
        }
    }
}
