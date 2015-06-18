/* 
Problem 1. Student class
Define a class `Student`, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e -mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by `System.Object`: `Equals()`, `ToString()`, `GetHashCode()` and operators `==` and `!=`. 
 
Problem 2. IClonable
Add implementations of the `ICloneable` interface. The `Clone()` method should deeply copy all object's fields into a new object of type `Student`.

Problem 3. IComparable
Implement the `IComparable<Student>` interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).
 */

namespace Student
{
    using System;

    public class TestStudent
    {
        public static void Main()
        {
            Student student = new Student("Ani", "Vasileva", "Rizova", "10025480", "Sofia", "0878251414", "ani.rizova@gmail.com", 2, Specialty.Physicist, University.TU, Faculty.Physics);
            Console.WriteLine(student.ToString());
            Console.WriteLine("Hash Code: {0}\n\n", student.GetHashCode());
            
            Student student2 = new Student("Ivan", "G", "Peshev", "20026591", "Kyustendil", "0888112233", "peshev@abv.bg", 3, Specialty.Economician, University.UNSS, Faculty.Economy);
            Console.WriteLine(student2.ToString());
            Console.WriteLine("Hash Code: {0}\n\n", student2.GetHashCode());


            Console.WriteLine("Is student1 == student2? -> {0}", student == student2);
            Console.WriteLine("Is student1 equal to student1? -> {0}", student.Equals(student));
            Console.WriteLine("Is student1 equal to student2? -> {0}", student.Equals(student2));
            Console.WriteLine("Is student1 != student2? -> {0}", student != student2);
        }
    }
}
