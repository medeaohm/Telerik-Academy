namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private const decimal ConvertedHeight = 0.10M;
        private readonly decimal NonConvertedHeight;

        public ConvertibleChair(string model, MaterialType matType, decimal price, decimal height, int numberOfLegs)
            : base (model, matType, price, height, numberOfLegs)
        {
            this.NonConvertedHeight = height;
        }
        public bool IsConverted {get; private set;}

        public void Convert()
        {
            if (IsConverted)
            {
                this.Height = NonConvertedHeight;
            }
            else
            {
                this.Height = ConvertedHeight;
            }
            this.IsConverted = !this.IsConverted;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
