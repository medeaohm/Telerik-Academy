namespace FurnitureManufacturer.Models
{
    using System;

    using Interfaces;

    /* Each furniture piece has model, material, price in dollars, and height in meters*/
    public abstract class Furniture : IFurniture
    {
        const int ModelMinLengh = 3;
        const decimal Zero = 0M;

        private string model;
        private MaterialType materialType;
        private decimal price;
        private decimal height;

        public Furniture(string model, MaterialType matType, decimal price, decimal height)
        {
            this.Model = model;
            this.materialType = matType;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get 
            {
                return this.model;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be empty!");
                }
                if (value.Length < ModelMinLengh)
                {
                    throw new ArgumentException("Model cannot be less than 3 symbols!");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get 
            {
                return this.materialType.ToString();
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <=  Zero)
                {
                    throw new ArgumentException("Price cannot be less or equal to $0.00.");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get 
            {
                return this.height;
            }
            protected set
            {
                if (value <= Zero)
                {
                    throw new ArgumentException("Height cannot be less or equal to 0.00 m.");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
