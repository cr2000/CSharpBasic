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
            Console.WriteLine("The sum of the first ten natural numbers is: " + sum);
            Console.WriteLine("\n\nInitializing task2... please press Enter!");
            Console.ReadLine();

            #endregion

            #region task2
            //2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.

            //int i, n, sumFromInput = 0;
            //double avg;

            //Console.Write("\n\n");
            //Console.Write("Read 10 numbers and calculate sum and average:\n");
            //Console.Write("----------------------------------------------");
            //Console.Write("\n\n");

            //Console.Write("Input the 10 numbers : \n");
            //for (i = 1; i <= 10; i++)
            //{
            //    Console.Write("Number-{0} :", i);

            //    n = Convert.ToInt32(Console.ReadLine());
            //    sumFromInput += n;
            //}
            //avg = sumFromInput / 10.0;
            //Console.Write("The sum of the 10 numbers you entered is : {0}\nThe Average is : {1}\n", sumFromInput, avg);
            //Console.WriteLine("\n\nInitializing task3... please press Enter!");
            //Console.ReadLine();


            #endregion

            #region task3
            //         3.Declare and init array of 10 integers by your choise. 
            //          Find maximum and minimum element in that array and their indexes.

            //int[] maxAndMinArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int i, mx, mn;
            //int n = maxAndMinArray.Length;

            //mx = maxAndMinArray[0];
            //mn = maxAndMinArray[0];


            //for (i = 1; i < n; i++)
            //{
            //    if (maxAndMinArray[i] > mx)
            //    {
            //        mx = maxAndMinArray[i];
            //    }


            //    if (maxAndMinArray[i] < mn)
            //    {
            //        mn = maxAndMinArray[i];
            //    }
            //}


            //int maxIndex = Array.IndexOf(maxAndMinArray, mx);
            //int minIndex = Array.IndexOf(maxAndMinArray, mn);
            //Console.Write("Maximum element is: " + mx + " and it is on an index numbered: " + maxIndex);
            //Console.Write("\n\nMinimum element is: " + mn + " and it is on an index numbered: " + minIndex);
            //Console.ReadLine();

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
            int i, j;


            //counting how many numbers are duplicate
            for (i = 0; i < s1; i++)
            {
                arr2[i] = duplicates[i];
                arr3[i] = 0;
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
            Console.ReadLine();

            #endregion
   
            #region task5
            //         oddEvenArray = [10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49]
            //         Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays







            #endregion

        }



    }
}





















