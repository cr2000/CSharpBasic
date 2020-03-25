using System;

namespace CalculatorWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Enter the desired operation +, -, /, * ");
                string operationChosen = Console.ReadLine();

                if (operationChosen != "+" && operationChosen != "-" && operationChosen != "*" && operationChosen != "/" && operationChosen != "s" && operationChosen != "S")
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operation selected. Please press enter and try try again.");
                    Console.ReadLine();
                    continue;
                }


                if (operationChosen == "s" || operationChosen == "S")
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Thanks for using the calculator!Please press enter and try again.");
                    Console.ReadLine();
                    return;
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



                else if (operationChosen == "+")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Sum(num1, num2));
                    Console.WriteLine("Please press enter to make another calculation.");
                }

                else if (operationChosen == "-")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Difference(num1, num2));
                    Console.WriteLine("Please press enter to make another calculation.");
                }

                else if (operationChosen == "/")
                {
                    if (num2 == 0)
                    {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Division with zero is not possible. Please press enter and try again.");
                    }

                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Quotient(num1, num2));
                        Console.WriteLine("Please press enter to make another calculation.");
                    }
                    
                }

                else if (operationChosen == "*")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Product(num1, num2));
                    Console.WriteLine("Please press enter to make another calculation.");
                }
                Console.ReadLine();


            }


        }

        public static double Sum(double number1, double number2)
        {
            double sum = 0;
            sum = number1 + number2;
            return sum;
        }

        public static double Difference(double number1, double number2)
        {
            double difference = 0;
            difference = number1 - number2;
            return difference;
        }

        public static double Product(double number1, double number2)
        {
            double product = 0;
            product = number1 * number2;
            return product;
        }

        public static double Quotient(double number1, double number2)
        {
            double quotient = 0;
            quotient = number1 / number2;
            return quotient;
        }

    }
}
