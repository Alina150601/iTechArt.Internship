using System;

//link: https://edabit.com/challenge/8JegGd37XazwMJvs6
namespace FiboWord
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(FiboWord(6));
        }

        public static string FiboWord(int n)
        {
            string first = "b";
            string second = "a";
            switch (n)
            {
                case < 2:
                    return "invalid";
                case 2:
                    return "b, a";
                default:
                {
                    n -= 2;
                    string str = string.Empty;
                    str += "b, a, ";
                    do
                    {
                        string newStr = second + first;
                        str += newStr;
                        if (n != 1) str += ", ";
                        var inMemory = second;
                        second = newStr;
                        first = inMemory;
                        n--;
                    } while (n != 0);

                    return str;
                }
            }
        }

        /* //Fibonachi with numbers
    // static void FiboNumber(int n)
    // {
    //     n -= 2;
    //     var first = 1;
    //     var second = 1;
    //     do
    //     {
    //         var newNumber = second + first;
    //         Console.Write(newNumber + " ");
    //         var inMemory = second;
    //         second = newNumber;
    //         first = inMemory;
    //         n--;
    //     } while (n != 0);
     }*/
    }
}
