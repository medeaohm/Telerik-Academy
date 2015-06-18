using System;
using System.Collections.Generic;


class WeLoveBits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n; i++)
            {
                int temp = numbers[i];
                int noTemp = ~temp;
                char[] chars = Convert.ToString(numbers[i], 2).ToCharArray();
                Array.Reverse(chars);
                int revTemp = Convert.ToInt32(new string(chars), 2);
                int newNum = (numbers[i] ^ noTemp) & revTemp;
                Console.WriteLine(newNum);
            }
        }
    }

