namespace GSM
{
    using System;
    using System.Text;

    class Display
    {
        private double inches;
        private int colors;

        public Display(double inches, int colors)
        {
            this.Inches = inches;
            this.Colors = colors;
        }

        public int Colors
        {
            get { return this.colors; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Color cannot be a negative number");
                }
                this.colors = value;
            }
        }

        public double Inches 
        {
            get { return this.inches; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Inches cannot be a negative number");
                }
                this.inches = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Information about the Display:");
            result.AppendLine("Inches: " + this.inches.ToString());
            result.AppendLine("Colors: " + this.colors.ToString());
            return result.ToString();
        }
    }

}
