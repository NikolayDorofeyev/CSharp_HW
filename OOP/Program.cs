namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Dmutro", "Petrenko", 20, "Kyiv");

            student.DeleteCourse("Python");
            student.PrintInformation();
            student.AddCourse("C#");
            student.PrintInformation();
            student.AddCourse("Python");
            student.PrintInformation();
            student.DeleteCourse("C#");
            student.PrintInformation();
            student.DeleteCourse("Python");
            student.PrintInformation();

            var course = new Course("Python", "Olena", 20, 30);

            course.PrintInformation();
            course.AddStudent();
            course.PrintInformation();
        }
    }
}