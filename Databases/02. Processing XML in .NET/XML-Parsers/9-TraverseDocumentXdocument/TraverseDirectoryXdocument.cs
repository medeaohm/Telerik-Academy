//9.  Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files.
//  Use `XDocument`, `XElement` and `XAttribute`.

namespace XMLparsers
{
    using System;
    using System.Xml.Linq;
    using System.IO;

    class TraverseDocumentXdocument
    {
        static void Main()
        {
            var directory = Traverse(@"../../../");
            directory.Save("../../dir.xml");
            Console.WriteLine("result saved as dir.xml");
        }

        static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}
