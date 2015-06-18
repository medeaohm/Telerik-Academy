using System;

//### Problem 12.	Null Values Arithmetic
//*	Create a program that assigns null values to an integer and to a double variable. 
//*	Try to print these variables at the console. 
//*	Try to add some number or the null literal to these variables and print the result.

    class NullValues
    {
        static void Main()
        {
            int? someInt = null;
            double? someDouble = null;
            Console.WriteLine("This is some integer with null value --> " + someInt);
            Console.WriteLine("This is some double with null value --> " + someDouble);

            someInt += 5;
            someDouble += 0.25;
            Console.WriteLine("This is a null integer + 5 --> " + someInt);
            Console.WriteLine("This is a null double + 0.25 --> " + someDouble);
            

            someInt = 5;
            someDouble = 0.25;
            Console.WriteLine("This is some integer with value 5 --> " + someInt);
            Console.WriteLine("This is some double with value 0.25 --> " + someDouble);
            
        }
    }

