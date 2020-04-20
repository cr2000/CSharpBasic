using System;
using System.Collections.Generic;
using System.Text;

namespace task02.Entities
{
    public class Project
    {
        public void PassedTheAcademy(bool[] array)
        {
            int cnt = 0;
            foreach (var grade in array)

                if (grade == false)
                    cnt++;

            if (cnt > 2)
            {
                Console.WriteLine("You Fail Academy");
            }
            else
            {
                Console.WriteLine("You passed Academy");
            }
        }
    }
}
