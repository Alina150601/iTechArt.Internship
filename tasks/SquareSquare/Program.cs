using System;

//link: https://www.codewars.com/kata/54c27a33fb7da0db0100040e/train/csharp

namespace SquareSquare
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsSquare(36));
        }

        public static bool IsSquare(int n)
        {
            var root = (int)Math.Sqrt(n);
            return root * root == n;
        }

        /*MORE SIMPLE VERSION
         * return Math.Truncate(Math.Sqrt(n)) == Math.Sqrt(n);
         */
    }
}