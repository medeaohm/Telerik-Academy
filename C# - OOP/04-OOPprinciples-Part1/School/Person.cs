namespace School
{
    using System;
    using System.Collections.Generic;

    public abstract class Person : IComment
    {
        private string firstName;
        private string lastName;
        public string comment;

        public Person(string firstName, string lastNames)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Fist name cannot be blanck!");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
            }
        }

        public string Comment { get; set; }
    }
}
