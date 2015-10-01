// Write a program, which (using `XmlReader` and `XmlWriter`) reads the file `catalog.xml` and creates the file 
// `album.xml`, in which stores in appropriate way the names of all albums and their authors.

namespace XMLparsers
{
    using System;
    using System.Xml.Linq;
    using System.IO;
    using System.Xml;
    using System.Text;

    class Albums
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../albums.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 2;

                writer.WriteStartDocument();
                writer.WriteStartElement("albums");

                using (XmlReader reader = XmlReader.Create("../../catalogue.xml"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            if (reader.Name == "name")
                            {
                                writer.WriteStartElement("album");
                                writer.WriteElementString("name", reader.ReadElementString());
                            }
                            else if (reader.Name == "artist")
                            {
                                writer.WriteElementString("artist", reader.ReadElementString());
                                writer.WriteEndElement();
                            }
                        }
                    }
                }

                writer.WriteEndDocument();
            }

            Console.WriteLine("albums saved as albums.xml");
        }
    }
}
