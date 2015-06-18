//Problem 4 - Kaspichania Boats
//The country of Kaspichania was once one of the greatest empires in the known universe. However after fierce battles with the neighboring countries of Javaland and CSharpia the armed forces of Kaspichania were dwindling. Then all of a sudden they decided they needed a change of strategy – they would start building a huge naval fleet. They hired boat architects and wood and material providers. But they needed a factory to manufacture them. This is where you come in.
//Your task is to create the boats needed by the country of Kaspichania to win their next battle. You will be given the size of the desired bottom (N) of the boat and your task is to build it. The entire width of the boat must be N * 2 + 1 and the height: 6 + ((N - 3) / 2) * 3. The boats have sails with a height 2/3 of the entire height of the boat. The base of the boat is the other 1/3 of the height. The boats also have a supporting beam that goes through the entire height of the boat.
//Input
//The input data should be read from the console.
//You have an integer number N - the size of the bottom of the boat.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//Use the “*” for the lines and “.” (dot) for the rest.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Boats
{
    static void Main()
    {
        int bottom = int.Parse(Console.ReadLine());
        int width = bottom * 2 + 1;
        int height = 6 + ((bottom - 3) / 2) * 3;
        int sails = 2 * width / 3;
        int baseB = width / 3;

        string dot = ".";
        string star = "*";
        int a = (width/2) + 1;
        int b = (width/2) - 1;
        int c = 0;
        int d = width-1;


        for (int j = 0; j < width / 2; j++)
        {
            a--;
            b++;
            Console.WriteLine("");
            for (int i = 0; i < width; i++)
            {
                if (i < a | i > b)
                {
                    Console.Write(dot);
                }
                else if (i == a | i == b | i == width / 2)
                {
                    Console.Write(star);
                }
                else
                {
                    Console.Write(dot);
                }
            }
        }

        for (int j = width / 2; j < height; j++)
        {
            Console.WriteLine("");
            if (j == width / 2)
            {
                for (int l = 0; l < width; l++)
                {
                    Console.Write(star);
                }
            }
            else if (j == height - 1)
            {
                for (int m = 0; m < width; m++)
                {
                    if (m <= bottom - bottom / 2 - 1 | m >= width - bottom + bottom / 2)
                    {
                        Console.Write(dot);
                    }
                    else
                    {
                        Console.Write(star);
                    }

                }
            }

            else
            {
                c++;
                d--;
                for (int k = 0; k < width; k++)
                {
                    if (k < c | k > d)
                    {
                        Console.Write(dot);
                    }
                    else if (k == c | k == d | k == width / 2)
                    {
                        Console.Write(star);
                    }
                    else
                    {
                        Console.Write(dot);
                    }
                }
            }
        }
    }
}



