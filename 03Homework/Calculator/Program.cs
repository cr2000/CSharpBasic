using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the desired operation +, -, /, * ");
            //if (Console.ReadLine() == "s" || Console.ReadLine() == "S")
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("Thanks for using the calculator! The aplication will automatically close.");
            //    Console.ReadLine();
            //    return;
            //}

            string operationChosen = Console.ReadLine();
            if (operationChosen == "")
            {
                Console.WriteLine("Invalid operation selected. The application will automaticaly close.");
                Console.ReadLine();
                return;
            }
            
            Console.WriteLine("Please Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            double num1;
            bool isNumeric = double.TryParse(Console.ReadLine(), out num1);
            if (isNumeric != true)
            {
                Console.WriteLine("Invalid number entered. The application will automaticaly close.");
                Console.ReadLine();
                return;
            }
            


                Console.WriteLine("Please Enter another number: ");
                //double num2 = Convert.ToDouble(Console.ReadLine());
                double num2;
                bool isNumericScnd = double.TryParse(Console.ReadLine(), out num2);
                if (isNumericScnd != true)
                {
                    Console.WriteLine("Invalid number entered. The application will automaticaly close.");
                    Console.ReadLine();
                    return;
                }
            


            if (operationChosen == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            if (operationChosen == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            if (operationChosen == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Division with zero is not possible. The app will automatically close.");
                }
                Console.WriteLine(num1 / num2);
            }
            if (operationChosen == "*")
            {
                Console.WriteLine(num1 * num2);
            }
           
            



            Console.ReadLine();
        }
    }
}
