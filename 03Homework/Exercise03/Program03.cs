using System;

namespace Homework_Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            var index = 0;
            Console.WriteLine("Please enter a name:");
            while (true)
            {
                string userName = Console.ReadLine();
                if (userName.Length > 1)
                {
                    names[index] = userName;
                    index++;
                }
                Console.WriteLine("Would you like to enter another name? Y/N?");
                if (userName.ToLower() == "n")
                {
                   
                    Console.WriteLine("\nThe entered names are: ");
                    foreach (var name in names)
                    {
                        Console.Write(name + " ");
                    }
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}