using System;

//### Problem 13.	Check a Bit at Given Position
//*	Write a Boolean expression that returns if the bit at position `p` (counting from `0`, starting from the right) in given integer number `n`, has value of 1.

//_Examples:_

//|   n   | binary representation of n |  p  | bit @ p == 1 |
//|:-----:|:--------------------------:|:---:|:------------:|
//| 5     | 00000000 00000101          | 2   | true         |
//| 0     | 00000000 00000000          | 9   | false        |
//| 15    | 00000000 00001111          | 1   | true         |
//| 5343  | 00010100 11011111          | 7   | true         |
//| 62241 | 11110011 00100001          | 11  | false        |

class CheckBit
    {
        static void Main()
        {
            int n = 5;
            int p = 9;
            int mask = 1 << p;
            int nAndMask = n & mask;
            int bit = nAndMask >> p;
            string binary = Convert.ToString(n, 2).PadLeft(16, '0');
            bool one = (bit == 1);
            Console.WriteLine("{0} --> Binary representation --> {1} --> Bit at p = {2} --> {3}", n, binary, p, bit);
            Console.WriteLine("Is this bit = 1? --> {0}", one);

        }
    }

