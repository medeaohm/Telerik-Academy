//### Problem 4.	Print a Deck of 52 Cards
//*	Write a program that generates and prints all possible cards from a [standard deck of 52 cards](http://en.wikipedia.org/wiki/Standard_52-card_deck) (without the jokers).
//    The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//    *	The card faces should start from 2 to A.
//    *	Print each card face in its four possible suits: clubs, diamonds, hearts and spades.
//    Use 2 nested for-loops and a switch-case statement.
	
//_output_

//    2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//    3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//    …  
//    K of spades, K of clubs, K of hearts, K of diamonds
//    A of spades, A of clubs, A of hearts, A of diamonds

//_Note: You may use the suit symbols instead of text._

using System;


class Cards
    {
        static void Main()
        {
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    switch (i)
                    {
                        case 2: Console.Write("Two of ");       break;
                        case 3: Console.Write("Tree of ");      break;
                        case 4: Console.Write("Four of ");      break;
                        case 5: Console.Write("Five of ");      break;
                        case 6: Console.Write("Six of ");       break;
                        case 7: Console.Write("Seven of ");     break;
                        case 8: Console.Write("Eight of ");     break;
                        case 9: Console.Write("Nine of ");      break;
                        case 10: Console.Write("Ten of ");      break;
                        case 11: Console.Write("Jack of ");     break;
                        case 12: Console.Write("Queen of ");    break;
                        case 13: Console.Write("King of ");     break;
                        case 14: Console.Write("Ace of ");      break;
                        default: Console.WriteLine("Error !");  break;
                    }
                    switch (j)
                    {
                        case 1: Console.WriteLine("Spades");    break;
                        case 2: Console.WriteLine("Hearts");    break;
                        case 3: Console.WriteLine("Diamonds");  break;
                        case 4: Console.WriteLine("Clubs");     break;
                        default: Console.WriteLine("Error !");  break;
                    }
                }
            }
        }
    }

