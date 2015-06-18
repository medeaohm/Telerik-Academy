//### Problem 10.	Odd and Even Product
//*	You are given `n` integers (given in a single line, separated by a space).
//*	Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//*	Elements are counted from `1` to `n`, so the first element is odd, the second is even, etc.

//_Examples:_

//| numbers           | result |
//|-------------------|--------|
//| 2 1 1 6 3         | yes    |
//| product = 6       |        |
//|                   |        |
//| 3 10 4 6 5 1      | yes    |
//| product = 60      |        |
//|                   |        |
//| 4 3 2 5 2         | no     |
//| odd_product = 16  |        |
//| even_product = 15 |        |

using System;

class OddAndEvenProduct
    {
        static void Main()
        {
            Console.WriteLine("Please insert a positive integer number...");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter {0} numbers (given in a single line, separated by a space)", n);
            //Read line, and split it by whitespace into an array of strings
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;
         
            for (int index = 0; index < array.Length; index++)
            {
                int number = int.Parse(array[index]);
                if (index %2 == 0 || index == 0)
                {
                    oddProduct *= number;
                }
                else
                {
                    evenProduct *= number;
                }
            }
            if (oddProduct == evenProduct)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd procuct = {0}", oddProduct);
                Console.WriteLine("even procuct = {0}", evenProduct);
            } 
        }
    }

