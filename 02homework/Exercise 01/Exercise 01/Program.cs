using System;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Tom";
            string lastName = " Brady";
            var result = firstName + lastName;
            Console.WriteLine("Your full name is " + result);
            Console.WriteLine("Please press enter!");
            Console.ReadLine();

           

            string firstNumber = "9";
            string secondNumber = "3";
            var resultFromNumbersAsString = firstNumber + secondNumber;
            Console.WriteLine("The sum of numbers as a string is " + resultFromNumbersAsString);
            Console.WriteLine("Please press enter again!");
            Console.ReadLine();


        }
    }
}
