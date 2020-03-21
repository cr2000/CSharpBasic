using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            int[] naturalNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach (var item in naturalNumbers)
            {
                sum += item;
            }
            Console.WriteLine("\b\b***TASK 01***");
            Console.WriteLine("The sum of the first ten natural numbers is: " + sum);
            Console.WriteLine("\n\nInitializing task2... please press Enter!");
            Console.ReadLine();

            #endregion





            #region task2
            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.

            int i, n, sumFromInput = 0;
            double avg;

            Console.Write("\n\n");
            Console.Write("Please enter ten numbers!\n");
            Console.Write("\n\n");

            Console.Write("Input the 10 numbers : \n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sumFromInput += n;
            }
            avg = sumFromInput / 10.0;

            Console.WriteLine("\b\b***TASK 02***");
            Console.Write("The sum of the 10 numbers you entered is : {0}\nThe Average is : {1}\n", sumFromInput, avg);
            Console.WriteLine("\n\nInitializing task3... please press Enter!");
            Console.ReadLine();


            #endregion






            #region task3

            //         3.Declare and init array of 10 integers by your choise. 
            //          Find maximum and minimum element in that array and their indexes.

            int[] maxAndMinArray = new int[] { 551, 2, 3557, 4, 577, 6, 7, -8, 9, 10 };
            int iit, mx, mn;
            int nt = maxAndMinArray.Length;

            mx = maxAndMinArray[0];
            mn = maxAndMinArray[0];


            for (iit = 1; iit < nt; iit++)
            {
                if (maxAndMinArray[iit] > mx)
                {
                    mx = maxAndMinArray[iit];
                }


                if (maxAndMinArray[iit] < mn)
                {
                    mn = maxAndMinArray[iit];
                }
            }


            int maxIndex = Array.IndexOf(maxAndMinArray, mx);
            int minIndex = Array.IndexOf(maxAndMinArray, mn);
            Console.WriteLine("\b\b***TASK 03***");
            Console.Write("Maximum element is: " + mx + " and it is on an index numbered: " + maxIndex);
            Console.Write("\n\nMinimum element is: " + mn + " and it is on an index numbered: " + minIndex);
            Console.WriteLine("\n\nInitializing task4... please press Enter!");
            Console.ReadLine();

            #endregion

            #region task4

            //         arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            //         Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            int[] duplicates = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };

            int[] arr2 = new int[100];
            int[] arr3 = new int[100];
            int[] arr4 = new int[100];
            int mm = 1, ctr = 0;
            int s1 = duplicates.Length;
            int it, j;


            //counting how many numbers are duplicate
            for (it = 0; it < s1; it++)
            {
                arr2[it] = duplicates[it];
                arr3[it] = 0;
            }



            for (i = 0; i < s1; i++)
            {
                for (j = 0; j < s1; j++)
                {
                    if (duplicates[i] == arr2[j])
                    {
                        arr3[j] = mm;
                        mm++;

                    }
                }
                mm = 1;
            }




            for (i = 0; i < s1; i++)
            {
                if (arr3[i] == 2) { ctr++; }
            }



            //printing the numbers that are duplicate

            Console.WriteLine("\b\b***TASK 04***");
            Console.WriteLine("The numbers that are duplicates are: ");
            for (i = 0; i < s1; i++)
            {
                for (j = i + 1; j < s1; j++)
                {
                    if (duplicates[i] == arr2[j])
                    {
                        arr4[i] = duplicates[i];
                        //Console.Write(i < s1 ? $" { duplicates[i] } , " : $" { duplicates[i] } .");
                        Console.WriteLine(arr4[i]);

                    }


                }

            }


            //printing how many numbers are duplicate
            Console.Write("\n\nThe number of duplicate elements is: {0} ", ctr);





            Console.Write("\n\n");
            Console.WriteLine("\n\nInitializing task5... please press Enter!");
            Console.ReadLine();

            #endregion

            #region task5
            //         oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //         Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays


            int[] oddEvenArray = new int[] { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };

            //Console.WriteLine("List of odd numbers: ");
            //for (i = 0; i < oddEvenArray.Length; i++)
            //{
            //    if (oddEvenArray[i] % 2 != 0)
            //        Console.Write(oddEvenArray[i] + " ");

            //}

            //Console.WriteLine("\n\nList of even numbers: ");
            //for (i = 0; i < oddEvenArray.Length; i++)
            //{
            //    if (oddEvenArray[i] % 2 == 0)
            //    {
            //        Console.Write((oddEvenArray[i]) + " ");

            //    }

            //}
            //Console.WriteLine();






            //tuka nadolu probuvam da gji zachuvam vrednostite vo niza, ova nad nego kako nevazhecho go smetam.

            int[] odd = new int[100];
            int[] even = new int[100];
            for (i = 0; i < oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i] % 2 == 0)
                {
                    even[i] = oddEvenArray[i];

                }
                else
                {
                    odd[i] = oddEvenArray[i];

                }

            }

            //....ama koga gji printam na mestoto kade shto ne treba da ima broj mi se zachuvuva nula

            Console.WriteLine("\b\b***TASK 05***");
            Console.WriteLine("The even numbers are: ");
            for (i = 0; i < oddEvenArray.Length; i++)
            {

                Console.Write(even[i] + " ");

            }

            Console.WriteLine("\n\nThe odd numbers are: ");
            for (i = 0; i < oddEvenArray.Length; i++)
            {

                Console.Write(odd[i] + " ");

            }


            //Console.Write("The even numbers are: {0}\nThe odd numebrs are: {1}\n", even[i], odd[i]); 
            //vaka kako gorniov red izglea nemohze :D
            Console.WriteLine("\n\nInitializing task6... please press Enter!");
            Console.ReadLine();


            #endregion

            #region task6

            //         6.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //          the day with strings.Example: user enters 1, you should print Monday.


            int dayNumber;

            Console.Write("\n\n");
            Console.Write("Enter a number from 1 to 7:\n");
            Console.Write("\n\n");


            Console.Write("Input Day Number : ");
            dayNumber = Convert.ToInt32(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.Write("You have chosen Monday! \n");
                    break;
                case 2:
                    Console.Write("You have chosen Tuesday. \n");
                    break;
                case 3:
                    Console.Write("Welcome to Wednesday! \n");
                    break;
                case 4:
                    Console.Write("Oh it's Thursday \n");
                    break;
                case 5:
                    Console.Write("Finally Friday \n");
                    break;
                case 6:
                    Console.Write("Saturday \n");
                    break;
                case 7:
                    Console.Write("Sunday  \n");
                    break;
                default:
                    Console.Write("Invalid day number. \nPlease try again ....\n");
                    break;
            }
            Console.ReadLine();



            #endregion




            #region task7

            //userNames = ["user1", "user2", "user3"]
            //passwords = ["first", "second", "third"]
            //Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //Create a logic when user enters specific username to provide a correct password for that user, and when that
            //happens you should print on the screen "You are logged in successfully".
            //If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //repeat the proccess from begining while he / she doesn't input correct username and password.


            //Note: Every element in userNames corresponds with the element in passwords at same index.
            //Example: password for "user1" is "first", password for "user2" is "second", password for "user3" is "third".











            #endregion



        }



    }
}
