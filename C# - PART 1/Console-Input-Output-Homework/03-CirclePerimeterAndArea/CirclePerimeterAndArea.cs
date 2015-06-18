using System;

//### Problem 3.	Circle Perimeter and Area
//*	Write a program that reads the radius `r` of a circle and prints its perimeter and area formatted with `2` digits after the decimal point.

//_Examples:_

//|          r          |          perimeter         |  area |
//|:-------------------:|:--------------------------:|:-----:|
//| 2                   | 12.57                      | 12.57 |
//| 3.5                 | 21.99                      | 38.48 |

class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.WriteLine("Please insert the radius of the circle...");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double perimeter = 2 * pi * radius;
            double area = pi * radius * radius;

            Console.WriteLine("Given a circle of radius R = {0:0.00}", radius);
            Console.WriteLine("Radius = {0:0.00} --> Perimeter = {1:0.00} --> Area = {2:0.00}", radius, perimeter, area);    
        }
    }

