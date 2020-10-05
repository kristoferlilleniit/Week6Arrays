using System;

namespace UserAgainstZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userBag = new string[5];
            int i = 0;
            while(i < 5)
            {
                Console.WriteLine("What's in your bag?");
                userBag[i] = Console.ReadLine();
                i++;
            }

            Random rnd = new Random();

            Console.WriteLine($"In case of a zombie apocalypse you will have to " + $"fight zombies off with a {userBag[rnd.Next(0, userBag.Length)]}");
        }
    }
}
