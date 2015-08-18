namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private const int MaxSudentsInCourse = 30;
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
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
                    throw new ArgumentNullException("Course name can't be empty");
                }

                this.name = value;
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
                throw new ArgumentNullException("Student can't be null");
            }

            if (this.Students.Count + 1 > Course.MaxSudentsInCourse)
            {
                throw new InvalidOperationException("Course is full");
            }

            if (this.students.Contains(student))
            {
                throw new InvalidOperationException("This student already has joined in the course");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (Validator.IsStudentValueNull(student))
            {
                throw new ArgumentNullException("Student can't be null");
            }

            if (!this.students.Contains(student))
            {
                throw new InvalidOperationException("This student doesn't attend in the course");
            }

            this.students.Remove(student);
        }
    }
}