//### Problem 2. Random numbers
//*	Write a program that generates and prints to the console `10` random values in the range [`100, 200`].

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.WriteLine("This program prints to the console 10 random numbers in the range [100, 200]:\n");
        Random r = new Random();
        for (int i = 0; i < 10; i++)
        {
            int rInt = r.Next(100, 200);
            Console.Write("{0}, ", rInt);
            if (i == 9)
            {
                Console.Write("{0}\n\n", rInt);
            }
        }
         
    }
}

