using System;

//### Problem 15.* Bits Exchange
//*	Write a program that exchanges bits `3`, `4` and `5` with bits `24`, `25` and `26` of given 32-bit unsigned integer.

//_Examples:_

//|      n     |      binary representation of n     |            binary result            |   result   |
//|:----------:|:-----------------------------------:|:-----------------------------------:|:----------:|
//| 1140867093 | 01000100 00000000 01000000 00010101 | 01000010 00000000 01000000 00100101 | 1107312677 |
//| 255406592  | 00001111 00111001 00110010 00000000 | 00001000 00111001 00110010 00111000 | 137966136  |
//| 4294901775 | 11111111 11111111 00000000 00001111 | 11111001 11111111 00000000 00111111 | 4194238527 |
//| 5351       | 00000000 00000000 00010100 11100111 | 00000100 00000000 00010100 11000111 | 67114183   |
//| 2369124121 | 10001101 00110101 11110111 00011001 | 10001011 00110101 11110111 00101001 | 2335569705 |

class BitsExchange
    {
        static void Main()
        {
            uint val = 2369124121; 
            string bVal = Convert.ToString(val, 2).PadLeft(32, '0');

            // snag the values from 3,4,5 (small) and 24,25,26 (large)
            uint small = val & (7 << 3), large = val & (7 << 24);

            // remove the old values, and add in the new ones
            uint res = (val ^ (small | large)) | (large >> 21) | (small << 21);
            string bRes = Convert.ToString(res, 2).PadLeft(32, '0');

            Console.WriteLine("{0} --> {1}", val, res);
            Console.WriteLine("{0} --> {1}", bVal, bRes);
        }
    }

