namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void StudentShouldNotThrowException()
        {
            var student = new Student("Gosho Petrov", 10000);
        }

        [TestMethod]
        public void StudentShouldReturnExpecedName()
        {
            var student = new Student("Gosho Petrov", 10000);
            Assert.AreEqual(student.Name, "Gosho Petrov");
        }

        [TestMethod]
        public void StudentShouldReturnExpecedUniqueNumber()
        {
            var student = new Student("Gosho Petrov", 10000);
            Assert.AreEqual(student.UniqueNumber, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenNameIsNull()
        {
            var student = new Student(null, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenNameIsEmpty()
        {
            var student = new Student(string.Empty, 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowExceptionWhenUniqueNumberIsLessThenMinimum()
        {
            var student = new Student("Gosho Petrov", 9999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentShouldThrowExceptionWhenUniqueNumberIsMoreThenMaximum()
        {
            var student = new Student("Gosho Petrov", 100000);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenAttendingCourse()
        {
            var student = new Student("Gosho Petrov", 10000);
            var course = new Course("JavaScript");
            student.AttendCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenAttendingCourseWithValueNull()
        {
            var student = new Student("Gosho Petrov", 10000);
            var course = new Course(null);
            student.AttendCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenAttendingCourseWithEmptyValue()
        {
            var student = new Student("Gosho Petrov", 10000);
            var course = new Course(string.Empty);
            student.AttendCourse(course);
        }

        [TestMethod]
        public void StudentShouldNotThrowExceptionWhenLeavesCourse()
        {
            var student = new Student("Gosho Petrov", 10000);
            var course = new Course("JavaScript");
            student.AttendCourse(course);
            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenLeavesCourseWithValueNull()
        {
            var student = new Student("Gosho Petrov", 10000);
            var course = new Course(null);
            student.LeaveCourse(course);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentShouldThrowExceptionWhenLeavesCourseWithEmptyValue()
        {
            var student = new Student("Gosho Petrov", 10000);
            var course = new Course(string.Empty);
            student.LeaveCourse(course);
        }
    }
}
