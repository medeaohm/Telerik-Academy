namespace SortingStudents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortStudent
    {
        public static void Main()
        {
            var students = new List<Student>()
            {
                new Student("pesho","peshev",21),
                new Student("maria","petkova",34),
                new Student("pesho","stoqnov",54),
                new Student("sonq","kolqnova",23),
                new Student("polq","pesheva",12),
                new Student("pesho","petrov",20),
                new Student("ivan","toshev",43),
                new Student("gosho","peshev",33),
                new Student("dragan","kirov",18),
                new Student("maria","paraskeva",24),
            };

            Console.WriteLine("Students:\n");
            Print(students);
            Console.WriteLine();

            Console.WriteLine("Students with first name before last name");
            // first method
            var firstBeforeLast = students.Where(student => student.FirstName.CompareTo(student.LastName) < 0);
            Print(firstBeforeLast);
            Console.WriteLine();
            // second method
            var firstBeforeLastL =
            from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;
            Print(firstBeforeLastL);
            Console.WriteLine();

            Console.WriteLine("Students with age between 8 and 24:");
            // first method
            var ageRange = students.Where(student => (student.Age >= 18 && student.Age <= 24));
            Print(ageRange);
            Console.WriteLine();
            // second method
            var ageRangeL =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select st;
            Print(ageRangeL);
            Console.WriteLine();

            Console.WriteLine("Ordered students:");
            // first method
            var orderStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
            Print(orderStudents);
            Console.WriteLine();
            // second method
            var orderStudentsL =
                from st in students
                orderby st.FirstName descending,
                st.LastName descending
                select st;
            Print(orderStudentsL);
            Console.WriteLine();
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
