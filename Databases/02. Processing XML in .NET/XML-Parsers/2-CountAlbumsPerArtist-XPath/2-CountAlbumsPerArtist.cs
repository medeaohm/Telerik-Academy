//  1.  Write program that extracts all different artists which are found in the `catalog.xml`.
//* For each author you should print the number of albums in the catalogue.
//* Use the XPath

namespace XMLparsers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class CountAlbumsPerArtist
    {
        public static void Main()
        {
            var catalogue = new XmlDocument();
            catalogue.Load("../../catalogue.xml");
            var root = catalogue.DocumentElement;

            foreach (var pair in CountAlbums(catalogue))
            {
                Console.WriteLine("{0} - {1} album(s)", pair.Key, pair.Value);
            }
        }

        private static Dictionary<string, int> CountAlbums(XmlDocument root)
        {
            var artistsAlbumsCount = new Dictionary<string, int>();
            var artists = root.SelectNodes("/catalogue/album/artist");

            foreach (XmlNode artist in artists)
            {
                var artistName = artist.InnerText;

                if (artistsAlbumsCount.ContainsKey(artistName))
                {
                    artistsAlbumsCount[artistName] += 1;
                }
                else
                {
                    artistsAlbumsCount.Add(artistName, 1);
                }
            }

            return artistsAlbumsCount;
        }
    }
}
