﻿using System;

namespace _05Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //            Task 1
            //* Print individual characters of the string in reverse order. *Example: we love c# *Expected Output : #c evol ew

            string reverseMe = "we love c#";
            char[] charReverseME = reverseMe.ToCharArray();
            Array.Reverse(charReverseME);
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

                Console.Write("Total number of words in the string is: {0}\n", wrd);
            }

            #endregion

            #region task3
            //            Task 3
            //* Find maximum occurring character in a string* Example: "We want this situation with covid-19 to ends!"
            //                * Expected Output: The highest frequency of character 't' appears number of times : 6


            #endregion



            Console.ReadLine();


        }

    }

}
