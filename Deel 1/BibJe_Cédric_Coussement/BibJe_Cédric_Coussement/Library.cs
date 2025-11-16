using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJe_Cédric_Coussement
{
    internal class Library
    {
        private string name;
        private List<Book> books = new List<Book>();

       public Library(string name)
        {
            this.name = name;
        }
        public void AddBook(Book book)
        {
           
            books.Add( book);
        } 

        
        public void RemoveBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
            }
            Console.WriteLine($"Boek niet gevonden");
        }
        public void SearchingOnTitelAndAuthor()
        {
            Console.WriteLine("Geef de naam van het boek:");
            string bookTitle = Console.ReadLine();
            Console.WriteLine("Geef de naam van de auteur:");
            string author = Console.ReadLine();

            bool found = false;
            foreach (Book book in books)
            {
                if (book.Title == bookTitle && book.Author == author)
                {
                    Console.WriteLine($"Gevonden: {book.Title} door {book.Author}");
                    book.ShowOverview(); 
                    found = true;
                    break; 
                }
            }
            if (!found)
            {
                Console.WriteLine("Boek is niet gevonden.");
            }
            Console.ReadKey();
        }

        public Book FindBookByTitle(string title)
        {
            foreach(Book book in books)
            {
                if (book.Title.Contains(title))
                {
                    return book;
                }
            }
            return null;
        }

       
        public void ShowAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title}");
            }
            Console.WriteLine("");
        }

        public void ReadingCsvFile(string fileName,Library library)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string items in lines)
            {
                string[] columns = items.Split(",");

                string col0 = columns[0];
                string col1 = columns[1];
                
                Console.WriteLine($"{col0}, {col1}");

                Book newBook = new Book(col0, col1, library);
                Console.WriteLine("csv opgeladen.");
            }
        }
    }
}
