using System;

namespace OOP.Persons
{
    internal class Student : PersonBase
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            try
            {
                if (age < 18)
                {
                    throw new StudentException($"Age should not be less than 18 years.");
                }

                FirstName = firstName;
                LastName = lastName;
                City = city;
                Age = age;
            }
            catch (StudentException e)
            {
                Console.WriteLine(e);
            }
        }
        public Student(string firstName, string lastName, int age) : this(firstName, lastName, age, "Kyiv")
        {
        }
        public Student(string firstName, string lastName) : this(firstName, lastName, 18, "Kyiv")
        {
        }
        public Student(string firstName) : this(firstName, "Default Last Name", 18, "Kyiv")
        {
        }
        
        public int Id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public string City { get; }
        //private string[] CoursesAttended;

        //public List<Course> CoursesList = new List<Course>();


        //public void PrintInformation()
        //{
        //    Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}, City: {City}");
        //    if (CoursesAttended == null || CoursesAttended.Length == 0)
        //    {
        //        Console.WriteLine("Courses attended: _ ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Courses attended: " + string.Join(", ", CoursesAttended));
        //    }
        //    Console.WriteLine();
        //}

        //public void AddCourse(string courseName)
        //{
        //    if (CoursesAttended != null)
        //    {
        //        var isCourseExist = false;

        //        foreach (var i in CoursesAttended)
        //        {
        //            if (i == courseName)
        //            {
        //                isCourseExist = true;
        //            }
        //        }

        //        if (!isCourseExist)
        //        {
        //            var newArray = new string[CoursesAttended.Length + 1];

        //            for (var i = 0; i < CoursesAttended.Length; i++)
        //            {
        //                newArray[i] = CoursesAttended[i];
        //            }

        //            newArray[CoursesAttended.Length] = courseName;

        //            CoursesAttended = newArray;
        //        }
        //    }
        //    else
        //    {
        //        CoursesAttended = new[] { courseName };
        //    }
        //}
        
        //public void DeleteCourse(string courseName)
        //{
        //    if (CoursesAttended == null || CoursesAttended.Length == 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        var index = -1;

        //        for (var i = 0; i < CoursesAttended.Length; i++)
        //        {
        //            if (CoursesAttended[i] == courseName)
        //            {
        //                index = i;
        //                break;
        //            }
        //        }

        //        if (index != -1)
        //        {
        //            var newArray = new string[CoursesAttended.Length - 1];

        //            for (var i = 0; i < index; i++)
        //            {
        //                newArray[i] = CoursesAttended[i];
        //            }

        //            for (var i = index + 1; i < CoursesAttended.Length; i++)
        //            {
        //                newArray[i - 1] = CoursesAttended[i];
        //            }

        //            CoursesAttended = newArray;
        //        }
        //    }
        //}

        public override void DescribeYourself()
        {
            Console.WriteLine($"First name: {FirstName}, Last name: {LastName}, Age: {Age}, City: {City}");
        }

        //public void AddCourse(Course course)
        //{
        //    CoursesList.Add(course);
        //    Console.WriteLine($"New '{course.CourseName}' course successfully added");
        //}
        //public void DeleteCourse(Course course)
        //{
        //    CoursesList.Remove(course);
        //    Console.WriteLine($"The '{course.CourseName}' course successfully removed");
        //}

        //public int GetCoursesNumber()
        //{
        //    return CoursesList.Count;
        //}
    }
}
