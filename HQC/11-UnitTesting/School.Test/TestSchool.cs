namespace Student_and_courses.Test
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void SchoolShouldNotThrowException()
        {
            var school = new School("Teleril Academy");
        }

        [TestMethod]
        public void SchoolShouldReturnSameName()
        {
            var school = new School("Teleril Academy");
            Assert.AreEqual(school.Name, "Teleril Academy");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsNull()
        {
            var school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenNameIsNullEmpty()
        {
            var school = new School(string.Empty);
        }

        [TestMethod]
        public void SchoolShouldAddStudent()
        {
            var school = new School("Teleril Academy");
            var student = new Student("Gosho Petrov", 10000);
            school.AddStudent(student);
            Assert.AreSame(school.Students.First(), student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenStudentIsNull()
        {
            var school = new School("Teleril Academy");
            Student student = null;
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionAddExistingStudent()
        {
            var school = new School("Teleril Academy");
            var student = new Student("Gosho Petrov", 10000);
            school.AddStudent(student);
            school.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SchoolShouldThrowExceptionAddStudentWithExistingUniqueNumber()
        {
            var school = new School("Teleril Academy");
            var firstStudent = new Student("Gosho Petrov", 10000);
            var secondStudent = new Student("Pesho Petrov", 10000);
            school.AddStudent(firstStudent);
            school.AddStudent(secondStudent);
        }

        [TestMethod]
        public void SchoolShouldRemoveStudent()
        {
            var school = new School("Teleril Academy");
            var student = new Student("Gosho Petrov", 10000);
            school.AddStudent(student);
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenStudentToRemoveIsNull()
        {
            var school = new School("Teleril Academy");
            Student student = null;
            school.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionRemoveUnexistingStudent()
        {
            var school = new School("Teleril Academy");
            var firstStudent = new Student("Gosho Petrov", 10000);
            var secondStudent = new Student("Pesho Petrov", 10000);
            school.AddStudent(firstStudent);
            school.RemoveStudent(secondStudent);
        }

        [TestMethod]
        public void SchoolShouldAddCourse()
        {
            var school = new School("Teleril Academy");
            var course = new Course("JavaScript");
            school.AddCourse(course);
            Assert.AreSame(school.Courses.First(), course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenCourseIsNull()
        {
            var school = new School("Teleril Academy");
            Course course = null;
            school.AddCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldThrowExceptionAddExistingCourse()
        {
            var school = new School("Teleril Academy");
            var course = new Course("JavaScript");
            school.AddCourse(course);
            school.AddCourse(course);
        }

        [TestMethod]
        public void SchoolShouldNotThrowExceptionAddTwoCourse()
        {
            var school = new School("Teleril Academy");
            var firstCourse = new Course("JavaScript");
            var SecondCourse = new Course("C#");
            school.AddCourse(firstCourse);
            school.AddCourse(SecondCourse);
        }

        [TestMethod]
        public void SchoolShouldRemoveCourse()
        {
            var school = new School("Teleril Academy");
            var course = new Course("JavaScript");
            school.AddCourse(course);
            school.RemoveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SchoolShouldThrowExceptionWhenRemovingCourseIsNull()
        {
            var school = new School("Teleril Academy");
            Course course = null;
            school.RemoveCourse(course);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void SchoolShouldNotThrowExceptionRemovingUnexistingCourse()
        {
            var school = new School("Teleril Academy");
            var firstCourse = new Course("JavaScript");
            var SecondCourse = new Course("C#");
            school.AddCourse(firstCourse);
            school.RemoveCourse(SecondCourse);
        }
    }
}