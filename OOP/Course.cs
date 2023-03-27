using System;
using System.Collections.Generic;
using OOP.Persons;

namespace OOP
{
    internal class Course
    {
        public Course(string courseName, string teacherName, int durationInDays, int numberOfStudents)
        {
            CourseName = courseName;
            TeacherName = teacherName;
            DurationInDays = durationInDays;
            NumberOfStudents = numberOfStudents;
        }
        public Course(string courseName, string teacherName, int durationInDays) : this(courseName, teacherName, durationInDays, 0)
        {
        }
        public Course(string courseName, string teacherName) : this(courseName, teacherName, 0, 0)
        {
        }
        public Course(string courseName) : this(courseName, "Default Teacher Name", 0, 0)
        {
        }
        public Course() : this("Default Course Name", "Default Teacher Name", 0, 0)
        {
        }

        public string CourseName { get; }
        public string TeacherName { get; }
        public int DurationInDays { get; }
        public int NumberOfStudents { get; set; }
        public readonly List<Student> StudentsList = new List<Student>();

        public void PrintInformation()
        {
            Console.WriteLine($"Course name: {CourseName}, Teacher name: {TeacherName}, Duration (days): {DurationInDays}, Number of students: {NumberOfStudents}");
        }

        public void AddStudent()
        {
            NumberOfStudents++;
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
