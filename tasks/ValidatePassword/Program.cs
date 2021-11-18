using System;
using System.Collections.Generic;
using System.Linq;

//link: https://edabit.com/challenge/etT7orqDDXJF2zGYM
namespace ValidatePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePassword("Pè7$areLove"));
        }

        public static bool ValidatePassword(string password)
        {
            var hasNormalLength = password.Length >= 6 && password.Length <= 24;
            var allowedSymbols = new List<char>
            {
                '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '=', '_', '-',
                '{', '}', '[', ']', ':', ';', '"', '\'', '?', '<', '>', ',', '.', ','
            };


            foreach (var symbol in password)
            {
                var repeats = password.Count(x => x == symbol);
                if (repeats > 2)
                {
                    return false;
                }
            }

            var isAllowed = password.All(x =>
                char.IsLetterOrDigit(x) || allowedSymbols.Contains(x));

            return hasNormalLength &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit) &&
                   password.All(x => x != 'è') &&
                   isAllowed;
        }
    }
}