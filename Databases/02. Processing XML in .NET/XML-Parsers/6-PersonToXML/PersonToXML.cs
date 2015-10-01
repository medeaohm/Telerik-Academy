//6.  In a text file we are given the name, address and phone number of given person (each at a single line).
//  * Write a program, which creates new XML document, which contains these data in structured XML format.

namespace XMLparsers
{
    using System;
    using System.Xml.Linq;
    using System.IO;

    class PersonToXML
    {
        static void Main(string[] args)
        {
            var person = new Person();

            using (StreamReader reader = new StreamReader("../../person.txt"))
            {
                person.Name = reader.ReadLine();
                person.Phone = reader.ReadLine();
                person.Address = reader.ReadLine();
            }

            var personElement = new XElement("person",
                new XElement("name", person.Name),
                new XElement("phone", person.Phone),
                new XElement("address", person.Address));

            Console.WriteLine("person saved as person.xml");
            personElement.Save("../../person.xml");
        }
    }
}
