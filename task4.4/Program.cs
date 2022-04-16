using System;

namespace task4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000; i++)
            {
                if (i >= 0)
                {
                    int c=i;
                    double b = c % 10;
                    double c1 = ((c % 100) - (c % 10)) / 10;
                    double d = ((c - (c % 100)) / 100) % 10;
                    double f = ((c - (c % 1000)) / 1000) % 10;
                    double t = (c - (c % 10000)) / 10000;
                    if (c%11==0 && b+d+c1+f+t>11)
                    {
                        Console.WriteLine(c);
                        if (c==286)
                        {
                            Console.WriteLine($"11-ci:286");
                            break;
                        }
                    }
                }
            }
        }
    }
}
