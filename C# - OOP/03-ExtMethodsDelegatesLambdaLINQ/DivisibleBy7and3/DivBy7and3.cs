namespace DivisibleBy7and3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DivBy7and3
    {
        public static void Main()
        {
            int[] arrayOfIntegers = new int[]
            {
                28,312,5,65,63,435,67,44,5462,34,36,78,6324,45687,21,
                8400,4,5,3,654,35,54,23,123,3,4366,7,210,12,21,70,78,
                564,840,5,454
            };

            Console.WriteLine("Original array:");
            Print(arrayOfIntegers);
            Console.WriteLine("\n");

            Console.WriteLine("First method:");
            // first method
            var divBy7and3 = arrayOfIntegers.Where(number => number % 3 == 0 || number % 7 == 0);
            Print(divBy7and3);
            Console.WriteLine();
            Console.WriteLine("Second method:");
            // second method
            var divBy7and3L =
            from n in arrayOfIntegers
            where n % 3 == 0 || n % 7 == 0
            select n;
            Print(divBy7and3L);
            Console.WriteLine();
        }

        static void Print(IEnumerable<int> collection)
        {
            foreach (var item in collection)
            {
                Console.Write(item + " ");
            }
        }
    }
}
