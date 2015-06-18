namespace Person
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age) : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be left blank");
                }
                this.name = value;
            } 
        }

        public int? Age 
        {
            get { return this.age; }
            set 
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("Invalid age");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", this.Name, this.Age == null ? "Unknow age" : this.Age.ToString());
        }
    }
}
