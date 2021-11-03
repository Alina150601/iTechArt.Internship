using System;

//link: https://www.codewars.com/kata/550498447451fbbd7600041c/train/csharp

namespace Сompair
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
            Console.WriteLine(Comp(a, b));
        }

        private static bool Comp(int[] a, int[] b)
        {
            var count = 0;
            var result = true;
            if (a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length; j++)
                    {
                        if (a[i] * a[i] == b[j])
                        {
                            count++;
                            break;
                        }
                    }
                }

                if (count == a.Length) result = true;
                else result = false;
            }

            return result;
        }
    }
}
