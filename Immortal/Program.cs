//TODO

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(ElderAge(8, 5, 1, 100));
    }

    public static long ElderAge(long n, long m, long k, long newp)
    {
        long[,] a = new long[n, m];

        long sum = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                a[i, j] = i ^ j;
                if (a[i, j] > 0)
                {
                    a[i, j] -= k;
                }

                sum += a[i, j];
            }
        }

        sum %= newp;
        return sum;
    }
}