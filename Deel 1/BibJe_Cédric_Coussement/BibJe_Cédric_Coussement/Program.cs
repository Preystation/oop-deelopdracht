using System.Security.Cryptography.X509Certificates;

namespace BibJe_Cédric_Coussement
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            Library codex = new Library("Codex");

            do
            {
                Console.Write("" +
                    "Maak een keuze aan de volgende opties:" +
                    "\n1 voor een boek toe tevoegen op basis van titel en auteur" +
                    "\n2" +
                    "\n3 Om te zoeken op naam en auteur" +
                    "\n4 " +
                    "\n5 Een boek te verwijderen uit de bibliotheek." +
                    "\n6 Al onze boeken." +
                    "\n7 Csv bestand inlezen." +
                    "\n=> ");

                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    // Case 1 adding book with title and author
                    case 1:
                       
                        Console.WriteLine("Geef de titel van het boek.");
                        string bookTitle = Console.ReadLine();
                        Console.WriteLine("Geef nu de naam van de autheur.");
                        string author = Console.ReadLine();
                        Book book = new Book(bookTitle, author, codex);

                        break;
                    case 2:
                        //Om informatie aan een boek toe te voegen: het ISBN, of het genre, of minstens één van je extra eigenschappen
                        Console.WriteLine("Geef de titel van het boek dat je wilt aanvullen.");
                        string findTitle =Console.ReadLine();
                        Book bookFound = codex.FindBookByTitle(findTitle);
                        if(bookFound != null) 
                        {
                            Console.WriteLine("" +
                                "Wat wil je invullen?" +
                                "\n1 Voor isbnnummer" +
                                "\n2 Voor genre" +
                                "\n3 Voor uitgeverµ" +
                                "\n4 Maak een keuze");
                            int keuze = Convert.ToInt32(Console.ReadLine());
                            switch (keuze)
                            {
                                case 1:
                                    Console.WriteLine("Geef ISBN nummer in");
                                    bookFound.IsbnNumber = Convert.ToInt32(Console.ReadLine());
                            break;
                                case 2:
                                    Console.WriteLine("Genre");
                                   //bookFound.Genre =(book.Genre)
                                    break;
                                case 3:
                                    
                                    Console.WriteLine("Geef naam  uitgever in");
                                    bookFound.Publisher = Console.ReadLine();
                                    break;
                                case 4:

                                    break;
                                case 5:

                                    break;
                                case 6:

                                    break;
                                case 7:

                                    break;
                                case 8:

                                    break;
                                default:
                                    Console.WriteLine("Onbekende keuze.");
                                    break;
                            }
                        
                        }
                        break;
                    case 3:
                        // case 3 Showing al information searching on title and author.
                        codex.SearchingOnTitelAndAuthor();
                        break;
                    case 4:
                    //Een boek op te zoeken op verschillende manieren in een submenu. (zie Library)


                    case 5:
                        // case 5 removing book on title
                        Console.WriteLine("Geef de titel van het boek.");
                        string removeBook = Console.ReadLine();


                        break;
                    case 6:
                        // case 6  shows every book in the books list.
                        codex.ShowAllBooks();
                        break;
                    case 7:
                        //Reading a csv file in
                        codex.ReadingCsvFile("BooksCsvlines.csv",codex);

                        break;
                    default:
                        Console.WriteLine("Keuze is niet herkent.");
                        break;
                }
                
            } while (true);
        }
    }
}
