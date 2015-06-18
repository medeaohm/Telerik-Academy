using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Slides
{
    static void Main()
    {
        string dim = Console.ReadLine();
        string[] di = dim.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var dimension = new int[di.Length];
        for (int i = 0; i < di.Length; i++)
        {
            dimension[i] = int.Parse(di[i]);
        }

        int height = dimension[1];
        int weight = dimension[0];
        int depth = dimension[2];

        var cube = new string[weight, height, depth];

        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] lineS = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < weight; w++)
                {
                    string[] lineSS = line.Split(new char[] { '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                    cube[w,h,d] = lineSS[w];
                }
            }
        }

        string ballCoordinates = Console.ReadLine();
        string[] ballWD = ballCoordinates.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string result = string.Empty;

        int ballH = 0;
        int ballW = int.Parse(ballWD[0]);
        int ballD = int.Parse(ballWD[1]);

        while (true)
        {
            if ((ballW < 0 | ballW >= weight | ballD < 0 | ballD >= depth | ballH < 0))
            {
                result = "No";
                break;
            }
            else if (cube[ballH, ballW, ballD] == "B")
            {
                result = "No";
                break;
            }
            else if (ballH >= height - 1)
            {
                result = "Yes";
                break;
            }
            
            else if (cube[ballH,ballW, ballD].Length > 1)
            {
                string[] move = cube[ballH, ballW, ballD].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (move[0]== "S")
                {
                    ballH++;
                    switch (move[1])
                    {
                        case "R": ballW++; break;
                        case "L": ballW--; break;
                        case "F": ballD--; break;
                        case "B": ballD++; break;
                        case "FL": ballD--; ballW--; break;
                        case "FR": ballW++; ballD--; break;
                        case "BL": ballD++; ballW--; break;
                        case "BR": ballW++; ballD++; break;
                        default:
                            break;
                    }
   
                }
                else if (move[0] == "T")
                {
                    ballW = int.Parse(move[1]);
                    ballD = int.Parse(move[2]);
                    //ballH++;
                }
                if ((ballW < 0 | ballW >= weight | ballD < 0 | ballD >= depth | ballH < 0))
                {
                    result = "No";
                    break;
                }
                else if (cube[ballH, ballW, ballD] == "B")
                {
                    result = "No";
                    break;
                }
                else if (ballH >= height - 1)
                {
                    result = "Yes";
                    break;
                }
            }
            else if (cube[ballH,ballW, ballD] == "E")
            {
                if ((ballW < 0 | ballW >= weight | ballD < 0 | ballD >= depth | ballH < 0))
                {
                    result = "No";
                    break;
                }
                else if (cube[ballH, ballW, ballD] == "B")
                {
                    result = "No";
                    break;
                }
                else if (ballH >= height - 1)
                {
                    result = "Yes";
                    break;
                }
                ballH++;
            }
        }
        Console.WriteLine(result);
        Console.WriteLine("{0} {1} {2}", ballW, ballH, ballD - 1);
    }
}

