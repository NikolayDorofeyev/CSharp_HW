namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Dmutro", "Petrenko", 20, "Kyiv");

            student1.DeleteCourse("Python");
            student1.PrintInformation();
            student1.AddCourse("C#");
            student1.PrintInformation();
            student1.AddCourse("Python");
            student1.PrintInformation();
            student1.DeleteCourse("C#");
            student1.PrintInformation();
            student1.DeleteCourse("Python");
            student1.PrintInformation();

            var course1 = new Course("Python", "Olena", 20, 30);

            course1.PrintInformation();
            course1.AddStudent();
            course1.PrintInformation();
        }
    }
}