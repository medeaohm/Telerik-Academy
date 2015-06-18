using System;

//### Problem 14.	Modify a Bit at Given Position
//*	We are given an integer number `n`, a bit value `v` (v=0 or 1) and a position `p`.
//*	Write a sequence of operators (a few lines of C# code) that modifies `n` to hold the value `v` at the position `p` from the binary representation of `n` while preserving all other bits in `n`.

//_Examples:_

//|   n   | binary representation of n |  p  | v |   binary result   | result |
//|:-----:|:--------------------------:|:---:|:-:|:-----------------:|--------|
//| 5     | 00000000 00000101          | 2   | 0 | 00000000 00000001 | 1      |
//| 0     | 00000000 00000000          | 9   | 1 | 00000010 00000000 | 512    |
//| 15    | 00000000 00001111          | 1   | 1 | 00000000 00001111 | 15     |
//| 5343  | 00010100 11011111          | 7   | 0 | 00010100 01011111 | 5215   |
//| 62241 | 11110011 00100001          | 11  | 0 | 11110011 00100001 | 62241  |

class ModifyBit
    {
        static void Main()
        {
            int n = 15;
            int p = 1;
            int v = 1;
            int mask = (1 << p);
            int nMask;

            if (v==0)
            {
                nMask = n & ~mask; 
            }
            else
            {
                nMask = n | mask;
            }
            string binary_n = Convert.ToString(n, 2).PadLeft(16, '0');
            string binary_nMask = Convert.ToString(nMask, 2).PadLeft(16, '0');
            
            Console.WriteLine("{0} --> Binary representation --> {1} \nBit at p = {2} -->  with value {3}", n, binary_n, p, v);
            Console.WriteLine("Binary Result --> {0} --> Result = {1}", binary_nMask, nMask);
        }
    }

