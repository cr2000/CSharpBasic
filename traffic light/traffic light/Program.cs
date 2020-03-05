using System;

namespace traffic_light
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("STOP!");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WAIT!");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GO!");
            Console.ReadLine();


        }
    }
}
