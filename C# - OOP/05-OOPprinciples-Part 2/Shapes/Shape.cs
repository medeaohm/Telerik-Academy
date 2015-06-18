namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }


        public double Width
        {
            get { return this.width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must be > 0");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height must be > 0");
                }
                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("Area = {0:F2}", this.CalculateSurface());
        }
    }
}
