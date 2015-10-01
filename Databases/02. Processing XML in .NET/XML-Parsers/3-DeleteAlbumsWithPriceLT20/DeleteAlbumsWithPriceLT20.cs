// Using the DOM parser write a program to delete from `catalog.xml` all albums having price > 20.

namespace XMLparsers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class DeleteAlbumsWithPriceLT20
    {
        static void Main(string[] args)
        {
            var catalogue = new XmlDocument();
            catalogue.Load("../../catalogue.xml");
            var root = catalogue.DocumentElement;

            DeleteAlbumsWithPrice(root, 20.0);
            catalogue.Save("../../updatedCatalogue.xml");
            Console.WriteLine("new catalogue saved as updatedCatalogue.xml");
        }

        private static void DeleteAlbumsWithPrice(XmlElement root, double maxPrice)
        {
            foreach (XmlElement album in root.ChildNodes)
            {
                var xmlPrice = album["price"].InnerText;
                var price = double.Parse(xmlPrice);

                if (price > maxPrice)
                {
                    root.RemoveChild(album);
                }
            }
        }
    }
}
