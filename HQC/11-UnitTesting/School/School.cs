namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class School
    {
        private ICollection<Course> courses;
        private ICollection<Student> students;
        private string name;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!Validator.IsValidName(value))
                {
                    throw new ArgumentNullException("School name can't be empty");
                }

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            if (Validator.IsStudentValueNull(student))
            {
                throw new ArgumentNullException("Student can't be empty");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student already has joined in the course");
            }

            if (this.students.Any(x => x.UniqueNumber == student.UniqueNumber))
            {
                throw new ArgumentException("This unique number is already used");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (Validator.IsStudentValueNull(student))
            {
                throw new ArgumentNullException("Student can't be empty");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("This student is not find");
            }

            this.students.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (Validator.IsCoureValueNull(course))
            {
                throw new ArgumentNullException("Course can't be empty");
            }

            if (this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course has been already added");
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (Validator.IsCoureValueNull(course))
            {
                throw new ArgumentNullException("Student can't be empty");
            }

            if (!this.courses.Contains(course))
            {
                throw new InvalidOperationException("This course is not find");
            }

            this.courses.Remove(course);
        }
    }
}