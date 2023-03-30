using System;
using System.Collections.Generic;
using System.Linq;
using OOP.Persons;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Dmutro", "Petrenko", 20, "Kyiv");
            var student2 = new Student("Oleg", "Melnyk", 21, "Lviv");
            var student3 = new Student("Vlad", "Kovtun", 25, "Zhytomyr");
            var student4 = new Student("Dmutro", "Kovalenko", 22, "Vinnytsia");
            var student5 = new Student("Dmutro", "Kovalenko", 10, "Vinnytsia"); // Test error handling (Age should not be less than 18 years)


            var teacher1 = new Teacher("Olena", "Tkachuk", 30, "Zhytomyr");
            var teacher2 = new Teacher("Taras", "Frolov", 30, "Kyiv");

            var course1 = new Course("Python", teacher1, 20);
            var course2 = new Course("C#", teacher2, 30);


            // For Homework 7:
            #region Homework_7
            /*
            course1.PrintInformation();
            course1.AddStudent();
            course1.PrintInformation();

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

            teacher1.AddStudent(student1);
            teacher1.AddStudent(new Student("Oleg", "Melnyk", 21, "Lviv"));
            Console.WriteLine($"Students number: {teacher1.GetStudentsNumber()}");
            teacher1.PrintStudentsList();
            teacher1.DeleteStudent(student1);
            teacher1.PrintStudentsList();

            teacher1.AddCourse(course1);
            teacher1.PrintCourseList();
            Console.WriteLine($"Courses number: {teacher1.GetCoursesNumber()}");
            teacher1.DeleteCourse(course1);
            teacher1.DescribeYourself();

            student1.AddCourse(course1);
            student1.PrintCourseList();
            student1.GetCoursesNumber();
            student1.DeleteCourse(course1);
            student1.PrintCourseList();

            course1.AddStudent(student1);
            course1.AddStudent(new Student("Oleg", "Melnyk", 21, "Lviv"));
            Console.WriteLine($"Students number: {teacher1.GetStudentsNumber()}");
            course1.PrintStudentsList();
            course1.DeleteStudent(student1);
            course1.PrintStudentsList();
            */
            #endregion


            // For Homework 8:
            student1.AddCourse(course1);
            student2.AddCourse(course1);
            student2.AddCourse(course2);
            var studentsList = new List<Student> { student1, student2 ,student3, student4};

            teacher1.AddCourse(course1);
            teacher2.AddCourse(course1);
            teacher2.AddCourse(course2);
            var teachersList = new List<Teacher> { teacher1, teacher2 };

            course1.AddStudent(student1);
            course1.AddStudent(student2);

            course2.AddStudent(student1);
            course2.AddStudent(student2);
            course2.AddStudent(student3);
            var coursesList = new List<Course> { course1, course2 };

            Console.WriteLine();

            // - displaying all students on the screen
            foreach (var student in studentsList)
            {
                student.DescribeYourself();
                student.PrintCourseList();
                Console.WriteLine();
            }

            // - displaying all teachers
            foreach (var teacher in teachersList)
            {
                teacher.DescribeYourself();
                teacher.PrintCourseList();
                Console.WriteLine();
            }

            // - displaying all courses
            foreach (var course in coursesList)
            {
                course.PrintInformation();
            }

            // - implement the ability to filter when linking students and a teacher by one field
            Console.WriteLine("Enter student's name:"); //e.g.: Dmutro
            var name = Console.ReadLine();
            foreach (var student in studentsList.Where(student => student.FirstName.Contains(name)))
            {
                student.DescribeYourself();
            }
        }
    }
}