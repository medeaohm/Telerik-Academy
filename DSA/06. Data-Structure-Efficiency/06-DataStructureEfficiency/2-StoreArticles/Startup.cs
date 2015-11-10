// 2. A large trade company has millions of articles, each described by barcode, vendor, title and price.
//  * Implement a data structure to store them that allows fast retrieval of all articles in given price range[x…y].
//  * _Hint_: use `OrderedMultiDictionary<K, T>` from Wintellect's Power Collections for .NET.

namespace StoreArticles
{
    using System;
    using System.Collections.Generic;

    using Wintellect.PowerCollections;

    using RandomGenerator;
    using System.Diagnostics;

    public class Startup
    {
        /* Of course you can run the program with a larger number - I left 20 so that i can be easly visualized on the console*/
        private const int ArticlesCount = 1000000; 

        private const int BarcodeLength = 10;
        private const int MinArticlePrice = 1;
        private const int MaxArticlePrice = 15;

        private static readonly Stopwatch sw = new Stopwatch();

        public static void Main(string[] args)
        {
            var articles = GenerateArticles(ArticlesCount);
            Search(articles);
        }

        private static OrderedMultiDictionary<decimal, Article> GenerateArticles(int count)
        {
            var barcodes = new HashSet<string>();
            RandomGenerator randomGenerator = new RandomGenerator(); 

            Console.WriteLine("Generating {0} barcodes...", ArticlesCount);
            sw.Start();
            while (barcodes.Count < count)
            {
                var barcode = randomGenerator.GetRandomString(BarcodeLength);
                barcodes.Add(barcode);
            }
            sw.Stop();
            Console.WriteLine("Elapsed time: {0}", sw.Elapsed);
            Console.WriteLine();
            sw.Reset();

            Console.WriteLine("Generating {0} articles...", ArticlesCount);
            sw.Start();
            var articles = new OrderedMultiDictionary<decimal, Article>(true);
            foreach (var barcode in barcodes)
            {
                var title = randomGenerator.GetRandomString((int)randomGenerator.GetRandomNumber(5, 50));
                var vendor = randomGenerator.GetRandomString((int)randomGenerator.GetRandomNumber(5, 50));
                var price = randomGenerator.GetRandomNumber(MinArticlePrice, MaxArticlePrice);
                var article = new Article(title, vendor, price, barcode);
                articles.Add(price, article);
            }

            sw.Stop();
            Console.WriteLine("Elapsed time: {0}", sw.Elapsed);
            Console.WriteLine();
            sw.Reset();
            return articles;
        }

        private static void Search(OrderedMultiDictionary<decimal, Article> articles)
        {
            RandomGenerator randomGenerator = new RandomGenerator();
            string input = string.Empty;

            while (input != "exit")
            {
                sw.Start();
                var minRange = (int)randomGenerator.GetRandomNumber(MinArticlePrice, MaxArticlePrice-1);
                var maxRange = (int)randomGenerator.GetRandomNumber(minRange, MaxArticlePrice);

                Console.WriteLine("Searching for articles in the price range[{0}, {1}]", minRange, maxRange);

                var articlesFound = 0;
                articles
                    .Range(minRange, true, maxRange, true)
                    .ForEach(x =>
                        {
                            foreach (var article in x.Value)
                            {
                                //Console.WriteLine(article);
                                articlesFound++;
                            }
                        });

                Console.WriteLine("{0} articles found", articlesFound);
                sw.Stop();
                Console.WriteLine("Elapsed time: {0}", sw.Elapsed);
                Console.WriteLine();

                Console.WriteLine("\nPress Enter for another search or type 'exit' for close the program");
                input =  Console.ReadLine();
            }
        }
    }
}
