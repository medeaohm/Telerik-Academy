namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle (double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return "Rectangle" + " -> " + base.ToString();
        }
    }
}
