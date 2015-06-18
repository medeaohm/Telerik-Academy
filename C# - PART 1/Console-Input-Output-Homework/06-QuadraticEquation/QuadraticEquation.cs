using System;

//### Problem 6.	Quadratic Equation
//*	Write a program that reads the coefficients `a`, `b` and `c` of a quadratic equation ax<sup>2</sup> + bx + c = 0 and solves it (prints its real roots).

//_Examples:_

//|   a  |  b  |  c  |     roots     |
//|:----:|:---:|:---:|---------------|
//| 2    | 5   | -3  | x1=-3; x2=0.5 |
//| -1   | 3   | 0   | x1=3; x2=0    |
//| -0.5 | 4   | -8  | x1=x2=4       |
//| 5    | 2   | 8   | no real roots |


class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("I will solve a quadratic equation...");
            Console.WriteLine();
            Console.WriteLine("Please insert the first coefficient...");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the second coefficient...");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the third coefficient...");
            float c = float.Parse(Console.ReadLine());
            
            Console.WriteLine("\nThe equation is: {0}x^2 + {1}x + {2} = 0", a, b, c);

            double d = (b * b) - (4 * a * c);
            double sol1;
            double sol2;

            if (d<0)
            {
                Console.WriteLine("\nThe roots are: no real roots");   
            }
            else
            {
                sol1 = (-b - Math.Sqrt(d)) / (2 * a);
                sol2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("\nThe roots are: x1 = {0}; x2 = {1}", sol1, sol2);
            }
        }
    }

