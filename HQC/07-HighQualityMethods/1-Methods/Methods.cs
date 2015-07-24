namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalcTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("Triangle sides should be >= 0");
            }

            bool areSidesValid = firstSide + secondSide > thirdSide || firstSide + thirdSide > secondSide || secondSide + thirdSide > firstSide;
            if (!areSidesValid)
            {
                throw new ArgumentException("Triangle sides invalid");
            }

            double semiperimeter = (firstSide + secondSide + thirdSide) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - firstSide) * (semiperimeter - secondSide) * (semiperimeter - thirdSide));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            string numberAsString;
            switch (number)
            {
                case 0: 
                    numberAsString = "zero"; 
                    break;
                case 1: 
                    numberAsString = "one"; 
                    break;
                case 2: 
                    numberAsString = "two"; 
                    break;
                case 3: 
                    numberAsString = "three"; 
                    break;
                case 4: 
                    numberAsString = "four"; 
                    break;
                case 5: 
                    numberAsString = "five"; 
                    break;
                case 6: 
                    numberAsString = "six"; 
                    break;
                case 7: 
                    numberAsString = "seven"; 
                    break;
                case 8: 
                    numberAsString = "eight"; 
                    break;
                case 9: 
                    numberAsString = "nine"; 
                    break;
                default: 
                    numberAsString = "Invalid number!"; 
                    break;
            }

            return numberAsString;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new NullReferenceException();
            }

            int maxValue = elements[0];
            int currentElement;

            for (int i = 1; i < elements.Length; i++)
            {
                currentElement = elements[i];

                if (currentElement > maxValue)
                {
                    maxValue = currentElement;
                }
            }

            return maxValue;
        }

        public static void PrintAsNumber(double number, string format)
        {
            string formatInLowerCase = format.ToLower();

            switch (formatInLowerCase)
            {
                case "f":
                     Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default: Console.WriteLine("Invalid format. Please choose one from \"f\", \"%\" and \"r\"");
                    break;
            }
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
