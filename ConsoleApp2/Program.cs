using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Edition Ed = new Edition();
            Ed.Name = "War and world";
            Ed.Author = "Rom";
            Ed.Year = 2002;
            Console.WriteLine($"{Ed.ToString()}");
            Console.WriteLine();

            Edition Ed2 = new Edition("Пушкин", "Чайковский", 88);
            Console.WriteLine($"{Ed2.ToString()}");
            Console.WriteLine();

            Console.Write("Название: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                name = "Неизвестный";
            }

            Console.Write("Имя: ");
            string author = Console.ReadLine();
            if (string.IsNullOrEmpty(author))
            {
                author = "Неизвестный";
            }

            Console.Write("Год: ");
            string yearInput = Console.ReadLine();
            double year;
            if (string.IsNullOrEmpty(yearInput) || !double.TryParse(yearInput, out year))
            {
                year = 0; 
            }

            Edition Ed3 = new Edition(name, author, year);
            Console.WriteLine($"{Ed3.ToString()}");
            Console.ReadLine();

        }
    }
}
