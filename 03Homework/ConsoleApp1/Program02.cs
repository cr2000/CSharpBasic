using System;

namespace ConsoleApp1
{
    class Program02
    {
        static void Main(string[] args)
        {
            //            EXERCISE 02:

            //Get an input number from the console
            //Print all even numbers starting from 2
            //Get another input number from the console
            //Print all odd numbers starting from 1





            Console.Write("Please enter a number: ");
            int theInput = 0;
            bool validInput = int.TryParse(Console.ReadLine(), out theInput);

            if (validInput == true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("The even numbers up to " + theInput + " are:");
                for (int i = 2; i <= theInput; i++)
                {

                    if (i % 2 == 0 && i < theInput)
                    {

                        Console.Write(i + ", ");

                    }
                    if (i % 2 == 0 && i == theInput)
                    {
                        Console.WriteLine(i + ".");
                    }//ne mi teknuva kako da napravam posledniot element od loopot da nema zapirka po nego :(

                }

            }
            else
            {
                Console.WriteLine("Wrong input, please enter a number!");


            }


            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\nPlease enter a number: ");
            int theInputForOdd = 0;
            bool validInputForOdd = int.TryParse(Console.ReadLine(), out theInputForOdd);

            if (validInputForOdd == true)
            {
                Console.WriteLine("The odd numbers up to " + theInputForOdd + " are:");
                for (int i = 1; i <= theInputForOdd; i++)
                {

                    if (i % 2 != 0 && i <= theInputForOdd)
                    {

                        Console.WriteLine(i);

                    }


                }

            }
            else
            {
                Console.WriteLine("Wrong input, please enter a number!");                                                                                                 



            }
            Console.ReadLine();
        }
    }
}