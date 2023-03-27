using System;
using OOP.Persons;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Dmutro", "Petrenko", 20, "Kyiv");
            
            student1.DeleteCourse("Python");
            student1.DescribeYourself();
            student1.AddCourse("C#");
            student1.DescribeYourself();
            student1.AddCourse("Python");
            student1.DescribeYourself();
            student1.DeleteCourse("C#");
            student1.DescribeYourself();
            student1.DeleteCourse("Python");
            student1.DescribeYourself();

            var course1 = new Course("Python", "Olena", 20, 30);
            
            course1.PrintInformation();
            course1.AddStudent();
            course1.PrintInformation();

            var teacher1 = new Teacher("Oleksandr", "Tkachuk", 30, "Zhytomyr");
            teacher1.DescribeYourself();


            // For Homework 7:

            teacher1.AddStudent(student1);
            teacher1.AddStudent(new Student("Oleg", "Melnyk", 21, "Lviv"));
            Console.WriteLine($"Students mumber: {teacher1.GetStudentsNumber()}");
            teacher1.PrintStudentsList();
            teacher1.DeleteStudent(student1);
            teacher1.PrintStudentsList();

            teacher1.AddCourse(course1);
            teacher1.PrintCourseList();
            Console.WriteLine($"Courses mumber: {teacher1.GetCoursesNumber()}");
            teacher1.DeleteCourse(course1);

            student1.AddCourse(course1);
            student1.PrintCourseList();
            student1.GetCoursesNumber();
            student1.DeleteCourse(course1);
            student1.PrintCourseList();

            course1.AddStudent(student1);
            course1.AddStudent(new Student("Oleg", "Melnyk", 21, "Lviv"));
            Console.WriteLine($"Students mumber: {teacher1.GetStudentsNumber()}");
            course1.PrintStudentsList();
            course1.DeleteStudent(student1);
            course1.PrintStudentsList();
        }
    }
}