using System;
using System.Collections.Generic;
using System.Linq;

//link: https://edabit.com/challenge/YGhgctqPsKQxQQCFS
namespace ReverseAndNot
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 123;
            Console.WriteLine(ReverseAndNot(i));
        }

        public static string ReverseAndNot(int i)
        {
            var numberToString = i.ToString();
            var numberToStringRevers = new string(i.ToString().ToCharArray().Reverse().ToArray());
            var newNumber = numberToStringRevers + numberToString;
            return newNumber;
        }
    }
}
