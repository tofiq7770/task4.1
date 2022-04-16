using System;

namespace task4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 0;
            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    int a = i;
                    while(a!=0)
                    {
                        sum += a % 10;
                        a /= 10;

                    }
                    if (sum==6)
                    {
                        number = i;
                    }
                
                }
                else
                {
                    sum = 0;
                } 

            }
            Console.WriteLine($"axtarilan eded={number}");
          
        }
    }
}
