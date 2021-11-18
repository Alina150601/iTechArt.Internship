using System;
using System.Linq;

//link: https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/solutions/csharp
namespace Kata
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(DuplicateEncode("babaevae"));
        }

        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            var newWord = "";
            foreach (var letter in word)
            {
                var letterCount = word.Count(x => x == letter);

                if (letterCount > 1)
                {
                    var newLetter = '(';
                    newWord += newLetter;
                }
                else
                {
                    var newLetter = ')';
                    newWord += newLetter;
                }
            }

            return newWord;
        }
    }
}