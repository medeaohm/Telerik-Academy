using System;

//### Problem 7.	Point in a Circle
//*	Write an expression that checks if given point (x,  y) is inside a circle `K({0, 0}, 2)`.

//_Examples:_

//|   x  |   y   | inside |
//|:----:|:-----:|:------:|
//| 0    | 1     | true   |
//| -2   | 0     | true   |
//| -1   | 2     | false  |
//| 1.5  | -1    | true   |
//| -1.5 | -1.5  | false  |
//| 100  | -30   | false  |
//| 0    | 0     | true   |
//| 0.2  | -0.8  | true   |
//| 0.9  | -1.93 | false  |
//| 1    | 1.655 | true   |

class PointInCircle
{
    static void Main()
    {
        int x_c = 0;
        int y_c = 0;
        int r = 2;
        double x = 0.9;
        double y = -1.93;

        bool inside = ((x-x_c)*(x-x_c)+(y-y_c)*(y-y_c)<=r*r);

        Console.WriteLine("Is the point [{0};{1}] inside the circle K=([0,0], 2)? --> {2}", x, y, inside);
    }
}
