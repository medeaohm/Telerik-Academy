namespace School
{
    using System;
    using System.Collections.Generic;

    public class Clas : IComment
    {
        private string uniqueID;
        private List<Teacher> teachers;
        private List<Student> students;
        private string comment;

        public Clas(string uniqueID)
        {
            this.UniqueID = uniqueID;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();
        }

        public string UniqueID
        {
            get { return uniqueID; }
            set { uniqueID = value; }
        }

        public string Comment
        {
            get
            {
                if (String.IsNullOrWhiteSpace(this.comment))
                {
                    return "No comments yet!";
                }

                return this.comment;
            }
            set { this.comment = value; }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public List<Teacher> GetTeachers()
        {
            return new List<Teacher>(this.teachers);
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public List<Student> GetStudent()
        {
            return new List<Student>(this.students);
        }

        public override string ToString()
        {
            return this.uniqueID;
        }
    }
}
