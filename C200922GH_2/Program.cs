using System;

namespace C200922GH_2
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Juhász Zoltán");
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                Console.Write("*");
            }
            Console.ReadKey(true);
        }
    }
}
