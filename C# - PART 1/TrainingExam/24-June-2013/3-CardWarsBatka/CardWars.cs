using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class CardWars
{
    static void Main()
    {
        int matchs = int.Parse(Console.ReadLine());
        BigInteger score1 = 0;
        BigInteger score2 = 0;
        BigInteger score1f = 0;
        BigInteger score2f = 0;
        int games1 = 0;
        int games2 = 0;
        bool x1 = false;
        bool x2 = false;
        for (int i = 0; i < matchs; i++)
        {
            for (int j = 0; j < 2; j++)
			{
			     if (j == 0)
	             {
                     score1 = 0;
                     x1 = false;
                    for (int k = 0; k < 3; k++)
                     {
                      
                        string card1 = Console.ReadLine();
                        switch (card1)
                        {
                            case "2": score1 = score1 + 10; break;
                            case "3": score1 = score1 + 9; break;
                            case "4": score1 = score1 + 8; break;
                            case "5": score1 = score1 + 7; break;
                            case "6": score1 = score1 + 6; break;
                            case "7": score1 = score1 + 5; break;
                            case "8": score1 = score1 + 4; break;
                            case "9": score1 = score1 + 3; break;
                            case "10":score1 = score1 + 2; break;
                            case "J": score1 = score1 + 11; break;
                            case "Q": score1 = score1 + 12; break;
                            case "K": score1 = score1 + 13; break;
                            case "A": score1 = score1 + 1; break;
                            case "Z": score1f = score1f * 2; break;
                            case "Y": score1f = score1f - 200; break;
                            case "X": x1 = true; break;
                    default:
                        break;
                        }
	                 }
			    }
                 if (j == 1)
                 {
                     score2 = 0;
                     x2 = false;
                     for (int k = 0; k < 3; k++)
                     {
                         // score2 = score2 + score2;
                         string card2 = Console.ReadLine();
                         switch (card2)
                         {
                             case "2": score2 = score2 + 10; break;
                             case "3": score2 = score2 + 9; break;
                             case "4": score2 = score2 + 8; break;
                             case "5": score2 = score2 + 7; break;
                             case "6": score2 = score2 + 6; break;
                             case "7": score2 = score2 + 5; break;
                             case "8": score2 = score2 + 4; break;
                             case "9": score2 = score2 + 3; break;
                             case "10": score2= score2 + 2; break;
                             case "J": score2 = score2 + 11; break;
                             case "Q": score2 = score2 + 12; break;
                             case "K": score2 = score2 + 13; break;
                             case "A": score2 = score2 + 1; break;
                             case "Z": score2f = score2f * 2; break;
                             case "Y": score2f = score2f - 200; break;
                             case "X": x2 = true; break;
                             default:
                                 break;
                         }
                     }
                 }
            }
            if (x1 & !x2)
            {
                break;
            }
            else if (x2 & !x1)
            {
                break;
            }
            else if (x1 & x2)
            {
                if (score1 == score2)
                {
                    score1f = score1f + 50;
                    score2f = score2f + 50;
                }
                else if (score1 > score2)
                {
                    score1f = score1 + score1f + 50;
                    score2f = score2f + 50;
                    games1++;
                }
                else if (score1 < score2)
                {
                    score1f = score1f + 50;
                    score2f = score2 + score2f + 50;
                    games2++;
                }
            }
            else if (score1 > score2)
	        {
		         games1++;
                 score1f = score1f + score1;
                 score2 = score2f;
	        }
            else if (score1 < score2)
	        {
		        games2++;
                score2f = score2f + score2;
                score1 = score1f;
            }
           
        }   
        if (x1 & !x2)
        {
            Console.WriteLine("X card drawn! Player one wins the match!"); 
        }
        else if (x2 & !x1)
        {
            Console.WriteLine("X card drawn! Player two wins the match!");
        }
        else
        {
            if (score1f > score2f)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: {0}", score1f);
                Console.WriteLine("Games won: {0}", games1);
            }
            else if (score2f > score1f)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: {0}", score2f);
                Console.WriteLine("Games won: {0}", games2);
            }
            else if (score1f == score2f)
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: {0}", score1f);
            }
        }
    }
}

