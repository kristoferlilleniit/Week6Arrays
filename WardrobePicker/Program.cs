using System;

namespace WardrobePicker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] clothes = {"hat", "hoodie", "jeans", "dress", "shirt" };
            string[] colors = { "red", "purple", "orange", "white", "pink", "black" };
            string[] patterns = { "flowery", "striped", "checkered", "circles" };
            Random rnd = new Random();
            int randomClothing = rnd.Next(0, clothes.Length);
            int randomColors = rnd.Next(0, colors.Length);
            int randomPatterns = rnd.Next(0, patterns.Length);

            Console.WriteLine("Do you need help with picking an outfit?");
            string userInput = Console.ReadLine().ToLower();

            if(userInput == "no")
            {
                Console.WriteLine("Farewell.");
            }else if(userInput == "yes")
            {
                 Console.WriteLine($"Today you'll wear {colors[randomColors]} {patterns[randomPatterns]} {clothes[randomClothing]}");
            }else
            {
                Console.WriteLine("No.");
            }
        }
    }
}
