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
        private int id;
        private string title;
        private string author;
        private Genres genre;
        private int isbnNumber;
        private DateTime releaseDate;
        private string publisher;
        private string pageAmount;



        public string Title
        {
            get 
            {
                return title;
            } 
            private set
            {
                if(value is not null)
                {
                    title = value;
                }
            }
        }

        public int Id;
        public string Author 
        { 
            get
            {
                return author;
            }
         set
            {

            }
        }
        public Genres Genre { get; set; }
        public int IsbnNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public int PageAmount { get; set; }


        // Constructor
        public Book(string title,string author,Library library)
        {
            this.title = title;
            this.author = author;
            library.AddBook(this);
        }

        //Methodes

        public void ShowOverview()
        {
            
        }

    }
}
