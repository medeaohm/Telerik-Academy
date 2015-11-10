//6. (*) A text file `phones.txt` holds information about people, their town and phone number:

//    Mimi Shmatkata          | Plovdiv  | 0888 12 34 56
//    Kireto                  | Varna    | 052 23 45 67
//    Daniela Ivanova Petrova | Karnobat | 0899 999 888
//    Bat Gancho              | Sofia    | 02 946 946 946

//	Duplicates can occur in people names, towns and phone numbers.Write a program to read the phones file and execute a sequence of commands given in the file `commands.txt`:
//    * `find(name)` – display all matching records by given name(first, middle, last or nickname)
//    * `find(name, town)` – display all matching records by given name and town

namespace Phons
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var records = File.ReadLines("../../../TextFiles/phones.txt").ToList();

            var splittedRecords = ParseInput(records);

            Console.WriteLine("Find by name - searching 'Mimi':");
            Find(splittedRecords, "Mimi");
            Console.WriteLine();
            Console.WriteLine("Find by name and town - searching 'Daniela' and 'Karnobat':");
            Find(splittedRecords, "Daniela", "Karnobat");
            Console.WriteLine();
        }

        private static string[,] ParseInput(List<string> records)
        {
            string[,] splittedRecords = new string[3, records.Count()];

            for (int i = 0; i < records.Count() - 1; i++)
            {
                var currentRecord = records[i].Split('|');

                for (int j = 0; j < 3; j++)
                {
                    splittedRecords[i, j] = currentRecord[j].Trim();
                }
            }

            return splittedRecords;
        }

        private static void Find(string[,] records, string name)
        {
            for (int i = 0; i < records.GetLength(0); i++)
            {
                if (records[i,0].ToLower().Contains(name.ToLower()))
                {
                    Console.WriteLine("{0} - {1} - {2}", records[i,0], records[i,1], records[i,2]);
                }
            }
        }

        private static void Find(string[,] records, string name, string town)
        {
            for (int i = 0; i < records.GetLength(0); i++)
            {
                if (records[i, 0].ToLower().Contains(name.ToLower()) && records[i, 1].ToLower().Contains(town.ToLower()))
                {
                    Console.WriteLine("{0} - {1} - {2}", records[i, 0], records[i, 1], records[i, 2]);
                }
            }
        }
    }
}
