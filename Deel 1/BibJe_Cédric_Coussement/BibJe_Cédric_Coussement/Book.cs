using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibJe_Cédric_Coussement
{
    internal class Book
    {
        enum Genres {
            Avontuur,Fantasy,Historische_fictie,
            Humor,Sciencefiction,Thriller, 
            Politiek,Gezondheid,
            Religie_Spiritualiteit,leerboeken }

        private string title { get; set; }
        private Genres genre { get; set; }
        private string author { get; set; }
        private int isbnNumber { get; set; }
        private int pageAmount { get; set; }

        private DateTime releaseYear { get; set; }
        private string publisher { get; set; }

        private bool isLentOut { get; set; }

        public Book(
            string title, Genres genre, string author, int isbnNumber, int pageAmount, 
            DateTime releaseYear, string publisher, bool isLentOut)
        {
            this.title = title;
            this.genre = genre;
            this.author = author;
            this.isbnNumber = isbnNumber;
            this.pageAmount = pageAmount;
            this.releaseYear = releaseYear;
            this.publisher = publisher;
            this.isLentOut = isLentOut;
        }
    }
}
