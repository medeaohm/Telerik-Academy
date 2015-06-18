using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Secrets
{
    static void Main()
    {
        string n = Console.ReadLine();
        BigInteger n1 = BigInteger.Parse(n);
        if (n1 < 0)
        {
            n1 = -n1;
        }
        string n2 = n1.ToString();
        char[] num = n2.Reverse().ToArray();
        int nL = n2.Length;
        double[] digits = new double[500];
        double odd = 0;
        double even = 0;
        for (int i = 0; i < nL; i++)
        {
            digits[i] = char.GetNumericValue(num[i]);
            if (i % 2 == 0)
            {
                odd += digits[i] * (i+1) * (i+1);
            }
            else
            {
                even += digits[i] * digits[i] * (i+1);
            }
        }
        double result = odd + even;
        Console.WriteLine(result);
        string resultCheck = result.ToString();
        int resultL = resultCheck.Length;
        char[] r = resultCheck.ToArray();
        if (int.Parse(Convert.ToString(r[resultL - 1])) != 0)
        {
            int res = (int)result % 26 + 1;
            int initial = res + 64;
            int final = 64 + (res + int.Parse((Convert.ToString(r[resultL - 1]))));
            int step = final - initial;
            int rim = 0;
            if (final < 90)
            {
                for (initial = res + 64; initial < final; initial++)
                {
                    char m = (char)initial;
                    Console.Write(m);
                }
            }
            if (final > 90)
            {
                for (initial = res + 64; initial <= 90; initial++)
                {
                    char m = (char)initial;
                    Console.Write(m);
                    rim = initial;
                }
                int other = final - 90;
                for (int i = 65; i < 64 + other; i++)
                {
                    char m = (char)i;
                    Console.Write(m);
                }
            }
        }
        else
        {
            Console.WriteLine("{0} has no secret alpha-sequence", n);
        }
    }
}

