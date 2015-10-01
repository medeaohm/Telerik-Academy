// Write a program, which using XDocument and Linq extracts all song titles from `catalog.xml`.

namespace XMLparsers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Linq;
    using System.Linq;

    public class AllSongs
    {
        public static void Main(string[] args)
        {
            var doc = XDocument.Load("../../catalogue.xml");
            var albums = doc.Element("catalogue")
                .Elements("album");

            var titles = from title in albums.Descendants("title") select title.Value;

            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
        }
    }
}
