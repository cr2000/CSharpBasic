using System;

namespace LoginRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Please enter 1 if you want to register, 2 if you want to login, or type EXIT if you want to EXIT");
                //kako mozham stringov gore da go napravam vo razlichni boi, do prvata zapirka vo edna, do vtorata vo druga itn...

                string registerOrLogin = Console.ReadLine();
                string[] listOfEmails = new string[] { };
                string[] listOfPasswords = new string[] { };








                switch (registerOrLogin)
                {
                    case "1":


                        Console.WriteLine("Please enter your username/emal: ");
                        string username = Console.ReadLine();

                        if (username.ToLower().Contains('@')
                            && username.ToLower().Contains('.')
                            && username.Length < 30
                            && !char.IsNumber(username[0])
                            && !char.IsNumber(username[username.Length - 1])
                            && char.IsLetterOrDigit(username[0])
                            && char.IsLetterOrDigit(username[username.Length - 1])) //neznaev kako da proveram da ne e simbol, morav vaka :)


                        {
                            Array.Resize(ref listOfEmails, listOfEmails.Length + 1);
                            listOfEmails[listOfEmails.Length - 1] = username;
                            Console.WriteLine("Please enter a password:");

                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid username, please try again!");
                            break;
                        }




                        string password = Console.ReadLine();

                        var containsNumber = 0;
                        var containsUpper = 0;
                        var containsLower = 0;
                        var containsSymbols = 0;




                        if (password.Length >= 10 && !String.IsNullOrEmpty(password))
                        {
                            foreach (var character in password)
                            {
                                if (Char.IsNumber(character))
                                    containsNumber++;
                                if (Char.IsUpper(character))
                                    containsUpper++;
                                if (Char.IsLower(character))
                                    containsLower++;
                                if (Char.IsSymbol(character))
                                    containsSymbols++;

                            }
                        }
                        if (containsNumber > 0 && containsUpper > 0 && containsLower > 0 && containsSymbols > 1)
                        {
                            Array.Resize(ref listOfPasswords, listOfPasswords.Length + 1);
                            listOfPasswords[listOfPasswords.Length - 1] = password;
                            Console.WriteLine("You have successfully registered, please press Enter and then follow the instructon to LogIn.");


                        }

                        else
                        {
                            Console.WriteLine("You have entered an invalid password, please try again!");
                        }


                        break;








                    case "2":

                        Console.WriteLine("Please enter your username/email: ");
                        string userName = Console.ReadLine();
                        if (UserValidation(userName))
                        {
                            Console.WriteLine("Please enter your password: ");

                        }


                        break;




                    case "exit":


                        return;







                    default:
                        Console.WriteLine("Invalid choise. Pleaase try again!");
                        break;
                }


                Console.ReadLine();






            }










        }

        public static bool UserValidation(string username)
        {
            if (username.ToLower().Contains('@')
                            && username.ToLower().Contains('.')
                            && username.Length < 30
                            && !char.IsNumber(username[0])
                            && !char.IsNumber(username[username.Length - 1])
                            && char.IsLetterOrDigit(username[0])
                            && char.IsLetterOrDigit(username[username.Length - 1]))
            {
                return true;
            }
            Console.WriteLine("Your username is incorrect. Please try again.");
            return false;


        }
        public static bool PassValidation(string password)
        {
            var containsNumber = 0;
            var containsUpper = 0;
            var containsLower = 0;
            var containsSymbols = 0;

            if (password.Length >= 10 && !String.IsNullOrEmpty(password))
            {
                foreach (var character in password)
                {
                    if (Char.IsNumber(character))
                        containsNumber++;
                    if (Char.IsUpper(character))
                        containsUpper++;
                    if (Char.IsLower(character))
                        containsLower++;
                    if (Char.IsSymbol(character))
                        containsSymbols++;
                }
            }
            
            if (containsNumber > 0 && containsUpper > 0 && containsLower > 0 && containsSymbols > 1)
            {

                Console.WriteLine("You have successfully registered, please press Enter and then follow the instructon to LogIn.");

            }
            else
            {
                Console.WriteLine("You have entered an invalid password, please try again!");
            }





        }

    }

}



