using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Enter the desired operation +, -, /, * ");


                string operationChosen = Console.ReadLine();
                if (operationChosen == "s" || operationChosen == "S")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thanks for using the calculator!Please press enter and try again.");
                    Console.ReadLine();
                    return;
                }

                if (operationChosen != "+" && operationChosen != "-" && operationChosen != "*" && operationChosen != "/")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operation selected. Please press enter and try try again.");
                    Console.ReadLine();
                    continue;
                }

               

                Console.WriteLine("Please Enter a number: ");
                //double num1 = Convert.ToDouble(Console.ReadLine());
                double num1;
                bool isNumeric = double.TryParse(Console.ReadLine(), out num1);
                if (isNumeric != true)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid number entered. Press eneter and try again.");
                    Console.ReadLine();
                    continue;
                }



                Console.WriteLine("Please Enter another number: ");
                //double num2 = Convert.ToDouble(Console.ReadLine());
                double num2;
                bool isNumericScnd = double.TryParse(Console.ReadLine(), out num2);
                if (isNumericScnd != true)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid number entered. Please press enter nd try again.");
                    Console.ReadLine();
                    continue;
                }



                if (operationChosen == "+")
                {
                    Console.WriteLine(num1 + num2);
                    Console.WriteLine("Please press enter to make another calculation.");
                }
                if (operationChosen == "-")
                {
                    Console.WriteLine(num1 - num2);
                    Console.WriteLine("Please press enter to make another calculation.");
                }
                if (operationChosen == "/")
                {
                    if (num2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Division with zero is not possible. Please press enter and try again.");
                    }
                    Console.WriteLine(num1 / num2);
                    Console.WriteLine("Please press enter to make another calculation.");
                }
                if (operationChosen == "*")
                {
                    Console.WriteLine(num1 * num2);
                    Console.WriteLine("Please press enter to make another calculation.");
                }
                Console.ReadLine();


            }


        }
    }
}