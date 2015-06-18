//### Problem 13.	Binary to Decimal Number
//*	Using loops write a program that converts a binary integer number to its decimal form.
//*	The input is entered as string. The output should be a variable of type long.
//*	Do not use the built-in .NET functionality.

//_Examples:_

//| binary                       | decimal   |
//|------------------------------|-----------|
//| 0                            | 0         |
//| 11                           | 3         |
//| 1010101010101011             | 43691     |
//| 1110000110000101100101000000 | 236476736 |

using System;
using System.Text;
using System.Linq;

class BinaryToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Please insert a binary number...");
            string binary =  Console.ReadLine();
            int binaryLength = binary.Length;
            int[] binaryArray = new int[binaryLength];
            
            double decimalNum = 0;

           
            for (int index = 0; index < binaryLength; index++)
			{
			    binaryArray[index] = int.Parse(binary.Substring(index, 1));
			}

            binaryArray = binaryArray.Reverse().ToArray();
            for (int index = 0; index < binaryLength; index++)
            {
                if (binaryArray[index] == 0 & index == 0 )
                {
                    decimalNum = 0;
                }
                else
                {
                    decimalNum += Math.Pow(2 * (binaryArray[index]), index);
                    //Console.WriteLine(binaryArray[index]);
                    //Console.WriteLine(index);
                } 
            }
            Console.WriteLine(decimalNum);
            //Console.WriteLine(Math.Pow(0,1));
        }
    }

