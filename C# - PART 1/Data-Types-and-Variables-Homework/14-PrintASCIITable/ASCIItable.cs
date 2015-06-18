using System;


//### Problem 14.*	Print the ASCII Table
//*	Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).

//_Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently._

//_Note: You may need to use for-loops (learn in Internet how)._

    class ASCIItable
    {
        static void Main()
        {
            for (int i = 0; i < 256; i++)
			{
                char ascii = (char)i;
                Console.WriteLine("{0} --> {1}", i, ascii);
                System.Threading.Thread.Sleep(50);
			}

        }
    }
