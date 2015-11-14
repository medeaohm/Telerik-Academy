namespace _02_ColouredRabbits
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Dictionary<int, int> rabbits = ReadInput();

            int result = CountMinNumberOfRabbits(rabbits);

            Console.WriteLine(result);
        }

        private static int CountMinNumberOfRabbits(Dictionary<int, int> rabbits)
        {
            int result = 0;

            foreach (var pair in rabbits)
            {
                if (pair.Value == 1)
                {
                    result += pair.Key;

                }
                else
                {
                    if (pair.Value % pair.Key == 0)
                    {
                        result += pair.Value;
                    }
                    else
                    {
                        result += (((pair.Value / pair.Key) + 1) * pair.Key);
                    }
                }
            }

            return result;
        }

        private static Dictionary<int, int> ReadInput()
        {
            Dictionary<int, int> rabbits = new Dictionary<int, int>();

            int numberOfAnswers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfAnswers; i++)
            {
                int current = int.Parse(Console.ReadLine()) + 1;

                if (rabbits.ContainsKey(current))
                {
                    rabbits[current] += 1;
                }

                else
                {
                    rabbits.Add(current, 1);
                }
            }

            return rabbits;
        }
    }
}
