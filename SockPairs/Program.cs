using System;
using System.Collections.Generic;
//link: https://edabit.com/challenge/C6wN5vGodWvWL7ZaK
namespace SockPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int SockPairs(string socks)
        {
            int amount = 0;
            var alphabet = new List<char>
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };
            foreach (var letter in alphabet)
            {
                var number = 0;
                foreach (var sock in socks)
                {
                    if (sock == letter)
                    {
                        number++;
                    }
                }

                amount += number / 2;
            }
            return amount;
        }
        
    }
}