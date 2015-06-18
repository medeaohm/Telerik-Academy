using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Poker
{
    static void Main()
    {
        string[] cards = new string[5];
        //char[] cards = new char[5];
        bool equal = false;
        for (int i = 0; i < 5; i++)
        {
            cards[i] = (Console.ReadLine());
        
        }
        Array.Sort(cards);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(cards[i]);
        }

        if (cards[0] == cards[1] & cards[1] == cards[2] & cards[2] == cards[3] & cards[3] == cards[4])
        {
            Console.WriteLine("Impossible");
        }
        else if ((cards[0] == cards[1] & cards[1] == cards[2] & cards[2] == cards[3]) | (cards[0] == cards[1] & cards[1] == cards[2] & cards[2] == cards[4]) | (cards[0] == cards[1] & cards[1] == cards[3] & cards[3] == cards[4]) | (cards[0] == cards[4] & cards[4] == cards[2] & cards[2] == cards[3]) | (cards[4] == cards[1] & cards[1] == cards[2] & cards[2] == cards[3]))
        {
            Console.WriteLine("Four of a Kind");
        }
        else if ((cards[0] == cards [1] & cards[1] == cards[2] & cards[3]== cards[4])|(cards[4] == cards [1] & cards[1] == cards[2] & cards[3]==cards[0])|(cards[3] == cards [1] & cards[1] == cards[2] & cards[0]==cards[4])|(cards[2] == cards [3] & cards[3] == cards[4] & cards[0]==cards[1])|(cards[0] == cards [1] & cards[1] == cards[3] & cards[2]==cards[4])|(cards[0] == cards [1] & cards[1] == cards[4] & cards[3]==cards[2])|(cards[3] == cards [1] & cards[1] == cards[4] & cards[0]==cards[2]))
        {
            Console.WriteLine("Full House");
        }
        else if (cards[0] = "2" & cards[1] == "3" & cards[2] == "4" & cards[3] == "5" & cards[4] =="6")
        {
            // to be continued
        }
    }
}

