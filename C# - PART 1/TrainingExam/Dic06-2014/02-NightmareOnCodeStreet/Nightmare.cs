//On “Alexander Malinov” street there is one dark and spooky place where everyone is getting goose bumps of. It is so scary that even the vampires from Twilight do not want to get close to it. The name is Nightmare Academy – dark and shadowy programmers reside inside. The floor is green, the stairs are green, the ceiling is green – brrrr, only the most fearsome and brave warriors have survived!
//Well, you do not have anything to worry, do you? You are in a safe place now, are you? Nothing wrong can happen here, right? Nice!
//This problem is simple. You are given a text with some digits. Your task is to find all digits in every odd position (starting from zero) throughout the text and calculate their sum.
//Input
//The input data should be read from the console.
//On the only input line you will receive the text.
//The input data will always be valid and in the format described. There is no need to check it explicitly.
//Output
//The output should be printed on the console.
//On the only input line you should print the total amount of digits in odd positions and their sum separated by space.

//using System;

//class Nightmare
//    {
//        static void Main()
//        {
//            string input = Console.ReadLine();
//            int l = input.Length;
//            int count=0;
//            int sum = 0;
//            int digit = 0;

//            for (int i = 0; i < l-1; i++)
//            {
//                bool check = int.TryParse(input[i].ToString(), out digit);
//                if (i % 2 != 0 && check)
//                {
//                    count++;
//                    sum += digit;
//                }
//            }
//            Console.WriteLine("{0} {1}", count, sum);
//        }
//    }

using System;

class NightmareOnCodeStreet
{
    static void Main()
    {

        string number = Console.ReadLine();
        // int pos = 0;
        int counter = 0;
        int result = 0;


        for (int i = 1; i < number.Length; i++)
        {
            if ((char)number[i] >= 48 && (char)number[i] <= 57)
            {
                result += ((char)(number[i]) - 48);
                counter++;
            }
            else if (number[i] == ' ')
            {
                result += ((char)(number[i]) - 32);
                counter++;
            }
            i++;
        }

        Console.WriteLine("{0} {1}", counter, result);
    }
}