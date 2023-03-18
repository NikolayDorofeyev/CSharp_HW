﻿using System;

namespace OOP
{
    internal class Student
    {
        public Student(string firstName, string lastName, int age, string city )
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        private string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string City { get; }
        public string[] CoursesAttended;


        public void PrintInformation()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}, City: {City}");
            if (CoursesAttended == null || CoursesAttended.Length == 0)
            {
                Console.WriteLine("Courses attended: _ ");
            }
            else
            {
                Console.WriteLine("Courses attended: " + string.Join(", ", CoursesAttended));
            }
            Console.WriteLine();
        }

        public void AddCourse(string courseName)
        {
            if (CoursesAttended != null)
            {
                var isCourseExist = false;

                foreach (var i in CoursesAttended)
                {
                    if (i == courseName)
                    {
                        isCourseExist = true;
                    }
                }

                if (!isCourseExist)
                {
                    var newArray = new string[CoursesAttended.Length + 1];

                    for (var i = 0; i < CoursesAttended.Length; i++)
                    {
                        newArray[i] = CoursesAttended[i];
                    }

                    newArray[CoursesAttended.Length] = courseName;

                    CoursesAttended = newArray;
                }
            }
            else
            {
                CoursesAttended = new[] { courseName };
            }
        }

        
        public void DeleteCourse(string courseName)
        {
            if (CoursesAttended == null || CoursesAttended.Length ==0)
            {
                return;
            }
            else
            {
                var index = -1;

                for (var i = 0; i < CoursesAttended.Length; i++)
                {
                    if (CoursesAttended[i] == courseName)
                    {
                        index = i;
                        break;
                    }
                }

                if (index != -1)
                {
                    var newArray = new string[CoursesAttended.Length - 1];

                    for (var i = 0; i < index; i++)
                    {
                        newArray[i] = CoursesAttended[i];
                    }

                    for (var i = index + 1; i < CoursesAttended.Length; i++)
                    {
                        newArray[i - 1] = CoursesAttended[i];
                    }

                    CoursesAttended = newArray;
                }
            }
        }
    }
}
