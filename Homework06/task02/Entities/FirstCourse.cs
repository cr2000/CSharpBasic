using System;
using System.Collections.Generic;
using System.Text;
using task02.Enums;

namespace task02.Entities
{
    public class FirstCourse
    {
        public FirstCourse(string courseName, Grades grade)
        {
            CourseName = courseName;
            Grade = grade;
        }

       

        public string CourseName;
        public Grades Grade;
      

        public bool hasPassed()
        {
            if (Grade == Grades.grade5)
                return false;
            else
                return true;
        }

    }
}
