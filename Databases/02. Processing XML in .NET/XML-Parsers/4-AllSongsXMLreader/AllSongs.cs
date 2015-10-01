// Write a program, which using `XmlReader` extracts all song titles from `catalog.xml`.

namespace XMLparsers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class AllSongs
    {
        public static void Main(string[] args)
        {
            using (XmlReader reader = new XmlTextReader("../../catalogue.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}
