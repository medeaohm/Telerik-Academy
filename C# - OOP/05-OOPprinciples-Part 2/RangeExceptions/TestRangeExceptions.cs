namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestRangeExceptions
    {
        public static void Main()
        {
            const int lowerNumber = 1;
            const int upperNumber = 100;

            DateTime lowerDate = new DateTime(1980, 1, 1);
            DateTime upperDate = new DateTime(2013, 12, 31);

            Console.Write("Please insert a number in range [1 ... 100] : ");
            int number = int.Parse(Console.ReadLine());
            if (number < lowerNumber || number > upperNumber)
            {
                throw new InvalidRangeException<int>("Number must be in the range [1 ... 100]");
            }


            Console.Write("Please insert a date in range [01.01.1980 ... 31.12.2013] : ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            if (date < lowerDate || date > upperDate)
            {
                throw new InvalidRangeException<int>("Date must be in the range [01.01.1980 ... 31.12.2013]");
            }

            Console.WriteLine("Done!");
        }
    }
}
