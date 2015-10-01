//11.  Write a program, which extract from the file `catalog.xml` the prices for all albums, published 5 years ago or earlier.
//  * Use LINQ query.

namespace XMLparsers
{
    using System;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;

    class ExtractPrices
    {
        static void Main(string[] args)
        {
            var doc = XDocument.Load("../../catalogue.xml");

            var albumPrices = from album in doc.Descendants("album")
                         where int.Parse(album.Element("year").Value) <= DateTime.Now.Year - 5
                         select album.Element("price").Value;

            Console.WriteLine(string.Join(Environment.NewLine, albumPrices));          
        }
    }
}
