using System;
using System.Collections.Generic;

namespace OOP.Persons
{
    internal abstract class PersonBase
    {
        private readonly List<Course> CoursesList = new List<Course>();

        public abstract void DescribeYourself();

        public void AddCourse(Course course)
        {
            CoursesList.Add(course);
            Console.WriteLine($"New '{course.CourseName}' course successfully added!");
        }

        public void DeleteCourse(Course course)
        {
            CoursesList.Remove(course);
            Console.WriteLine($"The '{course.CourseName}' course successfully removed!");
        }
        public int GetCoursesNumber()
        {
            return CoursesList.Count;
        }

        public void PrintCourseList()
        {
            if (CoursesList.Count > 0)
            {
                foreach (var course in CoursesList)
                {
                    Console.WriteLine($"Course name: {course.CourseName}, Teacher name: {course.TeacherName}, Duration: {course.DurationInDays}");
                }
            }
            else
            {
                Console.WriteLine("Courses list is empty.");
            }
        }
    }
}
