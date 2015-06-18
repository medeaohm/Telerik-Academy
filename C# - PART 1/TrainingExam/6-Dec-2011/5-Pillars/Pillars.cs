using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pillars
    {
        static void Main()
        {
            byte[] n = new byte[8];
            char[,] matrix = new char[8, 8];
            for (int i = 0; i < 8; i++)
            {
                n[i]= byte.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 8; i++)
            {
                char[] nc = Convert.ToString(n[i], 2).PadLeft(8,'0').ToCharArray();
                for (int j = 0; j < 8; j++)
                {
                    matrix[i, j] = nc[j];
                }                   
            }

            for (int h = 0; h < 8; h++)
            {
                int countLeft = 0;
                int countRight = 0;
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrix[j, i] == '1')
                        {
                            countLeft++;
                        } 
                    }
                   
                }
                for (int i = h + 1; i < 8; i++)
			    {
                    for (int j = 0; j < 8; j++)
                    {
                        if (matrix[j, i] == '1')
                        {
                            countRight++;
                        }
                    } 
                }
                if (countLeft == countRight)
                {
                    Console.WriteLine(7-h);
                    Console.WriteLine(countLeft);
                    break;
                }
                else if (countLeft != countRight & h == 7)
                {
                    Console.WriteLine("No");
                }
                else if (countLeft == countRight & countRight == 0 & h == 7)
                {
                    Console.WriteLine("7");
                    Console.WriteLine("0");
                }
            }
        }
    }

