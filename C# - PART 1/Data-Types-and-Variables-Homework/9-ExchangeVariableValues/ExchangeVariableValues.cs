using System;


//### Problem 9.	Exchange Variable Values
//*	Declare two integer variables `a` and `b` and assign them with `5` and `10` and after that exchange their values by using some programming logic.
//*	Print the variable values before and after the exchange.

    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            ushort a = 5;
            ushort b = 10;
            Console.WriteLine("Before the exchange \n a = " + a + "\n b = " + b);
            ushort temp = a; 
            a = b;
            b = temp;
            Console.WriteLine("After the exchange \n a = " + a + "\n b = " + b);
        }
    }

