namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade 
        {
            get { return grade; }
            set { grade = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1:F2}", base.ToString(), this.Grade);
        }
    }
}
