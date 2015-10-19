namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;
    using StudentSystem.Data;
    using StudentSystem.Models;
    using System.Collections.Generic;

    public class ConsoleClient
    {
        public static void PrintStudents(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.FirstName);
            }
        }

        public static void Main()
        {
            var db = new StudentSystemDbContext();

            var student = new Student()
            {
                FirstName = "Pesho",
                LastName = "Peshev",
            };

            db.Students.Add(student);
            db.SaveChanges();

            PrintStudents(db.Students);
            var savedStudent = db.Students.FirstOrDefault();
            db.Students.Remove(savedStudent);
            db.SaveChanges();
        }
    }
}
