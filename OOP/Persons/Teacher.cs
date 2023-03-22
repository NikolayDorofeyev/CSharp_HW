using System;

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

        private string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string City { get; }

        public override void DescribeYourself()
        {
            Console.WriteLine("I am a teacher");
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}, City: {City}");
            Console.WriteLine();
        }
    }
}
