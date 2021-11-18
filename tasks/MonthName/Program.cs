using System;
    
//link: https://edabit.com/challenge/uevxL5FNM77otyo9Z

namespace MonthName
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = 4;
            Console.WriteLine(MonthName(month));
        }

        public static string MonthName(int num)
        {
            string month;
            switch (num)
            {
                case 1: month = "January"; break;
                case 2: month = "February"; break;
                case 3: month = "March"; break;
                case 4: month = "April"; break;
                case 5: month = "May"; break;
                case 6: month = "June"; break;
                case 7: month = "July"; break;
                case 8: month = "August"; break;
                case 9: month = "September"; break;
                case 10: month = "October"; break;
                case 11: month = "November"; break;
                case 12: month = "December"; break;
                default: month = string.Empty; break;
            }

            return month;
            
            /* THE BEST REALIZATION OF RIDER
             var month = num switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => string.Empty
            };
            return month;
        }*/
        }

    }
}