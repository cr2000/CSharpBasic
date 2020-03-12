using System;

namespace ConsoleApp2
{
    class Program03
    {
        static void Main(string[] args)
        {

            //            Create an array with names
            //Give an option to the user to enter a name from the keyboard
            //After entering the name put it in the array
            //Ask the user if they want to enter another name(Y / N)
            //Do the same process over and over until the user enters N
            //Print all the names after user enters N
            //Hint: we need to use endless loop until user enter N, then we want to "break" the loop













            string[] names = new string[5];

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Please enter a name: ");
                names[i] = Console.In.ReadLine();
            }
            Console.WriteLine("The entered names are: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write(names[i] + " ");
            }



            Console.ReadLine();

        }
    }
}
