namespace testCode
{
    internal class Program
    {

       abstract class Dier
        {
            public void Eet()
            {
                Console.WriteLine("Nom nom");
            }
        }
        class Hond:Dier
        {
            public void geluid()
            {
                Console.WriteLine("Woef noef");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> customers = new Dictionary<int, string>();
            customers.Add(123, "Tim Dams");
            customers.Add(6463, "James Bond");
            customers.Add(666, "The beast");
            customers.Add(700, "James Bond");

            foreach (var item in customers)
            {
                Console.WriteLine($"{item.Key}\t:{item.Value}");
            }

            Console.WriteLine(customers[123]);


            Hond attila = new Hond();

            attila.geluid();
        }
    }
}
