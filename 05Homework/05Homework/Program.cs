using System;

namespace _05Homework
{
    #region task7
    //            Create a class Dog
    //Add properties: Name, race, color
    //The dog needs to have:
    //Eat method that returns message: The dog is now eating
    //Play method returning a message : The dog is now playing
    //ChaseTail method that returns a message: Dog is now chasing its tail.
    //The user needs to create the dog object by inputs and then given an option to choose one of the actions mentioned above.





    public class Dog
    {
        public string Name;
        public string Breed;
        public string Color;

        public void Eat()
        {
            Console.WriteLine($"Hello, I`m {Name}. I am now eating.");
        }
        public void Play()
        {
            Console.WriteLine($"Hello, My color is {Color}. I am now playing.");
        }
        public void ChaseTail()
        {
            Console.WriteLine($"Hello, I`m a {Breed}. I am now happy.");
        }
    }

    #endregion

    #region task8

    //    Create a class Human
    //Add properties: FirstName, LastName, Age
    //Create a method called GetPersonStats that returns the full name of the human as well as their age
    //Create an object human by asking the user to fill the required information
    //Call the GetPersonStats method and print the result in the console after the object is created

    public class Human
    {
        public string FirstName;
        public string LastName;
        public string Age;

        public void GetPersonStats()
        {
            Console.WriteLine($"\b\bI am {FirstName} {LastName} and I am {Age} years old.");
        }
    }


    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            #region task7

            Dog firstDog = new Dog();
            firstDog.Name = "Jack";
            firstDog.Color = "blue";
            firstDog.Breed = "Border Collie";
            firstDog.Eat();
            firstDog.Play();
            firstDog.ChaseTail();

            #endregion



            #region taksk8

            Human firstHuman = new Human();
            Console.WriteLine("Please enter your first name:");
            firstHuman.FirstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name:");
            firstHuman.LastName = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            firstHuman.Age = Console.ReadLine();

            firstHuman.GetPersonStats();


            #endregion





            #region task1
            ////            Task 1
            ////* Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew

            string reverseMe = "we love c#";
            char[] charReverseME = reverseMe.ToCharArray();
            Array.Reverse(charReverseME);
            Console.WriteLine("\b\b\b\b\b");
            Console.WriteLine(new string(charReverseME));

            #endregion

            #region task2

            //            Task 2
            //* Count the total number of words in a string entered by the user.

            //* Example: user enters "I love C#" * Expected output: "I love c#" contains 3 words.

            int i = 0;
            int wrd = 1;
            string howManyWords = "We love C#!";
            /* loop till end of string */
            if (howManyWords.Length == 0)
            {
                Console.WriteLine("The string is empty");
            }
            else
            {
                while (i <= howManyWords.Length - 1)
                {
                    /* check whether the current character is white space or new line or tab character*/
                    if (howManyWords[i] == ' ' || howManyWords[i] == '\n' || howManyWords[i] == '\t')
                    {
                        wrd++;
                    }

                    i++;
                }

                Console.Write("\nTotal number of words in the string is: {0}\n", wrd);
            }

            #endregion

            #region task3

            //            Task 3 
            //* Find maximum occurring character in a string* Example: "We want this situation with covid-19 to ends!"
            //  


            string covid19 = "aWe waaaaaaaaant this situa tion with ccccccccccccccccccccccccovid-19 to ends!";


            char[] covid19toChar = covid19.ToCharArray();

            int[] times = new int[covid19toChar.Length];




            for (int ii = 0; ii < covid19toChar.Length; ii++)
            {
                int time = 0;
                for (int j = ii; j < covid19toChar.Length; j++)
                {
                    if (covid19toChar[ii] == covid19toChar[j] && Char.IsLetterOrDigit(covid19toChar[ii]))
                    {
                        time++;
                    }

                }
                times[ii] = time;
            }

            int max = 0;
            int maxTimes = 0;

            for (int ii = 0; ii < times.Length; ii++)
            {
                if (times[ii] > maxTimes)
                {
                    max = Array.IndexOf(times, times[ii]);
                    maxTimes = times[ii];

                }


            }

            Console.WriteLine($"\n\nThe caracter: {covid19toChar[max]} repeats: {maxTimes} times");

            #endregion

            #region task4


            //            Task 4
            //"The whole group of G1 loves C#, we are sure that with their dedication and passion they will be successfull programers soon!"

            //* Print the whole text after "," in the console. *Bonus - Try to do that without counting the characters till "," by yourself :)


            string statement1 = "The whole group of G1 loves C#, we are sure that with their dedication and passion they will be successfull programers soon!";

            string shortenedStatement = statement1.Substring(32);
            Console.WriteLine("\nNew statement: " + shortenedStatement);

            //string academySubjectsAgaing = "HTML, CSS, Java Script, C#";
            //string[] subjects = academySubjectsAgaing.Split(", ");
            //foreach (var subject in subjects)
            //{
            //    Console.WriteLine(subject);
            //}



            string[] newstatement = statement1.Split(", ");
            Console.WriteLine("\nWithout counting ourselves: " + newstatement[1]);


            #endregion
            #region task5

            //            *Display the Day properties(year, month, day, hour, minute, second) from the today's date. *Expected Output : *year = 2020
            //* month = 3
            //* day = 26
            //* hour = 23
            //* minute = 12
            //* second = 22



            //string date2 = "05.15.1989";
            //string date3 = "15/05/1989 03:05:12";
            //string date4 = "03-26-2020";
            //string date5 = "mar.26.2020";

            //Console.WriteLine("DATE TIME CONVERSION:");
            //DateTime conversionDate3 = DateTime.Parse(date3);
            //Console.WriteLine(conversionDate3);


            var today = DateTime.Now;
            Console.WriteLine(today);
            //today
            int day = today.Day;
            int month = today.Month;
            int year = today.Year;
            int hour = today.Hour;
            int minute = today.Minute;
            int second = today.Second;
            Console.WriteLine($"Today is:   Day: {day}, Month: {month}, Year: {year}, and the time at the moment is: Hour:{hour}, Min:{minute}, Sec: {second}");

            #endregion


            #region task6


            //*Find the leap years between 2008 and 2020. * Expected output: *2008 is a leap year. * 2012 is a leap year. * 2016 is a leap year. * 2020 is a leap year.  
            //* Hint - make some researches of DateTime methods, you will find interesting ones that might help you;)


            int difference = year - 20;
            Console.WriteLine("The difference is: " + difference);

            Console.WriteLine("\n\nThe leap year in the last 30 years have been: ");
            for (int we = year - 30; we <= year; we++)
            {
                if (we % 4 == 0)
                {
                    Console.WriteLine(we);


                }
            }

            #endregion

            Console.ReadLine();





















        }

    }
}