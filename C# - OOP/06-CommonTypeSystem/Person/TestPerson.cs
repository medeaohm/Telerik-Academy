/* Problem 4. Person class
Create a class `Person` with two fields – name and age. Age can be left unspecified (may contain `null` value. Override `ToString()` to display the information of a person and if age is not specified – to say so. Write a program to test this functionality. */

namespace Person
{
    using System;

    public class TestPerson
    {
        public static void Main()
        {
            Person first = new Person("Pesho", 25);
            Console.WriteLine(first.ToString());

            Person second = new Person("Gosho");
            Console.WriteLine(second.ToString());
        }
    }
}
