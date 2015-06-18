using System;

//### Problem 10.	Point Inside a Circle & Outside of a Rectangle
//*	Write an expression that checks for given point (x, y) if it is within the circle `K({1, 1}, 1.5)` and out of the rectangle `R(top=1, left=-1, width=6, height=2)`.

//_Examples:_

//|   x  |   y  | inside K & outside of R |
//|:----:|:----:|:-----------------------:|
//| 1    | 2    | yes                     |
//| 2.5  | 2    | no                      |
//| 0    | 1    | no                      |
//| 2.5  | 1    | no                      |
//| 2    | 0    | no                      |
//| 4    | 0    | no                      |
//| 2.5  | 1.5  | no                      |
//| 2    | 1.5  | yes                     |
//| 1    | 2.5  | yes                     |
//| -100 | -100 | no                      |

class CircleRectangle
    {
        static void Main()
        {
            double x = 1;
            double y = 2.5;

            int x_c = 1;
            int y_c = 1;
            double r = 1.5;

            bool insideCircle = (((x - x_c) * (x - x_c) + (y - y_c) * ( y - y_c)) <= r * r);
            bool insideRect = ((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1));
            bool inCircleOutRect = (insideCircle && !insideRect);

            Console.WriteLine("Is the point [{0},{1}] inside the circle K([{2},{3},{4}]) and out of the rectangle R(top = 1, left =  -1, width = 6, height = 2)?", x,y,x_c,y_c,r);
            if (inCircleOutRect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

