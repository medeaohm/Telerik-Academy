//6.  In a text file we are given the name, address and phone number of given person (each at a single line).
//  * Write a program, which creates new XML document, which contains these data in structured XML format.

namespace XMLparsers
{
    public struct Person
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
