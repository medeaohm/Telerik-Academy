namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, MaterialType matType, decimal price, decimal height, int numberOfLegs)
            : base (model, matType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs {get; private set;}

        public override string ToString()
        {
            return base.ToString() + string.Format(", Legs: {0}", this.NumberOfLegs);
        }
    }
}
