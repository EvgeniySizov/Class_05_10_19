using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_05_10_19
{
    class Book
    {
        public string Name;
        public int Year;
        public string Author;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book>()
            {
                        new Book() { Name = "Guards! Guards!", Year = 1973, Author = "Petrov" },
                        new Book() { Name="Finders Keepers", Year = 1980, Author = "Ivanov" },
                        new Book() { Name = "LINQtask", Year = 2016, Author = "Petrov" },
                        new Book() { Name = "FirstStepInLINQ!", Year = 2019, Author = "Petrov" }
            };
            // 1
            Console.WriteLine(string.Join(",", books.Where(book => book.Name.Contains("LINQ") && DateTime.IsLeapYear(book.Year)).Select(book => book.Name)));

            // 2
            var words = new List<string>()
            {
                "London is a capital of Great Britan"
            };

            Console.WriteLine(words.SelectMany(str => str).Distinct().Count());

            // 3

            int[] myarr = new int[] { 12, 16, 20, 28, 32, 33 };
            Console.WriteLine(string.Join("," , myarr.OrderBy(i => i / 10).ThenByDescending(i => i % 10)));

            // 4
            Console.WriteLine(string.Join("\n", books.GroupBy(book => book.Author).Select(c => $"{c.Key}, {c.Count()}")));

        }
    }
}


