//### Problem 15. Prime numbers
//*	Write a program that finds all prime numbers in the range [`1...10 000 000`]. Use the [Sieve of Eratosthenes](http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes) algorithm.

using System;
using System.Collections.Generic;
using System.Linq;


class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Please enter the range 0 -> N.... N = ");
        int max = int.Parse(Console.ReadLine());
        int[] arr = new int[max];
        List<int> numNP = new List<int>();
        List<int> num = new List<int>();
        List<int> numP = new List<int>();

        int n = 2;
        numP.Add(n);
        
        for (int i = 0; i < max-1; i++)
        {
            arr[i] = i+2;
        }

        List<int> num2 = arr.ToList();
        while (num2.Count > 1)
        {
            
            for (int i = 0; i < num2.Count(); i++)
            {
                if (num2[i] % n == 0)
                {
                    numNP.Add(num2[i]);
                }
                else
                {
                    num.Add(num2[i]);
                }
            }
            n = num.Min();
            numP.Add(n);
            num2 = num.ToList();
            num.Clear();
            numNP.Clear();
        }
        Console.WriteLine("\n");
        Console.WriteLine("Prime numbers in the given range...");
        for (int i = 0; i < numP.Count(); i++)
        {
            Console.Write(numP[i] + ", ");
        }
        Console.WriteLine("\n");


        // Another implementations....

        Console.WriteLine("Prime numbers in the given range found with another implementation...");
        bool[] primes = new bool[n+2];

        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            if (primes[i] == false)
            {
                for (int j = i * i; j < primes.Length; j += i)
                {
                    primes[j] = true;
                }
            }
        }

        for (int i = 2; i < primes.Length; i++)
        {
            if (!primes[i]) Console.Write(i + ", ");
        }
        Console.WriteLine();
    }
}

