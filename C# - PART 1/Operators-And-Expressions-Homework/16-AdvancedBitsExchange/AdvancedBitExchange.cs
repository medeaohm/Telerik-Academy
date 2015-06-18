using System;

//### Problem 16.** Bit Exchange (Advanced)
//*	Write a program that exchanges bits `{p, p+1, …, p+k-1}` with bits `{q, q+1, …, q+k-1}` of a given 32-bit unsigned integer.
//*	The first and the second sequence of bits may not overlap.

//_Examples:_

//              |   p  |  q  | k  |      binary representation of n     | binary result                       | result       |
//|:-----------:|:----:|:---:|:--:|:-----------------------------------:|-------------------------------------|--------------|
//| 1140867093  | 3    | 24  | 3  | 01000100 00000000 01000000 00010101 | 01000010 00000000 01000000 00100101 | 1107312677   |
//| 4294901775  | 24   | 3   | 3  | 11111111 11111111 00000000 00001111 | 11111001 11111111 00000000 00111111 | 4194238527   |
//| 2369124121  | 2    | 22  | 10 | 10001101 00110101 11110111 00011001 | 01110001 10110101 11111000 11010001 | 1907751121   |
//| 987654321   | 2    | 8   | 11 | -                                   | -                                   | overlapping  |
//| 123456789   | 26   | 0   | 7  | -                                   | -                                   | out of range |
//| 33333333333 | -1   | 0   | 33 | -                                   | -                                   | out of range |

class AdvancedBitExchange
{
    static void Main()
    {

        long number = 1140867093;
        int p = 3;
        int q = 24;
        int k = 3;

        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("Out of range");
        }

        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            int counter = q;
            for (int i = p; i <= p + k - 1; i++)
            {
                long mask = 1;
                long firstBits = ((mask << i) & number) >> i;//Get bit p
                long secondBits = ((mask << counter) & number) >> counter;//Get bit q
                number = number & ~(mask << i);//Convert bit p to 0
                number = number & ~(mask << counter);//Convert bit q to 0
                number = number | (secondBits << i);//Replace bit p with q
                number = number | (firstBits << counter);//Replace bit q with p
                counter++;
            }

            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}

