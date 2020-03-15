using System;

namespace Homework_Class_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //#region taskwithouthelp
            //string[] names = new string[10];
            //var index = 0;
            //Console.WriteLine("Please enter a name:");
            //while (true)
            //{
            //    string userName = Console.ReadLine();
            //    if (userName.Length > 1)
            //    { 
            //        names[index] = userName;
            //        index++;
            //    }
            //    Console.WriteLine("Would you like to enter another name? Y/N?");
            //    if (userName.ToLower() == "n")
            //    {

            //        Console.WriteLine("\nThe entered names are: ");
            //        foreach (var name in names)
            //        {
            //            Console.Write(name + " ");
            //        }
            //        break;
            //    }
            //}
            //#endregion
            //Console.ReadLine();

            #region kodot od Goce

            string[] names = new string[] { };
            char[] answers = new char[] { 'Y', 'N' };
            while (true)
            {
                Console.WriteLine("Please enter a name");
                string name = Console.ReadLine();
                int index = names.Length;
                Array.Resize(ref names, names.Length + 1);
                names[index] = name;
                char answer;
                while (true)
                {
                    Console.WriteLine("Please press Y to continue or N to STOP and display names");
                    bool isConverted = char.TryParse(Console.ReadLine(), out answer);
                    if (isConverted && Array.IndexOf(answers, answer) != 1)
                        break;


                }
                if (Char.ToUpper(answer) == 'Y')
                    continue;
                else
                {
                    foreach (var userName in names)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine(userName);
                        Console.WriteLine("---------------------------------");

                    };
                    Console.ReadLine();

                    break;
                }

            }





            #endregion

        }
    }
}
