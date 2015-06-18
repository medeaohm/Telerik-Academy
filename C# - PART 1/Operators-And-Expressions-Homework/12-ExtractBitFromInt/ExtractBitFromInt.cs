using System;

//### Problem 12.	Extract Bit from Integer
//*	Write an expression that extracts from given integer `n` the value of given bit at index `p`.

//_Examples:_

//|   n   | binary representation |  p  | bit @ p |
//|:-----:|:---------------------:|:---:|:-------:|
//| 5     | 00000000 00000101     | 2   | 1       |
//| 0     | 00000000 00000000     | 9   | 0       |
//| 15    | 00000000 00001111     | 1   | 1       |
//| 5343  | 00010100 11011111     | 7   | 1       |
//| 62241 | 11110011 00100001     | 11  | 0       |


class ExtractBitFromInt
    {
        static void Main()
        {
            int n = 62241;
            int p = 11;
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            string binary = Convert.ToString(n, 2).PadLeft(16, '0');
            Console.WriteLine("{0} --> Binary representation --> {1} --> Bit at p = {2} --> {3}", n, binary, p, bit);
        }
    }

