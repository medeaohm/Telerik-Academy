namespace Rotate2D
{
    using System;

    public class Figure
    {
        private double width;
        private double height;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.Width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width have to be a positive double value");
                }

                this.Width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.Height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height have to be a positive double value");
                }

                this.Height = value;
            }
        }

        public Figure GetRotatedFigure(Figure figure, double angle)
        {
            double rotatadFigureWidth = (Math.Abs(Math.Cos(angle)) * figure.width) + (Math.Abs(Math.Sin(angle)) * figure.height);
            double rotatadFigureHeight = (Math.Abs(Math.Sin(angle)) * figure.width) + (Math.Abs(Math.Cos(angle)) * figure.height);

            Figure rotatedFigure = new Figure(rotatadFigureWidth, rotatadFigureHeight);

            return rotatedFigure;
        }
    }
}