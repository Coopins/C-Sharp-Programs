using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //added
using System.IO; //added

namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksContext context = new BooksContext();

            context.Database.EnsureCreated();

            Console.WriteLine("Enter the title and author of the book that you want to add with a ':' in between");
            Console.WriteLine("Type 'delete' to remove a book from the list");

            String TitleAuthor = Console.ReadLine();

            string[] parts = TitleAuthor.Split(':');
            if (parts.Length == 2)
            {
                Book NewBook = new Book(parts[0], parts[1]);
                context.Books.Add(NewBook);
                context.SaveChanges();
                Console.WriteLine("Book added");
            }
            else if (TitleAuthor == "delete")
            {
                Console.WriteLine("What is the ID?");
                int ID = Convert.ToInt32(Console.ReadLine());

                context.Books.Remove(context.Books.Find(ID));
                context.SaveChanges();
            }

            else
            {
                Console.WriteLine("Invalid entry, not added");
            }
            Console.WriteLine("Current list of books are: ");
            foreach (Book B in context.Books)
            {
                Console.WriteLine("{0}-{1} {2}", B.Id, B.Title, B.Author);
            }
            Console.ReadKey();
        }
    }
    class Book
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Book(string Title, String Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
    }
    class BooksContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DirectoryInfo ExecutionDirectory = new DirectoryInfo(AppContext.BaseDirectory);

            DirectoryInfo ProjectBase = ExecutionDirectory.Parent.Parent.Parent;

            String DatabaseFile = Path.Combine(ProjectBase.FullName, "Books.db");

            optionsBuilder.UseSqlite("Data Source=" + DatabaseFile);

        }

    }
}