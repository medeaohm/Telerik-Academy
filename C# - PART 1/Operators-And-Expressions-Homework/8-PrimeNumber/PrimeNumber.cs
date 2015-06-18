using System;

//### Problem 8.	Prime Number Check
//*	Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).

//_Examples:_

//|  n | Prime? |
//|:--:|:------:|
//| 1  | false  |
//| 2  | true   |
//| 3  | true   |
//| 4  | false  |
//| 9  | false  |
//| 97 | true   |
//| 51 | false  |
//| -3 | false  |
//| 0  | false  |


class PrimeNumber
    {
        static void Main()
        {
            int number = 3;
            if(isPrime(number))
            {
                Console.WriteLine("Is {0} prime? --> True!", number);
            }
            else
            {
                Console.WriteLine("Is {0} prime? --> False!", number);
            }   
        }  


        public static bool isPrime(int number)
            {
                int boundary = (int) Math.Floor(Math.Sqrt(Math.Abs(number)));
                if (number == 0) return false;
                if (number == 1) return false;
                if (number == 2) return true;

                for (int i = 2; i <= boundary; ++i)  
                {
                     if (number % i == 0)  return false;
                }
                return true;        
            }
        
    }

