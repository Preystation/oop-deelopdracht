using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJe_Cédric_Coussement
{
    internal class Book
    {
        public enum Genres
        {
            Avontuur,
            Fantasy,
            HistorischeFictie,
            Humor,
            Sciencefiction,
            Thriller,
            Politiek,
            Gezondheid,
            ReligieSpiritualiteit,
            Leerboeken
        }
        //  8 Propertys
        /*
       1 title;
       2 author,
       3 Genre,
       4 IsbnNumber,
       5 Releaseyear,
       6 id
       7 PageAmount
       8 Publisher
         */

        //private fields
        private static int id = 0;
        private string title;
        private string author;
        private Genres genre;
        private int isbnNumber;
        private DateTime releaseDate;
        private string publisher;
        private int pageAmount;



        public string Title
        {
            get 
            {
                return title;
            } 
            private set
            {
                if(value is not null && value !="")
                {
                    title = value;
                }
            }
        }

        public int Id { get; private set; }// extra functioniteit
        public string Author 
        { 
            get
            {
                return author;
            }
         set
            {
                if (value is not null && value != "")
                {
                    author = value;
                }
            }
        }
        public Genres Genre { 
            get { return genre; }
            set {
                genre = value;                       
            } }
        public int IsbnNumber
        {
            get
            {
                return isbnNumber;
            }
            set
            {
                if (value.ToString().Length == 13)
                {
                    isbnNumber = value;
                }
                else
                {
                    Console.WriteLine("ISBN moet 13 cijfers bevatten.");
                   
                }
            }
        }
  
        public DateTime ReleaseDate
        {
            get
            {
                return releaseDate;
            }
             set
            {

                if (value <= DateTime.Now)
                {
                    releaseDate = value;
                }

                Console.WriteLine("datum mag niet in de toekomst liggen.");
                
            }
        }
        public string Publisher { get 
            {
                return publisher;
            }
            set
            {
                if (value is not null && value != "")
                {
                    publisher = value;
                }
            }
                }
        public int PageAmount { get
            {
                return pageAmount;
            }
            set {

                if (value > 0)
                {
                    pageAmount = value;
                }
            } 
        }


        // Constructor
        public Book(string title,string author,Library library)
        {
            this.Title = title;
            this.Author = author;
            this.Id = ++id;
            library.AddBook(this);
           
        }

        //Methodes

        public void ShowOverview()
        {
            Console.WriteLine($"[{Id}] {Title} door {Author}");
            Console.WriteLine($"Genre: {Genre}, ISBN: {IsbnNumber}, Release: {ReleaseDate:yyyy}");
            Console.WriteLine($"Uitgever: {Publisher}, Pagina's: {PageAmount}");
            Console.WriteLine();
        }

    }
}
