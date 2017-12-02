using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Library library = new Library();

            for (int i = 0; i < input; i++)
            {
                string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string title = command[0];
                string author = command[1];
                string publisher = command[2];
                string releaseDate = command[3];
                string isbn = command[4];
                decimal price = decimal.Parse(command[5]);

                //идеята е че можеш да направиш всичко тук
                //когато ти подадат нова книга проверяваш дали вече има такък автор
                //и ако няма създаваш нова книга и я пъхаш в библиотеката
                //обаче ако има трябва да намериш книгата чийто автор е същия от входа и да я ъпдейтнеш
                Book book = null;
                if (!library.Books.Any(b => b.Author == author))
                {
                    book = new Book(title, author, publisher, releaseDate, isbn, price);

                    library.Books.Add(book);
                }
                else
                {
                    book = library.Books.First(b => b.Author == author);
                    book.Price += price;
                }
            }
            //var results = library.Books.Where(a => a.Author.Equals(a.Author)).Distinct();

            //bookAuthors.OrderByDescending(b => b.Value).ThenBy(a => a.Key);

            foreach (var item in library.Books
                .OrderByDescending(p => p.Price)
                .ThenBy(a => a.Author))
            {
                var authors = item.Author;

                Console.WriteLine($"{authors} -> {item.Price:f2}");
            }

        }
    }
    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, string publisher, string releaseDate, string isbn, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }
    }
}
