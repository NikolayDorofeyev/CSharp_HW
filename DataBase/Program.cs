using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SchoolContext>());

            using (var db = new SchoolContext())
            {
                var mathTeacher = new Teacher { Name = "John Doe" };
                var scienceTeacher = new Teacher { Name = "Jane Doe" };
                db.Teachers.AddRange(new List<Teacher> { mathTeacher, scienceTeacher });
                db.SaveChanges();

                var mathCourse = new Course { Name = "Math", Teacher = mathTeacher };
                var scienceCourse = new Course { Name = "Science", Teacher = scienceTeacher };
                db.Courses.AddRange(new List<Course> { mathCourse, scienceCourse });
                db.SaveChanges();

                var alice = new Student { Name = "Alice", Courses = new List<Course> { mathCourse, scienceCourse } };
                var bob = new Student { Name = "Bob", Courses = new List<Course> { scienceCourse } };
                var charlie = new Student { Name = "Charlie", Courses = new List<Course> { mathCourse } };
                db.Students.AddRange(new List<Student> { alice, bob, charlie });
                db.SaveChanges();
            }
        }
    }

    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>()
                .HasRequired<Teacher>(c => c.Teacher)
                .WithMany(t => t.Courses)
                .HasForeignKey<int>(c => c.TeacherID)
                .WillCascadeOnDelete(false);
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

    public class Teacher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }

    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TeacherID { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}