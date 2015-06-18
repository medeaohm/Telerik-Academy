//### Problem 11.	Random Numbers in Given Range
//*	Write a program that enters `3` integers `n`, `min` and `max` (`min = max`) and prints `n` random numbers in the range `[min...max]`.

//_Examples:_

//| n                 | min | max     |         random numbers        |
//|-------------------|-----|---------|-------------------------------|
//| 5                 | 0   | 1       | 1 0 0 1 1                     |
//| 10                | 10  | 15      | 12 14 12 15 10 12 14 13 13 11 |

//_Note: The above output is just an example. Due to randomness, your program most probably will produce different results._


using System;

class RandomNumbers
    {
        static void Main()
        {
            Console.Write("Please insert a positive integer number... n =");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please insert another positive integer number... min =");
            int min = int.Parse(Console.ReadLine());
            Console.Write("And another one (> max) ... max =");
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                int rand = rnd.Next(min, max+1); // creates a number between min and max
                Console.WriteLine(rand);
            }
        }
    }
