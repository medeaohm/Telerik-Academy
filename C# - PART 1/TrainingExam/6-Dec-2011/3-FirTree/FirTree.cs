//Christmas Eve is coming so even programmers got to prepare!
//In the spirit of the event your task is to write a program that prints a fir tree to the console.
//The format of the tree is shown in the examples bellow.
//Input
//The input data should be read from the console.
//On the only input line you have an integer number N, showing the height of the tree.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output data should be printed on the console.
//You must print the fir tree on the console. Each row contains only characters "." (point)  or "*" (asterisk).
//The first row should have exactly one "*" in the middle (that is the top of the tree) and each of the next lines two more.
//The last line should have exactly one asterisk in the middle, showing the stem of the tree.
//Constraints
//•	The number N is a positive integer between 4 and 100, inclusive.
//•	Allowed working time for your program: 0.25 seconds.
//•	Allowed memory: 16 MB.
//Examples
//Input example	Output example
//5	...*...
//    ..***..
//    .*****.
//    *******
//    ...*...


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int col = (2 * (n - 1)) - 1;
            int a = (col /2) +1;
            int b = (col / 2) - 1;
            string dot = ".";
            string star = "*";

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("");
                a--;
                b++;
                for (int j = 0; j < col; j++)
                {
                    
                    if (j < a | j > b)
                    {
                        Console.Write(dot);
                    }
                    else
                    {
                        Console.Write(star);
                    }
                }
            }
            for (int i = n; i < n+1; i++)
            {
                Console.WriteLine("");
             
                for (int j = 0; j < col; j++)
                {

                    if (j < col/2  | j > col/2)
                    {
                        Console.Write(dot);
                    }
                    else
                    {
                        Console.Write(star);
                    }
                }
            }
        }
    }

