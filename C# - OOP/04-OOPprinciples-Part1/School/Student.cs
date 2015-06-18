namespace School
{
    using System;

    public class Student : Person, IComment
    {
        private int ucn;
        string comment;

        public Student (string firstName, string lastName, int ucn):base(firstName, lastName)
        {
            this.UCN = ucn;
            this.Comment = comment;
        }

        public int UCN 
        {
            get { return this.ucn ;} 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The Unique class number cannot be <= 0");
                }
                this.ucn = value;
            }
        }
    }
}
