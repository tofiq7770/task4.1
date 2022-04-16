using System;

namespace Task4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i<1000 ; i++)
            {
                
                if (i>=60)
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
                        int d= ((c % 100) - (c % 10)) / 10;
                        if (!(d == 3) && !(c > 299 && c < 430) && !(c > 100 && c < 190) && 
                            !(c > 200 && c < 270) && !(c==505))
                        {
                            Console.WriteLine(c);
                        }

                    }
                }
            }

        }
    }
}
