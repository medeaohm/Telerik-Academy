namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class AdjustableChair : Chair, IAdjustableChair
    {
        public AdjustableChair(string model, MaterialType matType, decimal price, decimal height, int numberOfLegs)
            : base (model, matType, price, height, numberOfLegs)
        {

        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
