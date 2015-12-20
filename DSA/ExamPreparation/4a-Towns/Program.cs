namespace Towns
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int numberOfTowns = int.Parse(Console.ReadLine());
            var citiziens = new int[numberOfTowns];
            for (int currentTown = 0; currentTown < numberOfTowns; currentTown++)
            {
                var line = Console.ReadLine();
                var lineParts = line.Split(' ');
                citiziens[currentTown] = int.Parse(lineParts[0]);
            }

            int bestPath = FindLongestPath(citiziens);
            Console.WriteLine(bestPath);
        }

        private static int FindLongestPath(int[] citiziens)
        {
            int numberOfTowns = citiziens.Length;

            var longestPathAscending = new int[numberOfTowns];
            for (int currentTown = 0; currentTown < numberOfTowns; currentTown++)
            {
                longestPathAscending[currentTown] = 1;

                for (int previousTown = 0; previousTown < currentTown; previousTown++)
                {
                    if (citiziens[previousTown] < citiziens[currentTown])
                    {
                        longestPathAscending[currentTown] = Math.Max(longestPathAscending[currentTown], longestPathAscending[previousTown] + 1);
                    }
                }
            }

            var longestPathDescending = new int[numberOfTowns];
            for (int currentTown = numberOfTowns - 1; currentTown >= 0; currentTown--)
            {
                longestPathDescending[currentTown] = 1;
                for (int previousTown = numberOfTowns - 1; previousTown > currentTown; previousTown--)
                {
                    if (citiziens[previousTown] < citiziens[currentTown])
                    {
                        longestPathDescending[currentTown] = Math.Max(longestPathDescending[currentTown], longestPathDescending[previousTown] + 1);
                    }
                }
            }

            var bestPath = 0;
            for (int currentTown = 0; currentTown < numberOfTowns; currentTown++)
            {
                var currentPath = longestPathAscending[currentTown] + longestPathDescending[currentTown] - 1;
                bestPath = Math.Max(bestPath, currentPath);
            }

            return bestPath;
        }
    }
}
