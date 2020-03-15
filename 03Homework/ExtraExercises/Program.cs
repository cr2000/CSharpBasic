using System;

namespace ExtraExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            int[] naturalNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int sum = 0;
            foreach (var item in naturalNumbers)
            {
                sum += item;             
            }
            Console.WriteLine("The sum of the first ten natural numbers is: " + sum);
            Console.ReadLine();
            
            #endregion


        }
    }
}
