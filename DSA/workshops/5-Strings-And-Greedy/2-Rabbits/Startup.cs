namespace Rabbits
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {

            var line = Console.ReadLine();
            var inputAnswers = line.Split(' ').Select(int.Parse).ToList();
            inputAnswers.RemoveAt(inputAnswers.Count - 1);

            var answer = MinNumberOfRabbits(inputAnswers);
            Console.WriteLine(answer);
        }

        private static int MinNumberOfRabbits(IEnumerable inputAnswers)
        {
            var groups = new Dictionary<int, int>();
            foreach (int answer in inputAnswers)
            {
                if (!groups.ContainsKey(answer + 1))
                {
                    groups.Add(answer + 1, 0);
                }

                groups[answer + 1]++;
            }

            var rabbits = 0;
            foreach (var group in groups)
            {
                var size = group.Key;
                var rabbitsInGroup = group.Value;
                var groupsCount = (int)Math.Ceiling(rabbitsInGroup / (double)size);
                rabbits += groupsCount * size;

            }

            return rabbits;
        }
    }
}
