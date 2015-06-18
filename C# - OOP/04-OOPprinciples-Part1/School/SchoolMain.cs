namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SchoolMain
    {
        static void Main()
        {
            School mySchool = new School("Telerik Academy");

            // Creating students
            Student[] studentsFirstGroup = new Student[]
            {
                new Student("Georgi",  "Yonchev", 2342032),
                new Student("Stamat", "Stamatov", 3023224),
            };

            Student[] studentsSecondGroup = new Student[]
            {
                new Student("Georgi", "Petrov", 1342032),
                new Student("Albena", "Kalinova", 2333224),
            };
            
            // Creating disciplines
            Disciplines cSharp = new Disciplines("C Sharp Fundamentals", 30, 30);
            Disciplines html = new Disciplines("HTML5", 12, 13);

            // Creating teachers
            Teacher teacher1 = new Teacher("Nikolay", "Kostov", new List<Disciplines> { cSharp, html});
            Teacher teacher2 = new Teacher("Ivaylo", "Kenov", new List<Disciplines> { cSharp, html });

            // Creating Group classes
            Clas firstGroupClass = new Clas("First Group-morning");
            Clas secondGroupClass = new Clas("Second Group-evening");

            firstGroupClass.AddTeacher(teacher1);
            secondGroupClass.AddTeacher(teacher2);

            firstGroupClass.AddStudent(studentsFirstGroup[0]);
            firstGroupClass.AddStudent(studentsFirstGroup[1]);
            secondGroupClass.AddStudent(studentsSecondGroup[0]);
            secondGroupClass.AddStudent(studentsSecondGroup[1]);

            mySchool.AddClasses(firstGroupClass);
            mySchool.AddClasses(secondGroupClass);
            Console.WriteLine(mySchool);
        }
    }
}
