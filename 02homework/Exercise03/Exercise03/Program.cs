using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 102;
            int m = 5;
            var result = n / m;
            Console.WriteLine("You have " + n + " denars on your phone, and you can send max of " + result + " messages untill your credit runs out!");
            Console.ReadLine();


        }
    }
}
