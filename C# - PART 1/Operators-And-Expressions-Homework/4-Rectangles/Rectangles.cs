using System;


//### Problem 4.	Rectangles
//*	Write an expression that calculates rectangle’s perimeter and area by given width and height.

//_Examples:_

//| width | height | perimeter | area |
//|:-----:|:------:|:---------:|:----:|
//| 3     | 4      | 14        | 12   |
//| 2.5   | 3      | 11        | 7.5  |
//| 5     | 5      | 20        | 25   |

class Rectangles
    {
        static void Main(string[] args)
        {
            float width = 2.5f;
            float height = 3f;
            float perimeter = (2f*width)+(2f*height);
            float area = width * height;

            Console.WriteLine("Given a rectagle with width {0} and height {1} \n--> his perimeter is {2}\n--> his area is {3}", width,height,perimeter,area);
        }
    }

