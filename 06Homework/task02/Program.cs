﻿using System;
using task02.Entities;
using task02.Enums;

//Task 2

//In this exercise you are asked to program three simple classes which keep track of the grading of a sample student.
//The classes are called FirstCourse, SecondCourse, and Project.

//A FirstCourse encapsulates a course name and a registration of passed/not passed for our sample student.

//A SecondCourse encapsulates a course name and the grade of the student. For grading we use the grades, 
//numerical grades 10, 9, 8, 7, 6, 5. You are also welcome use the enumeration.The grade 6 is the lowest passing grade.

//In both FirstCourse and SecondCourse you should write a method called Passed. The method is supposed to return whether our sample student
//passes the course.

//The class Project aggregates two FirstCourse courses and two SecondCourse courses.You can assume that a project is passed if 
//at least three out of the four courses are passed. Write a method Passed in class Project which implements this passing policy.

//In Main method initialize 2 FirstCourse objects, 2 SecondCourse objects and 1 Project object. Add both FirstCourse and both 
//SecondCourse objects like a properties to Project object. Call Project's object Passed method to see if the student passed.
namespace task02
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var firstCourse = new FirstCourse("JS", Grades.grade5);
            var secondCourse = new FirstCourse("Angular", Grades.grade7);
            var thirdCourse = new SecondCourse("C#", Grades.grade10);
            var fourthCourse = new SecondCourse("React", Grades.grade5);

            Project FirstProject = new Project();

            bool[] gradesToBool = { firstCourse.hasPassed(), secondCourse.hasPassed(), thirdCourse.hasPassed(), fourthCourse.hasPassed() };

            FirstProject.PassedTheAcademy(gradesToBool);      


            Console.ReadLine();
        }
    }
}
