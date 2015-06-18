namespace StudentsNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsTest
    {
        public static void Main()
        {
            var students = new List<Student>(); 

            students.Add(new Student("Pesho", "Ivanov", "aa1206", "078528907", "peshoivanov@abv.bg", 2, new List<int> 
            {  6, 4, 2, 3 }));

            students.Add(new Student("Ivan", "Peshev", "bb0305", "021236547", "puh4o@mail.bg", 3, new List<int> { 3, 5, 6, 5 }));

            students.Add(new Student("Irka", "Marinova", "ab0806", "06956871", "macka@gmail.com", 1, new List<int> { 6, 6, 6, 6 }));

            students.Add(new Student("Chef", "Manchev", "fr0100", "02551122", "ko6marivkuhnqta@abv.bg", 2, new List<int> { 2, 2, 3, 3 }));
            Console.WriteLine("All students:");
            Print(students);


            //problem 9
            // Select only the students from group 2 and order them by first name

            var studentsGroup2 =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;


            // problem 10: implement the same as above, using extension methods

            //var studentsGroup2 = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);

            Console.WriteLine("Students from group 2:");
            Print(studentsGroup2);


            // problem 11: extract all students w/ email in abv.bg using LINQ

            var studentABV =
                from student in students
                where student.Email.Contains("@abv.bg")
                select student;

            //var studentABV = students.Where(st => st.Email.Contains("@abv.bg"));
            Console.WriteLine("Students with email \"abv.bg\":");
            Print(studentABV);


            // problem 12: Extract all students w/ phones in Sofia, using LINQ

            var studentPhoneSf =
                from student in students
                where student.Telephone.StartsWith("02")
                select student;

            // var studentPhoneSf = students.Where(st => st.Telephone.StartsWith("02"));
            Console.WriteLine("Students with telephone from sofia:");
            Print(studentPhoneSf);



            // problem 13: Select all students that have at least one mark Excellent (6)
            // into a new anonymous class that has properties – FullName and Marks.

            var studentsWithExcellentMark =
                from student in students
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    MarksList = student.Marks
                };

            Console.WriteLine("Students that have at least one excellent mark, each in new anonymous class with " +
                              "properties Fullname and MarksList:\n");

            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }



            // problem 14: Write down a similar program that extracts the students with exactly two marks "2".

            var studentsWithTwoTwos = students.Where(x => x.Marks.FindAll(y => y == 2).Count == 2).
                Select(x => new
                {
                    FullName = x.FirstName + " " + x.LastName,
                    MarksList = x.Marks
                });

            Console.WriteLine("Students that have exactly two poor marks, each in new anonymous class with " +
                              "properties Fullname and MarksList:\n");

            foreach (var student in studentsWithTwoTwos)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
                Console.WriteLine();
            }


            // problem 15: Extract all Marks of the students that enrolled in 2006. 
            // (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

            var studentsFrom2006 = students.Where(x => x.FacultyNumber [4] == '0' && x.FacultyNumber[5] == '6');
            var allMarksFrom2006 = new List<int>();

            foreach (var student in studentsFrom2006)
            {
                allMarksFrom2006.AddRange(student.Marks);
            }

            Console.WriteLine("All marks of the students, enrolled in 2006:\n{0}", string.Join(", ", allMarksFrom2006));
            Console.WriteLine();

            //Problem 18. Create a program that extracts all students grouped by `GroupName` and then prints them to the console. Use LINQ.

            var groupedStudents =
                from student in students
                group student by student.GroupNumber
                into groups
                select new
                {
                    Group = groups.Key,
                    Students = groups.ToList()
                };

            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                    string.Join("\r\n\r\n", grouped.Students));
            }


            // Problem 19 - do the same using extension methods.

           // var groupedStudents2 = students.GroupBy(x => x.GroupNumber, (groupNum, stud) => new { Group = groupNum, Students = stud});

        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine();
            }
        }
    }
}
