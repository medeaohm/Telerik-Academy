/*
 * Problem 1: Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
      Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure 
    (heightwidth for rectangle and heightwidth/2 for triangle).
      Define class Square and suitable constructor so that at initialization height must be kept equal to width and
    implement the CalculateSurface() method.
      Write a program that tests the behaviour of the CalculateSurface() method for 
    different shapes (Square, Rectangle, Triangle) stored in an array.
 */

namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class ShapesTest
    {
        public static void Main()
        {
            var shapes = new List<Shape>();

            shapes.Add(new Circle(1));
            shapes.Add(new Rectangle(2,5));
            shapes.Add(new Triangle(1,3));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
            }
        }
    }
}
