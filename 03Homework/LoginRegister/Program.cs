using System;

namespace LoginRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Please enter 1 if you want to register, or 2 if you want to login.");
                string registerOrLogin = Console.ReadLine();
                //if (registerOrLogin != "1" && registerOrLogin != "2") 
                //{
                //    Console.WriteLine("Invalid choise. Pleaase try again!");
                //    continue;

                //}





                switch (registerOrLogin)
                {
                    case "1":


                        Console.WriteLine("Please enter your username/emal: ");
                        string username = Console.ReadLine();
                        bool userCorrect = false;
                        if (username.ToLower().Contains('@') && username.ToLower().Contains('.') && username.Length < 30 && !char.IsNumber(username[0]) && !char.IsNumber(username[username.Length-1]) && !char.IsSymbol(username[0]) && !char.IsSymbol(username[username.Length-1]))


                        {
                            userCorrect = true;
                        }
                        

                        if (userCorrect)
                        {
                            Console.WriteLine("Please enter a password:");
                        }


                        if (userCorrect == false)
                        {
                            Console.WriteLine("You have entered an invalid username, please try again!");
                        }

                        break;



                    case "2":


                        break;





                    default:
                        Console.WriteLine("Invalid choise. Pleaase try again!");
                        break;
                }


                Console.ReadLine();






            }










        }
    }
}
