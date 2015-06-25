namespace Person
{
    public class Person
    {
        public enum Gender
        {
            male,
            female
        }

        public void CreatePerson(int years)
        {
            Person somePerson = new Person();
            somePerson.Age = years;
            if (years % 2 == 0)
            {
                somePerson.Name = "John";
                somePerson.Gender = Gender.male;
            }
            else
            {
                somePerson.Name = "Maria";
                somePerson.Gender = Gender.female;
            }
        }

        public class Person
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}