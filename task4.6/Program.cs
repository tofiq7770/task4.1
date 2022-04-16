using System;

namespace task4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin:");
            int eded = Convert.ToInt32(Console.ReadLine());
            int newEded = 0;
            int remind;
            int counter = 0;
            int count = 0;

            while (eded > 0)
            {
                remind = eded % 10;
                if (remind != 5 && remind != 7)
                {
                    newEded = newEded + (int)(eded % 10 * Math.Pow(10, counter));
                    counter++;
                }
                eded /= 10;
            }
            int first = (int)(newEded / Math.Pow(10, counter - 1));
            int last = newEded % 10;

          eded =  last*(int)Math.Pow(10,counter - 1)+first+(((int)(newEded% Math.Pow(10, counter - 1))/10)*10);

            double dublicate = newEded;
            while (newEded > 0)
            {
                int rem = (int)newEded % 10;
                if (rem % 2 != 0)
                {
                    count++;
                }
                newEded /= 10;
            }
            Console.WriteLine("{1}deki Tek reqemlerin sayi {0}", count, dublicate);

        }
    }
}
