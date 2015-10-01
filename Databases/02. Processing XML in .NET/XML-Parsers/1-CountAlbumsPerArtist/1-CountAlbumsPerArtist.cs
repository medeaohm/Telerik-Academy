//  1.  Write program that extracts all different artists which are found in the `catalog.xml`.
//* For each author you should print the number of albums in the catalogue.
//* Use the DOM parser and a hash-table.

namespace XMLparsers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    public class CountAlbumsPerArtist
    {
        public static void Main()
        {
            // initializing
            XmlDocument catalogue = new XmlDocument();
            
            catalogue.Load("../../catalogue.xml");
            XmlNodeList artists = catalogue.SelectNodes("catalogue/album/artist");

            // all the artist
            Console.WriteLine("Artists: ");
            foreach (XmlNode artist in artists)
            {
                Console.WriteLine(" - " + artist.InnerText);
            }

            // artist and albums count
            var artistAndAlbums = CountAlbums(artists);

            Console.WriteLine("\nAlbums per artist:");
            foreach (var artistAlbumPair in artistAndAlbums)
            {
                Console.WriteLine("{0} - {1} album(s)", artistAlbumPair.Key, artistAlbumPair.Value);
            }
        }

        private static Dictionary<string, int> CountAlbums(XmlNodeList allArtist)
        {
            var artistsAlbumsCount = new Dictionary<string, int>();

            foreach (XmlNode artist in allArtist)
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
