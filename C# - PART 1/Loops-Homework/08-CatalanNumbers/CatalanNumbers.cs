//### Problem 8.	Catalan Numbers
//*	In combinatorics, the Catalan numbers are calculated by the following formula:
//![catalan-formula](https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png)
//*	Write a program to calculate the `nth` Catalan number by given `n` (1 < n < 100). 

//_Examples:_

//| n           | Catalan(n) |
//|-------------|------------|
//| 0           | 1          |
//| 5           | 42         |
//| 10          | 16796      |
//| 15          | 9694845    |


using System;
using System.Numerics;

class CatalanNumbers
    {
        static void Main()
        {
            
                Console.WriteLine("Please insert a positive integer number n (1 ... 100)...");
                int n = int.Parse(Console.ReadLine());

                BigInteger expr1 = 1;
                BigInteger expr2 = 1;
                BigInteger expr3 = 1;

                if (n > 100 | n < 1)
                {
                    Console.WriteLine("Invalid input!");
                }

                else 
                {
                    for (int i = 1; i <= n; i++)
                    {
                        expr1 *= i;
                    }
                    for (int i = 1; i <= 2*n; i++)
                    {
                        expr2 *= i;
                    }
                    for (int i = 1; i <= n+1; i++)
			        {
			            expr3 *= i; 
			        }
                }

                int result = (int)(expr2 / (expr1 * expr3));
                Console.WriteLine(result);
        }
    }
    

