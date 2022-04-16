using System;

namespace task4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 1000000; i++)
            {

                if (i >= 0)
                {
                    int reqem = i;
                    int tersi = 0;
                    while (reqem > 0)
                    {
                        int qaliq = reqem % 10;
                        tersi = (tersi * 10) + qaliq;
                        reqem = reqem / 10;
                    }
                    if (i == tersi)
                    {
                        int c = (i = tersi);
                        int e = c;
                        if (c > 0 || c < 100)
                        {
                            double b11 = c % 10;
                            double c11 = (c - (c % 10)) / 10;

                            if (b11 == c11 && b11 + c11 >= 5&& c!=55)
                            {
                                Console.WriteLine(c);
                            }
                        }
                            if (c >= 99 || c < 1000)
                        {
                            double b1 = e % 10;
                            double c1 = ((e % 100) - (e % 10)) / 10;
                            double d1 = (e - (e % 100)) / 100;
                            int d = ((c % 100) - (c % 10)) / 10;

                            if (b1 == c1 && c1 == d1 && b1 == d1 && b1 + c1 + d1 >= 5 && c != 555)
                            {
                                Console.WriteLine(c);
                            }

                        }
                        if (c>=1000||c<10000)
                        {
                            double b2 = c % 10;
                            double c2 = ((c % 100) - (c % 10)) / 10;
                            double d2 = ((c - (c % 100)) / 100) % 10;
                            double f2 = (c - (c % 1000)) / 1000;
                            if (b2 == c2 && c2 == d2 && b2 == d2 && b2 == f2 &&
                                c2 == f2 && d2 == f2 && b2 + c2 + d2 + f2 >= 5 && c != 5555)
                            {
                                Console.WriteLine(c);
                            }
                        }
                        if (c >= 10000 || c < 100000)
                        {
                            double b3 = c % 10;
                            double c3 = ((c % 100) - (c % 10)) / 10;
                            double d3 = ((c - (c % 100)) / 100) % 10;
                            double f3 = ((c - (c % 1000)) / 1000) % 10;
                            double t3 = (c - (c % 10000)) / 10000;

                            if (b3 == c3 && c3 == d3 && b3 == d3 && b3 == f3 &&
                                c3 == f3 && d3 == f3 && b3 == t3 && c3 == t3 && t3 == d3 && t3 == f3
                                && b3 + c3 + d3 + f3 + t3 >= 5 && c != 55555)
                            {
                                Console.WriteLine(c);
                            }
                        }
                    }
                }
            }
        }
    }
}
