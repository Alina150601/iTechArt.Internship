using System;
using System.Collections.Generic;
using System.Linq;

//link: https://edabit.com/challenge/C6wN5vGodWvWL7ZaK
namespace SockPairs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(SockPairs("HeLLo World!"));
        }

        public static int SockPairs(string socks)
        {
            var amount = 0;
            socks = socks.ToLower();
            var socksChars = new HashSet<char>(socks);
            foreach (var letter in socksChars)
            {
                amount += socks.Count(sock => char.ToUpper(sock) == char.ToUpper(letter)) / 2;
            }
            return amount;
        }
    }
}
