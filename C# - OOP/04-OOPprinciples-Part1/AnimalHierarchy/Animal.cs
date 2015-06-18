namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gen = gender;
            this.Type = AnimalType.Other;
        }


        public string Name 
        { 
            get { return this.name; }
            set { this.name = value; } 
        }

        public int Age
        {
            get { return this.age; }
            set 
            {
                if (this.age < 0)
                {
                    throw new ArgumentException("Age must be greaten than 0!");
                }
                this.age = value; 
            }
        }

        public Gender Gen 
        {
            get { return this.gender; }
            set { this.gender = value; } 
        }

        public AnimalType Type { get; set; }

        public virtual string MakeSound()
        {
            return "Zzz.";
        }

        public override string ToString()
        {
            return String.Format("{0} {1} - {2} - {3} years old - \"{4}\" ",
                this.Gen, this.Type, this.Name, this.Age, this.MakeSound());
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            return animals.Average(x => x.Age);
        }
    }
}
