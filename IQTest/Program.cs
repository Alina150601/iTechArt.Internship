using System;
using System.Linq;

//link: https://www.codewars.com/kata/552c028c030765286c00007d/train/csharp

namespace IQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = "2,2,1";
            Console.WriteLine(Test(numbers));
        }

        public static int Test(string numbers)
        {
            var numberOfPosition = 0;
            var odd = numbers.Count(oneNumber => oneNumber % 2 == 0);
            if (odd == 1)
            {
                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0) numberOfPosition = i;
                }
            }
            else
            {
                for (var i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 1) numberOfPosition = i;
                }
            }

            return numberOfPosition;
        }
    }
}