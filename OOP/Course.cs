using System;

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

        public void PrintInformation()
        {
            Console.WriteLine($"Course name: {CourseName}, Teacher name: {TeacherName}, Duration (days): {DurationInDays}, Number of students: {NumberOfStudents}");
        }

        public void AddStudent()
        {
            NumberOfStudents++;
        }
    }
}
