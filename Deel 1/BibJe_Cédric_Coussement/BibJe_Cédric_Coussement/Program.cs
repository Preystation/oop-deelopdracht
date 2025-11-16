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
                    "\n2 om informatie van een boek aan te passen" +
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
                        Console.WriteLine("Geef de titel van het boek dat je wilt aanvullen.");
                        string findTitle = Console.ReadLine();
                        Book bookFound = codex.FindBookByTitle(findTitle);
                        if (bookFound != null)
                        {
                            Console.WriteLine("" +
                                "Wat wil je invullen?" +
                                "\n1 Voor ISBN-nummer" +
                                "\n2 Voor genre" +
                                "\n3 Voor uitgever" +
                                "\n4 Voor aantal pagina's" +
                                "\n5 Voor releasedatum" +
                                "\n6 Terug naar menu");
                            int keuze = Convert.ToInt32(Console.ReadLine());
                            switch (keuze)
                            {
                                case 1:
                                    Console.WriteLine("Geef ISBN-nummer in (13 cijfers):");
                                    bookFound.IsbnNumber = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("ISBN bijgewerkt.");
                                    break;
                                case 2:
                                    Console.WriteLine("Genre (1=Avontuur, 2=Fantasy, 3=HistorischeFictie, 4=Humor, 5=Sciencefiction, 6=Thriller, 7=Politiek, 8=Gezondheid, 9=ReligieSpiritualiteit, 10=Leerboeken):");
                                    int genreNum = Convert.ToInt32(Console.ReadLine());
                                    bookFound.Genre = (Book.Genres)genreNum;
                                    Console.WriteLine("Genre bijgewerkt.");
                                    break;
                                case 3:
                                    Console.WriteLine("Geef naam uitgever in:");
                                    bookFound.Publisher = Console.ReadLine();
                                    Console.WriteLine("Uitgever bijgewerkt.");
                                    break;
                                case 4:
                                    Console.WriteLine("Geef aantal pagina's in:");
                                    bookFound.PageAmount = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Aantal pagina's bijgewerkt.");
                                    break;
                                case 5:
                                    Console.WriteLine("Geef releasedatum in (dd-mm-yyyy):");
                                    bookFound.ReleaseDate = Convert.ToDateTime(Console.ReadLine());
                                    Console.WriteLine("Releasedatum bijgewerkt.");
                                    break;
                                
                                  
                                default:
                                    Console.WriteLine("Onbekende keuze.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Boek niet gevonden.");
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
                        Book bookToRemove = codex.FindBookByTitle(removeBook);
                        if (bookToRemove != null)
                        {
                            codex.RemoveBook(bookToRemove);
                            Console.WriteLine($"Boek '{removeBook}' verwijderd.");
                        }
                        else
                        {
                            Console.WriteLine("Boek niet gevonden.");
                        }

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
