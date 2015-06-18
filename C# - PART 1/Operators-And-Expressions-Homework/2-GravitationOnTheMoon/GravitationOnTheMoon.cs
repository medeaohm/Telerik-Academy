using System;

//### Problem 2.	Gravitation on the Moon
//*	The gravitational field of the Moon is approximately `17%` of that on the Earth.
//*	Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

//_Examples:_

//| weight | weight on the Moon |
//|:------:|:------------------:|
//| 86     | 14.62              |
//| 74.6   | 12.682             |
//| 53.7   | 9.129              |

class GravitationOnTheMoon
    {
        static void Main()
        {
            decimal weight = 53.7m;
            decimal weightOnTheMoon = 0.17m * weight;
            Console.WriteLine("If your weight is {0}kg, on the Moon your weight will be {1}kg", weight, weightOnTheMoon);
        }
    }

