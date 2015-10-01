//10.  Write a program, which extract from the file `catalog.xml` the prices for all albums, published 5 years ago or earlier.
//  * Use XPath query.

namespace XMLparsers
{
    using System;
    using System.Xml;

    class ExtractPrices
    {
        static void Main(string[] args)
        {
            // initializing
            XmlDocument catalogue = new XmlDocument();

            catalogue.Load("../../catalogue.xml");
            XmlNodeList albums = catalogue.SelectNodes("catalogue/album");

            foreach (XmlNode album in albums)
            {
                var year = int.Parse(album.SelectSingleNode("year").InnerText);
                var yearNow = DateTime.Now.Year;
                var yearDiff = yearNow - year;
                if (yearDiff >= 5)
                {
                    var albumName = album.SelectSingleNode("name").InnerText;
                    var albumPrice = album.SelectSingleNode("price").InnerText;
                    Console.WriteLine("{0}: {1}$", albumName, albumPrice);
                }
            }
        }
    }
}
