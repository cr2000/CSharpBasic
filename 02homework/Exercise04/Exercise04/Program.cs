using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter a number: ");
            var input = Console.ReadLine();
            int converted;
            bool isConverted = int.TryParse(input, out converted);
            if (isConverted && converted % 2 == 0)
            {
                Console.WriteLine("The number " + input + " is even.");
            }
            else if (isConverted && converted % 2 != 0)
            {
                Console.WriteLine("The number " + input + " is odd.");
            }
            else
            {
                Console.WriteLine("Please enter a valid number!");
            }
            Console.ReadLine();



        }
    }
}
