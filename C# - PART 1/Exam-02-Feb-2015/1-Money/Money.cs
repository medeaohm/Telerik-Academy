using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Money
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal price = ((n * s) / 400) * p;
        Console.WriteLine("{0:F3}", price);
    }
}

