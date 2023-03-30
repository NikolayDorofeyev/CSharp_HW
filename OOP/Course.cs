using System;
using System.Collections.Generic;
using OOP.Persons;

namespace OOP
{
    internal class Course
    {
        public Course(string courseName, Teacher teacher, int durationInDays)
        {
            CourseName = courseName;
            CourseTeacher = teacher;
            DurationInDays = durationInDays;
        }

        public string CourseName { get; }
        public Teacher CourseTeacher { get; }
        public int DurationInDays { get; }
        public readonly List<Student> StudentsList = new List<Student>();
        //public int NumberOfStudents { get; set; }

        public void PrintInformation()
        {
            Console.WriteLine($"Course name: '{CourseName}', Teacher name: '{CourseTeacher.FirstName} {CourseTeacher.FirstName}', Duration (days): {DurationInDays}");
            Console.WriteLine("Students list:");
            foreach (var student in StudentsList)
            {
                Console.WriteLine($"First Name: {student.FirstName}, Last Name: {student.LastName}, Age: {student.Age}, City: {student.City}");
            }
            Console.WriteLine();
        }

        public void AddStudent(Student student)
        {
            StudentsList.Add(student);
            Console.WriteLine($"New '{student.FirstName} {student.LastName}' student successfully added!");
        }

        public void DeleteStudent(Student student)
        {
            StudentsList.Remove(student);
            Console.WriteLine($"New '{student.FirstName} {student.LastName}' course successfully removed!");
        }

        public int GetStudentsNumber()
        {
            return StudentsList.Count;
        }

        public void PrintStudentsList()
        {
            foreach (var student in StudentsList)
            {
                Console.WriteLine($"First name: {student.FirstName}, Last name: {student.LastName}, Age: {student.Age}, City: {student.City}");
            }
        }
    }
}
