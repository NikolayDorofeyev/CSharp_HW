using System;
using System.Collections.Generic;

namespace OOP.Persons
{
    internal class Teacher : PersonBase
    {
        public Teacher(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string City { get; }
        private readonly List<Student> StudentsList = new List<Student>();

        public override void DescribeYourself()
        {
            Console.WriteLine("I am a teacher");
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}, City: {City}");
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
            Console.WriteLine($"The '{student.FirstName} {student.LastName}' student successfully removed!");
        }

        public int GetStudentsNumber()
        {
            return StudentsList.Count;
        }

        public void PrintStudentsList()
        {
            if (StudentsList.Count > 0)
            {
                foreach (var student in StudentsList)
                {
                    Console.WriteLine($"First name: {student.FirstName}, Last name: {student.LastName}, Age: {student.Age}, City: {student.City}");
                }
            }
            else
            {
                Console.WriteLine("Students list is empty.");
            }
        }
    }
}
