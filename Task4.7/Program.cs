using System;

namespace Task4._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Book b = new Book();
            b.Name = "Qərb Bürkusü";
            b.AuthorName = "Çingiz Abdullayev";
            b.PublishedDate =2013;
            b.PageCount = 300;

            Console.WriteLine(b);
            Console.WriteLine("-------------------------------");
            b.Book1();
        }
    }
}
