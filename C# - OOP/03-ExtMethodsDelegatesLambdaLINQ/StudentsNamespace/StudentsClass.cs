namespace StudentsNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telephone;
        private string email;
        private int groupNumber;
        private List<int> marks;

        public Student (string firstName, string lastName, string facultyNumber, string telephone, string email, int groupNumber, List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName; 
            this.FacultyNumber = facultyNumber;
            this.Telephone = telephone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }
    
        public  string FirstName 
        {
            get { return this.firstName; }
            set { this.firstName = value; } 
        }

        public  string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        
        public  string FacultyNumber
        {
            get { return this.facultyNumber; }
            set { this.facultyNumber = value; }
        }
        
        public  string Telephone
        {
            get { return this.telephone; }
            set { this.telephone = value; }
        }
        
        public  string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        
        public  int GroupNumber
        {
            get { return this.groupNumber; }
            set { this.groupNumber = value; }
        }
        
        public  List<int> Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

        
        public override string ToString()
        {
            return string.Format("First name: {0}\nLast name: {1}\nFaculty number: {2}\n" +
                                 "Group number: {3}\nMarks: {4}\nPhone: {5}\nEmail: {6}",
                this.FirstName, this.lastName, this.facultyNumber, this.groupNumber,
                string.Join(", ", this.marks), this.telephone, this.email);
        }
    }
}
