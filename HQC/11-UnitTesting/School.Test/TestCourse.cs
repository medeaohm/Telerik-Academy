namespace Student_and_courses.Test
{
    using System;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using School;

    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void CourseShouldNotThrowException()
        {
            var course = new Course("JavaScript");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWithNullValueName()
        {
            var course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseWithInvalidEmptyNameShouldThrowExcwption()
        {
            var course = new Course(string.Empty);
        }

        [TestMethod]
        public void CourseValidNameShouldBeReturn()
        {
            var course = new Course("JavaScript");
            Assert.AreEqual(course.Name, "JavaScript");
        }

        [TestMethod]
        public void CourseShouldAddStudentWithFirstNumber()
        {
            var course = new Course("JavaScript");
            var student = new Student("Gosho Petrov", 10000);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        public void CourseShouldAddStudentWithLastNumber()
        {
            var course = new Course("JavaScript");
            var student = new Student("Gosho Petrov", 99999);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.Last());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CourseShouldThrowExceptionWhenAddStudentWithInvalidNumber()
        {
            var course = new Course("JavaScript");
            var student = new Student("Gosho Petrov", 9999);
            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenAddStudentWithNullName()
        {
            var course = new Course("JavaScript");
            var student = new Student(null, 10000);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenAddStudentWithEmptyName()
        {
            var course = new Course("JavaScript");
            var student = new Student(string.Empty, 10000);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenExistingSutdentAdded()
        {
            var course = new Course("JavaScript");
            var student = new Student("Gosho Petrov", 10000);
            course.AddStudent(student);
            course.AddStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenCourseIsFull()
        {
            var course = new Course("JavaScript");
            var student = new Student("Gosho Petrov", 10000);

            for (int i = 0; i < 31; i++)
            {
                course.AddStudent(new Student(student.Name + i, student.UniqueNumber + i));
            }
        }

        [TestMethod]
        public void CourseShouldRemoveStudentWithFirstNumber()
        {
            var course = new Course("JavaScript");
            var student = new Student("Gosho Petrov", 10000);
            course.AddStudent(student);
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseShouldThrowExceptionWhenRemoveStudentWithValueNull()
        {
            var course = new Course("JavaScript");
            Student student = null;
            course.RemoveStudent(student);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CourseShouldThrowExceptionWhenRemoveUnexistingStudent()
        {
            var course = new Course("JavaScript");
            var student = new Student("Gosho Petrov", 10000);

            for (int i = 0; i < 30; i++)
            {
                course.AddStudent(new Student(student.Name + i, student.UniqueNumber + i));
            }

            course.RemoveStudent(student);
        }
    }
}
