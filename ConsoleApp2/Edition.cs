using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Edition
    {
        private const int V = 0;
        private string title;
        private string author;
        private int year;

        public string Name
        {
            get { return (title != "") ? title : "Неизвестно"; }
            set => title = value;
        }
          
            

        public string Author
        {
            get { return (author != "") ? author : "Неизвестно"; }
            set => author = value;
        }

        public int Year
        {
            get => year;
            set
            {
                if (value < 1990)
                    year = 1990;
                else if (value > 2024)
                    year = 2024;
                else year = value;
                if (value < 0)
                    throw new ArgumentException("Неизвестный");

            }
        }

     public Edition(string name, string Author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }

        public Edition()
        {
        }
        public Edition(string name, string author, double year)
        {
            this.Name = name;
            this.Author = author;
            this.Year = (int)year;
        }
        public override string ToString()
        {
            return $"Имя: {Name}\nАвтор: {Author}\nГод: {Year} ";
        }
    }
}
