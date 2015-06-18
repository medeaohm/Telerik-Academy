using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SingingCats
{
    static void Main()
    {
        string inputCats = Console.ReadLine();
        string[] inputCatsS = inputCats.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int catsNum = int.Parse(inputCatsS[0]);

        string inputSongs = Console.ReadLine();
        string[] inputSongsS = inputSongs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int songsNum = int.Parse(inputSongsS[0]);

        int[,] catXsong = new int[songsNum, catsNum];

        
        while (true)
        {
            string input = Console.ReadLine();
            if (input != "Mew!")
            {
                string[] inputS = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int cats = int.Parse(inputS[1]);
                int song = int.Parse(inputS[4]);
                catXsong[song - 1, cats - 1] += 1; 
            }
            else
            {
                break;
            }
        }

        //for (int i = 0; i < songsNum; i++)
        //{
        //    for (int j = 0; j < catsNum; j++)
        //    {
        //        Console.Write(catXsong[i, j]);
        //        Console.Write(" ");
        //    }
        //    Console.WriteLine("\n");
        //}

        int minNumberOfSongs = 0;
        var songs = new List<int>();
        bool[,] s = new bool[catsNum, songsNum];
        for (int i = 0; i < songsNum; i++)
        {
            minNumberOfSongs = 0;
            for (int j = 0; j < catsNum; j++)
            {
                var currentRow = new List<int>();
                if (catXsong[i,j] != 0)
	{
		 currentRow.Add(catXsong[i,j]);
                    
	}
                
            }
            if (minNumberOfSongs == 0)
	        {
                break;
	        }
            else
            {
                songs.Add(minNumberOfSongs);
                
            }
        }
        if (minNumberOfSongs == 0)
        {
            Console.WriteLine("No concert!"); 
        }
        else
        {
            Console.WriteLine(songs.Min());
        }
    }
}
