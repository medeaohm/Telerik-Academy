using System;

//### Problem 9.	Trapezoids
//*	Write an expression that calculates trapezoid's area by given sides `a` and `b` and height `h`.

//_Examples:_

//|   a   |   b   |   h   |    area   |
//|:-----:|:-----:|:-----:|:---------:|
//| 5     | 7     | 12    | 72        |
//| 2     | 1     | 33    | 49.5      |
//| 8.5   | 4.3   | 2.7   | 17.28     |
//| 100   | 200   | 300   | 45000     |
//| 0.222 | 0.333 | 0.555 | 0.1540125 |

class Trapezoids
    {
        static void Main()
        {
            decimal a = 0.222m;
            decimal b = 0.333m;
            decimal h = 0.555m;
            decimal area = ((a + b) / 2) * h;

            Console.WriteLine("The area of a trapezoid with sides a = {0} and b = {1} and height h = {2} is {3}", a, b, h, area);
        }
    }

