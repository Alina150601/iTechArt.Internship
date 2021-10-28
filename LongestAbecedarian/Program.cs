using System;
using System.Collections.Generic;
using System.Linq;
//link: https://edabit.com/challenge/nLjn3M5h3ZX3PoipQ
namespace LongestAbecedarian
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = { "fewfwe", "wefwef", "abcdef", "abcdeg" };
            Console.WriteLine(LongestAbecedarian(word));
        }

        public static string LongestAbecedarian(IEnumerable<string> arr)
        {
            var targetWords = new List<string>();
            foreach (var word in arr)
            {
                var wordIsAbecedarian = true;
                for (var j = 1; j < word.Length; j++)
                {
                    if (word[j - 1] > word[j])
                    {
                        wordIsAbecedarian = false;
                        break;
                    }
                }

                if (wordIsAbecedarian)
                {
                    targetWords.Add(word);
                }
            }
            if(!targetWords.Any())
            {
                return "";
            }
            var maxLength = targetWords.OrderBy(word => word.Length).Last().Length;
            var firstAbecedarian = targetWords.First(word => word.Length == maxLength);
            return firstAbecedarian;
        }
    }
}