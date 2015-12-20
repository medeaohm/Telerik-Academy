namespace ShortestPath
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        private static char[] path;

        private static SortedSet<string> results = new SortedSet<string>();

        public static void Find(int index)
        {
            if (index == path.Length)
            {
                results.Add(new string(path));
            }

            else if (path[index] != '*')
            {
                Find(index + 1);
            }

            else
            {
                path[index] = 'R';
                Find(index + 1);
                path[index] = 'L';
                Find(index + 1);
                path[index] = 'S';
                Find(index + 1);
                path[index] = '*';
            }
        }

        public static void Main()
        {
            path = Console.ReadLine().ToCharArray();
            var possiblePaths = new List<String>();

            Find(0);
            Console.WriteLine(results.Count);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
