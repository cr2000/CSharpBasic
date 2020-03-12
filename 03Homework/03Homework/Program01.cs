using System;

namespace _03Homework
{
    class Program01
    {
        static void Main(string[] args)
        {
            //            EXERCISE 01:
            //Get an input number from the console
            //Print all numbers from 1 to that number
            //Get another input number from the console
            //Print all numbers from that number to 1


            Console.Write("Please enter a number: ");
            int theInput = 0;
            bool validInput = int.TryParse(Console.ReadLine(), out theInput);
            if (validInput)
            {
                for (int i = 1; i <= theInput; i++)
                {
                    Console.WriteLine(i);

                }


            }
            else
            {
                Console.WriteLine("You have entered an invalid input!");


            }

            Console.Write("Please enter another number: ");
            int theInputSecondTime = 0;
            bool validInputTwo = int.TryParse(Console.ReadLine(), out theInputSecondTime);
            if (validInputTwo)
            {
                for (int i = theInputSecondTime; i >= 1; i--)
                {
                    Console.WriteLine(i);




                }
                Console.WriteLine("Thanks for playing! \n-Please press ENTER to close the program.");


            }
            else
            {
                Console.WriteLine("You have entered an invalid input!");
            }

            





            Console.ReadLine();



        }
    }
}
