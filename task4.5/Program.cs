using System;

namespace task4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers;
            int temp;
            int sum;
            int counter = 0;
            for (numbers = 1; numbers < 1000; numbers++)
            {
                temp = numbers;
                sum = 0;
                if (temp % 11 == 0)
                {
                    while (temp > 0)
                    {
                        sum = sum + (temp % 10);
                        temp /= 10;
                    }
                    if (sum > 11)
                    {
                        counter++;
                        if (counter == 11)
                        {
                            break;

                        }
                    }
                }
            }
            Console.Write("11-ci eded: ");
            Console.WriteLine(numbers);
        }
    }
}
