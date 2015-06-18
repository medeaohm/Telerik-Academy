namespace Shapes
{
    using System;

    public class Circle : Shape
        {
        public Circle (double radius) : base (radius, radius)
        {

        }

        public override double CalculateSurface()
        {
            return this.Height * this.Height * Math.PI;
        }

        public override string ToString()
        {
            return "Circle" + " -> " + base.ToString();
        }
    }
}
