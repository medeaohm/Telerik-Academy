namespace JediMeditation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int numberOfJedies = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            var splittedInput = input.Split(' ');

            List<string> masters = new List<string>();
            List<string> knights = new List<string>();
            List<string> padawans = new List<string>();

            for (int i = 0; i < numberOfJedies; i++)
            {
                if (splittedInput[i].StartsWith("m"))
                {
                    masters.Add(splittedInput[i]);
                }
                else if (splittedInput[i].StartsWith("k"))
                {
                    knights.Add(splittedInput[i]);
                }
                else if (splittedInput[i].StartsWith("p"))
                {
                    padawans.Add(splittedInput[i]);
                }
            }

            for (int i = 0; i < masters.Count; i++)
            {
                splittedInput[i] = masters[i];
            }
            for (int i = masters.Count; i < knights.Count + masters.Count; i++)
            {
                splittedInput[i] = knights[i - masters.Count];
            }
            for (int i = knights.Count + masters.Count; i < numberOfJedies; i++)
            {
                splittedInput[i] = padawans[i - knights.Count - masters.Count];
            }

            Console.WriteLine(string.Join(" ", splittedInput));
        }
    }
}

/* Other implementations (not passing the time limit): */

//public static void Main()
//{
//    int numberOfJedies = int.Parse(Console.ReadLine());
//    string input = Console.ReadLine();

//    var splittedInput = input.Split(' ');

//    var masters = new StringBuilder();
//    var knights = new StringBuilder();
//    var padawans = new StringBuilder();

//    for (int i = 0; i < numberOfJedies; i++)
//    {
//        if (splittedInput[i].StartsWith("m"))
//        {
//            masters.Append(splittedInput[i]);
//            masters.Append(" ");
//        }
//        else if (splittedInput[i].StartsWith("k"))
//        {
//            knights.Append(splittedInput[i]);
//            knights.Append(" ");
//        }
//        else if (splittedInput[i].StartsWith("p"))
//        {
//            padawans.Append(splittedInput[i]);
//            padawans.Append(" ");
//        }
//    }

//    var output = new StringBuilder();
//    output.Append(masters);
//    output.Append(knights);
//    output.Append(padawans.ToString().TrimEnd());


//    Console.WriteLine(output.ToString());
//}


//public static void Main()
//{
//    int numberOfJedies = int.Parse(Console.ReadLine());
//    string input = Console.ReadLine();

//    //int numberOfJedies = 7;
//    //string input = "p4 p2 p3 m1 k2 p1 k1";

//    List<string> splittedInput = input.Split(' ').ToList();

//    var output = new Dictionary<string, int>();

//    for (int i = 0; i < numberOfJedies; i++)
//    {
//        if (splittedInput[i].ToLower().StartsWith("m"))
//        {
//            output.Add(splittedInput[i], 1);
//        }
//        else if (splittedInput[i].ToLower().StartsWith("k"))
//        {
//            output.Add(splittedInput[i], 2);
//        }
//        else if (splittedInput[i].ToLower().StartsWith("p"))
//        {
//            output.Add(splittedInput[i], 3);
//        }
//    }

//    var dict = output.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

//    Console.WriteLine(string.Join(" ", dict.Keys));
//}

//public static void Main()
//{
//    int numberOfJedies = int.Parse(Console.ReadLine());
//    string input = Console.ReadLine();

//    int numberOfJedies = 7;
//    string input = "p4 p2 p3 m1 k2 p1 k1";

//    List<string> splittedInput = input.Split(' ').ToList();

//    var output = splittedInput
//                        .OrderBy(i => i.ToLower().StartsWith("p"))
//                        .ThenBy(i => i.ToLower().StartsWith("k"))
//                        .ThenBy(i => i.ToLower().StartsWith("m"))
//                        .ToList();

//    Console.WriteLine(string.Join(" ", output));
//}

//public static void Main()
//{
//    int numberOfJedies = int.Parse(Console.ReadLine());
//    string input = Console.ReadLine();

//    //int numberOfJedies = 7;
//    //string input = "p4 p2 p3 m1 k2 p1 k1";

//    var splittedInput = input.Split(' ');

//    List<string> masters = new List<string>();
//    List<string> knights = new List<string>();
//    List<string> padawans = new List<string>();

//    for (int i = 0; i < numberOfJedies; i++)
//    {
//        if (splittedInput[i].ToLower().StartsWith("m"))
//        {
//            masters.Add(splittedInput[i]);
//        }
//        else if (splittedInput[i].ToLower().StartsWith("k"))
//        {
//            knights.Add(splittedInput[i]);
//        }
//        else if (splittedInput[i].ToLower().StartsWith("p"))
//        {
//            padawans.Add(splittedInput[i]);
//        }
//    }

//    List<string> output = new List<string>();

//    foreach (var master in masters)
//    {
//        output.Add(master);
//    }

//    foreach (var knight in knights)
//    {
//        output.Add(knight);
//    }

//    foreach (var padawan in padawans)
//    {
//        output.Add(padawan);
//    }

//    Console.WriteLine(string.Join(" ", output));
//}